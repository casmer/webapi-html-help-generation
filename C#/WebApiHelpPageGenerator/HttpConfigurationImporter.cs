using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Http;

namespace WebApiHelpPageGenerator
{
    public static class HttpConfigurationImporter
    {
        public static readonly string ConfigurationMethodName = "Register";
        public static readonly string ConfigClassName = "WebApiConfig";
        public static readonly string HelpPageConfigClassName = "HelpPageConfig";

        public static HttpConfiguration ImportConfiguration(string assemblyPath)
        {
          FileInfo peInfo = new FileInfo(assemblyPath);
          assemblyPath = peInfo.FullName;
            var assembly = Assembly.LoadFrom(assemblyPath);

            string originalDirectory = Environment.CurrentDirectory;
            Environment.CurrentDirectory = Path.GetDirectoryName(assemblyPath);

            Type webApiConfigType = assembly.GetTypes().FirstOrDefault(t => t.Name == ConfigClassName);
            if (webApiConfigType == null)
            {
                throw new InvalidOperationException(string.Format("Cannot find the configuration class: '{0}' in {1}", ConfigClassName, assemblyPath));
            }
            MethodInfo registerConfigMethod = webApiConfigType.GetMethod(ConfigurationMethodName, BindingFlags.Static | BindingFlags.Public);
            if (registerConfigMethod == null)
            {
                throw new InvalidOperationException(string.Format("Cannot find the static configuration method: '{0}()' in {1}", ConfigurationMethodName, ConfigClassName));
            }
        
           // Action<HttpConfiguration> registerConfig = Delegate.CreateDelegate(typeof(Action<HttpConfiguration>), registerConfigMethod) as Action<HttpConfiguration>;
            HttpConfiguration config = new HttpConfiguration();
            registerConfigMethod.Invoke(new object(),new object[]{ config});
           // registerConfig(config);
            ImportHelpPageConfiguration(assembly, config);
            Environment.CurrentDirectory = originalDirectory;
          config.EnsureInitialized();
            return config;
        }

        private static HttpConfiguration ImportHelpPageConfiguration(Assembly assembly, HttpConfiguration config)
        {
            Type helpPageConfigType = assembly.GetTypes().FirstOrDefault(t => t.Name == HelpPageConfigClassName);
            if (helpPageConfigType != null)
            {
                MethodInfo registerConfigMethod = helpPageConfigType.GetMethod(ConfigurationMethodName, BindingFlags.Static | BindingFlags.Public);
                if (registerConfigMethod == null)
                {
                    throw new InvalidOperationException(string.Format("Cannot find the static configuration method: '{0}()' in {1}", ConfigurationMethodName, HelpPageConfigClassName));
                }

                Action<HttpConfiguration> registerConfig = Delegate.CreateDelegate(typeof(Action<HttpConfiguration>), registerConfigMethod) as Action<HttpConfiguration>;
                registerConfig(config);
            }

            return config;
        }
    }
}
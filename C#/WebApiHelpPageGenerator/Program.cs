using System;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Description;
using CommandLine;
using WebApiHelpPage;
using WebApiHelpPage.Models;

namespace WebApiHelpPageGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var options = new CommandLineOptions();
            try
            {
                if (CommandLine.Parser.Default.ParseArguments(args, options))
                {
                    LoadReferences(options);

                    string assemblyPath = options.AssemblyPath;
                    HttpConfiguration config = HttpConfigurationImporter.ImportConfiguration(assemblyPath);
                    Collection<ApiDescription> descriptions = config.Services.GetApiExplorer().ApiDescriptions;
                    IOutputGenerator outputGenerator = LoadOutputGenerator(options);
                  
                    outputGenerator.GenerateIndex(descriptions, options);

                    foreach (var api in descriptions)
                    {
                        HelpPageSampleGenerator sampleGenerator = config.GetHelpPageSampleGenerator();
						HelpPageApiModel apiModel = HelpPageConfigurationExtensions.GetHelpPageApiModel(config, api.GetFriendlyId());

						if (apiModel != null)
                        {
                            outputGenerator.GenerateApiDetails(apiModel, options);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);

            }

        }

        private static IOutputGenerator LoadOutputGenerator(CommandLineOptions options)
        {
            IOutputGenerator outputGenerator = null;
            string extensionAssemblyPath = options.ExtensionAssemblyPath;
            if (!String.IsNullOrEmpty(extensionAssemblyPath))
            {
                var assembly = Assembly.LoadFrom(extensionAssemblyPath);
                foreach (var type in assembly.GetTypes())
                {
                    if ((typeof(IOutputGenerator)).IsAssignableFrom(type))
                    {
                        outputGenerator = (IOutputGenerator)Activator.CreateInstance(type);
                    }
                }
            }
            if (outputGenerator == null)
            {
                outputGenerator = new DefaultOutputGenerator();
            }
            return outputGenerator;
        }

        private static void LoadReferences(CommandLineOptions options)
        {
            foreach (var reference in options.References)
            {
                Assembly.LoadFrom(reference);
            }
        }
    }
}
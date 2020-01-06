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
                var success = CommandLine.Parser.Default.ParseArguments(args, options);

                if (true)
                {
                    LoadReferences(options);

                    var assemblyPath = options.AssemblyPath;
                    var config = HttpConfigurationImporter.ImportConfiguration(assemblyPath);
                    var descriptions = config.Services.GetApiExplorer().ApiDescriptions;
                    var outputGenerator = LoadOutputGenerator(options);

                    outputGenerator.GenerateIndex(descriptions, options);

                    foreach (var api in descriptions)
                    {
                        var sampleGenerator = config.GetHelpPageSampleGenerator();
                        var apiModel = HelpPageConfigurationExtensions.GetHelpPageApiModel(config, api.GetFriendlyId());

                        if (apiModel != null)
                        {
                            outputGenerator.GenerateApiDetails(apiModel, options);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                PrintException(e);
                Environment.Exit(-1);
            }
        }

        private static void PrintException(Exception ex)
        {
            var origColor = Console.ForegroundColor;
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: {0}\n{1}", ex.Message, ex.StackTrace);
                if (ex.InnerException != null)
                {
                    PrintException(ex.InnerException);
                }
            }
            finally
            {
                Console.ForegroundColor = origColor;
            }

        }

        private static IOutputGenerator LoadOutputGenerator(CommandLineOptions options)
        {
            IOutputGenerator outputGenerator = null;
            var extensionAssemblyPath = options.ExtensionAssemblyPath;
            if (!string.IsNullOrEmpty(extensionAssemblyPath))
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

            if (!string.IsNullOrWhiteSpace(options.OutputPath))
            {
                outputGenerator.OutputPath = options.OutputPath;
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
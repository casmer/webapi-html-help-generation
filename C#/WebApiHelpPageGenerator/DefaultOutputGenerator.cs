using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Web.Http.Description;
using WebApiHelpPage;
using WebApiHelpPage.Models;

namespace WebApiHelpPageGenerator
{
    public class DefaultOutputGenerator : IOutputGenerator
    {
        private const string fileName = "Index.html";

        public string OutputPath { get; set; }
        public DefaultOutputGenerator()
        {
            OutputPath = Path.Combine(Environment.CurrentDirectory, "HtmlHelp");
        }
        public DefaultOutputGenerator(string baseBath) : base()
        {

        }
        public void GenerateIndex(Collection<ApiDescription> apis, CommandLineOptions options)
        {
            var indexTemplate = new Index
            {
                Model = apis,
                ApiLinkFactory = apiName =>
                {
                    return apiName + ".html";
                },
                Options = options
            };
            var helpPageIndex = indexTemplate.TransformText();
            WriteFile(fileName, helpPageIndex);
        }

        public void GenerateApiDetails(HelpPageApiModel apiModel, CommandLineOptions options)
        {
            var apiTemplate = new Api
            {
                Model = apiModel,
                HomePageLink = fileName,
                Options = options
            };
            var helpPage = apiTemplate.TransformText();
            WriteFile(apiModel.ApiDescription.GetFriendlyId() + ".html", helpPage);
        }

        private void WriteFile(string fileName, string pageContent)
        {
            var path = Path.Combine(OutputPath, fileName);
            Console.WriteLine("writing file: {0}", fileName);
            if (!Directory.Exists(OutputPath))
            {
                Directory.CreateDirectory(OutputPath);
            }

            File.WriteAllText(path, pageContent);
        }
    }
}
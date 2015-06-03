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
        private const string fileName = "HelpPage.html";
        public string basePath { get; set; }


      public DefaultOutputGenerator()
      {
        basePath = Path.Combine(Environment.CurrentDirectory, "HtmlHelp");
      }
      public DefaultOutputGenerator(string baseBath):base()
      {
        
      }
        public void GenerateIndex(Collection<ApiDescription> apis)
        {
            Index indexTemplate = new Index
            {
                Model = apis,
                ApiLinkFactory = apiName =>
                {
                    return apiName + ".html";
                }
            };
            string helpPageIndex = indexTemplate.TransformText();
            WriteFile(fileName, helpPageIndex);
        }

        public void GenerateApiDetails(HelpPageApiModel apiModel)
        {
            Api apiTemplate = new Api
            {
                Model = apiModel,
                HomePageLink = fileName
            };
            string helpPage = apiTemplate.TransformText();
            WriteFile(apiModel.ApiDescription.GetFriendlyId() + ".html", helpPage);
        }

        private static void WriteFile(string fileName, String pageContent)
        {
            Console.WriteLine("writing file: {0}", fileName);
            File.WriteAllText(fileName, pageContent);
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiHelpPageGenerator;

namespace WebApiJsClientGenerator
{
    public class JsClientGenrator : IOutputGenerator
    {
        public void GenerateApiDetails(WebApiHelpPage.Models.HelpPageApiModel apiModel, CommandLineOptions options)
        {
        }

        public void GenerateIndex(System.Collections.ObjectModel.Collection<System.Web.Http.Description.ApiDescription> apis, CommandLineOptions options)
        {
            JsClientTemplate jsClientTemplate = new JsClientTemplate
            {
                Apis = apis
            };
            string jsClient = jsClientTemplate.TransformText();
            WriteFile("client.js", jsClient);
        }

        private static void WriteFile(string fileName, String pageContent)
        {
            Console.WriteLine("writing file: {0}", fileName);
            File.WriteAllText(fileName, pageContent);
        }
    }
}
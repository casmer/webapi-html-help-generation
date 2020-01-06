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
        public string OutputPath { get; set; }

        public JsClientGenrator()
        {
            OutputPath = Path.Combine(Environment.CurrentDirectory, "JsHelp");
        }

        public void GenerateApiDetails(WebApiHelpPage.Models.HelpPageApiModel apiModel, CommandLineOptions options)
        {
        }

        public void GenerateIndex(System.Collections.ObjectModel.Collection<System.Web.Http.Description.ApiDescription> apis, CommandLineOptions options)
        {
            var jsClientTemplate = new JsClientTemplate
            {
                Apis = apis
            };
            var jsClient = jsClientTemplate.TransformText();
            WriteFile(Path.Combine(OutputPath, "client.js"), jsClient);
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
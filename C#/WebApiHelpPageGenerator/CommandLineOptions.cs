using CommandLine;
using CommandLine.Text;
using CommandLine.Infrastructure;

namespace WebApiHelpPageGenerator
{
    public class CommandLineOptions
    {
        [Option('p', "path", Required = true, HelpText = "Path to the assembly where the Web APIs are defined.")]
        public string AssemblyPath { get; set; }

        [OptionArray('r', "references", DefaultValue = new string[0], HelpText = "Additional assembly references.")]
        public string[] References { get; set; }

        [Option('e', "extensions", HelpText = "Path to the assembly where the extensions are defined.")]
        public string ExtensionAssemblyPath { get; set; }

		[OptionArray('s',"stylesheets", HelpText = "URL of style sheets to include, prefer relative paths such as ../styles.css")]
		public string[] StyleSheets { get; set; }

        [Option('o', "outputpath", Required = true, HelpText = "Path to the where the API help files are output.")]
        public string OutputPath { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
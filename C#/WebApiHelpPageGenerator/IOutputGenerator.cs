using System.Collections.ObjectModel;
using System.Web.Http.Description;
using WebApiHelpPage.Models;

namespace WebApiHelpPageGenerator
{
    public interface IOutputGenerator
    {
        void GenerateIndex(Collection<ApiDescription> apis, CommandLineOptions options);

        void GenerateApiDetails(HelpPageApiModel apiModel, CommandLineOptions options);
    }
}
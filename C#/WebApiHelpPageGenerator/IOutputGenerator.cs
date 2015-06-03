using System.Collections.ObjectModel;
using System.Web.Http.Description;
using WebApiHelpPage.Models;

namespace WebApiHelpPageGenerator
{
    public interface IOutputGenerator
    {
        void GenerateIndex(Collection<ApiDescription> apis);

        void GenerateApiDetails(HelpPageApiModel apiModel);
    }
}
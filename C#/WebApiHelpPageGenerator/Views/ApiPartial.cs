using System;
using WebApiHelpPage.Models;
using WebApiHelpPageGenerator;

namespace WebApiHelpPage
{
    public partial class Api
    {
        public HelpPageApiModel Model { get; set; }

        public string HomePageLink { get; set; }
		public CommandLineOptions Options { get; internal set; }
	}
}
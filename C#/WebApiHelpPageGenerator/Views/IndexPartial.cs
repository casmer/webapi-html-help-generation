﻿using System;
using System.Collections.ObjectModel;
using System.Web.Http.Description;
using WebApiHelpPageGenerator;

namespace WebApiHelpPage
{
    public partial class Index
    {
        public Collection<ApiDescription> Model { get; set; }

        public Func<string, string> ApiLinkFactory { get; set; }
        public CommandLineOptions Options { get; set; }
    }
}
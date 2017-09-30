﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace WebApiHelpPage
{
    using System.Web.Http.Description;
    using System.Web.Http.Controllers;
    using System.Collections.ObjectModel;
    using WebApiHelpPage.Models;
    using System.Web.Http;
    using System.Linq;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\Index.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class Index : IndexBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n");
            
            #line 9 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\Index.tt"

	var title = "ASP.NET Web API Help Page";
    // Group APIs by controller
    ILookup<string, ApiDescription> apiGroups = Model.ToLookup(api => api.ActionDescriptor.ControllerDescriptor.ControllerName);

            
            #line default
            #line hidden
            this.Write("\r\n<html>\r\n<head>\r\n    <title>");
            
            #line 17 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\Index.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(title));
            
            #line default
            #line hidden
            this.Write("</title>\r\n\t<style type=\"text/css\">\r\n\t\t");
            this.Write("pre.wrapped {\r\n    white-space: -moz-pre-wrap;\r\n    white-space: -pre-wrap;\r\n    " +
                    "white-space: -o-pre-wrap;\r\n    white-space: pre-wrap;\r\n}\r\n\r\n.warning-message-con" +
                    "tainer {\r\n    margin-top: 20px;\r\n    padding: 0 10px;\r\n    color: #525252;\r\n    " +
                    "background: #EFDCA9;\r\n    border: 1px solid #CCCCCC;\r\n}\r\n\r\n.help-page-table {\r\n " +
                    "   width: 100%;\r\n    border-collapse: collapse;\r\n    text-align: left;\r\n    marg" +
                    "in: 0px 0px 20px 0px;\r\n    border-top: 2px solid #D4D4D4;\r\n}\r\n\r\n    .help-page-t" +
                    "able th {\r\n        text-align: left;\r\n        font-weight: bold;\r\n        border" +
                    "-bottom: 2px solid #D4D4D4;\r\n        padding: 8px 6px 8px 6px;\r\n    }\r\n\r\n    .he" +
                    "lp-page-table td {\r\n        border-bottom: 2px solid #D4D4D4;\r\n        padding: " +
                    "15px 8px 15px 8px;\r\n        vertical-align: top;\r\n    }\r\n\r\n    .help-page-table " +
                    "pre, .help-page-table p {\r\n        margin: 0px;\r\n        padding: 0px;\r\n        " +
                    "font-family: inherit;\r\n        font-size: 100%;\r\n    }\r\n\r\n    .help-page-table t" +
                    "body tr:hover td {\r\n        background-color: #F3F3F3;\r\n    }\r\n\r\na:hover {\r\n    " +
                    "background-color: transparent;\r\n}\r\n\r\n.sample-header {\r\n    border: 2px solid #D4" +
                    "D4D4;\r\n    background: #76B8DB;\r\n    color: #FFFFFF;\r\n    padding: 8px 15px;\r\n  " +
                    "  border-bottom: none;\r\n    display: inline-block;\r\n    margin: 10px 0px 0px 0px" +
                    ";\r\n}\r\n\r\n.sample-content {\r\n    display: block;\r\n    border-width: 0;\r\n    paddin" +
                    "g: 15px 20px;\r\n    background: #FFFFFF;\r\n    border: 2px solid #D4D4D4;\r\n    mar" +
                    "gin: 0px 0px 10px 0px;\r\n}\r\n\r\n.api-name {\r\n    width: 40%;\r\n}\r\n\r\n.api-documentati" +
                    "on {\r\n    width: 60%;\r\n}\r\n\r\n.parameter-name {\r\n    width: 20%;\r\n}\r\n\r\n.parameter-" +
                    "documentation {\r\n    width: 50%;\r\n}\r\n\r\n.parameter-source {\r\n    width: 30%;\r\n}");
            this.Write("\r\n\t</style>\r\n\t");
            
            #line 21 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\Index.tt"
 foreach(string style in Options.StyleSheets) {
            
            #line default
            #line hidden
            this.Write("\t\t<link rel=\"stylesheet\" href=\"");
            
            #line 22 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\Index.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(style));
            
            #line default
            #line hidden
            this.Write("\" />\r\n\t");
            
            #line 23 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\Index.tt"
 } 
            
            #line default
            #line hidden
            this.Write("</head>\r\n<body>\r\n<header>\r\n    <div class=\"content-wrapper\">\r\n        <div class=" +
                    "\"float-left\">\r\n            <h1>");
            
            #line 29 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\Index.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(title));
            
            #line default
            #line hidden
            this.Write(@"</h1>
        </div>
    </div>
</header>
<div id=""body"">
    <section class=""featured"">
        <div class=""content-wrapper"">
            <h2>Introduction</h2>
            <p>
                Provide a general description of your APIs here.
            </p>
        </div>
    </section>
    <section class=""content-wrapper main-content clear-fix"">
        ");
            
            #line 43 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\Index.tt"
 foreach (IGrouping<string, ApiDescription> controllerGroup in apiGroups)
		{ 
            
            #line default
            #line hidden
            this.Write("            ");
            this.Write("<h2 id=\"");
            
            #line 1 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\DisplayTemplates\ApiGroup.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controllerGroup.Key));
            
            #line default
            #line hidden
            this.Write("\">");
            
            #line 1 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\DisplayTemplates\ApiGroup.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controllerGroup.Key));
            
            #line default
            #line hidden
            this.Write("</h2>\r\n<table class=\"help-page-table\">\r\n\t<thead>\r\n\t\t<tr><th>API</th><th>Descripti" +
                    "on</th></tr>\r\n\t</thead>\r\n\t<tbody class=\"ui-widget-content\">\r\n\t");
            
            #line 7 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\DisplayTemplates\ApiGroup.tt"
 foreach (var api in controllerGroup)
	{ 
            
            #line default
            #line hidden
            this.Write("\t\t<tr>\r\n\t\t\t<td class=\"api-name\"><a href=\"");
            
            #line 10 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\DisplayTemplates\ApiGroup.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApiLinkFactory(api.GetFriendlyId())));
            
            #line default
            #line hidden
            this.Write("\">");
            
            #line 10 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\DisplayTemplates\ApiGroup.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(api.HttpMethod.Method));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 10 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\DisplayTemplates\ApiGroup.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(api.RelativePath));
            
            #line default
            #line hidden
            this.Write("</a></td>\r\n\t\t\t<td class=\"api-documentation\">\r\n\t\t\t");
            
            #line 12 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\DisplayTemplates\ApiGroup.tt"
 if (api.Documentation != null)
			{ 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<p>");
            
            #line 14 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\DisplayTemplates\ApiGroup.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(api.Documentation));
            
            #line default
            #line hidden
            this.Write("</p>\r\n\t\t\t");
            
            #line 15 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\DisplayTemplates\ApiGroup.tt"
 }
			else
			{ 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<p>No documentation available.</p>\r\n\t\t\t");
            
            #line 19 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\DisplayTemplates\ApiGroup.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t</td>\r\n\t\t</tr>\r\n\t");
            
            #line 22 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\DisplayTemplates\ApiGroup.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t</tbody>\r\n</table>");
            this.Write("\r\n        ");
            
            #line 46 "C:\dev\experiments\webapi-html-help-generation\C#\WebApiHelpPageGenerator\Views\Index.tt"
 } 
            
            #line default
            #line hidden
            this.Write("    </section>\r\n</div>\r\n</body>\r\n</html>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class IndexBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}

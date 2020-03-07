using System;
using System.Reflection;

namespace WebApiHelpPage
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}
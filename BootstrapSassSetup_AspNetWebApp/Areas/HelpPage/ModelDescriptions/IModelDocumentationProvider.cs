using System;
using System.Reflection;

namespace BootstrapSassSetup_AspNetWebApp.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}
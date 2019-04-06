using System;
using System.Reflection;

namespace ValeriaTapiaFuscoFriendAPI1.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}
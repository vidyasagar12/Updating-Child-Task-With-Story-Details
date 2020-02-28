using System;
using System.Reflection;

namespace Updating_Child_Task_With_Story_Details_WebAPI.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}
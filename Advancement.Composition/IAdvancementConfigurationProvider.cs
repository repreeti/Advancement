using System;
using System.Collections.Generic;
using System.Text;

namespace Advancement.Composition
{
    public interface IAdvancementConfigurationProvider
    {
        string GetConnectionString(string name);
        string LocalUser();
        string AuthUser();
        string LocalHost();
        string NotAuthorizedRedirectPage();
        string UofIEmail();
        string EnvironmentSuffix();
        string AzureDirectory();
        string AzureShare();
    }
}

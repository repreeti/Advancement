using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Advancement.Composition
{
   public  class AdvancementConfigurationProvider : IAdvancementConfigurationProvider
    {

        private readonly IConfiguration _configuration;
        public AdvancementConfigurationProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string LocalUser() => _configuration.GetSection("Shibboleth:LocalUser").Value;

        public string AuthUser() => _configuration.GetSection("Shibboleth:AuthUser").Value;

        public string LocalHost() => _configuration.GetSection("Shibboleth:LocalHost").Value;

        public string NotAuthorizedRedirectPage() => _configuration.GetSection("Shibboleth:AuthorizationPage").Value;

        public string UofIEmail() => _configuration.GetSection("Shibboleth:UofIEmail").Value;

        public string GetConnectionString(string name) => _configuration.GetConnectionString(name);

        public string EnvironmentSuffix() => _configuration.GetSection("Organimi:EnvironmentSuffix").Value;
        public string AzureDirectory() => _configuration.GetSection("Organimi:AzureDirectory").Value;

        public string AzureShare() => _configuration.GetSection("Organimi:AzureShare").Value;

    }
}

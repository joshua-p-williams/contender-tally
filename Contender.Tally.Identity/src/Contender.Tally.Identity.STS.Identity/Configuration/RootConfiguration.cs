using Skoruba.IdentityServer4.Shared.Configuration.Configuration.Identity;
using Contender.Tally.Identity.STS.Identity.Configuration.Interfaces;

namespace Contender.Tally.Identity.STS.Identity.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {      
        public AdminConfiguration AdminConfiguration { get; } = new AdminConfiguration();
        public RegisterConfiguration RegisterConfiguration { get; } = new RegisterConfiguration();
    }
}








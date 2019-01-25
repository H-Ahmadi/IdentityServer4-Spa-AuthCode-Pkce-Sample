using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4;
using IdentityServer4.Models;

namespace STS
{
    public static class StaticData
    {
        public static List<Client> GetClients()
        {
            return new List<Client>()
            {
                new Client()
                {
                    ClientId = "demo-client",
                    ClientName = "Demo Client",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce = true,
                    RequireClientSecret = false,
                    RedirectUris =
                    {
                        "http://localhost:5003/callback.html",
                        "http://localhost:5003/silent-refresh.html",
                    },
                    AllowedCorsOrigins =     { "http://localhost:5003" },
                    AccessTokenLifetime = 20,
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "demo-api"
                    }
                }
            };
        }

        public static List<ApiResource> GetApiResource()
        {
            return new List<ApiResource>()
            {
                new ApiResource("demo-api","Demo Api")
            };
        }
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };
        }
    }
}

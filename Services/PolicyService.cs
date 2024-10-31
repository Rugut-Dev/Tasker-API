using Microsoft.AspNetCore.Authorization;
using TaskerAPI.Models.Enums;

namespace TaskerAPI.Services
{
    public static class PolicyService
    {
        public const string RequireAdmin = "RequireAdmin";
        public const string RequireManager = "RequireManager";

        public static void ConfigurePolicies(AuthorizationOptions options)
        {
            options.AddPolicy(RequireAdmin, policy => 
                policy.RequireRole(Roles.Admin.ToString()));
                
            options.AddPolicy(RequireManager, policy => 
                policy.RequireRole(Roles.Manager.ToString(), Roles.Admin.ToString()));
        }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Asd.AbpZeroTemplate.Authentication.TwoFactor.Google;
using Asd.AbpZeroTemplate.Authorization;
using Asd.AbpZeroTemplate.Authorization.Roles;
using Asd.AbpZeroTemplate.Authorization.Users;
using Asd.AbpZeroTemplate.Editions;
using Asd.AbpZeroTemplate.MultiTenancy;

namespace Asd.AbpZeroTemplate.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>(options =>
                {
                    options.Tokens.ProviderMap[GoogleAuthenticatorProvider.Name] = new TokenProviderDescriptor(typeof(GoogleAuthenticatorProvider));
                })
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}

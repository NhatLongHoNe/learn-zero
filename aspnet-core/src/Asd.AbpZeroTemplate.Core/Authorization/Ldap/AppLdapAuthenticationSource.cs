using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Asd.AbpZeroTemplate.Authorization.Users;
using Asd.AbpZeroTemplate.MultiTenancy;

namespace Asd.AbpZeroTemplate.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}
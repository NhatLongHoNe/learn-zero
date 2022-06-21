namespace Asd.AbpZeroTemplate.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}
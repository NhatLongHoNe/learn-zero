using Abp.Dependency;

namespace Asd.AbpZeroTemplate.Storage
{
    public interface ITempFileCacheManager: ITransientDependency
    {
        void SetFile(string token, byte[] content);

        byte[] GetFile(string token);
    }
}

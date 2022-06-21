using Asd.AbpZeroTemplate.Auditing;
using Asd.AbpZeroTemplate.Test.Base;
using Shouldly;
using Xunit;

namespace Asd.AbpZeroTemplate.Tests.Auditing
{
    // ReSharper disable once InconsistentNaming
    public class NamespaceStripper_Tests: AppTestBase
    {
        private readonly INamespaceStripper _namespaceStripper;

        public NamespaceStripper_Tests()
        {
            _namespaceStripper = Resolve<INamespaceStripper>();
        }

        [Fact]
        public void Should_Stripe_Namespace()
        {
            var controllerName = _namespaceStripper.StripNameSpace("Asd.AbpZeroTemplate.Web.Controllers.HomeController");
            controllerName.ShouldBe("HomeController");
        }

        [Theory]
        [InlineData("Asd.AbpZeroTemplate.Auditing.GenericEntityService`1[[Asd.AbpZeroTemplate.Storage.BinaryObject, Asd.AbpZeroTemplate.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null]]", "GenericEntityService<BinaryObject>")]
        [InlineData("CompanyName.ProductName.Services.Base.EntityService`6[[CompanyName.ProductName.Entity.Book, CompanyName.ProductName.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[CompanyName.ProductName.Services.Dto.Book.CreateInput, N...", "EntityService<Book, CreateInput>")]
        [InlineData("Asd.AbpZeroTemplate.Auditing.XEntityService`1[Asd.AbpZeroTemplate.Auditing.AService`5[[Asd.AbpZeroTemplate.Storage.BinaryObject, Asd.AbpZeroTemplate.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[Asd.AbpZeroTemplate.Storage.TestObject, Asd.AbpZeroTemplate.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],]]", "XEntityService<AService<BinaryObject, TestObject>>")]
        public void Should_Stripe_Generic_Namespace(string serviceName, string result)
        {
            var genericServiceName = _namespaceStripper.StripNameSpace(serviceName);
            genericServiceName.ShouldBe(result);
        }
    }
}

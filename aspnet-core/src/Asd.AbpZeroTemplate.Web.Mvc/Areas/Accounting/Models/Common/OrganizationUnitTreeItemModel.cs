namespace Asd.AbpZeroTemplate.Web.Areas.Accounting.Models.Common
{
    public class OrganizationUnitTreeItemModel
    {
        public IOrganizationUnitsEditViewModel EditModel { get; set; }

        public long? ParentId { get; set; }

        public OrganizationUnitTreeItemModel()
        {

        }

        public OrganizationUnitTreeItemModel(IOrganizationUnitsEditViewModel editModel, long? parentId)
        {
            EditModel = editModel;
            ParentId = parentId;
        }
    }
}
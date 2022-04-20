using TestMVC.DomainModels.ApplicationClasses;

namespace TestMVC.Repository.ProductGroupRepository
{
    public interface IProductGroupRepository
    {

        /// <summary>
        /// This method is used to get all the product groups
        /// </summary>
        /// <returns></returns>
        Task<List<ProductGroupAc>> GetProductGroupsAsync();
    }
}

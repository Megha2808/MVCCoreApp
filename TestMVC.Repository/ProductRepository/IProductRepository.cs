using TestMVC.DomainModels.ApplicationClasses;

namespace TestMVC.Repository.ProductRepository
{
    public interface IProductRepository
    {
        /// <summary>
        /// This method is used to get products by groupid
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        Task<List<ProductAc>> GetProductsByGroupIdAsync(int groupId);
    }
}

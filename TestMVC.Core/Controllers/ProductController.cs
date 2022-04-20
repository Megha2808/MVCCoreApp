using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestMVC.DomainModels.ApplicationClasses;
using TestMVC.Repository.ProductRepository;

namespace TestMVC.Core.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("api/products/{groupId}")]
        public async Task<List<ProductAc>> GetProductGroupsAsync([FromRoute] int groupId)
        {
            return await _productRepository.GetProductsByGroupIdAsync(groupId);
        }
    }
}

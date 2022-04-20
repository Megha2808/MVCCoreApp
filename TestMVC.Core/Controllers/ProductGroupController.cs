using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestMVC.DomainModels.ApplicationClasses;
using TestMVC.Repository.ProductGroupRepository;

namespace TestMVC.Core.Controllers
{
    [Authorize]
    public class ProductGroupController : Controller
    {
        private readonly IProductGroupRepository _productGroupRepository;

        public ProductGroupController(IProductGroupRepository productGroupRepository)
        {
            _productGroupRepository = productGroupRepository;
        }

        [HttpGet("api/groups")]
        public async Task<List<ProductGroupAc>> GetProductGroupsAsync()
        {
            return await _productGroupRepository.GetProductGroupsAsync();
        }
    }
}

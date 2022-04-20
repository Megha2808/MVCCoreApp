using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TestMVC.DomainModels.ApplicationClasses;
using TestMVC.DomainModels.DatabaseContext;
using TestMVC.DomainModels.Models;


namespace TestMVC.Repository.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDatabaseContext _dbContext;
        private readonly IMapper _mapper;
        public ProductRepository(ApplicationDatabaseContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }

        public async Task<List<ProductAc>> GetProductsByGroupIdAsync(int groupId)
        {
            var products = await _dbContext.Products.Where(x => x.ProductGroupId == groupId).ToListAsync();
            return _mapper.Map<List<Product>, List<ProductAc>>(products);
        }
    }
}

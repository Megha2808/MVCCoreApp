using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TestMVC.DomainModels.ApplicationClasses;
using TestMVC.DomainModels.DatabaseContext;
using TestMVC.DomainModels.Models;

namespace TestMVC.Repository.ProductGroupRepository
{
    public class ProductGroupRepository : IProductGroupRepository
    {
        private readonly ApplicationDatabaseContext _dbContext;
        private readonly IMapper _mapper;
        public ProductGroupRepository(ApplicationDatabaseContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }

        #region Public Methods
        public async Task<List<ProductGroupAc>> GetProductGroupsAsync()
        {
            var groups = await _dbContext.ProductGroups.ToListAsync();
            return _mapper.Map<List<ProductGroup>, List<ProductGroupAc>>(groups);
        }
        #endregion
    }
}

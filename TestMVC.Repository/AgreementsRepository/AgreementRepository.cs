using TestMVC.DomainModels.DatabaseContext;
using TestMVC.DomainModels.Models;
using TestMVC.DomainModels.ApplicationClasses;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace TestMVC.Repository.AgreementsRepository
{
    public class AgreementRepository : IAgreementRepository
    {
        private readonly ApplicationDatabaseContext _dbContext;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        public AgreementRepository(ApplicationDatabaseContext context, IMapper mapper, UserManager<AppUser> userManager)
        {
            _dbContext = context;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task AddOrUpdateAgreementAsync(AgreementAc agreementAc, Guid loggedInUSerId)
        {
            if (agreementAc.Id == 0)
            {
                var agreement = new Agreement()
                {
                    CreatedByUserId = loggedInUSerId,
                    CreatedDateTime = DateTime.UtcNow,
                    EffectiveDate = agreementAc.EffectiveDate,
                    ExpirationDate = agreementAc.ExpirationDate,
                    NewPrice = agreementAc.NewPrice,
                    ProductGroupId = agreementAc.ProductGroupId,
                    ProductId = agreementAc.ProductId,
                    IsActive = agreementAc.IsActive

                };
                await _dbContext.Agreements.AddAsync(agreement);
            }
            else
            {
                var agreementToUpdate = await _dbContext.Agreements.FindAsync(agreementAc.Id);
                if (agreementToUpdate != null)
                {
                    agreementToUpdate.UpdatedDateTime = DateTime.UtcNow;
                    agreementToUpdate.EffectiveDate = agreementAc.EffectiveDate;
                    agreementToUpdate.NewPrice = agreementAc.NewPrice;
                    agreementToUpdate.ExpirationDate = agreementAc.ExpirationDate;
                    agreementToUpdate.ProductGroupId = agreementAc.ProductGroupId;
                    agreementToUpdate.ProductId = agreementAc.ProductId;
                    agreementToUpdate.IsActive = agreementAc.IsActive;
                    agreementToUpdate.UpdatedByUserId = loggedInUSerId;

                    _dbContext.Agreements.Update(agreementToUpdate);
                }

            }

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAgreementById(int agreementId)
        {
            var agreement = await _dbContext.Agreements.FirstOrDefaultAsync(x => x.Id == agreementId);
            if (agreement != null)
            {
                _dbContext.Agreements.Remove(agreement);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<AgreementAc> GetAgreementById(int loggedInUserId)
        {
            var agreement = await _dbContext.Agreements.FirstOrDefaultAsync(x => x.Id == loggedInUserId);
            if (agreement != null)
                return _mapper.Map<Agreement, AgreementAc>(agreement);
            else
                return new AgreementAc();
        }

        public async Task<List<AgreementAc>> GetAgreementsAsync()
        {
            try
            {
                var agreements = await _dbContext.Agreements.Where(x => x.IsActive).Include(x => x.Product).Include(x => x.ProductGroup).ToListAsync();

                var agreementsAc = _mapper.Map<List<Agreement>, List<AgreementAc>>(agreements);
                foreach (var item in agreementsAc)
                {
                    var appUSer = await _userManager.FindByIdAsync(item.CreatedByUserId.ToString());
                    if (appUSer != null)
                    {
                        item.UserName = appUSer.UserName;
                    }
                }

                return agreementsAc;
            }
            catch (Exception ex)
            {
                return new List<AgreementAc>();
            }
        }
    }
}

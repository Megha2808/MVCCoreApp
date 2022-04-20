using TestMVC.DomainModels.ApplicationClasses;
using TestMVC.DomainModels.Models;

namespace TestMVC.Repository.AgreementsRepository
{
    public interface IAgreementRepository
    {
        Task<List<AgreementAc>> GetAgreementsAsync();
        Task AddOrUpdateAgreementAsync(AgreementAc agreementAc, Guid loggedInUSerId);
        Task<AgreementAc> GetAgreementById(int agreementId);
        Task DeleteAgreementById(int agreementId);


    }
}

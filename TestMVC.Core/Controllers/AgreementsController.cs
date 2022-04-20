using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestMVC.DomainModels.ApplicationClasses;
using TestMVC.Repository.AgreementsRepository;
using Microsoft.AspNet.Identity;
using System.Security.Claims;

namespace TestMVC.Core.Controllers
{
    [Authorize]
    public class AgreementsController : Controller
    {
        private readonly IAgreementRepository _agreementRepository;

        public AgreementsController(IAgreementRepository agreementRepository)
        {
            _agreementRepository = agreementRepository;
        }
        public IActionResult Index()
        {
            return View("~/Views/Agreements/Index.cshtml");
        }

        [HttpGet("api/agreements")]
        public async Task<JsonResult> GetData(JqueryDatatableParam param)
        {
            var agreements = await _agreementRepository.GetAgreementsAsync();
            // if user has searched data
            if (!string.IsNullOrEmpty(param.sSearch))
            {
                agreements = agreements.Where(x => x.UserName.ToLower().Contains(param.sSearch.ToLower())
                                               || x.NewPrice.ToString().Contains(param.sSearch.ToLower())
                                              || x.ProductPrice.ToString().Contains(param.sSearch.ToLower())
                                              || x.ProductGroupCode.ToString().Contains(param.sSearch.ToLower())
                                              || x.ProductNumber.ToString().Contains(param.sSearch.ToLower())
                                              || x.EffectiveDate.ToString("dd'/'MM'/'yyyy").ToLower().Contains(param.sSearch.ToLower())
                                              || x.ExpirationDate.ToString("dd'/'MM'/'yyyy").ToLower().Contains(param.sSearch.ToLower())
                                              ).ToList();
            }

            int sortColumnIndex = param.iSortCol_0;
            var sortDirection = param.sSortDir_0;
            if (sortColumnIndex == 7)
            {
                agreements = sortDirection == "asc" ? agreements.OrderBy(c => c.NewPrice).ToList() : agreements.OrderByDescending(c => c.NewPrice).ToList();
            }
            if (sortColumnIndex == 6)
            {
                agreements = sortDirection == "asc" ? agreements.OrderBy(c => c.ProductPrice).ToList() : agreements.OrderByDescending(c => c.ProductPrice).ToList();
            }
            var displayResult = agreements.Skip(param.iDisplayStart)
               .Take(param.iDisplayLength).ToList();
            var totalRecords = agreements.Count();
            return Json(new
            {
                param.sEcho,
                iTotalRecords = totalRecords,
                iTotalDisplayRecords = totalRecords,
                aaData = displayResult
            });
        }

        [HttpGet]
        public async Task<ActionResult> AddOrEditAgreements(int id = 0)
        {
            if (id == 0)
            {

                return View("~/Views/Agreements/AddOrEditAgreements.cshtml", new AgreementAc());
            }
            else
            {
                var agreement = await _agreementRepository.GetAgreementById(id);
                return View("~/Views/Agreements/AddOrEditAgreements.cshtml", agreement);

            }
        }

        [HttpPost]
        [Route("api/agreements")]
        public async Task<ActionResult> AddOrEdit(AgreementAc agreementAc)
        {
            if (ModelState.IsValid)
            {
                var userID = new Guid(User.Identity.GetUserId());
                await _agreementRepository.AddOrUpdateAgreementAsync(agreementAc, userID);
            }
            return View("~/Views/Agreements/Index.cshtml");
        }


        [HttpDelete]
        [Route("api/agreements/{id}")]
        public async Task<ActionResult> AddOrEdit([FromRoute] int id)
        {

            await _agreementRepository.DeleteAgreementById(id);

            return Json(new { success = true });
        }



    }
}

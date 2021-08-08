using IRAOProject.Entities;
using IRAOProject.Models;
using IRAOProject.UnitOfWorks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IRAOProject.Controllers
{
    [ApiController]
    [Route("api/markets/{marketId}/companes")]
    public class CompanyController : ControllerBase
    {
        #region Properties
        private readonly IUnitOfWork unitOfWork;
        #endregion

        #region Constructors
        public CompanyController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        #endregion

        #region Actions
        [HttpGet("list", Name = "CompanesList")]
        public async Task<ActionResult> GetCompanes(int marketId)
        {
            var retValue = default(ActionResult);
            var market  = (await unitOfWork.MarkeRepository.Find(m => m.MarketId == marketId));
            if (market.Count() == 0)
            {
                retValue = NotFound();
            }
            else
            {
                var companes = (await unitOfWork.MarketCompanyRepository.SubList(marketId)).Select(Item => new MarketCompanyDto() { CompanyId = Item.CompanyId, MarketId = Item.MarketId, CompanyName = Item.Company.CompanyName, CompanyPrice = Item.CompanyPrice }).ToList();
                retValue = Ok(companes);
            }
                return retValue;
        }

        [HttpPut("{companyId}")]
        public async Task<ActionResult> UpdateCompanyForMarket(int marketId, int companyId, CompanyForUpdateDto company)
         {
            var retValue = default(ActionResult);
            var marketCompanys = await unitOfWork.MarketCompanyRepository.Find(mc => mc.CompanyId == companyId && mc.MarketId == marketId);
            if (marketCompanys.Count() == 0)
            {
                retValue = NotFound();
            }
            else
            {
                var marketCompany = marketCompanys.FirstOrDefault();
                marketCompany.CompanyPrice = company.CompanyPrice;
                unitOfWork.MarketCompanyRepository.Update(marketCompany);
                await unitOfWork.SaveChanges();
                retValue = Ok();
            }
            return retValue;
        }

        #endregion
    }
}

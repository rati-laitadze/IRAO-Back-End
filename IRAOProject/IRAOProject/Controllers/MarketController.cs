using IRAOProject.Entities;
using IRAOProject.Models;
using IRAOProject.UnitOfWorks;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IRAOProject.Controllers
{
    [ApiController]
    [Route("api/markets")]
    public class MarketController : ControllerBase
    {
        #region Properties
        private readonly IUnitOfWork unitOfWork;
        #endregion

        #region Constructors
        public MarketController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        #endregion

        #region Actions
        [HttpGet("list", Name = "MarketsList")]
        public async Task<ActionResult> GetMarkets()
        {
            var markets = (await unitOfWork.MarkeRepository.All()).Select(Item => new MarketDto() { MarketId = Item.MarketId, MarketName = Item.MarketName }).ToList();
            return Ok(markets);
        }
        #endregion
    }
}

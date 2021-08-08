using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IRAOProject.Entities
{
    public class MarketCompany
    {
        #region Properties
        public int MarketId { get; set; }
        public Market Market { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        [Required]
        public double CompanyPrice { get; set; }
        #endregion
    }
}

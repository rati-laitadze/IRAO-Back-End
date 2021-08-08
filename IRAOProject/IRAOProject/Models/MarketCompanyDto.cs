using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IRAOProject.Models
{
    public class MarketCompanyDto
    {
        public int CompanyId { get; set; }
        public int MarketId { get; set; }
        public string CompanyName { get; set; }
        public double CompanyPrice { get; set; }
    }
}

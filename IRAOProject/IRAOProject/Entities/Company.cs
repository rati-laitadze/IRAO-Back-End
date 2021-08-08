using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IRAOProject.Entities
{
    public class Company
    {
        #region Properties    
        [Key]
        public int CompanyId { get; set; }
        [Required]
        [MaxLength(200)]
        [MinLength(4)]
        public string CompanyName { get; set; }
        
        public ICollection<MarketCompany> MarketCompanies { get; set; }
        #endregion
    }
}

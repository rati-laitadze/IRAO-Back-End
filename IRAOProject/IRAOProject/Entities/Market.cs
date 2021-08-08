using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IRAOProject.Entities
{
    public class Market
    {
        #region Properties
        [Key]
        public int MarketId { get; set; }
        [Required]
        [MaxLength(200)]
        [MinLength(4)]
        public string MarketName { get; set; }
        [Required]
        public ICollection<MarketCompany> MarketCompanies { get; set; }
        #endregion
    }
}

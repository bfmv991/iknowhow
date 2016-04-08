using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTradingWebsite.Models.DatabaseModels
{
    public class Offer
    {
        public int OfferID { get; set; }
        [StringLength(255)]
        
        public string OfferName { get; set; }
        [StringLength(255)]
        
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}

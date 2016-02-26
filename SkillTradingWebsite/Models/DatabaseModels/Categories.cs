using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTradingWebsite.Models.DatabaseModels
{
    public class Category
    {
        public int CategoryID { get; set; }
        [StringLength(255)]
        [Display(Name = "Kategorie")]
        public string CategoryName { get; set; }
        [StringLength(255)]
        [Display(Name = "Beschreibung")]
        public string Description { get; set; }

    }
}

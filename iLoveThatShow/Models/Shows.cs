using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iLoveThatShow.Models
{
    public class Shows
    {
        [Key]
        public int ShowId { get; set; }
        [Display(Name ="Show Name")]
        public string ShowName { get; set; }
        [Display(Name ="Show Type")]
        public string ShowType { get; set; }
        public string Network { get; set; }
        [Display(Name = "Airs On")]
        public string AirDay { get; set; }
        [Display(Name = "Time")]
        public string AirTime { get; set; }
        [Display(Name ="About this \"Channel\"")]
        public string Description { get; set; }
    }
}
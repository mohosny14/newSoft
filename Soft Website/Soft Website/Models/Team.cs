using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Soft_Website.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string image { get; set; }

        [Required]
        [Display(Name = "Job Title")]
        public string Job_title { get; set; }
    }
}
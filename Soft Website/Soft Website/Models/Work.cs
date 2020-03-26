using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Soft_Website.Models
{
    public class Work
    {
        //1
        public int Id { get; set; }


        //2
        [Required]
        [Display(Name = "Title")]
        public string title { get; set; }


        //3
        [Required]
        [Display(Name = "Image")]
        public string image { get; set; }


        //4
        [Required]
        [Display(Name = "Details")]
        public string details { get; set; }

        //5
        [Required]
        [Display(Name = "Features")]
        public string features { get; set; }


        //6
        [Required]
        [Display(Name = "Technologies")]
        public string technologies { get; set; }


        //7
      //  [Required]
        [Display(Name = "Project URL")]
        public string projectUrl { get; set; }


        public virtual Category category { get; set; }
    }
}
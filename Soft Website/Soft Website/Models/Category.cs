using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Soft_Website.Models
{
    public class Category
    {
        //1
        public int Id { get; set; }

        // 2
        [Required]
        [Display(Name = "Category Title")]
        public string CategoryName { get; set; }


        public virtual ICollection<Work> work { get; set; }
    }
}
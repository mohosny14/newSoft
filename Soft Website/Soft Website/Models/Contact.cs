using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Soft_Website.Models
{
    public class Contact
    {
        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string E_mail { get; set; }

        [Required]
        [Display(Name = "Message")]
        public string message { get; set; }
    }
}
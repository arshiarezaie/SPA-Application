
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace SPAexample.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        [Display(Name ="نام")]
        [MaxLength(100)]
        [Required(ErrorMessage ="لطفا {0} را وارد نمایید ")]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        [MaxLength(100)]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید ")]
        public string Family { get; set; }

        [Display(Name = "سن")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید ")]
        public int Age { get; set; }
    }
}
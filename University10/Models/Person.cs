using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace University10.Models
{
    public class Person
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]

        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot")]
        [Column("First Name")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [Display(Name = "Full Name")]

        public string FullName
        {
            get
            {
                return LastName + "," + FirstMidName;
            }
        }
    }
}
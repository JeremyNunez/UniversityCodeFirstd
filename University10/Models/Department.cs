﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace University10.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        [StringLength(50, MinimumLength = 3)]

        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]

        public decimal Budget { get; set; }
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime StarDate { get; set; }

        public int? InstructorID { get; set; }

        [Timestamp]

        public byte[] RowVersion { get; set; }

        public virtual Instructor Administrador { get; set; }

        public virtual ICollection<Course> Courses { get; set; }


    }
}
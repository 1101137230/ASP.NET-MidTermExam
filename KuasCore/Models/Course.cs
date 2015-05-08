namespace KuasCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        [StringLength(20)]
        public string CourseID { get; set; }

        [Required]
        [StringLength(200)]
        public string CourseName { get; set; }

        [StringLength(1000)]
        public string CourseDescription { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netCod.Models
{
    public class Course
    {
         public Course()
        {
            CourseUser = new HashSet<CourseUser>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public bool? Active { get; set; }
        public int? OrderCourse { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdateDate { get; set; }
        public int? InstitutionsId { get; set; }

        [ForeignKey(nameof(InstitutionsId))]
        [InverseProperty("Course")]
        public virtual Institutions Institutions { get; set; }
        [InverseProperty("Course")]
        public virtual ICollection<CourseUser> CourseUser { get; set; }
   
    }
}
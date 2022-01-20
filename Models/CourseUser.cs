using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netCod.Models
{
    public class CourseUser
    {
         [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("CourseID")]
        public int CourseId { get; set; }
        public int UserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdateDate { get; set; }

        [ForeignKey(nameof(CourseId))]
        [InverseProperty("CourseUser")]
        public virtual Course Course { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Users.CourseUser))]
        public virtual Users User { get; set; }
    
    }
}
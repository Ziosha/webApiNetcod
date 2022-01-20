using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace netCod.Models
{
    public class Users
    {
        public Users()
        {
            CourseUser = new HashSet<CourseUser>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Username { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        public int RolsId { get; set; }

        [ForeignKey(nameof(RolsId))]
        [InverseProperty("Users")]
        public virtual Rols Rols { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<CourseUser> CourseUser { get; set; }
    
    }
}
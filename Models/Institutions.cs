using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netCod.Models
{
    public class Institutions
    {
         public Institutions()
        {
            Course = new HashSet<Course>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }

        [InverseProperty("Institutions")]
        public virtual ICollection<Course> Course { get; set; }
    
    }
}
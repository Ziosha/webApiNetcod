using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netCod.Models
{
    public class Rols
    {
        public Rols()
        {
            Users = new HashSet<Users>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }

        [InverseProperty("Rols")]
        public virtual ICollection<Users> Users { get; set; }
    
    }
}
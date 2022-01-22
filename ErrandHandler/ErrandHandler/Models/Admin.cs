using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrandHandler.Models
{
    [Index(nameof(Name), IsUnique = true)]
    internal class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        public virtual ICollection<Errand> Errands { get; set; }
    }
}


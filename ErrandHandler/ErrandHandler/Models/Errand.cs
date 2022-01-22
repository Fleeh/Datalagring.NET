using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrandHandler.Models
{
    [Index(nameof(Email), IsUnique = true)]
    internal class Errand
    {
        [Key]     
        public int Id { get; set; }
        public string ErrandTitle { get; set; }
        
        public string CreationDate { get; set; }
        
        public string LastModifiedDate { get; set; }
        
        public string ErrandDescription { get; set; }
           
        public string Email { get; set; }
       
        public int RoleId { get; set; }

        public int AdminId { get; set; }

        public Admin Admin { get; set; }

        public Role Role { get; set; }
    
        public string DisplayCustomer => $"{Email}";
       

    }
}


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
    internal class User
    {
        [Key]
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
      
        public string Email { get; set; }

        public string Number { get; set; }

        public string Adress { get; set; }

        public string Zipcode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
              
        public string DisplayName => $"{FirstName} {LastName}";
     
    }
}

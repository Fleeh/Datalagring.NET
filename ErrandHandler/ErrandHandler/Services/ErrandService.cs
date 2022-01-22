using ErrandHandler.Data;
using ErrandHandler.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrandHandler.Services
{
    internal interface IErrandService
    {
        bool Create(string email, string errandtitle, string erranddescription, string creationdate, string modifieddate, int roleId, int adminId);
        IEnumerable<Errand> GetAll();
    }
    internal class ErrandService : IErrandService
    {
        private readonly SqlContext _context = new();
        public bool Create(string email, string errandtitle, string erranddescription, string creationdate, string modifieddate, int roleId, int adminId)
        {
            var errand = _context.Errands.Where(x => x.Email ==email).FirstOrDefault();
            if (errand == null)
            {
                _context.Errands.Add(new Errand
                {
                    Email = email,
                    ErrandTitle = errandtitle,
                    ErrandDescription = erranddescription,
                    CreationDate = creationdate,
                    LastModifiedDate = modifieddate, 
                    RoleId = roleId,
                    AdminId = adminId,
                  

                });
                _context.SaveChanges();
                return true;
                
            }
            return false;            
        }

        public IEnumerable<Errand> GetAll()
        {
            return _context.Errands.Include(x => x.Role);
        }

    }
}

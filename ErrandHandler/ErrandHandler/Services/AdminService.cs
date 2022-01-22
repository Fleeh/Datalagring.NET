using ErrandHandler.Data;
using ErrandHandler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrandHandler.Services
{
    internal interface IAdminService
    {
        bool Create(string adminName);
        IEnumerable<Admin> GetAll();
    }
    internal class AdminService : IAdminService
    {
        private readonly SqlContext _context = new();
        public bool Create(string adminName)
        {
            var admin = _context.Admins.Where(x => x.Name == adminName).FirstOrDefault();
            if (admin == null)
            {
                _context.Admins.Add(new Admin  { Name = adminName });
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Admin> GetAll()
        {
            return _context.Admins;
        }
    }
}

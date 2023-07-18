using GettingStart1.DataAcess.Data;
using GettingStart1.DataAcess.Repository.IRepository;
using GettingStart1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GettingStart1.DataAcess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser> ,IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(ApplicationUser obj)
        {
            _db.ApplicationUsers.Update(obj);
        }
    }
}

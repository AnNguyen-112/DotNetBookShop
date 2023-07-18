using GettingStart1.DataAcess.Data;
using GettingStart1.DataAcess.Repository.IRepository;
using GettingStart1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStart1.DataAcess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update (Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}

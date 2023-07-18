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
    public class ShoppingCartRepository : Repository<ShoppingCart> ,IShoppingCartRepository
    {
        private readonly ApplicationDbContext _db;
        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}

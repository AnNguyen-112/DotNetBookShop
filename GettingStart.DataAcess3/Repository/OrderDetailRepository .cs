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
    public class OrderDetailRepository : Repository<OrderDetail> ,IOrderDetailRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(OrderDetail obj)
        {
            _db.OrderDetails.Update(obj);
        }
    }
}

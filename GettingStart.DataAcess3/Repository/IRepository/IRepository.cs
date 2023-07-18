using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GettingStart1.DataAcess.Repository.IRepository
{
    public interface IRepository <T> where T : class
    {
        //T - Category
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter=null, string? includeProperties = null);
        T Get (Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false);
        void Add(T entity);

        // // should not put in repository pattern due to difference in logical between entities
        //void Update(T entity);  
        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);

    }
}

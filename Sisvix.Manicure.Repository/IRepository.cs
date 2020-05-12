using System;
using System.Collections.Generic;
using System.Text;

namespace Sisvix.Manicure.Repository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetList();
        long Insert(T entity);
        bool InsertList(List<T> listEntity);
        bool Update(T entity);
        bool Delete(T entity);
        IEnumerable<T> Query(string query);
    }
}

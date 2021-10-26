using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    /// <summary>
    /// making interface general enough that any class can make any change necessary such as crud operations
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepositoryBase<T> where T : class
    {
        /// <summary>
        /// array of type T is generatic class returning all similar to a select *
        /// </summary>
        /// <returns></returns>
        ICollection<T> FindAll();

        T FindById(int id);

        bool isExists(int id);

        bool Edit(int id);

        bool Create(T entity);

        bool Update(T entity);

        bool Delete (T entity);

        bool Save();
    }
}

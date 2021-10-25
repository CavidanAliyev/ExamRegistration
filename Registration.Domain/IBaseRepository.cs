using Registration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Domain
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        IEnumerable<TEntity> GetItems();
        TEntity GetItemByID(int id);
        void InsertItem(TEntity entity);
        void DeleteItem(int id);
        void UpdateItem(TEntity entity);
        void Save();
    }
}

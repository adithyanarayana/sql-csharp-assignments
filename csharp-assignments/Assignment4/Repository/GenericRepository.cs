using Assignment4.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : Entity
    {
        private List<T> list;

        public GenericRepository()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Remove(T item)
        {
            list.Remove(item);
        }

        public void Save()
        {
           
        }

        public IEnumerable<T> GetAll()
        {
            return list;
        }

        public T GetById(int id)
        {
            foreach (var item in list)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}

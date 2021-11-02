using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Repositories
{
    abstract public class Feed<T> : IRepository<T>
    {
        public RSSReader reader;
        public List<T> list;

        public Feed(List<T> list)
        {
            reader = new RSSReader();
            this.list = list;
        }
        public virtual void Create(T entity)
        {
            list.Add(entity);
        }
        public virtual void Delete(T entity)
        {
            list.Remove(entity);
        }
        public virtual void Delete(int index)
        {
            list.RemoveAt(index);
        }

        public virtual List<T> GetAll()
        {
            return list;
        }
        public abstract void Update(string a, string b);

        //ldfjvndlfjvn
    }
}

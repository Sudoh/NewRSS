using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelss;

namespace DataAccessLayer.Repositories
{
    public interface IKategoriRepository<T> : IRepository<T> where T : Kategori
    {
        T GetKategoriByName(string name);

        int GetIndex(string name);

    }
}

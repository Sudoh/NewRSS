using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelss;
using DataAccessLayer.Repositories;


namespace ServiceLayer.ServiceFolder
{
    public class KategoriService
    {
        IKategoriRepository<Kategori> kategoriRepository;

        public KategoriService()
        {
            kategoriRepository = new KategoriRepository();
        }

        public void CreateKategori(string name)
        {
            Kategori nyKategori = null;
            nyKategori = new Kategori(name);
            kategoriRepository.Create(nyKategori);
        }

        public void RenameKategori(string oldName, string nyName)
        {

            Kategori uppdateradKategori = null;
            int index = kategoriRepository.GetIndex(oldName);
            uppdateradKategori = new Kategori(nyName);
            kategoriRepository.Update(index, uppdateradKategori);
   
        }

        public void DeleteKategori(string name)
        {
            int index = kategoriRepository.GetIndex(name);
            kategoriRepository.Delete(index);
        }

        public List<Kategori> GetAllKategoris()
        {
            return kategoriRepository.GetAll();
        }

        public int GetKategoriIndex(string name)
        {
            int index = kategoriRepository.GetIndex(name);

            return index;
        }

    }
}

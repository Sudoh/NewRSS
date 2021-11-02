using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelss;
using DataAccesLayer;

namespace DataAccessLayer.Repositories
{
    public class KategoriRepository : IKategoriRepository<Kategori>
    {
        //Note to self: Här sker filhanteringen.
        //Gör om metoderna så att det ser ut soma tt den har laddat från interface när allt är klart. 

        SerializerForKategori dataManager;
        List<Kategori> listOfKategories;

        public KategoriRepository()
        {
            dataManager = new SerializerForKategori();
            listOfKategories = new List<Kategori>();
            listOfKategories = GetAll();
        }

        public void Create(Kategori entity)
        {
            listOfKategories.Add(entity);
            SaveChanges();
        }

        public void Delete(int index)
        {
            //Metoderna pratar med serializer
            listOfKategories.RemoveAt(index);
            SaveChanges();

        }

        public List<Kategori> GetAll()
        {
            //Metoderna pratar med serializer
            List<Kategori> listOfKategoriesDeserialized = new List<Kategori>();

            try
            {
                listOfKategoriesDeserialized = dataManager.Deserialize();
            }
            catch (Exception)
            {
                
            
            }

            return listOfKategoriesDeserialized;

        }

        public int GetIndex(string name)
        {
            return GetAll().FindIndex(e => e.KategoriNamn.Equals(name));
        }

        public Kategori GetKategoriByName(string name)
        {
            return GetAll().FirstOrDefault(p => p.KategoriNamn.Equals(name));
        }

        public void Update(int index, Kategori entity)
        {

         listOfKategories[index].KategoriNamn = entity.KategoriNamn.ToString();

            SaveChanges();
        }

        public void SaveChanges()
        {
            //Skicka till serializer
            dataManager.Serialize(listOfKategories);
        }

    }

}

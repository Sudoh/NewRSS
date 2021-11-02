using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using modelss;

namespace DataAccessLayer.Repositories
{
  
    public class AvsnittRepository
    {
       
        List<Avsnitt> listOfAvsnitt;

        public AvsnittRepository()
        {
             listOfAvsnitt = new List<Avsnitt>();
            listOfAvsnitt = GetAll();
        }

        
        public Avsnitt GetTheNewsByIndex(string namn)
        {

            return GetAll().FirstOrDefault(p => p.NewsTitel.Equals(namn));

        }

        public List<Avsnitt> GetAll()
        {
            return listOfAvsnitt;
        }


    }
}

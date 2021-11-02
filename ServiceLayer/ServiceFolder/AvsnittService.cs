using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using modelss;

namespace ServiceLayer.ServiceFolder
{
    
    public class AvsnittService
    {
        AvsnittRepository AvsnittRepository;

        public AvsnittService()
        {
            AvsnittRepository = new AvsnittRepository();
        }


        public string GetAvsnitt(string namn)
        {
            return AvsnittRepository.GetTheNewsByIndex(namn).NewsDescription.ToString();
        }
    }
}

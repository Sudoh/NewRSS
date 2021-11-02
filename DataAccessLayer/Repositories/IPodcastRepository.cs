using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelss;


namespace DataAccessLayer.Repositories
{
    public interface IPodcastRepository<T> : IRepository<T> where T: Podcast
    {

        T GetPodcastByName(string name);

        int GetIndex(string name);

        void UpdateAllPodcastKategori(string oldKategori, string newKategori);

        Task UpdatePodcastAvsnitt(List<Podcast> batch);

    }
}

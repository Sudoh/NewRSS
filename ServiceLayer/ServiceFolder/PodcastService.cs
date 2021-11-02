using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelss;
using DataAccessLayer.Repositories;

namespace ServiceLayer.ServiceFolder
{
    public class PodcastService
    {
        IPodcastRepository<Podcast> podcastRepository;

        public PodcastService()
        {
            podcastRepository = new PodcastRepository();
        }


        public void DownloadPodcast(string url, string namn, string kategori, int uppdateringsFrekvens, DateTime dateTime)
        {

            Podcast podcast = new Podcast();
            podcast.URL = url;
            podcast.Namn = namn;
            podcast.kategori = kategori;
            podcast.UppdateringsIntervall = uppdateringsFrekvens;
            podcast.datumTillaggd = dateTime;
            podcastRepository.Create(podcast);

        }

        public async Task DownloadPodcastAsync(string url, string namn, string kategori, int uppdateringsFrekvens)
        {
            await Task.Run(() => DownloadPodcast(url, namn, kategori, uppdateringsFrekvens, DateTime.Now));

        }

        public List<Podcast> GetAllPodcasts()
        {
            return podcastRepository.GetAll();

        }

        public List<Avsnitt> GetAllAvsnittFromPodcastByName(string name)
        {

         return podcastRepository.GetPodcastByName(name).DisplayAllaAvsnitt();
   
        }

        public void DeletPodcast(string name)
        {

            int index = podcastRepository.GetIndex(name);
            podcastRepository.Delete(index);
        }

        public void ChangePodcast(string oldName, string newName, int oldIntervall, int newIntervall, string oldKategori, string newKategori)
        {

            Podcast uppdateradPodcast;
            int index = podcastRepository.GetIndex(oldName);

            uppdateradPodcast = new Podcast
            {
                Namn = newName,
                kategori = newKategori,
                UppdateringsIntervall = newIntervall,
                datumTillaggd = DateTime.Now
            };

            podcastRepository.Update(index, uppdateradPodcast);

        }

        public void UpdatePodcasts(string oldkat, string newKat)
        {
            podcastRepository.UpdateAllPodcastKategori(oldkat, newKat);
        }

        public void DeletePodcastByKategori(string podcastKategori)
        {

           
            var listOfpodcasts = podcastRepository.GetAll();


            //int index = podcastRepository.GetIndex(kategori);

            var listOfPodcasts = (from pod in listOfpodcasts
                           where pod.kategori == podcastKategori
                           select pod).ToList();

            foreach (Podcast item in listOfPodcasts)
            {
                string name = item.Namn;
                int index = podcastRepository.GetIndex(name);
                podcastRepository.Delete(index);
            }
            
        }

        public async Task DownloadNewAvsnittForPodcasts(List<Podcast> podcasts)
        {

            var listOfpodcasts = podcastRepository.GetAll();
            await podcastRepository.UpdatePodcastAvsnitt(podcasts);

        }

    }
}

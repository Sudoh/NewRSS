using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;


namespace modelss
{

  
    [Serializable]

        public class Podcast
    {

        //Podcast
        public string Namn { get; set; }
        public string URL { get; set; }
        public List<Avsnitt> Avsnitt { get; set; }

        public int AntalAvsnitt { get; set; }

        //public Kategori kategori { get; set; }

        //Ändrar om till att kategori sparas som kategori objekt för att komma index.
        public string kategori { get; set; }

        public int UppdateringsIntervall { get; set; }

        public DateTime datumTillaggd { get; set; }

        public Podcast(string namn, string kategori, string url, int antalAvsnitt, int uppdateringsIntervall, List<Avsnitt> avsnitt, DateTime dateTime)
        {
            Namn = namn;
            this.kategori = kategori;
            URL = url;
            UppdateringsIntervall = uppdateringsIntervall;
            AntalAvsnitt = antalAvsnitt;
            Avsnitt = avsnitt;
            datumTillaggd = dateTime;

        }

        public Podcast()
        {

        }

        public List<Avsnitt> DisplayAllaAvsnitt()
        {
            return Avsnitt;
        }

    }

    }

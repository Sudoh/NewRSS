using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace modelss
{
    [Serializable]
    public class Avsnitt
    {
        //Avsnitt
        public string NewsLink { get; set; }

        public string NewsDescription { get; set; }

        public string NewsTitel { get; set; }

        public Avsnitt(string titel, string link, string desc)
        {
            NewsTitel = titel;
            NewsLink = link;
            NewsDescription = desc;
            
        }

        public Avsnitt()
        {
            NewsTitel = "";
            NewsLink = "";
            NewsDescription = "";
        }

        public object ToList()
        {
            throw new NotImplementedException();
        }

        public string DisplayNews()
        {
            return NewsDescription;
        }
    }
}

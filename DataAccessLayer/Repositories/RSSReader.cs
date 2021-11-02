using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using modelss;

namespace DataAccessLayer.Repositories
{

    public class RSSReader
    {

        public List<Avsnitt> RssRead(string url)
        {

            List<Avsnitt> avsnitt = new List<Avsnitt>();
            XDocument rssfeedxml = XDocument.Load(url);

            try
            {
                avsnitt = (from x in rssfeedxml.Descendants("item")

                               //Response.Write(list);  
                           select new Avsnitt
                           {
                               NewsTitel = x.Element("title").Value,
                               NewsDescription = x.Element("description").Value,
                               //NewsLink = x.Element("link").Value,

                           }).ToList();
            }
            catch (Exception)
            {

                throw;
            }

 


 return avsnitt;

        }
    }
}



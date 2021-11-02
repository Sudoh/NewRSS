using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using modelss;
using DataAccesLayer.Exceptions;

namespace DataAccesLayer
{
    internal class SerializerForPodcast
    {
        public void Serialize(List<Podcast> PodcastList)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream outFile = new FileStream("Podcast.xml", FileMode.Create,
                    FileAccess.Write))
                {
                    xmlSerializer.Serialize(outFile, PodcastList);
                }
            }
            catch (Exception e)
            {
                throw new SerializerException("Podcast.xml", "Could not serialize to the file");
            }
        }

       public List<Podcast> Deserialize()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream inFile = new FileStream("Podcast.xml", FileMode.Open,
                    FileAccess.Read))
                {
                    return (List<Podcast>)xmlSerializer.Deserialize(inFile);
                }
            }
            catch (Exception e)
            {
                throw new SerializerException("Podcast.xml", "Could not deserialize the file.");
            }
            
        }
    }
}

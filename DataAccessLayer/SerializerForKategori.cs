using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using modelss;
using DataAccesLayer.Exceptions;


namespace DataAccesLayer
{
    internal class SerializerForKategori
    {
        public void Serialize(List<Kategori> kategoriList)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kategori>));
                using (FileStream outFile = new FileStream("Kategori.xml", FileMode.Create,
                    FileAccess.Write))
                {
                    xmlSerializer.Serialize(outFile, kategoriList);
                }
            }
            catch (Exception)
            {
                throw new SerializerException("Kategori.xml", "Could not serialize to the file");
            }
        }

        public List<Kategori> Deserialize()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kategori>));
                using (FileStream inFile = new FileStream("Kategori.xml", FileMode.Open,
                    FileAccess.Read))
                {
                    return (List<Kategori>)xmlSerializer.Deserialize(inFile);
                }
            }
            catch (Exception)
            {
                throw new SerializerException("Kategori.xml", "Could not deserialize the file.");
            }
            
        }
    }
}

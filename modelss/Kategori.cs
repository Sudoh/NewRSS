using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelss
{
    [Serializable]
    public class Kategori
    {
        //Här är själva kategoriclassen, varje kategori blir ett obkjekt.
        public string KategoriNamn{ get; set; }

        public Kategori(string kategoriNamn)
        {
            KategoriNamn = kategoriNamn;

        }

        //Tom kontruktor - för att klara krav om fler konstruktörer.
        public Kategori()
        {
            KategoriNamn = "";

        }
    }
}

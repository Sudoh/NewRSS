using ServiceLayer.ServiceFolder;
using System;
using System.Net;
using System.Windows.Forms;


namespace Grupp_28_RSS
{
    public class Validering


    {
       public readonly KategoriService kategoriService;

        public Validering()
        {
            kategoriService = new KategoriService();

        }
        public bool StringIsEmpty(string input)
        {
            bool result = false;

            if (input.Equals(""))
            {
                result = true;
            }

            return result;
        }

        public bool ValideraURL(string url)
        {
            string URLValidering = string.Empty;
            try
            {
                System.Text.Encoding enc = System.Text.Encoding.ASCII;
                WebClient obj = new WebClient();
                URLValidering = enc.GetString(obj.DownloadData(url));
            }
            catch (Exception e)
            {

                return false;
            }
            return URLValidering.Length != 0 ? true : false;
        }

        public bool ComboBoxHasSelectedValue(ComboBox comboBox)
        {
            bool result = true;

            if (!(comboBox.SelectedIndex > -1))
            {
                result = false;
            }

            return result;
        }
        public bool TextBoxNotEmptyOrNull(TextBox textBox)
        {
            bool result = true;

            if (!String.IsNullOrEmpty(textBox.Text))
            {
                result = false;
            }

            return result;
        }


        public bool CheckIfCategoryIsAvailable(TextBox textBox)
        {
            System.Collections.Generic.List<modelss.Kategori> KategorierSomFinns = kategoriService.GetAllKategoris();

            foreach (var kategori in KategorierSomFinns)
            {
                if (textBox.Text == kategori.ToString())
                {
                    MessageBox.Show("Det finns redan en kategori med det namnet");
                    return false;
                }

            }
            return true;

        }



    }
}

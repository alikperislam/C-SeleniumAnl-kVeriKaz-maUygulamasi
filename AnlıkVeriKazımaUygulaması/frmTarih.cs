using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections;

namespace AnlıkVeriKazımaUygulaması
{
    public partial class frmTarih : Form
    {
        public frmTarih()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmTarih_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            IWebDriver drive = new ChromeDriver();
            drive.Navigate().GoToUrl("https://www.imdb.com/chart/top");

            // imdb çekelim xpath ile :

            ReadOnlyCollection<IWebElement> filmİsim = drive.FindElements(By.XPath("//*[@id=\"main\"]/div/span/div/div/div/table/tbody/tr/td/a")); // hata verirse \"main\" yap unutma!!! // not : bir dizi aldığımız için tammanı seçmek amacıyla[x] içerisindeki tüm değerleri sil ve tüm diziyi al. tek tek almak için silme !!!

            ReadOnlyCollection<IWebElement> FilmImdb = drive.FindElements(By.XPath("//*[@id=\"main\"]/div/span/div/div/div/table/tbody/tr/td/strong")); // imdb verilerini aldık.


            ////////////////////////////////////////////////////
            // diziler-listeler.

            List<string> filmList = new List<string>();

            for (int i=0;i<filmİsim.Count;i++)
            {
                var filmm = filmİsim[i].Text;
                filmList.Add(filmm);
            }

            List<string> imdbList = new List<string>();

            for (int i = 0; i < FilmImdb.Count; i++)
            {
                var imdbb = FilmImdb[i].Text;
                imdbList.Add(imdbb);
            }



            /////////////////////////////////////////////////////
            // listbox

            for (int i = 0; i < filmİsim.Count; i++)
            {

                var film = filmİsim[i].Text;



                FİLM.Items.Add(film);

            }

            for (int i = 0; i < FilmImdb.Count; i++)
            {

                var im = FilmImdb[i].Text;



                İMDB.Items.Add(im);

            }

            ////////////////////////////////////////////////////
            //combobox


            for (int i = 0; i < filmList.Count; i++)
            {

                string film = filmList[i];



                comboFilm.Items.Add(film);

            }


            for (int i = 0; i < imdbList.Count; i++)
            {

                string im = imdbList[i];



                comboİMDB.Items.Add(im);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            txtFilm.Text = comboFilm.Text;
            lblfilmadı.Text = comboFilm.Text;

            if (comboFilm.Text.Count()>0 && comboFilm.Text.Count() < 5)
            {
                txtİmdb.Text = "9,0";
            }
            if (comboFilm.Text.Count() > 5 && comboFilm.Text.Count() < 10)
            {
                txtİmdb.Text = "8,3";
            }
            if (comboFilm.Text.Count() > 10 && comboFilm.Text.Count() < 15)
            {
                txtİmdb.Text = "8,8";
            }
            if (comboFilm.Text.Count() > 15 && comboFilm.Text.Count() < 20)
            {
                txtİmdb.Text = "8,2";
            }
            if (comboFilm.Text.Count() > 20 && comboFilm.Text.Count() < 25)
            {
                txtİmdb.Text = "8,0";
            }
            if (comboFilm.Text.Count() ==0 )
            {
                txtİmdb.Text = "0,0";
            }
            if (comboFilm.Text.Count() > 25)
            {
                txtİmdb.Text = "8,7";
            }



        }

        private void comboFilm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

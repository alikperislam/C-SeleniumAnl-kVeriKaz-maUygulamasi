using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AnlıkVeriKazımaUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) // windows penceresi eğer kodlandığı şekilde yani normal vaziyette ise.
            {
                WindowState = FormWindowState.Maximized; // ekranı en büyük yap.

                //int btndelx =btnDelete.Location.X;

                // tamamen kod ile ekran büyüyü küçüldüğü zaman butonların yerinin bozulmamasını yine sağ yukarı çaprazda kalmalarını sağlaıdk bu kod sayesinde.


                Point pt = new Point();
                Point pt0 = new Point();
                Point pt1 = new Point();

                pt.X = btnDelete.Location.X + 325;
                pt.Y = btnDelete.Location.Y;


                pt0.X = btnMinimum.Location.X + 325;
                pt0.Y = btnMinimum.Location.Y;


                pt1.X = btnMinMax.Location.X + 325;
                pt1.Y = btnMinMax.Location.Y;

                btnDelete.Location = pt;
                btnMinimum.Location = pt0;
                btnMinMax.Location = pt1;

            }
            else
            {
                // eğer büyük vaziyetteyse ekran yani normal vaziyette değil ise o zaman;
                WindowState = FormWindowState.Normal;

                int btndelx = btnDelete.Location.X;
                int btndely = btnDelete.Location.Y;
                int btnminx = btnMinimum.Location.X;
                int btnminy = btnMinimum.Location.Y;
                int btnmaxx = btnMinMax.Location.X;
                int btnmaxy = btnMinMax.Location.Y;

                Point pt = new Point();
                Point pt0 = new Point();
                Point pt1 = new Point();

                pt.X = btndelx - 325;
                pt.Y = btndely;


                pt0.X = btnminx - 325;
                pt0.Y = btnminy;


                pt1.X = btnmaxx - 325;
                pt1.Y = btnmaxy;

                btnDelete.Location = pt;
                btnMinimum.Location = pt0;
                btnMinMax.Location = pt1;

            }
        }

        private void panelform(Form frm) // bir method içeriisnde belirtip formdan gelen veriyi methoda göndereceğiz.
        {
            anaPanel.Controls.Clear(); // üst üste formlar gelmemesi için panelin içerisini her seferinde temizliyoruz.
            frm.MdiParent = this; // gelen formu yani açılacak olan formu burada açacağına dair Mdi=this; yapıyoruz.
            anaPanel.Controls.Add(frm);//formu nerede açacaksa o panelin controlune ekliyoruz.
            frm.Show(); // formu ekranda göstermesi için klasik .show methodunu kullnmamız gerek.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureTarih.BackColor = Color.FromArgb(172, 126, 241);
            lblbaslik.ForeColor = Color.FromArgb(172, 126, 241);

            frmTarih tar = new frmTarih();
            panelform(tar);

            

            

        }

        
            
        


        private void button7_Click(object sender, EventArgs e)
        {
            pictureDoviz.BackColor = Color.FromArgb(249, 118, 176);
            lblbaslik.ForeColor = Color.FromArgb(249, 118, 176);

            frmDoviz dov = new frmDoviz();
            panelform(dov);


        }

        private void button6_Click(object sender, EventArgs e)
        {
           pictureDunyaNufus.BackColor = Color.FromArgb(253, 138, 114);
            lblbaslik.ForeColor = Color.FromArgb(253, 138, 114);

            frmDunyaNufuscs dunN = new frmDunyaNufuscs();
            panelform(dunN);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureTurkiyeNufus.BackColor = Color.FromArgb(9, 237, 237);
            lblbaslik.ForeColor = Color.FromArgb(9, 237, 237);

            frmTurkiyeNufus tur = new frmTurkiyeNufus();
            panelform(tur);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureCovid.BackColor = Color.FromArgb(249, 88, 155);
            lblbaslik.ForeColor = Color.FromArgb(249, 88, 155);

            frmCovid cov = new frmCovid();
            panelform(cov);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureDunyaDeprem.BackColor = Color.FromArgb(24, 161, 251);
            lblbaslik.ForeColor = Color.FromArgb(24, 161, 251);

            frmDunyaDeprem dep = new frmDunyaDeprem();
            panelform(dep);


        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            lblbaslik.ForeColor = Color.White;
            
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PopupNotifier popp = new PopupNotifier();
            popp.ContentText = "www.theblackconsole.com";
            popp.BodyColor = Color.Black;
            popp.ContentColor = Color.White;
            popp.Image = Properties.Resources.git;
            popp.Popup();

            IWebDriver drive = new ChromeDriver();
            drive.Navigate().GoToUrl("http://theblackconsole.com/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PopupNotifier popp = new PopupNotifier();
            popp.ContentText = "alikperislam";
            popp.BodyColor = Color.Fuchsia;
            popp.ContentColor = Color.White;
            popp.Image = Properties.Resources.ins;
            popp.Popup();

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.instagram.com/accounts/onetap/?next=%2F&hl=tr");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PopupNotifier popp = new PopupNotifier();
            popp.ContentText = "+90 (xxx) xxx xx xx";
            popp.BodyColor = Color.Green;
            popp.ContentColor = Color.White;
            popp.Image = Properties.Resources.wppp;
            popp.Popup();
        }

        private void anaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void anaPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}

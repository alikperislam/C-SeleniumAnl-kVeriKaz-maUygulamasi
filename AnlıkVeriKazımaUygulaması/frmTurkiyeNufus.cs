using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnlıkVeriKazımaUygulaması
{
    public partial class frmTurkiyeNufus : Form
    {
        public frmTurkiyeNufus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["nufus"].Points.Clear();
            chart1.Series["nufus"].Points.AddXY("ANKARA", 5639076);
            
            chart1.Series["nufus"].Points.AddXY("İSTANBUL", 15519627);


            chart1.Series["nufus"].Points.AddXY("ADANA", 2237940);
            chart1.Series["nufus"].Points.AddXY("KONYA", 2232374);
            chart1.Series["nufus"].Points.AddXY("BURSA", 3056120);
            chart1.Series["nufus"].Points.AddXY("ŞANLIURFA", 2073614);
            chart1.Series["nufus"].Points.AddXY("GAZİANTEP", 2069364);
            chart1.Series["nufus"].Points.AddXY("ANTALYA", 2511700);
            chart1.Series["nufus"].Points.AddXY("İZMİR", 4367251);
            chart1.Series["nufus"].Points.AddXY("KOCAELİ", 1953035);
        }
    }
}

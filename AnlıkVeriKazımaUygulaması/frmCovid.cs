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
    public partial class frmCovid : Form
    {
        public frmCovid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["covid"].Points.Clear();

            chart1.Series["covid"].Points.AddXY("26.10.2020", 2198);
            chart1.Series["covid"].Points.AddXY("27.10.2020", 2210);
            chart1.Series["covid"].Points.AddXY("28.10.2020", 2304);
            chart1.Series["covid"].Points.AddXY("29.10.2020", 2319);
            chart1.Series["covid"].Points.AddXY("30.10.2020", 2322);
            chart1.Series["covid"].Points.AddXY("31.10.2020", 2213);
            chart1.Series["covid"].Points.AddXY("01.11.2020", 2106);
            chart1.Series["covid"].Points.AddXY("02.11.2020", 2302);
            chart1.Series["covid"].Points.AddXY("03.11.2020", 2343);
            chart1.Series["covid"].Points.AddXY("04.11.2020", 2391);
        }
    }
}

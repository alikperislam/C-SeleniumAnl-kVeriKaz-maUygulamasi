using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AnlıkVeriKazımaUygulaması
{
    public partial class frmDoviz : Form
    {
        public frmDoviz()
        {
            InitializeComponent();
        }

        private void frmDoviz_Load(object sender, EventArgs e)
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml"; // tcmb'nin xml hali.
            var xmldoc = new XmlDocument(); // xml doküman nesnesi oluşturduk.
            xmldoc.Load(bugun); // bugün'ü yükle -----> xmldok'un içerisine.

            // bugünün tarihi için :
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value); // tcmb'nin kaynak kodunda Tarih_Date diye girildiği için biz de aynısını kullanmak zorundayız.

            // döviz kurlarını alalım :

            string dolar = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;

            string euro = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;

            string paund = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling").InnerXml;

            string riyal = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/BanknoteSelling").InnerXml;

            string kron = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='NOK']/BanknoteSelling").InnerXml;

            string dinar = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/BanknoteSelling").InnerXml;

            string frang = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/BanknoteSelling").InnerXml;

            string kanada = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/BanknoteSelling").InnerXml;

            lblabd.Text += dolar;
            lbleuro.Text += euro;
            lblsterlin.Text += paund;
            lblkron.Text += kron;
            lbldinar.Text += dinar;
            lblkanada.Text += kanada;
            lblriyal.Text += riyal;
            lblfrang.Text += frang;

            



            tarihgir.Text += tarih.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml"; // tcmb'nin xml hali.
            var xmldoc = new XmlDocument(); // xml doküman nesnesi oluşturduk.
            xmldoc.Load(bugun); // bugün'ü yükle -----> xmldok'un içerisine.

            // bugünün tarihi için :
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value); // tcmb'nin kaynak kodunda Tarih_Date diye girildiği için biz de aynısını kullanmak zorundayız.

            // döviz kurlarını alalım :

            string dolar = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;

            string euro = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;

            string paund = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling").InnerXml;

            string riyal = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/BanknoteSelling").InnerXml;

            string kron = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='NOK']/BanknoteSelling").InnerXml;

            string dinar = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/BanknoteSelling").InnerXml;

            string frang = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/BanknoteSelling").InnerXml;

            string kanada = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/BanknoteSelling").InnerXml;


            double sayidolar = double.Parse(dolar);
            double sayieuro = double.Parse(euro);
            double sayisterlin = double.Parse(paund);
            double sayiriyal = double.Parse(riyal);
            double sayikron = double.Parse(kron);
            double sayidinar = double.Parse(dinar);
            double sayifrang = double.Parse(frang);
            double sayikanada = double.Parse(kanada);
            sayikron = sayikron - 80000;

            chart1.Series["doviz"].Points.Clear();

            chart1.Series["doviz"].Points.AddXY("ABD DOLARı",sayidolar);
            chart1.Series["doviz"].Points.AddXY("EURO", sayieuro);
            chart1.Series["doviz"].Points.AddXY("STERLİN", sayisterlin);
            chart1.Series["doviz"].Points.AddXY("RİYAL", sayiriyal);
            chart1.Series["doviz"].Points.AddXY("KUVVEYT DİNARI", sayidinar);
            chart1.Series["doviz"].Points.AddXY("İSVİÇRE FRANGI", sayifrang);
            chart1.Series["doviz"].Points.AddXY("KANADA DOLARI", sayikanada);

            chart1.Series["doviz"].Points.AddXY("NORVEÇ KRONU", (sayikron));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

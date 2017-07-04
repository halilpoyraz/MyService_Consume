using MyService_Tuket.ProductionService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyService_Tuket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductionServiceSoapClient service = new ProductionServiceSoapClient();
            MessageBox.Show(service.HelloWorld());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductionServiceSoapClient service = new ProductionServiceSoapClient();
            try
            {
                Kullanici k = new Kullanici();
                k.KullaniciAdi = "Halil";
                k.Parola = "123";
                dataGridView1.DataSource = service.GetAllProducts(k);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

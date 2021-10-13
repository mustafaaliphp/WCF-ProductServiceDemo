using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClient
{
    public partial class Form1 : Form
    {
        ProductServiceReference.ProductServiceClient proxy = new ProductServiceReference.ProductServiceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductServiceReference.ProductContract productContract = new ProductServiceReference.ProductContract();
            textBox1.Text = "Will be implemented soon";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductServiceReference.ProductContract productContract = new ProductServiceReference.ProductContract();
            textBox2.Text = "Will be implemented soon";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductServiceReference.ProductContract productContract = new ProductServiceReference.ProductContract();
            textBox3.Text = "Will be implemented soon";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductServiceReference.ProductContract productContract = new ProductServiceReference.ProductContract();
            textBox4.Text = "Will be implemented soon";
        }
    }
}

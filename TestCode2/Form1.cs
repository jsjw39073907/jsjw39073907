using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCode2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sale;
            txtNumOut.Text = txtNum.Text;
            if (int.Parse(txtAge.Text) < 18 || int.Parse(txtAge.Text) >= 70)
                sale = double.Parse(txtPri.Text) * 0.2;
            else if (int.Parse(txtAge.Text) >= 60 && int.Parse(txtAge.Text) < 70)
                sale = double.Parse(txtPri.Text) * 0.15;
            else
                sale = double.Parse(txtPri.Text) * 0;
            txtSale.Text = sale.ToString();
            txtPriOut.Text = (double.Parse(txtPri.Text) - sale).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

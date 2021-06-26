using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCode5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtNumOut.Text = txtNum.Text;
            double ppr = 0, price = 0;
            switch (txtGra.Text)
            {
                case "1":
                    ppr = 450;
                    break;
                case "2":
                    ppr = 300;
                    break;
                case "3":
                    ppr = 200;
                    break;
            }
            price = double.Parse(txtUse.Text) * ppr;
            txtTax.Text = (price * 0.1).ToString();
            txtPri.Text = (price + double.Parse(txtTax.Text)).ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

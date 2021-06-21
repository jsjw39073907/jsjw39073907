using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtAge.Text) >= 8)
            {

                if (double.Parse(txtHei.Text) >= 120)
                {
                    label5.Text = "탑승가능";
                }
                else
                {
                    label5.Text = "키 미달";
                }


            }
            else {

                if (double.Parse(txtHei.Text) >= 120)
                {
                    label5.Text = "나이 미달";
                }
                else {
                    label5.Text = "둘 다 미달";
                }
                

            }



        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCode6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCpy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("복사하시겠습니까?", "질문", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtResult.Text = "이름 : " + txtName.Text + "\r\n나이 : " + txtAge.Text + "\r\n학번 : " + txtNum.Text + "\r\n주소 : " + txtAdd.Text;
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

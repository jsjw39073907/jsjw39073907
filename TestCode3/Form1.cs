using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCode3
{
    public partial class Form1 : Form
    {
        int cash = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            cash = cash + int.Parse(txtCash.Text);
            MessageBox.Show("입력한 금액은 " + txtCash.Text + " 입니다.", "투입금", MessageBoxButtons.OK);
        }

        private void btnCoff_Click(object sender, EventArgs e)
        {
            if (cash >= 200)
            {
                MessageBox.Show("선택하신 음료는 커피(200원)입니다.", "커피", MessageBoxButtons.OK);
                labelFN.Text = "거스름 돈 " + (cash - 200) + "원을 받아가세요.";
            }

            else
            {
                MessageBox.Show("금액이 부족합니다.", "잔액 부족", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnJui_Click(object sender, EventArgs e)
        {
            if (cash >= 500)
            {
                MessageBox.Show("선택하신 음료는 음료수(500원)입니다.", "음료수", MessageBoxButtons.OK);
                labelFN.Text = "거스름 돈 " + (cash - 500) + "원을 받아가세요.";
            }

            else
            {
                MessageBox.Show("금액이 부족합니다.", "잔액 부족", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCoco_Click(object sender, EventArgs e)
        {
            if (cash >= 300)
            {
                MessageBox.Show("선택하신 음료는 코코아(300원)입니다.", "코코아", MessageBoxButtons.OK);
                labelFN.Text = "거스름 돈 " + (cash - 300) + "원을 받아가세요.";
            }

            else
            {
                MessageBox.Show("금액이 부족합니다.", "잔액 부족", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancof_Click(object sender, EventArgs e)
        {
            if (cash >= 700)
            {
                MessageBox.Show("선택하신 음료는 캔커피(700원)입니다.", "캔커피", MessageBoxButtons.OK);
                labelFN.Text = "거스름 돈 " + (cash - 700) + "원을 받아가세요.";
            }

            else
            {
                MessageBox.Show("금액이 부족합니다.", "잔액 부족", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

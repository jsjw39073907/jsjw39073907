using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study
{
    public partial class Main : Form
    {
        private string strParameter;

        public Main()
        {
            InitializeComponent();
            Load += Main_Load;
            btnFormShow.Click += BtnFormShow_Click;
            btnFormOutShow.Click += BtnFormOutShow_Click;

            strParameter = "안녕하세요";
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void BtnFormShow_Click(object sender, EventArgs e)
        {
            // 0. 중복 창이 띄어져있는지 체크

            if (Application.OpenForms["btnHi"] is btnHi form)
            {
                // btnHi 열려 있을 경우
                form.Focus();
                return;
            }

            // 열려 있지 않은 경우

            // 1. 새로 띄울 Form의 new 객체 생성
            form = new btnHi(strParameter);

            // 2. 폼이름.Show()
            form.MdiParent = this;
            form.Show();
        }

        // 독립 실행으로 열기
        private void BtnFormOutShow_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["btnHi"] is btnHi form)
            {
                // btnHi 열려 있을 경우
                form.Close();
            }

            // 1. 새로 띄울 Form의 new 객체 생성
            form = new btnHi();

            // 2. 폼이름.Show()
            form.Show();
        }

    }
}

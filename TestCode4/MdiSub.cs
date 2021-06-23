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
    public partial class btnHi : Form
    {
        private string parameter;

        public btnHi()
        {
            InitializeComponent();
        }


        public btnHi(string strParameter)
        {
            InitializeComponent();
            Load += BtnHi_Load;

            parameter = strParameter;
        }

        private void BtnHi_Load(object sender, EventArgs e)
        {
            btnHi1.Text = parameter;
        }
    }
}

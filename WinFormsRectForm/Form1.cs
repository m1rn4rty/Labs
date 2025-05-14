using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsRectForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBorderStyle_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void btnOpacity_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }
    }
}

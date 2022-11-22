using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grand
{
    public partial class SuperForm : Form
    {
        public SuperForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void centre_Click(object sender, EventArgs e)
        {
            Rectangle x = Screen.PrimaryScreen.Bounds;

            Int32 widh = this.Size.Width;
            Int32 hei = this.Size.Height;

            this.Location = new Point((x.Width / 2)-(widh/2), (x.Height / 2)-(hei/2));
        }

        private void up_Click(object sender, EventArgs e)
        {
            Rectangle x = Screen.PrimaryScreen.Bounds;

            Int32 widh = this.Size.Width;
            Int32 hei = this.Size.Height;

            this.Top = 0;
            this.Left = x.Size.Width / 2 - widh / 2;
        }

        private void right_Click(object sender, EventArgs e)
        {
            Rectangle x = Screen.PrimaryScreen.Bounds;

            Int32 widh = this.Size.Width;
            Int32 hei = this.Size.Height;

            this.Location = new Point((x.Width / 2) - (widh / 2), (x.Height / 2) - (hei / 2));
        }

        private void upl_Click(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;

        }
    }
}

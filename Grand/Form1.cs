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
        public bool locker10 = false;
        public int UserWidth = 880;
        public int UserHeight = 500;

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

            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
        }

        private void upl_Click(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;

        }

        private void downr_Click(object sender, EventArgs e)
        {
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
        }

        private void down_Click(object sender, EventArgs e)
        {
            Rectangle x = Screen.PrimaryScreen.Bounds;

            Int32 widh = this.Size.Width;
            Int32 hei = this.Size.Height;

            this.Location = new Point((x.Width / 2) - (widh / 2), (x.Height / 2) - (hei / 2));

            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
        }

        private void upr_Click(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
        }

        private void left_Click(object sender, EventArgs e)
        {
            Rectangle x = Screen.PrimaryScreen.Bounds;

            Int32 widh = this.Size.Width;
            Int32 hei = this.Size.Height;

            this.Location = new Point((x.Width / 2) - (widh / 2), (x.Height / 2) - (hei / 2));

            this.Left = 0;
        }

        private void downl_Click(object sender, EventArgs e)
        {
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Left = 0;
        }

        private void Polojeniye_Enter(object sender, EventArgs e)
        {

        }

        private void resbutton_Click(object sender, EventArgs e)
        {
            this.Size = new Size(UserWidth, UserHeight);
        }

        private void textresol_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void SuperForm_Resize(object sender, EventArgs e)
        {
            Size ScRes, WARes;
            ScRes = Screen.PrimaryScreen.Bounds.Size;
            WARes = Screen.GetWorkingArea(this).Size;
            textBoxrab.Text = $"{WARes.Width}x{WARes.Height}";
            textBoxres.Text = $"{ScRes.Width}x{ScRes.Height}";
            textresol.Text = ($"{Width}x{Height}");
            textBoxform.Text = textresol.Text;
        }

        private void cheking_CheckedChanged(object sender, EventArgs e)
        {
            if (cheking.Checked)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                locker10 = false;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                locker10 = true;
            }
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            UserWidth += 250;
            UserHeight += 150;
            resbutton.Text = ($"{UserWidth}x{UserHeight}");
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            if (UserWidth > 880 & UserHeight > 500)
            {
                UserWidth -= 250;
                UserHeight -= 150;
                resbutton.Text = ($"{UserWidth}x{UserHeight}");
            }
            else
            {
                UserWidth = 880;
                UserHeight = 500;
                resbutton.Text = ($"{UserWidth}x{UserHeight}");
            }
        }

        private void sver_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sverwind_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void razver_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void textBoxres_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxform_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxrab_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.25;
        }

        private void разрешитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            locker10 = false;
        }

        private void запретитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            locker10 = true;
        }

        private void стандартныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = DefaultCursor;
        }

        private void кастомныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("cursor.cur");
        }

        private void акварамироваяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            this.ForeColor = Color.Black;
            Polojeniye.ForeColor = Color.Black;
            Swertok.ForeColor = Color.Black;
            locker.ForeColor = Color.Black;
            info.ForeColor = Color.Black;
            terminatebut.ForeColor = Color.Black;
            textresol.ForeColor = Color.Black;
            textBoxres.ForeColor = Color.Black;
            textBoxform.ForeColor = Color.Black;
            textBoxrab.ForeColor = Color.Black;

            Polojeniye.BackColor = Color.Aquamarine;
            Swertok.BackColor = Color.MediumAquamarine;
            locker.BackColor = Color.LightSeaGreen;
            info.BackColor = Color.Turquoise;
            terminatebut.BackColor = Color.MediumTurquoise;

            centre.BackColor = SystemColors.Control;
            up.BackColor = SystemColors.Control;
            down.BackColor = SystemColors.Control;
            downr.BackColor = SystemColors.Control;
            downl.BackColor = SystemColors.Control;
            left.BackColor = SystemColors.Control;
            right.BackColor = SystemColors.Control;
            upr.BackColor = SystemColors.Control;
            upl.BackColor = SystemColors.Control;
            exit.BackColor = SystemColors.Control;
            resbutton.BackColor = SystemColors.Control;
            razver.BackColor = SystemColors.Control;
            sver.BackColor = SystemColors.Control;
            sverwind.BackColor = SystemColors.Control;
            buttonplus.BackColor = SystemColors.Control;
            buttonminus.BackColor = SystemColors.Control;
            textBoxform.BackColor = SystemColors.Window;
            textBoxres.BackColor = SystemColors.Window;
            textBoxrab.BackColor = SystemColors.Window;
            textresol.BackColor = SystemColors.Window;
        }

        private void краснаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Crimson;
            this.ForeColor = Color.Black;
            Polojeniye.ForeColor = Color.White;
            Swertok.ForeColor = Color.White;
            locker.ForeColor = Color.White;
            info.ForeColor = Color.White;
            terminatebut.ForeColor = Color.White;
            textresol.ForeColor = Color.White;
            textBoxres.ForeColor = Color.White;
            textBoxform.ForeColor = Color.White;
            textBoxrab.ForeColor = Color.White;

            Polojeniye.BackColor = Color.DarkRed;
            Swertok.BackColor = Color.DarkRed;
            locker.BackColor = Color.DarkRed;
            info.BackColor = Color.DarkRed;
            terminatebut.BackColor = Color.DarkRed;


            centre.BackColor = Color.Red;
            up.BackColor = Color.Red;
            down.BackColor = Color.Red;
            downr.BackColor = Color.Red;
            downl.BackColor = Color.Red;
            left.BackColor = Color.Red;
            right.BackColor = Color.Red;
            upr.BackColor = Color.Red;
            upl.BackColor = Color.Red;
            exit.BackColor = Color.Red;
            resbutton.BackColor = Color.Red;
            sver.BackColor = Color.Red;
            razver.BackColor = Color.Red;
            sverwind.BackColor = Color.Red;
            buttonplus.BackColor = Color.Red;
            buttonminus.BackColor = Color.Red;
            textBoxform.BackColor = Color.Red;
            textBoxres.BackColor = Color.Red;
            textBoxrab.BackColor = Color.Red;
            textresol.BackColor = Color.Red;
        }

        private void заднийФонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = null;  
            OpenFileDialog openFileDialogBg = new OpenFileDialog(); 
            openFileDialogBg.InitialDirectory = "C:\\"; 
            if (openFileDialogBg.ShowDialog() == DialogResult.OK)   
            {
                image = new Bitmap(openFileDialogBg.FileName);
                tableLayoutPanel1.BackgroundImage = image;
            }
        }
    }
}

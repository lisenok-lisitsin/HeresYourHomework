using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessCalc
{
    public partial class BusForm : Form
    {
        public BusForm()
        {
            InitializeComponent();
            nedvPR.Text = "0";
            yearBET.Text = "0";
            monthz.Text = "0";
            firstInp.Text = "0";
        }
        private void nedvPR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void nedvPR_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length == 0)
            {
                (sender as TextBox).Text = "0";
            }
            while ((sender as TextBox).Text.StartsWith("."))
            {
                (sender as TextBox).Text = (sender as TextBox).Text.Remove(0, 1);
            }
        }
        private void yearBET_TextChanged(object sender, EventArgs e)
        {
            while ((sender as TextBox).Text.StartsWith("."))
            {
                (sender as TextBox).Text = (sender as TextBox).Text.Remove(0, 1);
            }
            if ((Convert.ToDouble((sender as TextBox).Text)) > 100)
            {
                (sender as TextBox).Text = "100";
            }
        }
        private void monthz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}

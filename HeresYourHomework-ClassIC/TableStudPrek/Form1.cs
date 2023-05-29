using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableStudPrek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bacon_Click(object sender, EventArgs e)
        {
            int rowco = Convert.ToInt32(rowc.Text);
            int colco = Convert.ToInt32(colc.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int c = 29;
            string[] b = RandomName.SortRName(c);
            int er = DGV1.ColumnCount;
            int lmg = (er * c);
            string[] fr = RandomMark.Default(lmg);
            DGV1.Rows.Add(c-1);
            int jey = DGV1.Rows.Count;
            for (int i = 0; i < er; i++)
            {
                for (int j = 0; j < jey; j++)
                {
                    DGV1.Rows[j].Cells[i].Value = fr[k];
                }
            }
            for (int i = 0; i < c; i++)
            {
                DGV1.Rows[i].Cells[0].Value = (b[i]);
                DGV1.Rows[i].HeaderCell.Value = $"{i + 1}";
            }
            DGV1.TopLeftHeaderCell.Value = "Номер";
        }
    }
}

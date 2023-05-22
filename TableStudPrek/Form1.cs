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
            int jey = DGV1.Rows.Count;
            int lmg = er + jey;
            //string[] g = RandomMark.Default(c);
            //string[] ea = RandomMark.Special(c);
            string g;
            for (int i = 0; i < c; i++)
            {
                g = RandomMark.Default(lmg);
                DGV1.Rows.Add(b[i]);
                //DGV1.Rows[i].Cells[3].Value = ea[i];
                //DGV1.Rows[i].Cells[1].Value = g[i];
                DGV1.Rows[i].Cells[1].Value = g;
                DGV1.Rows[i].HeaderCell.Value = $"{i + 1}";
            }

            

            
            //string g;
            //for (int i = 0; i < lmg; i++)
            //{
            //    DGV1.Rows[i].Cells[i+1].Value = g;
            //}
            DGV1.TopLeftHeaderCell.Value = "Номер";
            
        }
    }
}

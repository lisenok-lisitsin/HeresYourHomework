﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double first, sec, resu;
            first = Convert.ToDouble(num1.Text);
            sec = Convert.ToDouble(num2.Text);
            resu = first / sec;
            res.Text = Convert.ToString(resu);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double first, sec, resu;
            first = Convert.ToDouble(num1.Text);
            sec = Convert.ToDouble(num2.Text);
            resu = first * sec;
            res.Text = Convert.ToString(resu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double first, sec, resu;
            first = Convert.ToDouble(num1.Text);
            sec = Convert.ToDouble(num2.Text);
            resu = first - sec;
            res.Text = Convert.ToString(resu);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double first, sec, resu;
            first = Convert.ToDouble(num1.Text);
            sec = Convert.ToDouble(num2.Text);
            resu = first + sec;
            res.Text = Convert.ToString(resu);
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

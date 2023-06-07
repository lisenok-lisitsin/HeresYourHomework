using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Times
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Int32 lnum = 1;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerMisec.Stop();
            startbut.Text = "Запуск";
            ms.Text = "0";
            s.Text = "0";
            min.Text = "0";
            hours.Text = "0";
            laps.Text = string.Empty;
            lnum = 1;
            msh.Enabled = true;
            noms.Enabled = true;
            noh.Enabled = true;
            nomsh.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timerMisec.Enabled == false)
            {
                startbut.Text = "Стоп";
                if (msh.Checked == true)
                {
                    timerMisec.Enabled = true;
                    ms.Enabled = true;
                    ms.Visible = true;
                    s.Enabled = true;
                    s.Visible = true;
                    min.Enabled = true;
                    min.Visible = true;
                    hours.Enabled = true;
                    hours.Visible = true;
                }
                else if (noms.Checked == true)
                {
                    timerMisec.Enabled = true;
                    ms.Enabled = false;
                    ms.Visible = false;
                    s.Enabled = true;
                    s.Visible = true;
                    min.Enabled = true;
                    min.Visible = true;
                    hours.Enabled = true;
                    hours.Visible = true;
                }
                else if (noh.Checked == true)
                {
                    timerMisec.Enabled = true;
                    ms.Enabled = true;
                    ms.Visible = true;
                    s.Enabled = true;
                    s.Visible = true;
                    min.Enabled = true;
                    min.Visible = true;
                    hours.Enabled = false;
                    hours.Visible = false;
                }
                else if (nomsh.Checked == true)
                {
                    timerMisec.Enabled = true;
                    ms.Enabled = false;
                    ms.Visible = false;
                    s.Enabled = true;
                    s.Visible = true;
                    min.Enabled = true;
                    min.Visible = true;
                    hours.Enabled = false;
                    hours.Visible = false;
                }
                msh.Enabled = false;
                noms.Enabled = false;
                noh.Enabled = false;
                nomsh.Enabled = false;
            }
            else
            {
                startbut.Text = "Запуск";
                timerMisec.Enabled = false;
                msh.Enabled = true;
                noms.Enabled = true;
                noh.Enabled = true;
                nomsh.Enabled = true;
            }    
        }

        private void timerMisec_Tick(object sender, EventArgs e)
        {
            ms.Text = Convert.ToString(Math.Round(Convert.ToDouble(ms.Text) + 17.04));
            if (Convert.ToDouble(ms.Text) >= 1000)
            {
                ms.Text = "0";
                s.Text = Convert.ToString(Convert.ToInt32(s.Text) + 1);
                if (Convert.ToInt32(s.Text) == 60)
                {
                    s.Text = "0";
                    min.Text = Convert.ToString(Convert.ToInt32(min.Text) + 1);
                    if (Convert.ToInt32(min.Text) == 60)
                    {
                        min.Text = "0";
                        hours.Text = Convert.ToString(Convert.ToInt32(hours.Text) + 1);
                        if (Convert.ToInt32(hours.Text) == 24)
                        {
                            hours.Text = "0";
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            msh.Checked = true;
        }

        public void lapbut_Click(object sender, EventArgs e)
        {
            laps.Text += Convert.ToString(lnum) + " - ";
            if (msh.Checked == true)
            {
                laps.Text += hours.Text + ":" + min.Text + ":" + s.Text + ":" + ms.Text;
            }
            else if (noms.Checked == true)
            {
                laps.Text += hours.Text + ":" + min.Text + ":" + s.Text;
            }
            else if (noh.Checked == true)
            {
                laps.Text += min.Text + ":" + s.Text + ":" + ms.Text;
            }
            else if (nomsh.Checked == true)
            {
                laps.Text += min.Text + ":" + s.Text;
            }
            laps.Text += "\r\n";
            lnum++;
        }

        private void hou_TextChanged(object sender, EventArgs e)
        {

        }

        private void minu_TextChanged(object sender, EventArgs e)
        {

        }

        private void sec_TextChanged(object sender, EventArgs e)
        {

        }
        private void timertimer_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(sec.Text) == 0)
            {
                if (Convert.ToInt32(minu.Text) > 0)
                {
                    minu.Text = Convert.ToString(Convert.ToInt32(minu.Text) - 1);
                    sec.Text = "60";
                }
                else if (Convert.ToInt32(hou.Text) > 0)
                {
                    hou.Text = Convert.ToString(Convert.ToInt32(hou.Text) - 1);
                    minu.Text = "59";
                    sec.Text = "60";
                }
            }
            if (Convert.ToInt32(sec.Text) == 0 && Convert.ToInt32(minu.Text) == 0 && Convert.ToInt32(hou.Text) == 0)
            {
                timertimer.Stop();
                MessageBox.Show(Text = "Время вышло");
                startimer.Text = "Старт";
                sec.ReadOnly = minu.ReadOnly = false;
            }
            if (timertimer.Enabled)
            {
                sec.Text = Convert.ToString(Convert.ToInt32(sec.Text) - 1);
            }
        }

        private void startimer_Click(object sender, EventArgs e)
        {
            if (timertimer.Enabled ==  false)
            {
                startimer.Text = "Пауза";
                timertimer.Start();
            }
            else
            {
                timertimer.Stop();
                startimer.Text = "Старт";
            }
        }

        private void droptimer_Click(object sender, EventArgs e)
        {
            timertimer.Stop();
            startimer.Text = "Старт";
            sec.Text = "0";
            minu.Text = "0";
            hou.Text = "0";
        }

        private void starta_Click(object sender, EventArgs e)
        {
                timeralarm.Start();
            label9.Text = "В потоке";
        }

        private void timeralarm_Tick(object sender, EventArgs e)
        {
            DateTime currtim = DateTime.Now;
            DateTime user = currtime.Value;

            if (currtim.Hour==user.Hour&&currtim.Minute==user.Minute&&currtim.Second==user.Second)
            {
                timeralarm.Stop();
                label9.Text = "Ожидание..";
                MessageBox.Show("Время вышло");
            }
        }

        private void stopal_Click(object sender, EventArgs e)
        {
            timeralarm.Stop();
            label9.Text = "Ожидание..";
        }
    }
}
namespace Times
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lapbut = new System.Windows.Forms.Button();
            this.dropbut = new System.Windows.Forms.Button();
            this.startbut = new System.Windows.Forms.Button();
            this.nomsh = new System.Windows.Forms.RadioButton();
            this.noh = new System.Windows.Forms.RadioButton();
            this.noms = new System.Windows.Forms.RadioButton();
            this.msh = new System.Windows.Forms.RadioButton();
            this.laps = new System.Windows.Forms.TextBox();
            this.hours = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.TextBox();
            this.s = new System.Windows.Forms.TextBox();
            this.ms = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerMisec = new System.Windows.Forms.Timer(this.components);
            this.hou = new System.Windows.Forms.TextBox();
            this.minu = new System.Windows.Forms.TextBox();
            this.sec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.startimer = new System.Windows.Forms.Button();
            this.droptimer = new System.Windows.Forms.Button();
            this.timertimer = new System.Windows.Forms.Timer(this.components);
            this.currtime = new System.Windows.Forms.DateTimePicker();
            this.starta = new System.Windows.Forms.Button();
            this.timeralarm = new System.Windows.Forms.Timer(this.components);
            this.stopal = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.stopal);
            this.groupBox1.Controls.Add(this.starta);
            this.groupBox1.Controls.Add(this.currtime);
            this.groupBox1.Location = new System.Drawing.Point(262, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Будильник";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.droptimer);
            this.groupBox2.Controls.Add(this.startimer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.hou);
            this.groupBox2.Controls.Add(this.minu);
            this.groupBox2.Controls.Add(this.sec);
            this.groupBox2.Location = new System.Drawing.Point(262, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Таймер";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lapbut);
            this.groupBox3.Controls.Add(this.dropbut);
            this.groupBox3.Controls.Add(this.startbut);
            this.groupBox3.Controls.Add(this.nomsh);
            this.groupBox3.Controls.Add(this.noh);
            this.groupBox3.Controls.Add(this.noms);
            this.groupBox3.Controls.Add(this.msh);
            this.groupBox3.Controls.Add(this.laps);
            this.groupBox3.Controls.Add(this.hours);
            this.groupBox3.Controls.Add(this.min);
            this.groupBox3.Controls.Add(this.s);
            this.groupBox3.Controls.Add(this.ms);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 450);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Секундомер";
            // 
            // lapbut
            // 
            this.lapbut.Location = new System.Drawing.Point(137, 388);
            this.lapbut.Name = "lapbut";
            this.lapbut.Size = new System.Drawing.Size(107, 50);
            this.lapbut.TabIndex = 16;
            this.lapbut.Text = "Круг";
            this.lapbut.UseVisualStyleBackColor = true;
            this.lapbut.Click += new System.EventHandler(this.lapbut_Click);
            // 
            // dropbut
            // 
            this.dropbut.Location = new System.Drawing.Point(137, 346);
            this.dropbut.Name = "dropbut";
            this.dropbut.Size = new System.Drawing.Size(107, 36);
            this.dropbut.TabIndex = 15;
            this.dropbut.Text = "Сброс";
            this.dropbut.UseVisualStyleBackColor = true;
            this.dropbut.Click += new System.EventHandler(this.button2_Click);
            // 
            // startbut
            // 
            this.startbut.Location = new System.Drawing.Point(12, 346);
            this.startbut.Name = "startbut";
            this.startbut.Size = new System.Drawing.Size(119, 92);
            this.startbut.TabIndex = 14;
            this.startbut.Text = "Запуск";
            this.startbut.UseVisualStyleBackColor = true;
            this.startbut.Click += new System.EventHandler(this.button1_Click);
            // 
            // nomsh
            // 
            this.nomsh.AutoSize = true;
            this.nomsh.Location = new System.Drawing.Point(6, 323);
            this.nomsh.Name = "nomsh";
            this.nomsh.Size = new System.Drawing.Size(101, 17);
            this.nomsh.TabIndex = 13;
            this.nomsh.TabStop = true;
            this.nomsh.Text = "без мс + часов";
            this.nomsh.UseVisualStyleBackColor = true;
            // 
            // noh
            // 
            this.noh.AutoSize = true;
            this.noh.Location = new System.Drawing.Point(154, 300);
            this.noh.Name = "noh";
            this.noh.Size = new System.Drawing.Size(75, 17);
            this.noh.TabIndex = 12;
            this.noh.TabStop = true;
            this.noh.Text = "без часов";
            this.noh.UseVisualStyleBackColor = true;
            // 
            // noms
            // 
            this.noms.AutoSize = true;
            this.noms.Location = new System.Drawing.Point(88, 300);
            this.noms.Name = "noms";
            this.noms.Size = new System.Drawing.Size(60, 17);
            this.noms.TabIndex = 11;
            this.noms.TabStop = true;
            this.noms.Text = "без мс";
            this.noms.UseVisualStyleBackColor = true;
            // 
            // msh
            // 
            this.msh.AutoSize = true;
            this.msh.Location = new System.Drawing.Point(6, 300);
            this.msh.Name = "msh";
            this.msh.Size = new System.Drawing.Size(76, 17);
            this.msh.TabIndex = 10;
            this.msh.TabStop = true;
            this.msh.Text = "мс + часы";
            this.msh.UseVisualStyleBackColor = true;
            // 
            // laps
            // 
            this.laps.Location = new System.Drawing.Point(6, 151);
            this.laps.Multiline = true;
            this.laps.Name = "laps";
            this.laps.ReadOnly = true;
            this.laps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.laps.Size = new System.Drawing.Size(242, 143);
            this.laps.TabIndex = 9;
            // 
            // hours
            // 
            this.hours.Location = new System.Drawing.Point(91, 102);
            this.hours.Name = "hours";
            this.hours.ReadOnly = true;
            this.hours.Size = new System.Drawing.Size(157, 20);
            this.hours.TabIndex = 8;
            this.hours.Text = "0";
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(91, 79);
            this.min.Name = "min";
            this.min.ReadOnly = true;
            this.min.Size = new System.Drawing.Size(157, 20);
            this.min.TabIndex = 7;
            this.min.Text = "0";
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(91, 56);
            this.s.Name = "s";
            this.s.ReadOnly = true;
            this.s.Size = new System.Drawing.Size(157, 20);
            this.s.TabIndex = 6;
            this.s.Text = "0";
            // 
            // ms
            // 
            this.ms.Location = new System.Drawing.Point(91, 33);
            this.ms.Name = "ms";
            this.ms.ReadOnly = true;
            this.ms.Size = new System.Drawing.Size(157, 20);
            this.ms.TabIndex = 5;
            this.ms.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(96, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Круги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "ч";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "мин";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "с";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "мс";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timerMisec
            // 
            this.timerMisec.Interval = 1;
            this.timerMisec.Tick += new System.EventHandler(this.timerMisec_Tick);
            // 
            // hou
            // 
            this.hou.Location = new System.Drawing.Point(59, 91);
            this.hou.Name = "hou";
            this.hou.Size = new System.Drawing.Size(157, 20);
            this.hou.TabIndex = 11;
            this.hou.Text = "0";
            this.hou.TextChanged += new System.EventHandler(this.hou_TextChanged);
            // 
            // minu
            // 
            this.minu.Location = new System.Drawing.Point(59, 68);
            this.minu.Name = "minu";
            this.minu.Size = new System.Drawing.Size(157, 20);
            this.minu.TabIndex = 10;
            this.minu.Text = "0";
            this.minu.TextChanged += new System.EventHandler(this.minu_TextChanged);
            // 
            // sec
            // 
            this.sec.Location = new System.Drawing.Point(59, 45);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(157, 20);
            this.sec.TabIndex = 9;
            this.sec.Text = "0";
            this.sec.TextChanged += new System.EventHandler(this.sec_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "ч";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "мин";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "с";
            // 
            // startimer
            // 
            this.startimer.Location = new System.Drawing.Point(252, 45);
            this.startimer.Name = "startimer";
            this.startimer.Size = new System.Drawing.Size(67, 65);
            this.startimer.TabIndex = 15;
            this.startimer.Text = "Старт";
            this.startimer.UseVisualStyleBackColor = true;
            this.startimer.Click += new System.EventHandler(this.startimer_Click);
            // 
            // droptimer
            // 
            this.droptimer.Location = new System.Drawing.Point(59, 119);
            this.droptimer.Name = "droptimer";
            this.droptimer.Size = new System.Drawing.Size(156, 28);
            this.droptimer.TabIndex = 17;
            this.droptimer.Text = "Сброс";
            this.droptimer.UseVisualStyleBackColor = true;
            this.droptimer.Click += new System.EventHandler(this.droptimer_Click);
            // 
            // timertimer
            // 
            this.timertimer.Interval = 1000;
            this.timertimer.Tick += new System.EventHandler(this.timertimer_Tick);
            // 
            // currtime
            // 
            this.currtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.currtime.Location = new System.Drawing.Point(167, 19);
            this.currtime.Name = "currtime";
            this.currtime.Size = new System.Drawing.Size(200, 20);
            this.currtime.TabIndex = 0;
            // 
            // starta
            // 
            this.starta.Location = new System.Drawing.Point(167, 45);
            this.starta.Name = "starta";
            this.starta.Size = new System.Drawing.Size(200, 49);
            this.starta.TabIndex = 1;
            this.starta.Text = "Запуск";
            this.starta.UseVisualStyleBackColor = true;
            this.starta.Click += new System.EventHandler(this.starta_Click);
            // 
            // timeralarm
            // 
            this.timeralarm.Interval = 1000;
            this.timeralarm.Tick += new System.EventHandler(this.timeralarm_Tick);
            // 
            // stopal
            // 
            this.stopal.Location = new System.Drawing.Point(167, 100);
            this.stopal.Name = "stopal";
            this.stopal.Size = new System.Drawing.Size(199, 27);
            this.stopal.TabIndex = 2;
            this.stopal.Text = "Стоп";
            this.stopal.UseVisualStyleBackColor = true;
            this.stopal.Click += new System.EventHandler(this.stopal_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ожидание..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "TimeFreak";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Timer timerMisec;
        private System.Windows.Forms.Button lapbut;
        private System.Windows.Forms.Button dropbut;
        private System.Windows.Forms.Button startbut;
        private System.Windows.Forms.RadioButton nomsh;
        private System.Windows.Forms.RadioButton noh;
        private System.Windows.Forms.RadioButton noms;
        private System.Windows.Forms.RadioButton msh;
        private System.Windows.Forms.TextBox laps;
        private System.Windows.Forms.TextBox hours;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.TextBox s;
        private System.Windows.Forms.TextBox ms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hou;
        private System.Windows.Forms.TextBox minu;
        private System.Windows.Forms.TextBox sec;
        private System.Windows.Forms.Button droptimer;
        private System.Windows.Forms.Button startimer;
        internal System.Windows.Forms.Timer timertimer;
        private System.Windows.Forms.Button starta;
        private System.Windows.Forms.DateTimePicker currtime;
        internal System.Windows.Forms.Timer timeralarm;
        private System.Windows.Forms.Button stopal;
        private System.Windows.Forms.Label label9;
    }
}


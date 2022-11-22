namespace Grand
{
    partial class SuperForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Polojeniye = new System.Windows.Forms.GroupBox();
            this.Swertok = new System.Windows.Forms.GroupBox();
            this.locker = new System.Windows.Forms.GroupBox();
            this.info = new System.Windows.Forms.GroupBox();
            this.terminatebut = new System.Windows.Forms.GroupBox();
            this.up = new System.Windows.Forms.Button();
            this.centre = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.upr = new System.Windows.Forms.Button();
            this.downr = new System.Windows.Forms.Button();
            this.upl = new System.Windows.Forms.Button();
            this.downl = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.Polojeniye.SuspendLayout();
            this.terminatebut.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.Polojeniye, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Swertok, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.locker, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.info, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.terminatebut, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(864, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Polojeniye
            // 
            this.Polojeniye.BackColor = System.Drawing.Color.Aquamarine;
            this.Polojeniye.Controls.Add(this.downl);
            this.Polojeniye.Controls.Add(this.upl);
            this.Polojeniye.Controls.Add(this.downr);
            this.Polojeniye.Controls.Add(this.upr);
            this.Polojeniye.Controls.Add(this.right);
            this.Polojeniye.Controls.Add(this.left);
            this.Polojeniye.Controls.Add(this.down);
            this.Polojeniye.Controls.Add(this.centre);
            this.Polojeniye.Controls.Add(this.up);
            this.Polojeniye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Polojeniye.Location = new System.Drawing.Point(3, 3);
            this.Polojeniye.Name = "Polojeniye";
            this.tableLayoutPanel1.SetRowSpan(this.Polojeniye, 2);
            this.Polojeniye.Size = new System.Drawing.Size(282, 455);
            this.Polojeniye.TabIndex = 0;
            this.Polojeniye.TabStop = false;
            this.Polojeniye.Text = "SuperBox!";
            // 
            // Swertok
            // 
            this.Swertok.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Swertok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Swertok.Location = new System.Drawing.Point(291, 3);
            this.Swertok.Name = "Swertok";
            this.Swertok.Size = new System.Drawing.Size(282, 224);
            this.Swertok.TabIndex = 1;
            this.Swertok.TabStop = false;
            this.Swertok.Text = "groupBox1";
            // 
            // locker
            // 
            this.locker.BackColor = System.Drawing.Color.LightSeaGreen;
            this.locker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locker.Location = new System.Drawing.Point(291, 233);
            this.locker.Name = "locker";
            this.locker.Size = new System.Drawing.Size(282, 225);
            this.locker.TabIndex = 2;
            this.locker.TabStop = false;
            this.locker.Text = "groupBox2";
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Turquoise;
            this.info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info.Location = new System.Drawing.Point(579, 3);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(282, 224);
            this.info.TabIndex = 3;
            this.info.TabStop = false;
            this.info.Text = "groupBox3";
            // 
            // terminatebut
            // 
            this.terminatebut.BackColor = System.Drawing.Color.MediumTurquoise;
            this.terminatebut.Controls.Add(this.exit);
            this.terminatebut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.terminatebut.Location = new System.Drawing.Point(579, 233);
            this.terminatebut.Name = "terminatebut";
            this.terminatebut.Size = new System.Drawing.Size(282, 225);
            this.terminatebut.TabIndex = 4;
            this.terminatebut.TabStop = false;
            this.terminatebut.Text = "groupBox4";
            // 
            // up
            // 
            this.up.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.up.Location = new System.Drawing.Point(103, 88);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(75, 23);
            this.up.TabIndex = 0;
            this.up.Text = "Вверх";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // centre
            // 
            this.centre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.centre.Location = new System.Drawing.Point(103, 202);
            this.centre.Name = "centre";
            this.centre.Size = new System.Drawing.Size(75, 23);
            this.centre.TabIndex = 1;
            this.centre.Text = "Центр";
            this.centre.UseVisualStyleBackColor = true;
            this.centre.Click += new System.EventHandler(this.centre_Click);
            // 
            // down
            // 
            this.down.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.down.Location = new System.Drawing.Point(103, 316);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(75, 23);
            this.down.TabIndex = 2;
            this.down.Text = "Вниз";
            this.down.UseVisualStyleBackColor = true;
            // 
            // left
            // 
            this.left.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.left.Location = new System.Drawing.Point(17, 202);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(75, 23);
            this.left.TabIndex = 3;
            this.left.Text = "Лево";
            this.left.UseVisualStyleBackColor = true;
            // 
            // right
            // 
            this.right.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.right.Location = new System.Drawing.Point(189, 202);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(75, 23);
            this.right.TabIndex = 4;
            this.right.Text = "Право";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // upr
            // 
            this.upr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upr.Location = new System.Drawing.Point(177, 136);
            this.upr.Name = "upr";
            this.upr.Size = new System.Drawing.Size(75, 39);
            this.upr.TabIndex = 5;
            this.upr.Text = "Вверх Право";
            this.upr.UseVisualStyleBackColor = true;
            // 
            // downr
            // 
            this.downr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.downr.Location = new System.Drawing.Point(177, 248);
            this.downr.Name = "downr";
            this.downr.Size = new System.Drawing.Size(75, 39);
            this.downr.TabIndex = 6;
            this.downr.Text = "Вниз Право";
            this.downr.UseVisualStyleBackColor = true;
            // 
            // upl
            // 
            this.upl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upl.Location = new System.Drawing.Point(20, 136);
            this.upl.Name = "upl";
            this.upl.Size = new System.Drawing.Size(75, 39);
            this.upl.TabIndex = 7;
            this.upl.Text = "Вверх Лево";
            this.upl.UseVisualStyleBackColor = true;
            this.upl.Click += new System.EventHandler(this.upl_Click);
            // 
            // downl
            // 
            this.downl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.downl.Location = new System.Drawing.Point(20, 248);
            this.downl.Name = "downl";
            this.downl.Size = new System.Drawing.Size(75, 39);
            this.downl.TabIndex = 8;
            this.downl.Text = "Вниз Лево";
            this.downl.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit.Location = new System.Drawing.Point(104, 83);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(73, 59);
            this.exit.TabIndex = 0;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // SuperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(860, 360);
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(880, 500);
            this.Name = "SuperForm";
            this.Text = "Супер-Программа!";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Polojeniye.ResumeLayout(false);
            this.terminatebut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox Polojeniye;
        private System.Windows.Forms.GroupBox Swertok;
        private System.Windows.Forms.GroupBox locker;
        private System.Windows.Forms.GroupBox info;
        private System.Windows.Forms.GroupBox terminatebut;
        private System.Windows.Forms.Button downl;
        private System.Windows.Forms.Button upl;
        private System.Windows.Forms.Button downr;
        private System.Windows.Forms.Button upr;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button centre;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button exit;
    }
}


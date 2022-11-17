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
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Polojeniye
            // 
            this.Polojeniye.BackColor = System.Drawing.Color.Aquamarine;
            this.Polojeniye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Polojeniye.Location = new System.Drawing.Point(3, 3);
            this.Polojeniye.Name = "Polojeniye";
            this.tableLayoutPanel1.SetRowSpan(this.Polojeniye, 2);
            this.Polojeniye.Size = new System.Drawing.Size(260, 444);
            this.Polojeniye.TabIndex = 0;
            this.Polojeniye.TabStop = false;
            this.Polojeniye.Text = "SuperBox!";
            // 
            // Swertok
            // 
            this.Swertok.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Swertok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Swertok.Location = new System.Drawing.Point(269, 3);
            this.Swertok.Name = "Swertok";
            this.Swertok.Size = new System.Drawing.Size(260, 219);
            this.Swertok.TabIndex = 1;
            this.Swertok.TabStop = false;
            this.Swertok.Text = "groupBox1";
            // 
            // locker
            // 
            this.locker.BackColor = System.Drawing.Color.LightSeaGreen;
            this.locker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locker.Location = new System.Drawing.Point(269, 228);
            this.locker.Name = "locker";
            this.locker.Size = new System.Drawing.Size(260, 219);
            this.locker.TabIndex = 2;
            this.locker.TabStop = false;
            this.locker.Text = "groupBox2";
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Turquoise;
            this.info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info.Location = new System.Drawing.Point(535, 3);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(262, 219);
            this.info.TabIndex = 3;
            this.info.TabStop = false;
            this.info.Text = "groupBox3";
            // 
            // terminatebut
            // 
            this.terminatebut.BackColor = System.Drawing.Color.MediumTurquoise;
            this.terminatebut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.terminatebut.Location = new System.Drawing.Point(535, 228);
            this.terminatebut.Name = "terminatebut";
            this.terminatebut.Size = new System.Drawing.Size(262, 219);
            this.terminatebut.TabIndex = 4;
            this.terminatebut.TabStop = false;
            this.terminatebut.Text = "groupBox4";
            // 
            // SuperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SuperForm";
            this.Text = "Супер-Программа!";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox Polojeniye;
        private System.Windows.Forms.GroupBox Swertok;
        private System.Windows.Forms.GroupBox locker;
        private System.Windows.Forms.GroupBox info;
        private System.Windows.Forms.GroupBox terminatebut;
    }
}


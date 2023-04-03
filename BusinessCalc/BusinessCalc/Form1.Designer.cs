namespace BusinessCalc
{
    partial class BusForm
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
            this.inpGB = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstInp = new System.Windows.Forms.TextBox();
            this.monthz = new System.Windows.Forms.TextBox();
            this.yearBET = new System.Windows.Forms.TextBox();
            this.nedvPR = new System.Windows.Forms.TextBox();
            this.busBut = new System.Windows.Forms.Button();
            this.inpGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // inpGB
            // 
            this.inpGB.Controls.Add(this.label4);
            this.inpGB.Controls.Add(this.label3);
            this.inpGB.Controls.Add(this.label2);
            this.inpGB.Controls.Add(this.label1);
            this.inpGB.Controls.Add(this.firstInp);
            this.inpGB.Controls.Add(this.monthz);
            this.inpGB.Controls.Add(this.yearBET);
            this.inpGB.Controls.Add(this.nedvPR);
            this.inpGB.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inpGB.Location = new System.Drawing.Point(13, 12);
            this.inpGB.Name = "inpGB";
            this.inpGB.Size = new System.Drawing.Size(430, 286);
            this.inpGB.TabIndex = 0;
            this.inpGB.TabStop = false;
            this.inpGB.Text = "Input here!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "bet yearly (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "period in months";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "% of first payment";
            // 
            // firstInp
            // 
            this.firstInp.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstInp.Location = new System.Drawing.Point(6, 224);
            this.firstInp.Name = "firstInp";
            this.firstInp.Size = new System.Drawing.Size(232, 23);
            this.firstInp.TabIndex = 3;
            this.firstInp.TextChanged += new System.EventHandler(this.yearBET_TextChanged);
            this.firstInp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nedvPR_KeyPress);
            // 
            // monthz
            // 
            this.monthz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthz.Location = new System.Drawing.Point(6, 172);
            this.monthz.Name = "monthz";
            this.monthz.Size = new System.Drawing.Size(232, 23);
            this.monthz.TabIndex = 2;
            this.monthz.TextChanged += new System.EventHandler(this.nedvPR_TextChanged);
            this.monthz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.monthz_KeyPress);
            // 
            // yearBET
            // 
            this.yearBET.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearBET.Location = new System.Drawing.Point(6, 120);
            this.yearBET.Name = "yearBET";
            this.yearBET.Size = new System.Drawing.Size(232, 23);
            this.yearBET.TabIndex = 1;
            this.yearBET.TextChanged += new System.EventHandler(this.yearBET_TextChanged);
            this.yearBET.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nedvPR_KeyPress);
            // 
            // nedvPR
            // 
            this.nedvPR.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nedvPR.Location = new System.Drawing.Point(6, 68);
            this.nedvPR.Name = "nedvPR";
            this.nedvPR.Size = new System.Drawing.Size(232, 23);
            this.nedvPR.TabIndex = 0;
            this.nedvPR.TextChanged += new System.EventHandler(this.nedvPR_TextChanged);
            this.nedvPR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nedvPR_KeyPress);
            // 
            // busBut
            // 
            this.busBut.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busBut.Location = new System.Drawing.Point(679, 474);
            this.busBut.Name = "busBut";
            this.busBut.Size = new System.Drawing.Size(189, 71);
            this.busBut.TabIndex = 1;
            this.busBut.Text = "Business";
            this.busBut.UseVisualStyleBackColor = true;
            // 
            // BusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 557);
            this.Controls.Add(this.busBut);
            this.Controls.Add(this.inpGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BusForm";
            this.Text = "business time";
            this.inpGB.ResumeLayout(false);
            this.inpGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inpGB;
        private System.Windows.Forms.TextBox nedvPR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstInp;
        private System.Windows.Forms.TextBox monthz;
        private System.Windows.Forms.TextBox yearBET;
        private System.Windows.Forms.Button busBut;
    }
}


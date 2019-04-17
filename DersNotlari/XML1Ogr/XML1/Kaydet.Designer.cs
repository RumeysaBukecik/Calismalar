namespace XML1
{
    partial class Kaydet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Num = new System.Windows.Forms.TextBox();
            this.textBox_Adsoy = new System.Windows.Forms.TextBox();
            this.textBox_Sinif = new System.Windows.Forms.TextBox();
            this.button_OgrKyt = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_OgrNum = new System.Windows.Forms.Label();
            this.label_Adsoy = new System.Windows.Forms.Label();
            this.label_Sinif = new System.Windows.Forms.Label();
            this.label_Tarih = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Num
            // 
            this.textBox_Num.AccessibleName = "";
            this.textBox_Num.Location = new System.Drawing.Point(159, 27);
            this.textBox_Num.Name = "textBox_Num";
            this.textBox_Num.Size = new System.Drawing.Size(100, 20);
            this.textBox_Num.TabIndex = 0;
            // 
            // textBox_Adsoy
            // 
            this.textBox_Adsoy.Location = new System.Drawing.Point(159, 78);
            this.textBox_Adsoy.Name = "textBox_Adsoy";
            this.textBox_Adsoy.Size = new System.Drawing.Size(100, 20);
            this.textBox_Adsoy.TabIndex = 1;
            // 
            // textBox_Sinif
            // 
            this.textBox_Sinif.Location = new System.Drawing.Point(159, 122);
            this.textBox_Sinif.Name = "textBox_Sinif";
            this.textBox_Sinif.Size = new System.Drawing.Size(100, 20);
            this.textBox_Sinif.TabIndex = 2;
            // 
            // button_OgrKyt
            // 
            this.button_OgrKyt.Location = new System.Drawing.Point(159, 232);
            this.button_OgrKyt.Name = "button_OgrKyt";
            this.button_OgrKyt.Size = new System.Drawing.Size(100, 23);
            this.button_OgrKyt.TabIndex = 4;
            this.button_OgrKyt.Text = "Öğrenci Kaydet";
            this.button_OgrKyt.UseVisualStyleBackColor = true;
            this.button_OgrKyt.Click += new System.EventHandler(this.button_OgrKyt_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 170);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label_OgrNum
            // 
            this.label_OgrNum.AutoSize = true;
            this.label_OgrNum.Location = new System.Drawing.Point(35, 27);
            this.label_OgrNum.Name = "label_OgrNum";
            this.label_OgrNum.Size = new System.Drawing.Size(91, 13);
            this.label_OgrNum.TabIndex = 6;
            this.label_OgrNum.Text = "Öğrenci Numarası";
            // 
            // label_Adsoy
            // 
            this.label_Adsoy.AutoSize = true;
            this.label_Adsoy.Location = new System.Drawing.Point(35, 78);
            this.label_Adsoy.Name = "label_Adsoy";
            this.label_Adsoy.Size = new System.Drawing.Size(53, 13);
            this.label_Adsoy.TabIndex = 7;
            this.label_Adsoy.Text = "Ad Soyad";
            // 
            // label_Sinif
            // 
            this.label_Sinif.AutoSize = true;
            this.label_Sinif.Location = new System.Drawing.Point(35, 122);
            this.label_Sinif.Name = "label_Sinif";
            this.label_Sinif.Size = new System.Drawing.Size(27, 13);
            this.label_Sinif.TabIndex = 8;
            this.label_Sinif.Text = "Sınıf";
            // 
            // label_Tarih
            // 
            this.label_Tarih.AutoSize = true;
            this.label_Tarih.Location = new System.Drawing.Point(35, 170);
            this.label_Tarih.Name = "label_Tarih";
            this.label_Tarih.Size = new System.Drawing.Size(31, 13);
            this.label_Tarih.TabIndex = 9;
            this.label_Tarih.Text = "Tarih";
            // 
            // Kaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 303);
            this.Controls.Add(this.label_Tarih);
            this.Controls.Add(this.label_Sinif);
            this.Controls.Add(this.label_Adsoy);
            this.Controls.Add(this.label_OgrNum);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_OgrKyt);
            this.Controls.Add(this.textBox_Sinif);
            this.Controls.Add(this.textBox_Adsoy);
            this.Controls.Add(this.textBox_Num);
            this.Name = "Kaydet";
            this.Text = "Kaydet";
            this.Load += new System.EventHandler(this.Kaydet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Num;
        private System.Windows.Forms.TextBox textBox_Adsoy;
        private System.Windows.Forms.TextBox textBox_Sinif;
        private System.Windows.Forms.Button button_OgrKyt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_OgrNum;
        private System.Windows.Forms.Label label_Adsoy;
        private System.Windows.Forms.Label label_Sinif;
        private System.Windows.Forms.Label label_Tarih;
    }
}
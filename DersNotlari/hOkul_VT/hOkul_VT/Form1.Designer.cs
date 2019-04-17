namespace hOkul_VT
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Ogrtmn = new System.Windows.Forms.Label();
            this.label_Ogrtmn_Adi = new System.Windows.Forms.Label();
            this.textBox_Ogrtmn_Adi = new System.Windows.Forms.TextBox();
            this.button_Gncl = new System.Windows.Forms.Button();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Ogrtmn_DT = new System.Windows.Forms.Label();
            this.label_Ogrnci = new System.Windows.Forms.Label();
            this.label_Ogrnci_Adi = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.button_Gncl2 = new System.Windows.Forms.Button();
            this.button_Ekle2 = new System.Windows.Forms.Button();
            this.button_Sil2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox_Ogrnci_Adi = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.label_Ogrtmn_DT);
            this.panel1.Controls.Add(this.button_Sil);
            this.panel1.Controls.Add(this.button_Ekle);
            this.panel1.Controls.Add(this.button_Gncl);
            this.panel1.Controls.Add(this.textBox_Ogrtmn_Adi);
            this.panel1.Controls.Add(this.label_Ogrtmn_Adi);
            this.panel1.Controls.Add(this.label_Ogrtmn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 164);
            this.panel1.TabIndex = 0;
            // 
            // label_Ogrtmn
            // 
            this.label_Ogrtmn.AutoSize = true;
            this.label_Ogrtmn.Location = new System.Drawing.Point(84, 7);
            this.label_Ogrtmn.Name = "label_Ogrtmn";
            this.label_Ogrtmn.Size = new System.Drawing.Size(69, 13);
            this.label_Ogrtmn.TabIndex = 0;
            this.label_Ogrtmn.Text = "ÖĞRETMEN";
            // 
            // label_Ogrtmn_Adi
            // 
            this.label_Ogrtmn_Adi.AutoSize = true;
            this.label_Ogrtmn_Adi.Location = new System.Drawing.Point(4, 38);
            this.label_Ogrtmn_Adi.Name = "label_Ogrtmn_Adi";
            this.label_Ogrtmn_Adi.Size = new System.Drawing.Size(31, 13);
            this.label_Ogrtmn_Adi.TabIndex = 1;
            this.label_Ogrtmn_Adi.Text = "Adı : ";
            // 
            // textBox_Ogrtmn_Adi
            // 
            this.textBox_Ogrtmn_Adi.Location = new System.Drawing.Point(89, 31);
            this.textBox_Ogrtmn_Adi.Name = "textBox_Ogrtmn_Adi";
            this.textBox_Ogrtmn_Adi.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ogrtmn_Adi.TabIndex = 2;
            // 
            // button_Gncl
            // 
            this.button_Gncl.Location = new System.Drawing.Point(22, 104);
            this.button_Gncl.Name = "button_Gncl";
            this.button_Gncl.Size = new System.Drawing.Size(75, 23);
            this.button_Gncl.TabIndex = 4;
            this.button_Gncl.Text = "Güncelle";
            this.button_Gncl.UseVisualStyleBackColor = true;
            this.button_Gncl.Click += new System.EventHandler(this.button_Gncl_Click);
            // 
            // button_Ekle
            // 
            this.button_Ekle.Location = new System.Drawing.Point(114, 104);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(75, 23);
            this.button_Ekle.TabIndex = 5;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.UseVisualStyleBackColor = true;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.Location = new System.Drawing.Point(66, 134);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(75, 23);
            this.button_Sil.TabIndex = 6;
            this.button_Sil.Text = "Sil";
            this.button_Sil.UseVisualStyleBackColor = true;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_Ogrnci_Adi);
            this.panel2.Controls.Add(this.button_Sil2);
            this.panel2.Controls.Add(this.button_Ekle2);
            this.panel2.Controls.Add(this.button_Gncl2);
            this.panel2.Controls.Add(this.checkBox);
            this.panel2.Controls.Add(this.label_Ogrnci_Adi);
            this.panel2.Controls.Add(this.label_Ogrnci);
            this.panel2.Location = new System.Drawing.Point(12, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 146);
            this.panel2.TabIndex = 1;
            // 
            // label_Ogrtmn_DT
            // 
            this.label_Ogrtmn_DT.AutoSize = true;
            this.label_Ogrtmn_DT.Location = new System.Drawing.Point(4, 73);
            this.label_Ogrtmn_DT.Name = "label_Ogrtmn_DT";
            this.label_Ogrtmn_DT.Size = new System.Drawing.Size(79, 13);
            this.label_Ogrtmn_DT.TabIndex = 7;
            this.label_Ogrtmn_DT.Text = "Doğum Tarihi : ";
            // 
            // label_Ogrnci
            // 
            this.label_Ogrnci.AutoSize = true;
            this.label_Ogrnci.Location = new System.Drawing.Point(84, 9);
            this.label_Ogrnci.Name = "label_Ogrnci";
            this.label_Ogrnci.Size = new System.Drawing.Size(56, 13);
            this.label_Ogrnci.TabIndex = 0;
            this.label_Ogrnci.Text = "ÖĞRENCİ";
            // 
            // label_Ogrnci_Adi
            // 
            this.label_Ogrnci_Adi.AutoSize = true;
            this.label_Ogrnci_Adi.Location = new System.Drawing.Point(19, 44);
            this.label_Ogrnci_Adi.Name = "label_Ogrnci_Adi";
            this.label_Ogrnci_Adi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Ogrnci_Adi.Size = new System.Drawing.Size(31, 13);
            this.label_Ogrnci_Adi.TabIndex = 1;
            this.label_Ogrnci_Adi.Text = "Adı : ";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(109, 66);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(81, 17);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "Mezun mu?";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // button_Gncl2
            // 
            this.button_Gncl2.Location = new System.Drawing.Point(22, 89);
            this.button_Gncl2.Name = "button_Gncl2";
            this.button_Gncl2.Size = new System.Drawing.Size(75, 23);
            this.button_Gncl2.TabIndex = 4;
            this.button_Gncl2.Text = "Güncelle";
            this.button_Gncl2.UseVisualStyleBackColor = true;
            this.button_Gncl2.Click += new System.EventHandler(this.button_Gncl2_Click);
            // 
            // button_Ekle2
            // 
            this.button_Ekle2.Location = new System.Drawing.Point(114, 89);
            this.button_Ekle2.Name = "button_Ekle2";
            this.button_Ekle2.Size = new System.Drawing.Size(75, 23);
            this.button_Ekle2.TabIndex = 5;
            this.button_Ekle2.Text = "Ekle";
            this.button_Ekle2.UseVisualStyleBackColor = true;
            this.button_Ekle2.Click += new System.EventHandler(this.button_Ekle2_Click);
            // 
            // button_Sil2
            // 
            this.button_Sil2.Location = new System.Drawing.Point(66, 118);
            this.button_Sil2.Name = "button_Sil2";
            this.button_Sil2.Size = new System.Drawing.Size(75, 23);
            this.button_Sil2.TabIndex = 6;
            this.button_Sil2.Text = "Sil";
            this.button_Sil2.UseVisualStyleBackColor = true;
            this.button_Sil2.Click += new System.EventHandler(this.button_Sil2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(265, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 164);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(265, 190);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 146);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // textBox_Ogrnci_Adi
            // 
            this.textBox_Ogrnci_Adi.Location = new System.Drawing.Point(89, 37);
            this.textBox_Ogrnci_Adi.Name = "textBox_Ogrnci_Adi";
            this.textBox_Ogrnci_Adi.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ogrnci_Adi.TabIndex = 7;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(89, 66);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 371);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Ogrtmn_DT;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.Button button_Gncl;
        private System.Windows.Forms.TextBox textBox_Ogrtmn_Adi;
        private System.Windows.Forms.Label label_Ogrtmn_Adi;
        private System.Windows.Forms.Label label_Ogrtmn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Sil2;
        private System.Windows.Forms.Button button_Ekle2;
        private System.Windows.Forms.Button button_Gncl2;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label label_Ogrnci_Adi;
        private System.Windows.Forms.Label label_Ogrnci;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBox_Ogrnci_Adi;
    }
}


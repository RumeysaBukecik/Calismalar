namespace EF_2
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
               this.label7 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.textBox_KisaBilgi = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.textBox_FilmFragman = new System.Windows.Forms.TextBox();
               this.btn_FilmKaydet = new System.Windows.Forms.Button();
               this.textBox_FilmAdi_1 = new System.Windows.Forms.TextBox();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.button1 = new System.Windows.Forms.Button();
               this.textBox2 = new System.Windows.Forms.TextBox();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.textBox_Sil_ID = new System.Windows.Forms.TextBox();
               this.button_Sil = new System.Windows.Forms.Button();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
               this.panel1.BackColor = System.Drawing.Color.Lavender;
               this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.panel1.Controls.Add(this.label7);
               this.panel1.Controls.Add(this.label6);
               this.panel1.Controls.Add(this.textBox_KisaBilgi);
               this.panel1.Controls.Add(this.label1);
               this.panel1.Controls.Add(this.textBox_FilmFragman);
               this.panel1.Controls.Add(this.btn_FilmKaydet);
               this.panel1.Controls.Add(this.textBox_FilmAdi_1);
               this.panel1.Location = new System.Drawing.Point(8, 131);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(370, 238);
               this.panel1.TabIndex = 1;
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.label7.Location = new System.Drawing.Point(29, 145);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(83, 20);
               this.label7.TabIndex = 9;
               this.label7.Text = "Film Özeti:";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.label6.Location = new System.Drawing.Point(1, 88);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(117, 20);
               this.label6.TabIndex = 8;
               this.label6.Text = "Film Fragmanı :";
               // 
               // textBox_KisaBilgi
               // 
               this.textBox_KisaBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.textBox_KisaBilgi.Location = new System.Drawing.Point(118, 139);
               this.textBox_KisaBilgi.Multiline = true;
               this.textBox_KisaBilgi.Name = "textBox_KisaBilgi";
               this.textBox_KisaBilgi.Size = new System.Drawing.Size(237, 86);
               this.textBox_KisaBilgi.TabIndex = 7;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.label1.Location = new System.Drawing.Point(24, 22);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(73, 20);
               this.label1.TabIndex = 2;
               this.label1.Text = "Film Adı :";
               // 
               // textBox_FilmFragman
               // 
               this.textBox_FilmFragman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.textBox_FilmFragman.Location = new System.Drawing.Point(118, 85);
               this.textBox_FilmFragman.Name = "textBox_FilmFragman";
               this.textBox_FilmFragman.Size = new System.Drawing.Size(237, 26);
               this.textBox_FilmFragman.TabIndex = 6;
               // 
               // btn_FilmKaydet
               // 
               this.btn_FilmKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.btn_FilmKaydet.Location = new System.Drawing.Point(257, 21);
               this.btn_FilmKaydet.Name = "btn_FilmKaydet";
               this.btn_FilmKaydet.Size = new System.Drawing.Size(98, 29);
               this.btn_FilmKaydet.TabIndex = 1;
               this.btn_FilmKaydet.Text = "Film Ekle";
               this.btn_FilmKaydet.UseVisualStyleBackColor = true;
               this.btn_FilmKaydet.Click += new System.EventHandler(this.btn_FilmKaydet_Click);
               // 
               // textBox_FilmAdi_1
               // 
               this.textBox_FilmAdi_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.textBox_FilmAdi_1.Location = new System.Drawing.Point(118, 22);
               this.textBox_FilmAdi_1.Name = "textBox_FilmAdi_1";
               this.textBox_FilmAdi_1.Size = new System.Drawing.Size(133, 26);
               this.textBox_FilmAdi_1.TabIndex = 0;
               // 
               // dataGridView1
               // 
               this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Location = new System.Drawing.Point(464, 108);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.Size = new System.Drawing.Size(380, 189);
               this.dataGridView1.TabIndex = 2;
               // 
               // button1
               // 
               this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.button1.Location = new System.Drawing.Point(464, 432);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(207, 29);
               this.button1.TabIndex = 10;
               this.button1.Text = "Fragman Güncelle";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // textBox2
               // 
               this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.textBox2.Location = new System.Drawing.Point(464, 335);
               this.textBox2.Name = "textBox2";
               this.textBox2.Size = new System.Drawing.Size(207, 26);
               this.textBox2.TabIndex = 10;
               // 
               // textBox1
               // 
               this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.textBox1.Location = new System.Drawing.Point(464, 391);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(207, 26);
               this.textBox1.TabIndex = 11;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.label2.Location = new System.Drawing.Point(460, 312);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(67, 20);
               this.label2.TabIndex = 10;
               this.label2.Text = "Film ID :";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.label3.Location = new System.Drawing.Point(460, 364);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(114, 20);
               this.label3.TabIndex = 12;
               this.label3.Text = "Film Fragman :";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.label4.Location = new System.Drawing.Point(682, 312);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(67, 20);
               this.label4.TabIndex = 13;
               this.label4.Text = "Film ID :";
               // 
               // textBox_Sil_ID
               // 
               this.textBox_Sil_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.textBox_Sil_ID.Location = new System.Drawing.Point(686, 335);
               this.textBox_Sil_ID.Name = "textBox_Sil_ID";
               this.textBox_Sil_ID.Size = new System.Drawing.Size(207, 26);
               this.textBox_Sil_ID.TabIndex = 14;
               // 
               // button_Sil
               // 
               this.button_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.button_Sil.Location = new System.Drawing.Point(686, 391);
               this.button_Sil.Name = "button_Sil";
               this.button_Sil.Size = new System.Drawing.Size(207, 29);
               this.button_Sil.TabIndex = 15;
               this.button_Sil.Text = "Film Sil";
               this.button_Sil.UseVisualStyleBackColor = true;
               this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(918, 499);
               this.Controls.Add(this.button_Sil);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.textBox_Sil_ID);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.textBox2);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.dataGridView1);
               this.Controls.Add(this.panel1);
               this.Name = "Form1";
               this.Text = "Form1";
               this.Load += new System.EventHandler(this.Form1_Load);
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.TextBox textBox_KisaBilgi;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.TextBox textBox_FilmFragman;
          private System.Windows.Forms.Button btn_FilmKaydet;
          private System.Windows.Forms.TextBox textBox_FilmAdi_1;
          private System.Windows.Forms.DataGridView dataGridView1;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.TextBox textBox2;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.TextBox textBox_Sil_ID;
          private System.Windows.Forms.Button button_Sil;
     }
}


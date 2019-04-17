namespace VB_KullaniciGiris
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
            this.Label_KullaniciAdi = new System.Windows.Forms.Label();
            this.Label_Parola = new System.Windows.Forms.Label();
            this.Text_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.Text_Parola = new System.Windows.Forms.TextBox();
            this.Buton_Gonder = new System.Windows.Forms.Button();
            this.Buton_Kayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_KullaniciAdi
            // 
            this.Label_KullaniciAdi.AutoSize = true;
            this.Label_KullaniciAdi.Location = new System.Drawing.Point(26, 53);
            this.Label_KullaniciAdi.Name = "Label_KullaniciAdi";
            this.Label_KullaniciAdi.Size = new System.Drawing.Size(70, 13);
            this.Label_KullaniciAdi.TabIndex = 0;
            this.Label_KullaniciAdi.Text = "Kullanıcı Adı: ";
            // 
            // Label_Parola
            // 
            this.Label_Parola.AutoSize = true;
            this.Label_Parola.Location = new System.Drawing.Point(26, 107);
            this.Label_Parola.Name = "Label_Parola";
            this.Label_Parola.Size = new System.Drawing.Size(37, 13);
            this.Label_Parola.TabIndex = 1;
            this.Label_Parola.Text = "Parola";
            // 
            // Text_KullaniciAdi
            // 
            this.Text_KullaniciAdi.Location = new System.Drawing.Point(92, 50);
            this.Text_KullaniciAdi.Name = "Text_KullaniciAdi";
            this.Text_KullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.Text_KullaniciAdi.TabIndex = 2;
            // 
            // Text_Parola
            // 
            this.Text_Parola.Location = new System.Drawing.Point(92, 104);
            this.Text_Parola.Name = "Text_Parola";
            this.Text_Parola.PasswordChar = '*';
            this.Text_Parola.Size = new System.Drawing.Size(100, 20);
            this.Text_Parola.TabIndex = 3;
            // 
            // Buton_Gonder
            // 
            this.Buton_Gonder.Location = new System.Drawing.Point(126, 160);
            this.Buton_Gonder.Name = "Buton_Gonder";
            this.Buton_Gonder.Size = new System.Drawing.Size(75, 23);
            this.Buton_Gonder.TabIndex = 4;
            this.Buton_Gonder.Text = "Giriş";
            this.Buton_Gonder.UseVisualStyleBackColor = true;
            this.Buton_Gonder.Click += new System.EventHandler(this.Buton_Gonder_Click);
            // 
            // Buton_Kayit
            // 
            this.Buton_Kayit.Location = new System.Drawing.Point(29, 160);
            this.Buton_Kayit.Name = "Buton_Kayit";
            this.Buton_Kayit.Size = new System.Drawing.Size(75, 23);
            this.Buton_Kayit.TabIndex = 5;
            this.Buton_Kayit.Text = "Kayıt";
            this.Buton_Kayit.UseVisualStyleBackColor = true;
            this.Buton_Kayit.Click += new System.EventHandler(this.Buton_Kayit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Buton_Kayit);
            this.Controls.Add(this.Buton_Gonder);
            this.Controls.Add(this.Text_Parola);
            this.Controls.Add(this.Text_KullaniciAdi);
            this.Controls.Add(this.Label_Parola);
            this.Controls.Add(this.Label_KullaniciAdi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_KullaniciAdi;
        private System.Windows.Forms.Label Label_Parola;
        private System.Windows.Forms.TextBox Text_KullaniciAdi;
        private System.Windows.Forms.TextBox Text_Parola;
        private System.Windows.Forms.Button Buton_Gonder;
        private System.Windows.Forms.Button Buton_Kayit;
    }
}


namespace VB_Form2
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
            this.txt_Not = new System.Windows.Forms.Label();
            this.label_OgrNo = new System.Windows.Forms.Label();
            this.txt_OgrNo = new System.Windows.Forms.TextBox();
            this.txt_DersAdi = new System.Windows.Forms.TextBox();
            this.label_DersAdi = new System.Windows.Forms.Label();
            this.label_Vize = new System.Windows.Forms.Label();
            this.label_Final = new System.Windows.Forms.Label();
            this.txt_Vize = new System.Windows.Forms.TextBox();
            this.txt_Final = new System.Windows.Forms.TextBox();
            this.button_Gonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Not
            // 
            this.txt_Not.AutoSize = true;
            this.txt_Not.Font = new System.Drawing.Font("Bell MT", 15F);
            this.txt_Not.Location = new System.Drawing.Point(61, 9);
            this.txt_Not.Name = "txt_Not";
            this.txt_Not.Size = new System.Drawing.Size(160, 23);
            this.txt_Not.TabIndex = 0;
            this.txt_Not.Text = "Not Kayıt Sistemi";
            // 
            // label_OgrNo
            // 
            this.label_OgrNo.AutoSize = true;
            this.label_OgrNo.Location = new System.Drawing.Point(12, 63);
            this.label_OgrNo.Name = "label_OgrNo";
            this.label_OgrNo.Size = new System.Drawing.Size(100, 13);
            this.label_OgrNo.TabIndex = 1;
            this.label_OgrNo.Text = "Öğrenci Numarası : ";
            // 
            // txt_OgrNo
            // 
            this.txt_OgrNo.Location = new System.Drawing.Point(121, 60);
            this.txt_OgrNo.Name = "txt_OgrNo";
            this.txt_OgrNo.Size = new System.Drawing.Size(100, 20);
            this.txt_OgrNo.TabIndex = 2;
            // 
            // txt_DersAdi
            // 
            this.txt_DersAdi.Location = new System.Drawing.Point(121, 90);
            this.txt_DersAdi.Name = "txt_DersAdi";
            this.txt_DersAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_DersAdi.TabIndex = 3;
            // 
            // label_DersAdi
            // 
            this.label_DersAdi.AutoSize = true;
            this.label_DersAdi.Location = new System.Drawing.Point(12, 94);
            this.label_DersAdi.Name = "label_DersAdi";
            this.label_DersAdi.Size = new System.Drawing.Size(53, 13);
            this.label_DersAdi.TabIndex = 4;
            this.label_DersAdi.Text = "Ders Adı :";
            // 
            // label_Vize
            // 
            this.label_Vize.AutoSize = true;
            this.label_Vize.Location = new System.Drawing.Point(12, 123);
            this.label_Vize.Name = "label_Vize";
            this.label_Vize.Size = new System.Drawing.Size(33, 13);
            this.label_Vize.TabIndex = 5;
            this.label_Vize.Text = "Vize :";
            // 
            // label_Final
            // 
            this.label_Final.AutoSize = true;
            this.label_Final.Location = new System.Drawing.Point(12, 149);
            this.label_Final.Name = "label_Final";
            this.label_Final.Size = new System.Drawing.Size(38, 13);
            this.label_Final.TabIndex = 6;
            this.label_Final.Text = "Final : ";
            // 
            // txt_Vize
            // 
            this.txt_Vize.Location = new System.Drawing.Point(121, 117);
            this.txt_Vize.Name = "txt_Vize";
            this.txt_Vize.Size = new System.Drawing.Size(100, 20);
            this.txt_Vize.TabIndex = 7;
            // 
            // txt_Final
            // 
            this.txt_Final.Location = new System.Drawing.Point(121, 144);
            this.txt_Final.Name = "txt_Final";
            this.txt_Final.Size = new System.Drawing.Size(100, 20);
            this.txt_Final.TabIndex = 8;
            // 
            // button_Gonder
            // 
            this.button_Gonder.Location = new System.Drawing.Point(80, 186);
            this.button_Gonder.Name = "button_Gonder";
            this.button_Gonder.Size = new System.Drawing.Size(75, 23);
            this.button_Gonder.TabIndex = 9;
            this.button_Gonder.Text = "Gönder";
            this.button_Gonder.UseVisualStyleBackColor = true;
            this.button_Gonder.Click += new System.EventHandler(this.button_Gonder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_Gonder);
            this.Controls.Add(this.txt_Final);
            this.Controls.Add(this.txt_Vize);
            this.Controls.Add(this.label_Final);
            this.Controls.Add(this.label_Vize);
            this.Controls.Add(this.label_DersAdi);
            this.Controls.Add(this.txt_DersAdi);
            this.Controls.Add(this.txt_OgrNo);
            this.Controls.Add(this.label_OgrNo);
            this.Controls.Add(this.txt_Not);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_Not;
        private System.Windows.Forms.Label label_OgrNo;
        private System.Windows.Forms.TextBox txt_OgrNo;
        private System.Windows.Forms.TextBox txt_DersAdi;
        private System.Windows.Forms.Label label_DersAdi;
        private System.Windows.Forms.Label label_Vize;
        private System.Windows.Forms.Label label_Final;
        private System.Windows.Forms.TextBox txt_Vize;
        private System.Windows.Forms.TextBox txt_Final;
        private System.Windows.Forms.Button button_Gonder;
    }
}


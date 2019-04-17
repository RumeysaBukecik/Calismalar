namespace DesignPattern02 {
   partial class Form1 {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if ( disposing && ( components != null ) ) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.panel1 = new System.Windows.Forms.Panel();
         this.bnt_doc = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.input_docname = new System.Windows.Forms.TextBox();
         this.panel2 = new System.Windows.Forms.Panel();
         this.bnt_pat = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.input_patientname = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.panel3 = new System.Windows.Forms.Panel();
         this.input_apppat = new System.Windows.Forms.ComboBox();
         this.input_appdoc = new System.Windows.Forms.ComboBox();
         this.input_apptime = new System.Windows.Forms.DateTimePicker();
         this.label8 = new System.Windows.Forms.Label();
         this.bnt_app_remove = new System.Windows.Forms.Button();
         this.bnt_app_list = new System.Windows.Forms.Button();
         this.bnt_app_add = new System.Windows.Forms.Button();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.btn_app_update = new System.Windows.Forms.Button();
         this.clear = new System.Windows.Forms.Button();
         this.panel1.SuspendLayout();
         this.panel2.SuspendLayout();
         this.panel3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.bnt_doc);
         this.panel1.Controls.Add(this.label2);
         this.panel1.Controls.Add(this.label1);
         this.panel1.Controls.Add(this.input_docname);
         this.panel1.Location = new System.Drawing.Point(12, 12);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(239, 120);
         this.panel1.TabIndex = 0;
         // 
         // bnt_doc
         // 
         this.bnt_doc.Location = new System.Drawing.Point(82, 82);
         this.bnt_doc.Name = "bnt_doc";
         this.bnt_doc.Size = new System.Drawing.Size(75, 23);
         this.bnt_doc.TabIndex = 2;
         this.bnt_doc.Text = "Add";
         this.bnt_doc.UseVisualStyleBackColor = true;
         this.bnt_doc.Click += new System.EventHandler(this.bnt_doc_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(37, 41);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(57, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Full Name:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(97, 10);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(39, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Doctor";
         // 
         // input_docname
         // 
         this.input_docname.Location = new System.Drawing.Point(100, 38);
         this.input_docname.Name = "input_docname";
         this.input_docname.Size = new System.Drawing.Size(100, 20);
         this.input_docname.TabIndex = 0;
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.bnt_pat);
         this.panel2.Controls.Add(this.label3);
         this.panel2.Controls.Add(this.input_patientname);
         this.panel2.Controls.Add(this.label4);
         this.panel2.Location = new System.Drawing.Point(12, 148);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(239, 116);
         this.panel2.TabIndex = 1;
         // 
         // bnt_pat
         // 
         this.bnt_pat.Location = new System.Drawing.Point(88, 77);
         this.bnt_pat.Name = "bnt_pat";
         this.bnt_pat.Size = new System.Drawing.Size(75, 23);
         this.bnt_pat.TabIndex = 2;
         this.bnt_pat.Text = "Add";
         this.bnt_pat.UseVisualStyleBackColor = true;
         this.bnt_pat.Click += new System.EventHandler(this.bnt_pat_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(37, 36);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(57, 13);
         this.label3.TabIndex = 1;
         this.label3.Text = "Full Name:";
         // 
         // input_patientname
         // 
         this.input_patientname.Location = new System.Drawing.Point(100, 33);
         this.input_patientname.Name = "input_patientname";
         this.input_patientname.Size = new System.Drawing.Size(100, 20);
         this.input_patientname.TabIndex = 0;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(97, 9);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(40, 13);
         this.label4.TabIndex = 1;
         this.label4.Text = "Patient";
         // 
         // panel3
         // 
         this.panel3.Controls.Add(this.input_apppat);
         this.panel3.Controls.Add(this.input_appdoc);
         this.panel3.Controls.Add(this.input_apptime);
         this.panel3.Controls.Add(this.label8);
         this.panel3.Controls.Add(this.btn_app_update);
         this.panel3.Controls.Add(this.bnt_app_remove);
         this.panel3.Controls.Add(this.bnt_app_list);
         this.panel3.Controls.Add(this.bnt_app_add);
         this.panel3.Controls.Add(this.label6);
         this.panel3.Controls.Add(this.label7);
         this.panel3.Controls.Add(this.label5);
         this.panel3.Location = new System.Drawing.Point(12, 280);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(239, 191);
         this.panel3.TabIndex = 2;
         // 
         // input_apppat
         // 
         this.input_apppat.FormattingEnabled = true;
         this.input_apppat.Location = new System.Drawing.Point(82, 98);
         this.input_apppat.Name = "input_apppat";
         this.input_apppat.Size = new System.Drawing.Size(147, 21);
         this.input_apppat.TabIndex = 3;
         // 
         // input_appdoc
         // 
         this.input_appdoc.FormattingEnabled = true;
         this.input_appdoc.Location = new System.Drawing.Point(82, 71);
         this.input_appdoc.Name = "input_appdoc";
         this.input_appdoc.Size = new System.Drawing.Size(147, 21);
         this.input_appdoc.TabIndex = 3;
         // 
         // input_apptime
         // 
         this.input_apptime.CustomFormat = "dd-MM-yyyy hh:mm tt";
         this.input_apptime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.input_apptime.Location = new System.Drawing.Point(82, 45);
         this.input_apptime.Name = "input_apptime";
         this.input_apptime.RightToLeft = System.Windows.Forms.RightToLeft.No;
         this.input_apptime.Size = new System.Drawing.Size(147, 20);
         this.input_apptime.TabIndex = 3;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(97, 16);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(63, 13);
         this.label8.TabIndex = 1;
         this.label8.Text = "Appoinment";
         // 
         // bnt_app_remove
         // 
         this.bnt_app_remove.Location = new System.Drawing.Point(135, 156);
         this.bnt_app_remove.Name = "bnt_app_remove";
         this.bnt_app_remove.Size = new System.Drawing.Size(75, 23);
         this.bnt_app_remove.TabIndex = 2;
         this.bnt_app_remove.Text = "Remove";
         this.bnt_app_remove.UseVisualStyleBackColor = true;
         this.bnt_app_remove.Click += new System.EventHandler(this.bnt_app_remove_Click);
         // 
         // bnt_app_list
         // 
         this.bnt_app_list.Location = new System.Drawing.Point(135, 127);
         this.bnt_app_list.Name = "bnt_app_list";
         this.bnt_app_list.Size = new System.Drawing.Size(75, 23);
         this.bnt_app_list.TabIndex = 2;
         this.bnt_app_list.Text = "List";
         this.bnt_app_list.UseVisualStyleBackColor = true;
         this.bnt_app_list.Click += new System.EventHandler(this.bnt_app_list_Click);
         // 
         // bnt_app_add
         // 
         this.bnt_app_add.Location = new System.Drawing.Point(50, 127);
         this.bnt_app_add.Name = "bnt_app_add";
         this.bnt_app_add.Size = new System.Drawing.Size(75, 23);
         this.bnt_app_add.TabIndex = 2;
         this.bnt_app_add.Text = "Add";
         this.bnt_app_add.UseVisualStyleBackColor = true;
         this.bnt_app_add.Click += new System.EventHandler(this.bnt_app_add_Click);
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(3, 47);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(80, 13);
         this.label6.TabIndex = 1;
         this.label6.Text = "Date and Time:";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(38, 101);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(43, 13);
         this.label7.TabIndex = 1;
         this.label7.Text = "Patient:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(37, 74);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(45, 13);
         this.label5.TabIndex = 1;
         this.label5.Text = "Doctor: ";
         // 
         // dataGridView1
         // 
         this.dataGridView1.AllowUserToAddRows = false;
         this.dataGridView1.AllowUserToDeleteRows = false;
         this.dataGridView1.AllowUserToResizeColumns = false;
         this.dataGridView1.AllowUserToResizeRows = false;
         this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(269, 12);
         this.dataGridView1.MultiSelect = false;
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.ReadOnly = true;
         this.dataGridView1.Size = new System.Drawing.Size(397, 459);
         this.dataGridView1.TabIndex = 3;
         this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
         // 
         // btn_app_update
         // 
         this.btn_app_update.Location = new System.Drawing.Point(50, 156);
         this.btn_app_update.Name = "btn_app_update";
         this.btn_app_update.Size = new System.Drawing.Size(75, 23);
         this.btn_app_update.TabIndex = 2;
         this.btn_app_update.Text = "Update";
         this.btn_app_update.UseVisualStyleBackColor = true;
         this.btn_app_update.Click += new System.EventHandler(this.btn_update_Click);
         // 
         // clear
         // 
         this.clear.Location = new System.Drawing.Point(622, 450);
         this.clear.Name = "clear";
         this.clear.Size = new System.Drawing.Size(44, 21);
         this.clear.TabIndex = 4;
         this.clear.Text = "Clear";
         this.clear.UseVisualStyleBackColor = true;
         this.clear.Click += new System.EventHandler(this.clear_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(678, 479);
         this.Controls.Add(this.clear);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.panel3);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.panel3.ResumeLayout(false);
         this.panel3.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button bnt_doc;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox input_docname;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Button bnt_pat;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox input_patientname;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.DateTimePicker input_apptime;
      private System.Windows.Forms.Button bnt_app_add;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.ComboBox input_apppat;
      private System.Windows.Forms.ComboBox input_appdoc;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Button bnt_app_remove;
      private System.Windows.Forms.Button bnt_app_list;
      private System.Windows.Forms.Button btn_app_update;
      private System.Windows.Forms.Button clear;
   }
}


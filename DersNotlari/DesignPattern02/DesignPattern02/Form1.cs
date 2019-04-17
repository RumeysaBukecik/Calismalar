using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Business.Entity;
using Business.Facade;

namespace DesignPattern02 {
   public partial class Form1 : Form {
      public Form1() {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e) {
         UpdateDocList();
         UpdatePatList();
         UpdateAppList();
      }

      List<string> DocList = new List<string>();
      List<string> PatList = new List<string>();

      private void bnt_doc_Click(object sender, EventArgs e) {
         EntityClass eClass = new EntityClass();
         eClass.DocName = input_docname.Text;
         int temp = FacadeClass.InsertDoc(eClass);
         CheckConfirmation(temp);
         UpdateDocList();
      }

      private void bnt_pat_Click(object sender, EventArgs e) {
         EntityClass eClass = new EntityClass();
         eClass.PatName = input_patientname.Text;
         int temp = FacadeClass.InsertPat(eClass);
         CheckConfirmation(temp);
         UpdatePatList();
      }

      private void bnt_app_add_Click(object sender, EventArgs e) {
         EntityClass eClass = new EntityClass();
         eClass.AppTime = input_apptime.Value;
         eClass.AppDocID = int.Parse(DocList[( DocList.IndexOf(input_appdoc.Text) - 1 )]);
         eClass.AppPatID = int.Parse(PatList[( PatList.IndexOf(input_apppat.Text) - 1 )]);
         int temp = FacadeClass.InsertApp(eClass);
         CheckConfirmation(temp);
         UpdateAppList();
      }

      private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
         input_apptime.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
         input_appdoc.SelectedItem = dataGridView1.CurrentRow.Cells[1].Value.ToString();
         input_apppat.SelectedItem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
         btn_app_update.Enabled = true;
         bnt_app_remove.Enabled = true;
      }

      private void bnt_app_list_Click(object sender, EventArgs e) {
         UpdateAppList();
      }

      private void UpdateAppList() {
         dataGridView1.DataSource = FacadeClass.List("App");
         btn_app_update.Enabled = false;
         bnt_app_remove.Enabled = false;
         input_apptime.Value = DateTime.Now;
         input_appdoc.Text = "";
         input_apppat.Text= "";
      }

      private void bnt_app_remove_Click(object sender, EventArgs e) {
         EntityClass eClass = new EntityClass();
         eClass.AppID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
         int temp = FacadeClass.RemoveApp(eClass);
         CheckConfirmation(temp);
         UpdateAppList();
      }

      private void btn_update_Click(object sender, EventArgs e) {
         EntityClass eClass = new EntityClass();
         eClass.AppTime = input_apptime.Value;
         eClass.AppDocID = int.Parse(DocList[( DocList.IndexOf(input_appdoc.Text) - 1 )]);
         eClass.AppPatID = int.Parse(PatList[( PatList.IndexOf(input_apppat.Text) - 1 )]);
         eClass.AppID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
         int temp = FacadeClass.UpdateApp(eClass);
         CheckConfirmation(temp);
         UpdateAppList();
      }

      private void UpdateDocList() {
         DataTable temptable = FacadeClass.List("Doc");
         DocList.Clear();
         for ( int i = 0; i < temptable.Rows.Count; i++ ) {
            DocList.Add(temptable.Rows[i][0].ToString()); DocList.Add(temptable.Rows[i][1].ToString());
            input_appdoc.Items.Add(temptable.Rows[i][1]);
         }
      }

      private void UpdatePatList() {
         DataTable temptable = FacadeClass.List("Pat");
         PatList.Clear();
         for ( int i = 0; i < temptable.Rows.Count; i++ ) {
            PatList.Add(temptable.Rows[i][0].ToString()); PatList.Add(temptable.Rows[i][1].ToString());
            input_apppat.Items.Add(temptable.Rows[i][1]);
         }
      }

      private void CheckConfirmation(int temp) {
         if ( temp > 0 ) MessageBox.Show("Done.");
         else MessageBox.Show("Error.");
      }

      private void clear_Click(object sender, EventArgs e) {
         UpdateAppList();
         input_docname.Text = "";
         input_patientname.Text = "";
      }
   }
}

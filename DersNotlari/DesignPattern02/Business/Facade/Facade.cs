using System.Data;
using Business.Entity;
using Business.Commons;
using System.Data.SqlClient;

namespace Business.Facade {
   public class FacadeClass {
      public static int InsertDoc(EntityClass ent) {
         SqlCommand sqlCommand01 = new SqlCommand("InsertDoc", Common.Conn) {CommandType = CommandType.StoredProcedure };
         sqlCommand01.Parameters.AddWithValue("@docname", ent.DocName);
         return Common.ExecuteSQL(sqlCommand01);
      }
      public static int InsertPat(EntityClass ent) {
         SqlCommand sqlCommand01 = new SqlCommand("InsertPat", Common.Conn) { CommandType = CommandType.StoredProcedure };
         sqlCommand01.Parameters.AddWithValue("@patname", ent.PatName);
         return Common.ExecuteSQL(sqlCommand01);
      }
      public static int InsertApp(EntityClass ent) {
         SqlCommand sqlCommand01 = new SqlCommand("InsertApp", Common.Conn) { CommandType = CommandType.StoredProcedure };
         sqlCommand01.Parameters.AddWithValue("@apptime", ent.AppTime);
         sqlCommand01.Parameters.AddWithValue("@appdocid", ent.AppDocID);
         sqlCommand01.Parameters.AddWithValue("@apppatid", ent.AppPatID);
         return Common.ExecuteSQL(sqlCommand01);
      }
      public static int RemoveApp(EntityClass ent) {
         SqlCommand sqlCommand01 = new SqlCommand("RemoveApp", Common.Conn) { CommandType = CommandType.StoredProcedure };
         sqlCommand01.Parameters.AddWithValue("@appid", ent.AppID);
         return Common.ExecuteSQL(sqlCommand01);
      }
      public static int UpdateApp(EntityClass ent) {
         SqlCommand sqlCommand01 = new SqlCommand("UpdateApp", Common.Conn) { CommandType = CommandType.StoredProcedure };
         sqlCommand01.Parameters.AddWithValue("@apptime", ent.AppTime);
         sqlCommand01.Parameters.AddWithValue("@appdocid", ent.AppDocID);
         sqlCommand01.Parameters.AddWithValue("@apppatid", ent.AppPatID);
         sqlCommand01.Parameters.AddWithValue("@appid", ent.AppID);
         return Common.ExecuteSQL(sqlCommand01);
      }
      public static DataTable List(string type) {
         SqlDataAdapter sqlDataAdapter01 = new SqlDataAdapter($"List{type}", Common.Conn);
         DataTable dataTable = new DataTable();
         sqlDataAdapter01.Fill(dataTable);
         return dataTable;
      }
   }
}

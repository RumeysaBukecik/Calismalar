using System.Data.SqlClient;
using System.Configuration;

namespace Business.Commons {
   class Common {
      private static SqlConnection PriConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS_Hospital"].ConnectionString);

      public static SqlConnection Conn { get { return PriConn; } }

      public static int ExecuteSQL(SqlCommand sqlCommand01) {
         Conn.Open(); int temp = sqlCommand01.ExecuteNonQuery(); Conn.Close(); return temp;
      }
   }
}

using System.Data.SqlClient;

namespace aottest
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Hello, World!");

         using (SqlConnection sqlConnection = new SqlConnection("server=xxx.database.windows.net;user id=xxx;password=xxx;Initial Catalog=appMpower;Connection Timeout=120;"))
         {
            sqlConnection.Open();
            sqlConnection.Close();
         }
      }
   }
}

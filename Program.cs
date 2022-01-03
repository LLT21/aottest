using Microsoft.Data.SqlClient;

namespace aottest
{
   class Program
   {
      static async Task Main(string[] args)
      {
         DateTime bTime;
         Console.WriteLine("Hello, World!");

         string connectionString = "server=xxx.database.windows.net;user id=xxx;password=xxx;Initial Catalog=appMpower;Connection Timeout=120;";

         using (SqlConnection sqlConnection = new SqlConnection(connectionString))
         {
            bTime = DateTime.Now;
            await sqlConnection.OpenAsync();
            Console.WriteLine(DateTime.Now - bTime);
            await sqlConnection.CloseAsync();
         }

         using (SqlConnection sqlConnection = new SqlConnection(connectionString))
         {
            bTime = DateTime.Now;
            await sqlConnection.OpenAsync();
            Console.WriteLine(DateTime.Now - bTime);
            await sqlConnection.CloseAsync();
         }
      }
   }
}

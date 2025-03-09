using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;


namespace ParkingReservationSystem.src.Database
{
    static class DatabaseConnection
    {
        public static SqlConnection GetDBConnection()
        {
            return new SqlConnection("Data Source=****;Initial Catalog=ParkingReservationSystem;Integrated Security=True");
        }

        public static void ExecuteCommand(SqlCommand cmd, SqlConnection con) {
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

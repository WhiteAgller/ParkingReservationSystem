using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ParkingReservationSystem.src.Database.DatabaseConnection;

namespace ParkingReservationSystem.src
{
    internal class Statistics
    {
        private readonly SqlConnection _con = GetDBConnection();
        private readonly Cars _cars = new Cars();


        public int GetTotalReservations() {

            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Reservations", _con))
            {
                _con.Open();
                int totalCount = (int)cmd.ExecuteScalar();
                _con.Close();
                return totalCount;
            }
        }

        public int GetTotalReservationsByCarVIM(string vim)
        {
            var carId = _cars.GetCarsIdbyVin(vim);

            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Reservations WHERE Car_ID = @ID", _con))
            {
                cmd.Parameters.AddWithValue("@ID", carId);

                _con.Open();
                int totalCount = (int)cmd.ExecuteScalar();
                _con.Close();

                return totalCount;
            }
        }

        public DateTime GetLatestReservation()
        {
            using (var cmd = new SqlCommand("SELECT MAX(CreationTime) FROM Reservations", _con))
            {

                _con.Open();
                var dt = (DateTime)cmd.ExecuteScalar();
                _con.Close();

                return dt;
            }
        }

        public DateTime GetLatestReservationByCarVIM(string vim)
        {
            var carId = _cars.GetCarsIdbyVin(vim);

            if(carId == null)
            {
                return DateTime.Today;
            }

            using (var cmd = new SqlCommand("SELECT MAX(CreationTime) FROM Reservations WHERE ID = @ID", _con))
            {
                cmd.Parameters.AddWithValue("@ID", carId);

                _con.Open();
                var dt = (DateTime)cmd.ExecuteScalar();
                _con.Close();

                return dt;
            }
        }
    }
}

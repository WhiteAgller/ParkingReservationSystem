using ParkingReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ParkingReservationSystem.src.Database.DatabaseConnection;
using static ParkingReservationSystem.src.Validator;
using System.Windows.Forms;

namespace ParkingReservationSystem.src
{
    internal class Reservations
    {
        private readonly SqlConnection _con = GetDBConnection();
        private readonly Cars _cars = new Cars();
        
        public DataTable GetReservations()
        {
            var cmd = new SqlCommand("Select r.ID, c.VIN, r. ParkPlace_ID,r.DateTo, r.DateFrom, r.Description, r.CreationTime from dbo.Reservations as r Join dbo.Cars as c ON r.Car_ID = c.ID", _con);
            var dt = new DataTable();
            _con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            _con.Close();

            return dt;
        }

        public void Insert(ReservationsModel input)
        {
            var id = GetCarId(input.CarName)?.ToString();
            if (id == null)
            {
                System.Windows.Forms.MessageBox.Show("Car was not found!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!CorrectDates(input.DateForm, input.DateTo))
            {
                System.Windows.Forms.MessageBox.Show("The DateTo is earlier than DateFrom.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cmd = new SqlCommand("INSERT INTO Reservations (Car_ID, ParkPlace_ID, DateFrom, DateTo, Description, CreationTime) VALUES (@Car_ID, @ParkPlace_ID, @DateFrom, @DateTo, @Description, @CreationTime)", _con);
                cmd.Parameters.AddWithValue("@Car_ID", id);
                cmd.Parameters.AddWithValue("@ParkPlace_ID", input.ParkingPlaceId);
                cmd.Parameters.AddWithValue("@DateFrom", input.DateForm);
                cmd.Parameters.AddWithValue("@DateTo", input.DateTo);
                cmd.Parameters.AddWithValue("@Description", input.Description);
                cmd.Parameters.AddWithValue("@CreationTime", DateTime.Now);

            ExecuteCommand(cmd, _con);
        }

        private string GetCarId(string vin)
        {
            return _cars.GetCars()
                    .AsEnumerable()
                    .FirstOrDefault(x => x.Field<string>("VIN") == vin)?
                    .Field<int>("Id")
                    .ToString();
        }

        public void Update(int reservationId, ReservationsModel input)
        {
            if (reservationId == 0)
            {
                System.Windows.Forms.MessageBox.Show("There is nothing to update!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var carId = GetCarId(input.CarName);

            var cmd = new SqlCommand("UPDATE Reservations SET Car_ID = @Car_ID, ParkPlace_ID = @ParkPlace_ID, DateFrom = @DateFrom, DateTo = @DateTo, Description = @Description WHERE ID=@ID", _con);
            cmd.Parameters.AddWithValue("@Car_ID", carId);
            cmd.Parameters.AddWithValue("@ParkPlace_ID", input.ParkingPlaceId);
            cmd.Parameters.AddWithValue("@DateFrom", input.DateForm);
            cmd.Parameters.AddWithValue("@DateTo", input.DateTo);
            cmd.Parameters.AddWithValue("@Description", input.Description);
            cmd.Parameters.AddWithValue("@ID", reservationId);

            ExecuteCommand(cmd, _con);
        }

        public void Delete(int id)
        {
            if (id == 0)
            {
                System.Windows.Forms.MessageBox.Show("There is nothing to delete!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var cmd = new SqlCommand("DELETE FROM Reservations WHERE ID = @ID", _con);
            cmd.Parameters.AddWithValue("@ID", id);
            ExecuteCommand(cmd, _con);
            
            
        }
    }
}

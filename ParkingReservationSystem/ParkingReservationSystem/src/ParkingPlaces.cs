using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingReservationSystem.Models;
using static ParkingReservationSystem.src.Database.DatabaseConnection;
using static ParkingReservationSystem.src.Validator;


namespace ParkingReservationSystem.src
{
    class ParkingPlaces
    {
        private readonly SqlConnection _con = GetDBConnection();
        private readonly Sectors _sectors = new Sectors();

        public DataTable GetParkingSlots()
        {
            var cmd = new SqlCommand("Select ps.ID, s.Name, ps.Description from ParkingSlots as ps Join dbo.Sectors as s ON ps.Sector_ID = s.ID", _con);
            var dt = new DataTable();

            _con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            _con.Close();

            return dt;
        }

        public void Insert(ParkingPlacesModel input)
        {
            if (IsNotEmpty(input.SectorName))
            {
                var id = GetSectorId(input.SectorName)?.ToString();
                if (id == null)
                {
                    System.Windows.Forms.MessageBox.Show("Sector was not found!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var cmd = new SqlCommand("INSERT INTO ParkingSlots (Sector_ID, Description) VALUES (@sector_id, @description)", _con);
                cmd.Parameters.AddWithValue("@sector_id", id);
                cmd.Parameters.AddWithValue("@description", input.Description);

                ExecuteCommand(cmd, _con);
            }
        }

        public void Update(int parkingPlaceId, ParkingPlacesModel input)
        {
            if(parkingPlaceId == 0)
            {
                System.Windows.Forms.MessageBox.Show("There is nothing to update!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var id = GetSectorId(input.SectorName)?.ToString();
            if (id == null)
            {
                System.Windows.Forms.MessageBox.Show("Sector was not found!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var cmd = new SqlCommand("UPDATE ParkingSlots SET Sector_ID = @sector_id, Description = @description WHERE ID=@ID", _con);
            cmd.Parameters.AddWithValue("@sector_id", id);
            cmd.Parameters.AddWithValue("@description", input.Description);
            cmd.Parameters.AddWithValue("@ID", parkingPlaceId);

            ExecuteCommand(cmd, _con);
        }

        private string GetSectorId(string name)
        {
            return _sectors.GetSectors()
                    .AsEnumerable()
                    .FirstOrDefault(x => x.Field<string>("Name") == name)?
                    .Field<int>("Id")
                    .ToString();
        }

        public void Delete(int id)
        {
            if (id == 0)
            {
                System.Windows.Forms.MessageBox.Show("There is nothing to delete!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var cmd = new SqlCommand("DELETE FROM ParkingSlots WHERE ID = @ID", _con);
            cmd.Parameters.AddWithValue("@ID", id);

            ExecuteCommand(cmd, _con);
        }

    }
}

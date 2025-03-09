using ParkingReservationSystem.Models;
using ParkingReservationSystem.src.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ParkingReservationSystem.src.Database.DatabaseConnection;
using static ParkingReservationSystem.src.Validator;

namespace ParkingReservationSystem.src
{
    class Sectors
    {
        private readonly SqlConnection _con = GetDBConnection();

        public DataTable GetSectors()
        {
            var cmd = new SqlCommand("Select * from Sectors", _con);
            var dt = new DataTable();

            _con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            _con.Close();

            return dt;
        }

        public void Insert(SectorsModel input)
        {
            if (IsNotEmpty(input.Name))
            {
                var cmd = new SqlCommand("INSERT INTO Sectors (Name, Description) VALUES (@name, @description)", _con);
                cmd.Parameters.AddWithValue("@name", input.Name);
                cmd.Parameters.AddWithValue("@description", input.Description);

                ExecuteCommand(cmd, _con);
            }
        }

        public void Update(int sectorId, SectorsModel input)
        {
            if (sectorId == 0)
            {
                System.Windows.Forms.MessageBox.Show("There is nothing to update!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cmd = new SqlCommand("UPDATE Sectors SET Name = @name, Description = @description WHERE ID=@ID", _con);
            cmd.Parameters.AddWithValue("@name", input.Name);
            cmd.Parameters.AddWithValue("@description", input.Description);
            cmd.Parameters.AddWithValue("@ID", sectorId);

            ExecuteCommand(cmd, _con);
        }

        public void Delete(int id)
        {
            if (id == 0)
            {
                System.Windows.Forms.MessageBox.Show("There is nothing to delete!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var cmd = new SqlCommand("DELETE FROM Sectors WHERE ID = @ID", _con);
            cmd.Parameters.AddWithValue("@ID", id);

            ExecuteCommand(cmd, _con);
        }
    }
}

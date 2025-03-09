using ParkingReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ParkingReservationSystem.src.Database.DatabaseConnection;
using static ParkingReservationSystem.src.Validator;
using System.Net.Http;
using static System.Net.WebRequestMethods;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.Runtime.InteropServices.WindowsRuntime;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace ParkingReservationSystem.src
{
    class Cars
    {
        private readonly SqlConnection _con = GetDBConnection();

        public DataTable GetCars()
        {
            var cmd = new SqlCommand("Select * from Cars", _con);
            var dt = new DataTable();
            _con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            _con.Close();

            return dt;
        }

        public async Task Insert(CarsModelInputModel input)
        {
            if (IsNotEmpty(input.VIN))
            {
                var details = await GetInfoFromApi(input.VIN);

                var cmd = new SqlCommand();

                if(details == null)
                {
                    cmd = new SqlCommand("INSERT INTO Cars (VIN, Year, Make, Model, Description) VALUES (@VIN, @Year, @Make, @Model, @Description)", _con);
                    cmd.Parameters.AddWithValue("@VIN", input.VIN);
                    cmd.Parameters.AddWithValue("@Year", "");
                    cmd.Parameters.AddWithValue("@Make", "");
                    cmd.Parameters.AddWithValue("@Model", "");
                    cmd.Parameters.AddWithValue("@Description", input.Description);
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO Cars (VIN, Year, Make, Model, Description) VALUES (@VIN, @Year, @Make, @Model, @Description)", _con);
                    cmd.Parameters.AddWithValue("@VIN", input.VIN);
                    cmd.Parameters.AddWithValue("@Year", details.Specification.Year);
                    cmd.Parameters.AddWithValue("@Make", details.Specification.Make);
                    cmd.Parameters.AddWithValue("@Model", details.Specification.Make);
                    cmd.Parameters.AddWithValue("@Description", input.Description);
                }
                
                ExecuteCommand(cmd, _con);
            }
        }

        private async Task<CarsGetModel> GetInfoFromApi(string VIN)
        {
            HttpClient client = new HttpClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://vindecoder.p.rapidapi.com/decode_vin?vin={VIN}"),
                Headers =
                {
                    { "X-RapidAPI-Key", "606809d474msha41edc5b3b28f60p1eeeacjsne42320dfe010" },
                    { "X-RapidAPI-Host", "vindecoder.p.rapidapi.com" },
                }
            };
            
            var response = await client.SendAsync(request);
            var car = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<CarsGetModel>(car);
            return response.IsSuccessStatusCode ? json : null;
        }

        public void Update(int carId, CarsModel input)
        {
            if (carId == 0)
            {
                System.Windows.Forms.MessageBox.Show("There is nothing to update!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var cmd = new SqlCommand("UPDATE Cars SET VIN = @VIN, Year = @Year, Make = @Make, Model = @Model, Description = @Description WHERE ID=@ID", _con);
            cmd.Parameters.AddWithValue("@VIN", input.VIN);
            cmd.Parameters.AddWithValue("@Year", input.Year);
            cmd.Parameters.AddWithValue("@Make", input.Make);
            cmd.Parameters.AddWithValue("@Model", input.Make);
            cmd.Parameters.AddWithValue("@Description", input.Description);
            cmd.Parameters.AddWithValue("@ID", carId);

            ExecuteCommand(cmd, _con);
        }

        public void Delete(int id)
        {
            if (id == 0)
            {
                System.Windows.Forms.MessageBox.Show("There is nothing to delete!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var cmd = new SqlCommand("DELETE FROM Cars WHERE ID = @ID", _con);
            cmd.Parameters.AddWithValue("@ID", id);

            ExecuteCommand(cmd, _con);
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.Title = "Select a File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                MessageBox.Show("Selected File: " + selectedFilePath);
            }
        }

        public string GetCarsViNbyId(int carId)
        {
            return (GetCars()
                    .AsEnumerable()
                    .FirstOrDefault(x => x.Field<int>("ID") == carId) ?? throw new InvalidOperationException())
            .Field<int>("Id")
            .ToString();
        }

        public string GetCarsIdbyVin(string vin)
        {
            return (GetCars()
                    .AsEnumerable()
                    .FirstOrDefault(x => x.Field<string>("VIN") == vin) ?? throw new InvalidOperationException())
            .Field<int>("Id")
            .ToString();
        }
    }
}

using ParkingReservationSystem.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ParkingReservationSystem
{
    public partial class ParkingPlacesForm : Form
    {
        public ParkingPlacesForm()
        {
            InitializeComponent();
            SetParkingPlaces();
            SetSectorNamesToCombo();
        }

        private int _parkingPlacesId;

        private readonly ParkingPlaces _parkingPlaces = new ParkingPlaces();
        private readonly Sectors _sectors = new Sectors();

        private void ParkingPlaces_Load(object sender, EventArgs e)
        {
        }

        private void SetParkingPlaces()
        {
            parkingPlaces_Grid.DataSource = _parkingPlaces.GetParkingSlots();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }

        private void SetSectorNamesToCombo()
        {
            var allSectors = _sectors.GetSectors();
            var sectorNames = allSectors.AsEnumerable()
                .Select(row => row.Field<string>("Name"))
                .ToList();
            parkingPlaces__comboBox.Items.AddRange(sectorNames.ToArray());
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            _parkingPlaces.Insert(new Models.ParkingPlacesModel()
            {
                SectorName = parkingPlaces__comboBox.Text,
                Description = parkingPlaces_description_textBox.Text
            });
            SetParkingPlaces();
            ResetFormControls();
        }


        private void Update_button_Click(object sender, EventArgs e)
        {
            _parkingPlaces.Update(_parkingPlacesId, new Models.ParkingPlacesModel()
            {
                SectorName = parkingPlaces__comboBox.Text,
                Description = parkingPlaces_description_textBox.Text
            });
            SetParkingPlaces();
            ResetFormControls();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            _parkingPlaces.Delete(_parkingPlacesId);
            SetParkingPlaces();
        }

        private void ResetFormControls()
        {
            parkingPlaces__comboBox.Text = "";
            parkingPlaces_description_textBox.Clear();
        }

        private void ParkingSlotsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _parkingPlacesId = Convert.ToInt32(parkingPlaces_Grid.SelectedRows[0].Cells[0].Value);
            parkingPlaces__comboBox.Text = parkingPlaces_Grid.SelectedRows[0].Cells[1].Value.ToString();
            parkingPlaces_description_textBox.Text = parkingPlaces_Grid.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }
    }
}

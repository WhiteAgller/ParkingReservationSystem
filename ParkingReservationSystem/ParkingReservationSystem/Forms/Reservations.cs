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
    public partial class ReservationsForm : Form
    {
        public ReservationsForm()
        {
            InitializeComponent();
            SetReservations();
            SetCarVinsToCombo();
            SetParkPlaceIdToCombo();
        }

        private int _reservationId;

        private readonly Cars _cars = new Cars();
        private readonly ParkingPlaces _places = new ParkingPlaces();
        private readonly Reservations _reservations = new Reservations();

        private void Reservations_Load(object sender, EventArgs e)
        {
        }

        private void SetCarVinsToCombo()
        {
            var allCars = _cars.GetCars();
            var vinNames = allCars.AsEnumerable()
                .Select(row => row.Field<string>("VIN"))
                .ToList();
            reservations__VIN_comboBox.Items.AddRange(vinNames.ToArray());
        }

        private void SetParkPlaceIdToCombo()
        {
            var allParkPlaces = _places.GetParkingSlots();
            var parkPlacesIDs = allParkPlaces.AsEnumerable()
                .Select(row => row.Field<int>("ID").ToString())
                .ToList();
            reservations_parkingPlace_comboBox.Items.AddRange(parkPlacesIDs.ToArray());
        }

        private void SetReservations()
        {
            reservations_Grid.DataSource = _reservations.GetReservations();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void ParkingSlotsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            _reservations.Insert(new Models.ReservationsModel()
            {
                CarName = reservations__VIN_comboBox.Text,
                ParkingPlaceId = Convert.ToInt32(reservations_parkingPlace_comboBox.Text),
                DateForm = reservations_from_dateTimePicker1.Value,
                DateTo = reservations_to_dateTimePicker1.Value,
                Description = reservations_description_textBox.Text,
            });
            ResetFormControls();
            SetReservations();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            _reservations.Update(_reservationId, new Models.ReservationsModel()
            {
                 CarName = reservations__VIN_comboBox.Text,
                 ParkingPlaceId = Convert.ToInt32(reservations_parkingPlace_comboBox.Text),
                 DateForm = reservations_from_dateTimePicker1.Value,
                 DateTo = reservations_to_dateTimePicker1.Value,
                 Description = reservations_description_textBox.Text,
             });
            SetReservations();
            ResetFormControls();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            _reservations.Delete(_reservationId);
            SetReservations();
        }

        private void ResetFormControls()
        {
            reservations__VIN_comboBox.Text = "";
            reservations_parkingPlace_comboBox.Text = "";
            reservations_from_dateTimePicker1.Value = DateTime.Now;
            reservations_to_dateTimePicker1.Value = DateTime.Now;
            reservations_description_textBox.Clear();
        }

        private void ParkingSlotsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _reservationId = Convert.ToInt32(reservations_Grid.SelectedRows[0].Cells[0].Value);
            reservations__VIN_comboBox.Text = reservations_Grid.SelectedRows[0].Cells[1].Value.ToString();
            reservations_parkingPlace_comboBox.Text = reservations_Grid.SelectedRows[0].Cells[2].Value.ToString();
            reservations_from_dateTimePicker1.Text = reservations_Grid.SelectedRows[0].Cells[3].Value.ToString();
            reservations_to_dateTimePicker1.Text = reservations_Grid.SelectedRows[0].Cells[4].Value.ToString();
            reservations_description_textBox.Text = reservations_Grid.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }
    }
}

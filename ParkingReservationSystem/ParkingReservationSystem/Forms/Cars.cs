using ParkingReservationSystem.Models;
using ParkingReservationSystem.src;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ParkingReservationSystem
{
    public partial class CarsForm : Form
    {
        public CarsForm()
        {
            InitializeComponent();
            SetCars();
        }

        private int _carId;

        private readonly Cars _cars = new Cars();

        private void Cars_Load(object sender, EventArgs e)
        {
        }

        private void SetCars()
        {
            cars_Grid.DataSource = _cars.GetCars();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }

        private async void Insert_button_Click(object sender, EventArgs e)
        {
            await _cars.Insert(new Models.CarsModelInputModel()
            {
                VIN = cars__textBox.Text,
                Description = cars_description_textBox.Text,
            });
            ResetFormControls();
            SetCars();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            _cars.Update(_carId, new Models.CarsModel()
            {
                VIN = cars__textBox.Text,
                Year = cars_year_textBox.Text,
                Make = cars_model_textBox.Text,
                Model = cars_model_textBox.Text,
                Description = cars_description_textBox.Text
            });
            SetCars();
            ResetFormControls();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            _cars.Delete(_carId);
            SetCars();
        }

        private void ResetFormControls()
        {
            cars__textBox.Text = "";
            cars_year_textBox.Clear();
            cars_make_textBox.Clear();
            cars_model_textBox.Clear();
            cars_description_textBox.Clear();
        }

        private void ParkingSlotsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _carId = Convert.ToInt32(cars_Grid.SelectedRows[0].Cells[0].Value);
            cars__textBox.Text = cars_Grid.SelectedRows[0].Cells[1].Value.ToString();
            cars_year_textBox.Text = cars_Grid.SelectedRows[0].Cells[2].Value.ToString();
            cars_make_textBox.Text = cars_Grid.SelectedRows[0].Cells[3].Value.ToString();
            cars_model_textBox.Text = cars_Grid.SelectedRows[0].Cells[4].Value.ToString();
            cars_description_textBox.Text = cars_Grid.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.Title = "Select a File";

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            var selectedFilePath = openFileDialog.FileName;
            var parsedData = ParseFile(selectedFilePath);
            foreach (var data in parsedData)
            {
                await _cars.Insert(new Models.CarsModelInputModel()
                {
                    VIN = data.VIN,
                    Description = data.Description,
                });

            }
            SetCars();
        }

        private static List<CarsModelInputModel> ParseFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);

            return (from line in lines select line
                .Split(';') into parts where parts.Length == 2 let vin = parts[0]
                .Trim() let role = parts[1].Trim() select new CarsModelInputModel() { VIN = vin, Description = role })
                .ToList();
        }
    }
}

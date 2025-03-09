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
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
            SetTotalCount();
            SetCarVinsToCombo();
        }

        private readonly Statistics _statistics = new Statistics();
        private readonly Cars _cars = new Cars();

        private void SetCarVinsToCombo()
        {
            var allCars = _cars.GetCars();
            var vinNames = allCars.AsEnumerable()
                .Select(row => row.Field<string>("VIN"))
                .ToList();
            comboBox1.Items.AddRange(vinNames.ToArray());
        }

        private void SetTotalCount()
        {
            lateest_reservation_label.Text = _statistics.GetTotalReservations().ToString();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            statistics_latest_reservation__car_label.Text = _statistics.GetLatestReservationByCarVIM(comboBox1.Text).ToString();
            statistics_total_reservation_car_label.Text = _statistics.GetTotalReservationsByCarVIM(comboBox1.Text).ToString();
        }
    }
}

using System;
using System.Windows.Forms;

namespace ParkingReservationSystem
{
    public partial class Main : Form
    {

        private Form _activeForm = null;

        public Main()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Main().FormBorderStyle = FormBorderStyle.FixedSingle;
            new Main().MaximizeBox = false;
            new Main().MinimizeBox = false;
        }

        private void CustomizeDesign()
        {
            cars_subMenu.Visible = false;
            parkingPlaces_subMenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if(cars_subMenu.Visible)
            {
                cars_subMenu.Visible = false;
            }
            if(parkingPlaces_subMenu.Visible)
            {
                parkingPlaces_subMenu.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            ShowSubMenu(parkingPlaces_subMenu);
        }

        private void ParkingPlaces_subButton_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new ParkingPlacesForm());
            HideSubMenu();
        }

        private void ParkingPlaces_subButton2_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new SectorsForm());
            HideSubMenu();
        }

        private void Cars_MainButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(cars_subMenu);
        }

        private void Cars_subButton_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new CarsForm());
            HideSubMenu();
        }

        private void Cars_subButton2_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new StatisticsForm());
            HideSubMenu();
        }

        private void Reservations_MainButton_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new ReservationsForm());
        }
        private void OpenChildFrom(Form childForm)
        {
            if(_activeForm != null)
            {
                _activeForm.Close();
            }
            _activeForm = null;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            main_backgroundPanel.Controls.Add(childForm);
            main_backgroundPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
    }
}

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
    public partial class SectorsForm : Form
    {
        public SectorsForm()
        {
            InitializeComponent();
            SetSectors();
        }

        private int _sectorsId;

        private readonly Sectors _sectors = new Sectors();

        private void Sectors_Load(object sender, EventArgs e)
        {
        }

        private void SetSectors()
        {
            sectors_Grid.DataSource = _sectors.GetSectors();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }

        private void ParkingSlotsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            _sectors.Insert(new Models.SectorsModel()
            {
                Name = sectors__textBox.Text,
                Description = sectors_description_textBox.Text
            });
            SetSectors();
            ResetFormControls();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            _sectors.Update(_sectorsId, new Models.SectorsModel()
            {
                Name = sectors__textBox.Text,
                Description = sectors_description_textBox.Text
            });
            SetSectors();
            ResetFormControls();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            _sectors.Delete(_sectorsId);
            SetSectors();
        }

        private void ResetFormControls()
        {
            sectors__textBox.Text = "";
            sectors_description_textBox.Clear();
        }

        private void ParkingSlotsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _sectorsId = Convert.ToInt32(sectors_Grid.SelectedRows[0].Cells[0].Value);
            sectors__textBox.Text = sectors_Grid.SelectedRows[0].Cells[1].Value.ToString();
            sectors_description_textBox.Text = sectors_Grid.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }
    }
}

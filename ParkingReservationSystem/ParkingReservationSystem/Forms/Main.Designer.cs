namespace ParkingReservationSystem
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sideMenu = new System.Windows.Forms.Panel();
            this.reservations_MainButton = new System.Windows.Forms.Button();
            this.cars_subMenu = new System.Windows.Forms.Panel();
            this.cars_subButton2 = new System.Windows.Forms.Button();
            this.cars_subButton = new System.Windows.Forms.Button();
            this.cars_MainButton = new System.Windows.Forms.Button();
            this.parkingPlaces_subMenu = new System.Windows.Forms.Panel();
            this.parkingPlaces_subButton2 = new System.Windows.Forms.Button();
            this.parkingPlaces_subButton = new System.Windows.Forms.Button();
            this.parkingPlaces_MainButton = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Panel();
            this.main_backgroundPanel = new System.Windows.Forms.Panel();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sideMenu.SuspendLayout();
            this.cars_subMenu.SuspendLayout();
            this.parkingPlaces_subMenu.SuspendLayout();
            this.main_backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sideMenu.Controls.Add(this.reservations_MainButton);
            this.sideMenu.Controls.Add(this.cars_subMenu);
            this.sideMenu.Controls.Add(this.cars_MainButton);
            this.sideMenu.Controls.Add(this.parkingPlaces_subMenu);
            this.sideMenu.Controls.Add(this.parkingPlaces_MainButton);
            this.sideMenu.Controls.Add(this.header);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 0);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(212, 515);
            this.sideMenu.TabIndex = 11;
            // 
            // reservations_MainButton
            // 
            this.reservations_MainButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reservations_MainButton.FlatAppearance.BorderSize = 0;
            this.reservations_MainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservations_MainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reservations_MainButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservations_MainButton.Location = new System.Drawing.Point(0, 348);
            this.reservations_MainButton.Name = "reservations_MainButton";
            this.reservations_MainButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.reservations_MainButton.Size = new System.Drawing.Size(212, 40);
            this.reservations_MainButton.TabIndex = 5;
            this.reservations_MainButton.Text = "Reservations";
            this.reservations_MainButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reservations_MainButton.UseVisualStyleBackColor = true;
            this.reservations_MainButton.Click += new System.EventHandler(this.Reservations_MainButton_Click);
            // 
            // cars_subMenu
            // 
            this.cars_subMenu.BackColor = System.Drawing.Color.Teal;
            this.cars_subMenu.Controls.Add(this.cars_subButton2);
            this.cars_subMenu.Controls.Add(this.cars_subButton);
            this.cars_subMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.cars_subMenu.Location = new System.Drawing.Point(0, 264);
            this.cars_subMenu.Name = "cars_subMenu";
            this.cars_subMenu.Size = new System.Drawing.Size(212, 84);
            this.cars_subMenu.TabIndex = 4;
            // 
            // cars_subButton2
            // 
            this.cars_subButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.cars_subButton2.FlatAppearance.BorderSize = 0;
            this.cars_subButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cars_subButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cars_subButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cars_subButton2.Location = new System.Drawing.Point(0, 40);
            this.cars_subButton2.Name = "cars_subButton2";
            this.cars_subButton2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.cars_subButton2.Size = new System.Drawing.Size(212, 41);
            this.cars_subButton2.TabIndex = 4;
            this.cars_subButton2.Text = "Statistics";
            this.cars_subButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cars_subButton2.UseVisualStyleBackColor = true;
            this.cars_subButton2.Click += new System.EventHandler(this.Cars_subButton2_Click);
            // 
            // cars_subButton
            // 
            this.cars_subButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cars_subButton.FlatAppearance.BorderSize = 0;
            this.cars_subButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cars_subButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cars_subButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cars_subButton.Location = new System.Drawing.Point(0, 0);
            this.cars_subButton.Name = "cars_subButton";
            this.cars_subButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.cars_subButton.Size = new System.Drawing.Size(212, 40);
            this.cars_subButton.TabIndex = 3;
            this.cars_subButton.Text = "Cars";
            this.cars_subButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cars_subButton.UseVisualStyleBackColor = true;
            this.cars_subButton.Click += new System.EventHandler(this.Cars_subButton_Click);
            // 
            // cars_MainButton
            // 
            this.cars_MainButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cars_MainButton.FlatAppearance.BorderSize = 0;
            this.cars_MainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cars_MainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cars_MainButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cars_MainButton.Location = new System.Drawing.Point(0, 224);
            this.cars_MainButton.Name = "cars_MainButton";
            this.cars_MainButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cars_MainButton.Size = new System.Drawing.Size(212, 40);
            this.cars_MainButton.TabIndex = 3;
            this.cars_MainButton.Text = "Cars";
            this.cars_MainButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cars_MainButton.UseVisualStyleBackColor = true;
            this.cars_MainButton.Click += new System.EventHandler(this.Cars_MainButton_Click);
            // 
            // parkingPlaces_subMenu
            // 
            this.parkingPlaces_subMenu.BackColor = System.Drawing.Color.Teal;
            this.parkingPlaces_subMenu.Controls.Add(this.parkingPlaces_subButton2);
            this.parkingPlaces_subMenu.Controls.Add(this.parkingPlaces_subButton);
            this.parkingPlaces_subMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.parkingPlaces_subMenu.Location = new System.Drawing.Point(0, 140);
            this.parkingPlaces_subMenu.Name = "parkingPlaces_subMenu";
            this.parkingPlaces_subMenu.Size = new System.Drawing.Size(212, 84);
            this.parkingPlaces_subMenu.TabIndex = 2;
            // 
            // parkingPlaces_subButton2
            // 
            this.parkingPlaces_subButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.parkingPlaces_subButton2.FlatAppearance.BorderSize = 0;
            this.parkingPlaces_subButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingPlaces_subButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parkingPlaces_subButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.parkingPlaces_subButton2.Location = new System.Drawing.Point(0, 40);
            this.parkingPlaces_subButton2.Name = "parkingPlaces_subButton2";
            this.parkingPlaces_subButton2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.parkingPlaces_subButton2.Size = new System.Drawing.Size(212, 41);
            this.parkingPlaces_subButton2.TabIndex = 4;
            this.parkingPlaces_subButton2.Text = "Sectors";
            this.parkingPlaces_subButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parkingPlaces_subButton2.UseVisualStyleBackColor = true;
            this.parkingPlaces_subButton2.Click += new System.EventHandler(this.ParkingPlaces_subButton2_Click);
            // 
            // parkingPlaces_subButton
            // 
            this.parkingPlaces_subButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.parkingPlaces_subButton.FlatAppearance.BorderSize = 0;
            this.parkingPlaces_subButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingPlaces_subButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parkingPlaces_subButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.parkingPlaces_subButton.Location = new System.Drawing.Point(0, 0);
            this.parkingPlaces_subButton.Name = "parkingPlaces_subButton";
            this.parkingPlaces_subButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.parkingPlaces_subButton.Size = new System.Drawing.Size(212, 40);
            this.parkingPlaces_subButton.TabIndex = 3;
            this.parkingPlaces_subButton.Text = "Parking places";
            this.parkingPlaces_subButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parkingPlaces_subButton.UseVisualStyleBackColor = true;
            this.parkingPlaces_subButton.Click += new System.EventHandler(this.ParkingPlaces_subButton_Click);
            // 
            // parkingPlaces_MainButton
            // 
            this.parkingPlaces_MainButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.parkingPlaces_MainButton.FlatAppearance.BorderSize = 0;
            this.parkingPlaces_MainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingPlaces_MainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parkingPlaces_MainButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.parkingPlaces_MainButton.Location = new System.Drawing.Point(0, 100);
            this.parkingPlaces_MainButton.Name = "parkingPlaces_MainButton";
            this.parkingPlaces_MainButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.parkingPlaces_MainButton.Size = new System.Drawing.Size(212, 40);
            this.parkingPlaces_MainButton.TabIndex = 1;
            this.parkingPlaces_MainButton.Text = "Parking places";
            this.parkingPlaces_MainButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parkingPlaces_MainButton.UseVisualStyleBackColor = true;
            this.parkingPlaces_MainButton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(212, 100);
            this.header.TabIndex = 0;
            // 
            // main_backgroundPanel
            // 
            this.main_backgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.main_backgroundPanel.Controls.Add(this.bottom_panel);
            this.main_backgroundPanel.Controls.Add(this.pictureBox1);
            this.main_backgroundPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.main_backgroundPanel.Location = new System.Drawing.Point(209, 0);
            this.main_backgroundPanel.Name = "main_backgroundPanel";
            this.main_backgroundPanel.Size = new System.Drawing.Size(1221, 515);
            this.main_backgroundPanel.TabIndex = 12;
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(0, 428);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(1221, 87);
            this.bottom_panel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(532, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 179);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(1430, 515);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.main_backgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideMenu.ResumeLayout(false);
            this.cars_subMenu.ResumeLayout(false);
            this.parkingPlaces_subMenu.ResumeLayout(false);
            this.main_backgroundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.Panel parkingPlaces_subMenu;
        private System.Windows.Forms.Button parkingPlaces_MainButton;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button parkingPlaces_subButton;
        private System.Windows.Forms.Button parkingPlaces_subButton2;
        private System.Windows.Forms.Button cars_MainButton;
        private System.Windows.Forms.Panel cars_subMenu;
        private System.Windows.Forms.Button cars_subButton2;
        private System.Windows.Forms.Button cars_subButton;
        private System.Windows.Forms.Button reservations_MainButton;
        private System.Windows.Forms.Panel main_backgroundPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel bottom_panel;
    }
}


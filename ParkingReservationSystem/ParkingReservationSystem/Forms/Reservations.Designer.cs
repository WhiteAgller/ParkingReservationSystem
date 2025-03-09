namespace ParkingReservationSystem
{
    partial class ReservationsForm
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
            this.reservations_reset_button = new System.Windows.Forms.Button();
            this.reservations_delete_button = new System.Windows.Forms.Button();
            this.reservations_desciprtion_label = new System.Windows.Forms.Label();
            this.reservations_textBox = new System.Windows.Forms.Label();
            this.reservations_description_textBox = new System.Windows.Forms.TextBox();
            this.reservations_Grid = new System.Windows.Forms.DataGridView();
            this.reservations_header_label = new System.Windows.Forms.Label();
            this.reservations_closeButton = new FontAwesome.Sharp.IconButton();
            this.reservations_top_panel = new System.Windows.Forms.Panel();
            this.reservations_update_button = new System.Windows.Forms.Button();
            this.reservations__insert_button = new System.Windows.Forms.Button();
            this.reservations_background_panel = new System.Windows.Forms.Panel();
            this.reservations_to_dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.reservations_from_dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.reservations_parkingPlace_comboBox = new System.Windows.Forms.ComboBox();
            this.reservations__VIN_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservations_Grid)).BeginInit();
            this.reservations_top_panel.SuspendLayout();
            this.reservations_background_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reservations_reset_button
            // 
            this.reservations_reset_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.reservations_reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservations_reset_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservations_reset_button.Location = new System.Drawing.Point(218, 325);
            this.reservations_reset_button.Name = "reservations_reset_button";
            this.reservations_reset_button.Size = new System.Drawing.Size(88, 32);
            this.reservations_reset_button.TabIndex = 20;
            this.reservations_reset_button.Text = "Reset";
            this.reservations_reset_button.UseVisualStyleBackColor = false;
            this.reservations_reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // reservations_delete_button
            // 
            this.reservations_delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.reservations_delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservations_delete_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservations_delete_button.Location = new System.Drawing.Point(114, 325);
            this.reservations_delete_button.Name = "reservations_delete_button";
            this.reservations_delete_button.Size = new System.Drawing.Size(88, 32);
            this.reservations_delete_button.TabIndex = 19;
            this.reservations_delete_button.Text = "Delete";
            this.reservations_delete_button.UseVisualStyleBackColor = false;
            this.reservations_delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // reservations_desciprtion_label
            // 
            this.reservations_desciprtion_label.AutoSize = true;
            this.reservations_desciprtion_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.reservations_desciprtion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reservations_desciprtion_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservations_desciprtion_label.Location = new System.Drawing.Point(15, 139);
            this.reservations_desciprtion_label.Name = "reservations_desciprtion_label";
            this.reservations_desciprtion_label.Size = new System.Drawing.Size(78, 16);
            this.reservations_desciprtion_label.TabIndex = 16;
            this.reservations_desciprtion_label.Text = "Description:";
            // 
            // reservations_textBox
            // 
            this.reservations_textBox.AutoSize = true;
            this.reservations_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.reservations_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reservations_textBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservations_textBox.Location = new System.Drawing.Point(15, 16);
            this.reservations_textBox.Name = "reservations_textBox";
            this.reservations_textBox.Size = new System.Drawing.Size(63, 16);
            this.reservations_textBox.TabIndex = 14;
            this.reservations_textBox.Text = "Cars VIN:";
            // 
            // reservations_description_textBox
            // 
            this.reservations_description_textBox.Location = new System.Drawing.Point(114, 139);
            this.reservations_description_textBox.Multiline = true;
            this.reservations_description_textBox.Name = "reservations_description_textBox";
            this.reservations_description_textBox.Size = new System.Drawing.Size(192, 110);
            this.reservations_description_textBox.TabIndex = 13;
            // 
            // reservations_Grid
            // 
            this.reservations_Grid.Location = new System.Drawing.Point(325, 16);
            this.reservations_Grid.Name = "reservations_Grid";
            this.reservations_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservations_Grid.Size = new System.Drawing.Size(874, 341);
            this.reservations_Grid.TabIndex = 21;
            this.reservations_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ParkingSlotsGrid_CellClick);
            this.reservations_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ParkingSlotsGrid_CellContentClick);
            // 
            // reservations_header_label
            // 
            this.reservations_header_label.AutoSize = true;
            this.reservations_header_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.reservations_header_label.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reservations_header_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservations_header_label.Location = new System.Drawing.Point(12, 12);
            this.reservations_header_label.Name = "reservations_header_label";
            this.reservations_header_label.Size = new System.Drawing.Size(166, 33);
            this.reservations_header_label.TabIndex = 11;
            this.reservations_header_label.Text = "Reservations";
            // 
            // reservations_closeButton
            // 
            this.reservations_closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.reservations_closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservations_closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.reservations_closeButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.reservations_closeButton.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservations_closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reservations_closeButton.IconSize = 24;
            this.reservations_closeButton.Location = new System.Drawing.Point(1158, 12);
            this.reservations_closeButton.Name = "reservations_closeButton";
            this.reservations_closeButton.Size = new System.Drawing.Size(41, 33);
            this.reservations_closeButton.TabIndex = 22;
            this.reservations_closeButton.UseVisualStyleBackColor = false;
            this.reservations_closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // reservations_top_panel
            // 
            this.reservations_top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.reservations_top_panel.Controls.Add(this.reservations_closeButton);
            this.reservations_top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reservations_top_panel.Location = new System.Drawing.Point(0, 0);
            this.reservations_top_panel.Name = "reservations_top_panel";
            this.reservations_top_panel.Size = new System.Drawing.Size(1211, 60);
            this.reservations_top_panel.TabIndex = 23;
            // 
            // reservations_update_button
            // 
            this.reservations_update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.reservations_update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservations_update_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservations_update_button.Location = new System.Drawing.Point(218, 278);
            this.reservations_update_button.Name = "reservations_update_button";
            this.reservations_update_button.Size = new System.Drawing.Size(88, 32);
            this.reservations_update_button.TabIndex = 18;
            this.reservations_update_button.Text = "Update";
            this.reservations_update_button.UseVisualStyleBackColor = false;
            this.reservations_update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // reservations__insert_button
            // 
            this.reservations__insert_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.reservations__insert_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservations__insert_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservations__insert_button.Location = new System.Drawing.Point(114, 278);
            this.reservations__insert_button.Name = "reservations__insert_button";
            this.reservations__insert_button.Size = new System.Drawing.Size(88, 32);
            this.reservations__insert_button.TabIndex = 17;
            this.reservations__insert_button.Text = "Insert";
            this.reservations__insert_button.UseVisualStyleBackColor = false;
            this.reservations__insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // reservations_background_panel
            // 
            this.reservations_background_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.reservations_background_panel.Controls.Add(this.reservations_to_dateTimePicker1);
            this.reservations_background_panel.Controls.Add(this.reservations_from_dateTimePicker1);
            this.reservations_background_panel.Controls.Add(this.reservations_parkingPlace_comboBox);
            this.reservations_background_panel.Controls.Add(this.reservations__VIN_comboBox);
            this.reservations_background_panel.Controls.Add(this.reservations_textBox);
            this.reservations_background_panel.Controls.Add(this.label3);
            this.reservations_background_panel.Controls.Add(this.label2);
            this.reservations_background_panel.Controls.Add(this.reservations_Grid);
            this.reservations_background_panel.Controls.Add(this.label1);
            this.reservations_background_panel.Controls.Add(this.reservations_desciprtion_label);
            this.reservations_background_panel.Controls.Add(this.reservations_delete_button);
            this.reservations_background_panel.Controls.Add(this.reservations_description_textBox);
            this.reservations_background_panel.Controls.Add(this.reservations_reset_button);
            this.reservations_background_panel.Controls.Add(this.reservations__insert_button);
            this.reservations_background_panel.Controls.Add(this.reservations_update_button);
            this.reservations_background_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reservations_background_panel.Location = new System.Drawing.Point(0, 60);
            this.reservations_background_panel.Name = "reservations_background_panel";
            this.reservations_background_panel.Size = new System.Drawing.Size(1211, 371);
            this.reservations_background_panel.TabIndex = 24;
            // 
            // reservations_to_dateTimePicker1
            // 
            this.reservations_to_dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:MM";
            this.reservations_to_dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reservations_to_dateTimePicker1.Location = new System.Drawing.Point(114, 108);
            this.reservations_to_dateTimePicker1.Name = "reservations_to_dateTimePicker1";
            this.reservations_to_dateTimePicker1.Size = new System.Drawing.Size(192, 20);
            this.reservations_to_dateTimePicker1.TabIndex = 34;
            // 
            // reservations_from_dateTimePicker1
            // 
            this.reservations_from_dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:MM";
            this.reservations_from_dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reservations_from_dateTimePicker1.Location = new System.Drawing.Point(114, 78);
            this.reservations_from_dateTimePicker1.Name = "reservations_from_dateTimePicker1";
            this.reservations_from_dateTimePicker1.Size = new System.Drawing.Size(192, 20);
            this.reservations_from_dateTimePicker1.TabIndex = 33;
            // 
            // reservations_parkingPlace_comboBox
            // 
            this.reservations_parkingPlace_comboBox.FormattingEnabled = true;
            this.reservations_parkingPlace_comboBox.Location = new System.Drawing.Point(114, 48);
            this.reservations_parkingPlace_comboBox.Name = "reservations_parkingPlace_comboBox";
            this.reservations_parkingPlace_comboBox.Size = new System.Drawing.Size(192, 21);
            this.reservations_parkingPlace_comboBox.TabIndex = 32;
            // 
            // reservations__VIN_comboBox
            // 
            this.reservations__VIN_comboBox.FormattingEnabled = true;
            this.reservations__VIN_comboBox.Location = new System.Drawing.Point(114, 16);
            this.reservations__VIN_comboBox.Name = "reservations__VIN_comboBox";
            this.reservations__VIN_comboBox.Size = new System.Drawing.Size(192, 21);
            this.reservations__VIN_comboBox.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Date To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Date From:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Parking Place:";
            // 
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 430);
            this.Controls.Add(this.reservations_header_label);
            this.Controls.Add(this.reservations_background_panel);
            this.Controls.Add(this.reservations_top_panel);
            this.Name = "ReservationsForm";
            this.Text = "sectors";
            this.Load += new System.EventHandler(this.Reservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservations_Grid)).EndInit();
            this.reservations_top_panel.ResumeLayout(false);
            this.reservations_background_panel.ResumeLayout(false);
            this.reservations_background_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reservations_reset_button;
        private System.Windows.Forms.Button reservations_delete_button;
        private System.Windows.Forms.Label reservations_desciprtion_label;
        private System.Windows.Forms.Label reservations_textBox;
        private System.Windows.Forms.TextBox reservations_description_textBox;
        private System.Windows.Forms.DataGridView reservations_Grid;
        private System.Windows.Forms.Label reservations_header_label;
        private FontAwesome.Sharp.IconButton reservations_closeButton;
        private System.Windows.Forms.Panel reservations_top_panel;
        private System.Windows.Forms.Button reservations_update_button;
        private System.Windows.Forms.Button reservations__insert_button;
        private System.Windows.Forms.Panel reservations_background_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker reservations_to_dateTimePicker1;
        private System.Windows.Forms.DateTimePicker reservations_from_dateTimePicker1;
        private System.Windows.Forms.ComboBox reservations_parkingPlace_comboBox;
        private System.Windows.Forms.ComboBox reservations__VIN_comboBox;
    }
}
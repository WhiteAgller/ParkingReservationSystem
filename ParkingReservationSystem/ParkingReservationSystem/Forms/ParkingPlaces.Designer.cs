namespace ParkingReservationSystem
{
    partial class ParkingPlacesForm
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
            this.parkingPlaces_reset_button = new System.Windows.Forms.Button();
            this.parkingPlaces_delete_button = new System.Windows.Forms.Button();
            this.parkingPlaces_desciprtion_label = new System.Windows.Forms.Label();
            this.parkingPlaces__comboBox = new System.Windows.Forms.ComboBox();
            this.parkingPlaces_textBox = new System.Windows.Forms.Label();
            this.parkingPlaces_description_textBox = new System.Windows.Forms.TextBox();
            this.parkingPlaces_Grid = new System.Windows.Forms.DataGridView();
            this.parkingPlaces_header_label = new System.Windows.Forms.Label();
            this.parkingPlaces_closeButton = new FontAwesome.Sharp.IconButton();
            this.parkingPlaces_top_panel = new System.Windows.Forms.Panel();
            this.parkingPlaces_update_button = new System.Windows.Forms.Button();
            this.parkingPlaces__insert_button = new System.Windows.Forms.Button();
            this.parkingPlaces_background_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.parkingPlaces_Grid)).BeginInit();
            this.parkingPlaces_top_panel.SuspendLayout();
            this.parkingPlaces_background_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // parkingPlaces_reset_button
            // 
            this.parkingPlaces_reset_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.parkingPlaces_reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingPlaces_reset_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.parkingPlaces_reset_button.Location = new System.Drawing.Point(218, 325);
            this.parkingPlaces_reset_button.Name = "parkingPlaces_reset_button";
            this.parkingPlaces_reset_button.Size = new System.Drawing.Size(88, 32);
            this.parkingPlaces_reset_button.TabIndex = 20;
            this.parkingPlaces_reset_button.Text = "Reset";
            this.parkingPlaces_reset_button.UseVisualStyleBackColor = false;
            this.parkingPlaces_reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // parkingPlaces_delete_button
            // 
            this.parkingPlaces_delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.parkingPlaces_delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingPlaces_delete_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.parkingPlaces_delete_button.Location = new System.Drawing.Point(114, 325);
            this.parkingPlaces_delete_button.Name = "parkingPlaces_delete_button";
            this.parkingPlaces_delete_button.Size = new System.Drawing.Size(88, 32);
            this.parkingPlaces_delete_button.TabIndex = 19;
            this.parkingPlaces_delete_button.Text = "Delete";
            this.parkingPlaces_delete_button.UseVisualStyleBackColor = false;
            this.parkingPlaces_delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // parkingPlaces_desciprtion_label
            // 
            this.parkingPlaces_desciprtion_label.AutoSize = true;
            this.parkingPlaces_desciprtion_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.parkingPlaces_desciprtion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parkingPlaces_desciprtion_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.parkingPlaces_desciprtion_label.Location = new System.Drawing.Point(15, 117);
            this.parkingPlaces_desciprtion_label.Name = "parkingPlaces_desciprtion_label";
            this.parkingPlaces_desciprtion_label.Size = new System.Drawing.Size(78, 16);
            this.parkingPlaces_desciprtion_label.TabIndex = 16;
            this.parkingPlaces_desciprtion_label.Text = "Description:";
            // 
            // parkingPlaces__comboBox
            // 
            this.parkingPlaces__comboBox.FormattingEnabled = true;
            this.parkingPlaces__comboBox.Location = new System.Drawing.Point(114, 76);
            this.parkingPlaces__comboBox.Name = "parkingPlaces__comboBox";
            this.parkingPlaces__comboBox.Size = new System.Drawing.Size(192, 21);
            this.parkingPlaces__comboBox.TabIndex = 15;
            // 
            // parkingPlaces_textBox
            // 
            this.parkingPlaces_textBox.AutoSize = true;
            this.parkingPlaces_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.parkingPlaces_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parkingPlaces_textBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.parkingPlaces_textBox.Location = new System.Drawing.Point(15, 76);
            this.parkingPlaces_textBox.Name = "parkingPlaces_textBox";
            this.parkingPlaces_textBox.Size = new System.Drawing.Size(49, 16);
            this.parkingPlaces_textBox.TabIndex = 14;
            this.parkingPlaces_textBox.Text = "Sector:";
            // 
            // parkingPlaces_description_textBox
            // 
            this.parkingPlaces_description_textBox.Location = new System.Drawing.Point(114, 117);
            this.parkingPlaces_description_textBox.Multiline = true;
            this.parkingPlaces_description_textBox.Name = "parkingPlaces_description_textBox";
            this.parkingPlaces_description_textBox.Size = new System.Drawing.Size(192, 110);
            this.parkingPlaces_description_textBox.TabIndex = 13;
            // 
            // parkingPlaces_Grid
            // 
            this.parkingPlaces_Grid.Location = new System.Drawing.Point(325, 76);
            this.parkingPlaces_Grid.Name = "parkingPlaces_Grid";
            this.parkingPlaces_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.parkingPlaces_Grid.Size = new System.Drawing.Size(375, 341);
            this.parkingPlaces_Grid.TabIndex = 21;
            this.parkingPlaces_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ParkingSlotsGrid_CellClick);
            // 
            // parkingPlaces_header_label
            // 
            this.parkingPlaces_header_label.AutoSize = true;
            this.parkingPlaces_header_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.parkingPlaces_header_label.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parkingPlaces_header_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.parkingPlaces_header_label.Location = new System.Drawing.Point(12, 12);
            this.parkingPlaces_header_label.Name = "parkingPlaces_header_label";
            this.parkingPlaces_header_label.Size = new System.Drawing.Size(184, 33);
            this.parkingPlaces_header_label.TabIndex = 11;
            this.parkingPlaces_header_label.Text = "Parking places";
            // 
            // parkingPlaces_closeButton
            // 
            this.parkingPlaces_closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.parkingPlaces_closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingPlaces_closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.parkingPlaces_closeButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.parkingPlaces_closeButton.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.parkingPlaces_closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.parkingPlaces_closeButton.IconSize = 24;
            this.parkingPlaces_closeButton.Location = new System.Drawing.Point(659, 12);
            this.parkingPlaces_closeButton.Name = "parkingPlaces_closeButton";
            this.parkingPlaces_closeButton.Size = new System.Drawing.Size(41, 33);
            this.parkingPlaces_closeButton.TabIndex = 22;
            this.parkingPlaces_closeButton.UseVisualStyleBackColor = false;
            this.parkingPlaces_closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // parkingPlaces_top_panel
            // 
            this.parkingPlaces_top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.parkingPlaces_top_panel.Controls.Add(this.parkingPlaces_closeButton);
            this.parkingPlaces_top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.parkingPlaces_top_panel.Location = new System.Drawing.Point(0, 0);
            this.parkingPlaces_top_panel.Name = "parkingPlaces_top_panel";
            this.parkingPlaces_top_panel.Size = new System.Drawing.Size(712, 60);
            this.parkingPlaces_top_panel.TabIndex = 23;
            // 
            // parkingPlaces_update_button
            // 
            this.parkingPlaces_update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.parkingPlaces_update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingPlaces_update_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.parkingPlaces_update_button.Location = new System.Drawing.Point(218, 278);
            this.parkingPlaces_update_button.Name = "parkingPlaces_update_button";
            this.parkingPlaces_update_button.Size = new System.Drawing.Size(88, 32);
            this.parkingPlaces_update_button.TabIndex = 18;
            this.parkingPlaces_update_button.Text = "Update";
            this.parkingPlaces_update_button.UseVisualStyleBackColor = false;
            this.parkingPlaces_update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // parkingPlaces__insert_button
            // 
            this.parkingPlaces__insert_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.parkingPlaces__insert_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingPlaces__insert_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.parkingPlaces__insert_button.Location = new System.Drawing.Point(114, 278);
            this.parkingPlaces__insert_button.Name = "parkingPlaces__insert_button";
            this.parkingPlaces__insert_button.Size = new System.Drawing.Size(88, 32);
            this.parkingPlaces__insert_button.TabIndex = 17;
            this.parkingPlaces__insert_button.Text = "Insert";
            this.parkingPlaces__insert_button.UseVisualStyleBackColor = false;
            this.parkingPlaces__insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // parkingPlaces_background_panel
            // 
            this.parkingPlaces_background_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.parkingPlaces_background_panel.Controls.Add(this.parkingPlaces_delete_button);
            this.parkingPlaces_background_panel.Controls.Add(this.parkingPlaces_reset_button);
            this.parkingPlaces_background_panel.Controls.Add(this.parkingPlaces__insert_button);
            this.parkingPlaces_background_panel.Controls.Add(this.parkingPlaces_update_button);
            this.parkingPlaces_background_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.parkingPlaces_background_panel.Location = new System.Drawing.Point(0, 60);
            this.parkingPlaces_background_panel.Name = "parkingPlaces_background_panel";
            this.parkingPlaces_background_panel.Size = new System.Drawing.Size(712, 371);
            this.parkingPlaces_background_panel.TabIndex = 24;
            // 
            // ParkingPlacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 430);
            this.Controls.Add(this.parkingPlaces_desciprtion_label);
            this.Controls.Add(this.parkingPlaces__comboBox);
            this.Controls.Add(this.parkingPlaces_textBox);
            this.Controls.Add(this.parkingPlaces_description_textBox);
            this.Controls.Add(this.parkingPlaces_Grid);
            this.Controls.Add(this.parkingPlaces_header_label);
            this.Controls.Add(this.parkingPlaces_background_panel);
            this.Controls.Add(this.parkingPlaces_top_panel);
            this.Name = "ParkingPlacesForm";
            this.Text = "ParkingPlaces";
            this.Load += new System.EventHandler(this.ParkingPlaces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parkingPlaces_Grid)).EndInit();
            this.parkingPlaces_top_panel.ResumeLayout(false);
            this.parkingPlaces_background_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button parkingPlaces_reset_button;
        private System.Windows.Forms.Button parkingPlaces_delete_button;
        private System.Windows.Forms.Label parkingPlaces_desciprtion_label;
        private System.Windows.Forms.ComboBox parkingPlaces__comboBox;
        private System.Windows.Forms.Label parkingPlaces_textBox;
        private System.Windows.Forms.TextBox parkingPlaces_description_textBox;
        private System.Windows.Forms.DataGridView parkingPlaces_Grid;
        private System.Windows.Forms.Label parkingPlaces_header_label;
        private FontAwesome.Sharp.IconButton parkingPlaces_closeButton;
        private System.Windows.Forms.Panel parkingPlaces_top_panel;
        private System.Windows.Forms.Button parkingPlaces_update_button;
        private System.Windows.Forms.Button parkingPlaces__insert_button;
        private System.Windows.Forms.Panel parkingPlaces_background_panel;
    }
}
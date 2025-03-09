namespace ParkingReservationSystem
{
    partial class SectorsForm
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
            this.sectors_reset_button = new System.Windows.Forms.Button();
            this.sectors_delete_button = new System.Windows.Forms.Button();
            this.sectors_desciprtion_label = new System.Windows.Forms.Label();
            this.sectors_textBox = new System.Windows.Forms.Label();
            this.sectors_description_textBox = new System.Windows.Forms.TextBox();
            this.sectors_Grid = new System.Windows.Forms.DataGridView();
            this.sectors_header_label = new System.Windows.Forms.Label();
            this.sectors_closeButton = new FontAwesome.Sharp.IconButton();
            this.sectors_top_panel = new System.Windows.Forms.Panel();
            this.sectors_update_button = new System.Windows.Forms.Button();
            this.sectors__insert_button = new System.Windows.Forms.Button();
            this.sectors_background_panel = new System.Windows.Forms.Panel();
            this.sectors__textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sectors_Grid)).BeginInit();
            this.sectors_top_panel.SuspendLayout();
            this.sectors_background_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sectors_reset_button
            // 
            this.sectors_reset_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sectors_reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sectors_reset_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sectors_reset_button.Location = new System.Drawing.Point(218, 325);
            this.sectors_reset_button.Name = "sectors_reset_button";
            this.sectors_reset_button.Size = new System.Drawing.Size(88, 32);
            this.sectors_reset_button.TabIndex = 20;
            this.sectors_reset_button.Text = "Reset";
            this.sectors_reset_button.UseVisualStyleBackColor = false;
            this.sectors_reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // sectors_delete_button
            // 
            this.sectors_delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sectors_delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sectors_delete_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sectors_delete_button.Location = new System.Drawing.Point(114, 325);
            this.sectors_delete_button.Name = "sectors_delete_button";
            this.sectors_delete_button.Size = new System.Drawing.Size(88, 32);
            this.sectors_delete_button.TabIndex = 19;
            this.sectors_delete_button.Text = "Delete";
            this.sectors_delete_button.UseVisualStyleBackColor = false;
            this.sectors_delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // sectors_desciprtion_label
            // 
            this.sectors_desciprtion_label.AutoSize = true;
            this.sectors_desciprtion_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sectors_desciprtion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sectors_desciprtion_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sectors_desciprtion_label.Location = new System.Drawing.Point(15, 117);
            this.sectors_desciprtion_label.Name = "sectors_desciprtion_label";
            this.sectors_desciprtion_label.Size = new System.Drawing.Size(78, 16);
            this.sectors_desciprtion_label.TabIndex = 16;
            this.sectors_desciprtion_label.Text = "Description:";
            // 
            // sectors_textBox
            // 
            this.sectors_textBox.AutoSize = true;
            this.sectors_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sectors_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sectors_textBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sectors_textBox.Location = new System.Drawing.Point(15, 76);
            this.sectors_textBox.Name = "sectors_textBox";
            this.sectors_textBox.Size = new System.Drawing.Size(47, 16);
            this.sectors_textBox.TabIndex = 14;
            this.sectors_textBox.Text = "Name:";
            // 
            // sectors_description_textBox
            // 
            this.sectors_description_textBox.Location = new System.Drawing.Point(114, 117);
            this.sectors_description_textBox.Multiline = true;
            this.sectors_description_textBox.Name = "sectors_description_textBox";
            this.sectors_description_textBox.Size = new System.Drawing.Size(192, 110);
            this.sectors_description_textBox.TabIndex = 13;
            // 
            // sectors_Grid
            // 
            this.sectors_Grid.Location = new System.Drawing.Point(325, 76);
            this.sectors_Grid.Name = "sectors_Grid";
            this.sectors_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sectors_Grid.Size = new System.Drawing.Size(375, 341);
            this.sectors_Grid.TabIndex = 21;
            this.sectors_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ParkingSlotsGrid_CellClick);
            this.sectors_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ParkingSlotsGrid_CellContentClick);
            // 
            // sectors_header_label
            // 
            this.sectors_header_label.AutoSize = true;
            this.sectors_header_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sectors_header_label.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sectors_header_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sectors_header_label.Location = new System.Drawing.Point(12, 12);
            this.sectors_header_label.Name = "sectors_header_label";
            this.sectors_header_label.Size = new System.Drawing.Size(102, 33);
            this.sectors_header_label.TabIndex = 11;
            this.sectors_header_label.Text = "Sectors";
            // 
            // sectors_closeButton
            // 
            this.sectors_closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sectors_closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sectors_closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sectors_closeButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.sectors_closeButton.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sectors_closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sectors_closeButton.IconSize = 24;
            this.sectors_closeButton.Location = new System.Drawing.Point(659, 12);
            this.sectors_closeButton.Name = "sectors_closeButton";
            this.sectors_closeButton.Size = new System.Drawing.Size(41, 33);
            this.sectors_closeButton.TabIndex = 22;
            this.sectors_closeButton.UseVisualStyleBackColor = false;
            this.sectors_closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // sectors_top_panel
            // 
            this.sectors_top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sectors_top_panel.Controls.Add(this.sectors_closeButton);
            this.sectors_top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sectors_top_panel.Location = new System.Drawing.Point(0, 0);
            this.sectors_top_panel.Name = "sectors_top_panel";
            this.sectors_top_panel.Size = new System.Drawing.Size(712, 60);
            this.sectors_top_panel.TabIndex = 23;
            // 
            // sectors_update_button
            // 
            this.sectors_update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sectors_update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sectors_update_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sectors_update_button.Location = new System.Drawing.Point(218, 278);
            this.sectors_update_button.Name = "sectors_update_button";
            this.sectors_update_button.Size = new System.Drawing.Size(88, 32);
            this.sectors_update_button.TabIndex = 18;
            this.sectors_update_button.Text = "Update";
            this.sectors_update_button.UseVisualStyleBackColor = false;
            this.sectors_update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // sectors__insert_button
            // 
            this.sectors__insert_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sectors__insert_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sectors__insert_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sectors__insert_button.Location = new System.Drawing.Point(114, 278);
            this.sectors__insert_button.Name = "sectors__insert_button";
            this.sectors__insert_button.Size = new System.Drawing.Size(88, 32);
            this.sectors__insert_button.TabIndex = 17;
            this.sectors__insert_button.Text = "Insert";
            this.sectors__insert_button.UseVisualStyleBackColor = false;
            this.sectors__insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // sectors_background_panel
            // 
            this.sectors_background_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sectors_background_panel.Controls.Add(this.sectors__textBox);
            this.sectors_background_panel.Controls.Add(this.sectors_delete_button);
            this.sectors_background_panel.Controls.Add(this.sectors_reset_button);
            this.sectors_background_panel.Controls.Add(this.sectors__insert_button);
            this.sectors_background_panel.Controls.Add(this.sectors_update_button);
            this.sectors_background_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sectors_background_panel.Location = new System.Drawing.Point(0, 60);
            this.sectors_background_panel.Name = "sectors_background_panel";
            this.sectors_background_panel.Size = new System.Drawing.Size(712, 371);
            this.sectors_background_panel.TabIndex = 24;
            // 
            // sectors__textBox
            // 
            this.sectors__textBox.Location = new System.Drawing.Point(114, 16);
            this.sectors__textBox.Name = "sectors__textBox";
            this.sectors__textBox.Size = new System.Drawing.Size(192, 20);
            this.sectors__textBox.TabIndex = 21;
            // 
            // sectors_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 430);
            this.Controls.Add(this.sectors_desciprtion_label);
            this.Controls.Add(this.sectors_textBox);
            this.Controls.Add(this.sectors_description_textBox);
            this.Controls.Add(this.sectors_Grid);
            this.Controls.Add(this.sectors_header_label);
            this.Controls.Add(this.sectors_background_panel);
            this.Controls.Add(this.sectors_top_panel);
            this.Name = "SectorsForm";
            this.Text = "sectors";
            this.Load += new System.EventHandler(this.Sectors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sectors_Grid)).EndInit();
            this.sectors_top_panel.ResumeLayout(false);
            this.sectors_background_panel.ResumeLayout(false);
            this.sectors_background_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sectors_reset_button;
        private System.Windows.Forms.Button sectors_delete_button;
        private System.Windows.Forms.Label sectors_desciprtion_label;
        private System.Windows.Forms.Label sectors_textBox;
        private System.Windows.Forms.TextBox sectors_description_textBox;
        private System.Windows.Forms.DataGridView sectors_Grid;
        private System.Windows.Forms.Label sectors_header_label;
        private FontAwesome.Sharp.IconButton sectors_closeButton;
        private System.Windows.Forms.Panel sectors_top_panel;
        private System.Windows.Forms.Button sectors_update_button;
        private System.Windows.Forms.Button sectors__insert_button;
        private System.Windows.Forms.Panel sectors_background_panel;
        private System.Windows.Forms.TextBox sectors__textBox;
    }
}
namespace ParkingReservationSystem
{
    partial class CarsForm
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
            this.cars_reset_button = new System.Windows.Forms.Button();
            this.cars_delete_button = new System.Windows.Forms.Button();
            this.cars_desciprtion_label = new System.Windows.Forms.Label();
            this.cars_textBox = new System.Windows.Forms.Label();
            this.cars_description_textBox = new System.Windows.Forms.TextBox();
            this.cars_Grid = new System.Windows.Forms.DataGridView();
            this.cars_header_label = new System.Windows.Forms.Label();
            this.cars_closeButton = new FontAwesome.Sharp.IconButton();
            this.cars_top_panel = new System.Windows.Forms.Panel();
            this.cars_update_button = new System.Windows.Forms.Button();
            this.cars__insert_button = new System.Windows.Forms.Button();
            this.cars_background_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cars_model_textBox = new System.Windows.Forms.TextBox();
            this.cars_make_textBox = new System.Windows.Forms.TextBox();
            this.cars_year_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cars__textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cars_Grid)).BeginInit();
            this.cars_top_panel.SuspendLayout();
            this.cars_background_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cars_reset_button
            // 
            this.cars_reset_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cars_reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cars_reset_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cars_reset_button.Location = new System.Drawing.Point(218, 325);
            this.cars_reset_button.Name = "cars_reset_button";
            this.cars_reset_button.Size = new System.Drawing.Size(88, 32);
            this.cars_reset_button.TabIndex = 20;
            this.cars_reset_button.Text = "Reset";
            this.cars_reset_button.UseVisualStyleBackColor = false;
            this.cars_reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // cars_delete_button
            // 
            this.cars_delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cars_delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cars_delete_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cars_delete_button.Location = new System.Drawing.Point(114, 325);
            this.cars_delete_button.Name = "cars_delete_button";
            this.cars_delete_button.Size = new System.Drawing.Size(88, 32);
            this.cars_delete_button.TabIndex = 19;
            this.cars_delete_button.Text = "Delete";
            this.cars_delete_button.UseVisualStyleBackColor = false;
            this.cars_delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // cars_desciprtion_label
            // 
            this.cars_desciprtion_label.AutoSize = true;
            this.cars_desciprtion_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cars_desciprtion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cars_desciprtion_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cars_desciprtion_label.Location = new System.Drawing.Point(15, 139);
            this.cars_desciprtion_label.Name = "cars_desciprtion_label";
            this.cars_desciprtion_label.Size = new System.Drawing.Size(78, 16);
            this.cars_desciprtion_label.TabIndex = 16;
            this.cars_desciprtion_label.Text = "Description:";
            // 
            // cars_textBox
            // 
            this.cars_textBox.AutoSize = true;
            this.cars_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cars_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cars_textBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cars_textBox.Location = new System.Drawing.Point(15, 16);
            this.cars_textBox.Name = "cars_textBox";
            this.cars_textBox.Size = new System.Drawing.Size(32, 16);
            this.cars_textBox.TabIndex = 14;
            this.cars_textBox.Text = "VIN:";
            // 
            // cars_description_textBox
            // 
            this.cars_description_textBox.Location = new System.Drawing.Point(114, 139);
            this.cars_description_textBox.Multiline = true;
            this.cars_description_textBox.Name = "cars_description_textBox";
            this.cars_description_textBox.Size = new System.Drawing.Size(192, 110);
            this.cars_description_textBox.TabIndex = 13;
            // 
            // cars_Grid
            // 
            this.cars_Grid.Location = new System.Drawing.Point(325, 16);
            this.cars_Grid.Name = "cars_Grid";
            this.cars_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cars_Grid.Size = new System.Drawing.Size(732, 341);
            this.cars_Grid.TabIndex = 21;
            this.cars_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ParkingSlotsGrid_CellClick);
            // 
            // cars_header_label
            // 
            this.cars_header_label.AutoSize = true;
            this.cars_header_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cars_header_label.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cars_header_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cars_header_label.Location = new System.Drawing.Point(12, 12);
            this.cars_header_label.Name = "cars_header_label";
            this.cars_header_label.Size = new System.Drawing.Size(67, 33);
            this.cars_header_label.TabIndex = 11;
            this.cars_header_label.Text = "Cars";
            // 
            // cars_closeButton
            // 
            this.cars_closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cars_closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cars_closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cars_closeButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.cars_closeButton.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cars_closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cars_closeButton.IconSize = 24;
            this.cars_closeButton.Location = new System.Drawing.Point(1016, 12);
            this.cars_closeButton.Name = "cars_closeButton";
            this.cars_closeButton.Size = new System.Drawing.Size(41, 33);
            this.cars_closeButton.TabIndex = 22;
            this.cars_closeButton.UseVisualStyleBackColor = false;
            this.cars_closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // cars_top_panel
            // 
            this.cars_top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cars_top_panel.Controls.Add(this.cars_closeButton);
            this.cars_top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cars_top_panel.Location = new System.Drawing.Point(0, 0);
            this.cars_top_panel.Name = "cars_top_panel";
            this.cars_top_panel.Size = new System.Drawing.Size(1069, 60);
            this.cars_top_panel.TabIndex = 23;
            // 
            // cars_update_button
            // 
            this.cars_update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cars_update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cars_update_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cars_update_button.Location = new System.Drawing.Point(218, 278);
            this.cars_update_button.Name = "cars_update_button";
            this.cars_update_button.Size = new System.Drawing.Size(88, 32);
            this.cars_update_button.TabIndex = 18;
            this.cars_update_button.Text = "Update";
            this.cars_update_button.UseVisualStyleBackColor = false;
            this.cars_update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // cars__insert_button
            // 
            this.cars__insert_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cars__insert_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cars__insert_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cars__insert_button.Location = new System.Drawing.Point(114, 278);
            this.cars__insert_button.Name = "cars__insert_button";
            this.cars__insert_button.Size = new System.Drawing.Size(88, 32);
            this.cars__insert_button.TabIndex = 17;
            this.cars__insert_button.Text = "Insert";
            this.cars__insert_button.UseVisualStyleBackColor = false;
            this.cars__insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // cars_background_panel
            // 
            this.cars_background_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cars_background_panel.Controls.Add(this.button1);
            this.cars_background_panel.Controls.Add(this.cars_textBox);
            this.cars_background_panel.Controls.Add(this.cars_model_textBox);
            this.cars_background_panel.Controls.Add(this.cars_make_textBox);
            this.cars_background_panel.Controls.Add(this.cars_year_textBox);
            this.cars_background_panel.Controls.Add(this.label3);
            this.cars_background_panel.Controls.Add(this.label2);
            this.cars_background_panel.Controls.Add(this.cars_Grid);
            this.cars_background_panel.Controls.Add(this.label1);
            this.cars_background_panel.Controls.Add(this.cars_desciprtion_label);
            this.cars_background_panel.Controls.Add(this.cars__textBox);
            this.cars_background_panel.Controls.Add(this.cars_delete_button);
            this.cars_background_panel.Controls.Add(this.cars_description_textBox);
            this.cars_background_panel.Controls.Add(this.cars_reset_button);
            this.cars_background_panel.Controls.Add(this.cars__insert_button);
            this.cars_background_panel.Controls.Add(this.cars_update_button);
            this.cars_background_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cars_background_panel.Location = new System.Drawing.Point(0, 60);
            this.cars_background_panel.Name = "cars_background_panel";
            this.cars_background_panel.Size = new System.Drawing.Size(1069, 371);
            this.cars_background_panel.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 31;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cars_model_textBox
            // 
            this.cars_model_textBox.Location = new System.Drawing.Point(114, 108);
            this.cars_model_textBox.Name = "cars_model_textBox";
            this.cars_model_textBox.Size = new System.Drawing.Size(192, 20);
            this.cars_model_textBox.TabIndex = 30;
            // 
            // cars_make_textBox
            // 
            this.cars_make_textBox.Location = new System.Drawing.Point(114, 78);
            this.cars_make_textBox.Name = "cars_make_textBox";
            this.cars_make_textBox.Size = new System.Drawing.Size(192, 20);
            this.cars_make_textBox.TabIndex = 29;
            // 
            // cars_year_textBox
            // 
            this.cars_year_textBox.Location = new System.Drawing.Point(114, 48);
            this.cars_year_textBox.Name = "cars_year_textBox";
            this.cars_year_textBox.Size = new System.Drawing.Size(192, 20);
            this.cars_year_textBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Make:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Year:";
            // 
            // cars__textBox
            // 
            this.cars__textBox.Location = new System.Drawing.Point(114, 16);
            this.cars__textBox.Name = "cars__textBox";
            this.cars__textBox.Size = new System.Drawing.Size(192, 20);
            this.cars__textBox.TabIndex = 21;
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 430);
            this.Controls.Add(this.cars_header_label);
            this.Controls.Add(this.cars_background_panel);
            this.Controls.Add(this.cars_top_panel);
            this.Name = "CarsForm";
            this.Text = "sectors";
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cars_Grid)).EndInit();
            this.cars_top_panel.ResumeLayout(false);
            this.cars_background_panel.ResumeLayout(false);
            this.cars_background_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cars_reset_button;
        private System.Windows.Forms.Button cars_delete_button;
        private System.Windows.Forms.Label cars_desciprtion_label;
        private System.Windows.Forms.Label cars_textBox;
        private System.Windows.Forms.TextBox cars_description_textBox;
        private System.Windows.Forms.DataGridView cars_Grid;
        private System.Windows.Forms.Label cars_header_label;
        private FontAwesome.Sharp.IconButton cars_closeButton;
        private System.Windows.Forms.Panel cars_top_panel;
        private System.Windows.Forms.Button cars_update_button;
        private System.Windows.Forms.Button cars__insert_button;
        private System.Windows.Forms.Panel cars_background_panel;
        private System.Windows.Forms.TextBox cars__textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cars_model_textBox;
        private System.Windows.Forms.TextBox cars_make_textBox;
        private System.Windows.Forms.TextBox cars_year_textBox;
        private System.Windows.Forms.Button button1;
    }
}
using System;

namespace ParkingReservationSystem
{
    partial class StatisticsForm
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
            this.statistics_desciprtion_label = new System.Windows.Forms.Label();
            this.statistics_textBox = new System.Windows.Forms.Label();
            this.statistics_header_label = new System.Windows.Forms.Label();
            this.statistics_closeButton = new FontAwesome.Sharp.IconButton();
            this.statistics_top_panel = new System.Windows.Forms.Panel();
            this.statistics_background_panel = new System.Windows.Forms.Panel();
            this.lateest_reservation_label = new System.Windows.Forms.Label();
            this.statistics_latest_reservation__car_label = new System.Windows.Forms.Label();
            this.statistics_total_reservation_car_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statistics_top_panel.SuspendLayout();
            this.statistics_background_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statistics_desciprtion_label
            // 
            this.statistics_desciprtion_label.AutoSize = true;
            this.statistics_desciprtion_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.statistics_desciprtion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statistics_desciprtion_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statistics_desciprtion_label.Location = new System.Drawing.Point(16, 62);
            this.statistics_desciprtion_label.Name = "statistics_desciprtion_label";
            this.statistics_desciprtion_label.Size = new System.Drawing.Size(64, 16);
            this.statistics_desciprtion_label.TabIndex = 16;
            this.statistics_desciprtion_label.Text = "Cars VIM:";
            // 
            // statistics_textBox
            // 
            this.statistics_textBox.AutoSize = true;
            this.statistics_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.statistics_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statistics_textBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statistics_textBox.Location = new System.Drawing.Point(16, 16);
            this.statistics_textBox.Name = "statistics_textBox";
            this.statistics_textBox.Size = new System.Drawing.Size(124, 16);
            this.statistics_textBox.TabIndex = 14;
            this.statistics_textBox.Text = "Total Reservations:";
            // 
            // statistics_header_label
            // 
            this.statistics_header_label.AutoSize = true;
            this.statistics_header_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.statistics_header_label.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statistics_header_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statistics_header_label.Location = new System.Drawing.Point(12, 12);
            this.statistics_header_label.Name = "statistics_header_label";
            this.statistics_header_label.Size = new System.Drawing.Size(119, 33);
            this.statistics_header_label.TabIndex = 11;
            this.statistics_header_label.Text = "Statistics";
            this.statistics_header_label.Click += new System.EventHandler(this.statistics_header_label_Click);
            // 
            // statistics_closeButton
            // 
            this.statistics_closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.statistics_closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statistics_closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.statistics_closeButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.statistics_closeButton.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statistics_closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statistics_closeButton.IconSize = 24;
            this.statistics_closeButton.Location = new System.Drawing.Point(659, 12);
            this.statistics_closeButton.Name = "statistics_closeButton";
            this.statistics_closeButton.Size = new System.Drawing.Size(41, 33);
            this.statistics_closeButton.TabIndex = 22;
            this.statistics_closeButton.UseVisualStyleBackColor = false;
            this.statistics_closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // statistics_top_panel
            // 
            this.statistics_top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.statistics_top_panel.Controls.Add(this.statistics_closeButton);
            this.statistics_top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statistics_top_panel.Location = new System.Drawing.Point(0, 0);
            this.statistics_top_panel.Name = "statistics_top_panel";
            this.statistics_top_panel.Size = new System.Drawing.Size(712, 60);
            this.statistics_top_panel.TabIndex = 23;
            // 
            // statistics_background_panel
            // 
            this.statistics_background_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.statistics_background_panel.Controls.Add(this.statistics_textBox);
            this.statistics_background_panel.Controls.Add(this.lateest_reservation_label);
            this.statistics_background_panel.Controls.Add(this.statistics_latest_reservation__car_label);
            this.statistics_background_panel.Controls.Add(this.statistics_total_reservation_car_label);
            this.statistics_background_panel.Controls.Add(this.statistics_desciprtion_label);
            this.statistics_background_panel.Controls.Add(this.label2);
            this.statistics_background_panel.Controls.Add(this.label1);
            this.statistics_background_panel.Controls.Add(this.comboBox1);
            this.statistics_background_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statistics_background_panel.Location = new System.Drawing.Point(0, 60);
            this.statistics_background_panel.Name = "statistics_background_panel";
            this.statistics_background_panel.Size = new System.Drawing.Size(712, 371);
            this.statistics_background_panel.TabIndex = 24;
            // 
            // lateest_reservation_label
            // 
            this.lateest_reservation_label.AutoSize = true;
            this.lateest_reservation_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lateest_reservation_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lateest_reservation_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lateest_reservation_label.Location = new System.Drawing.Point(157, 16);
            this.lateest_reservation_label.Name = "lateest_reservation_label";
            this.lateest_reservation_label.Size = new System.Drawing.Size(0, 16);
            this.lateest_reservation_label.TabIndex = 29;
            // 
            // statistics_latest_reservation__car_label
            // 
            this.statistics_latest_reservation__car_label.AutoSize = true;
            this.statistics_latest_reservation__car_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.statistics_latest_reservation__car_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statistics_latest_reservation__car_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statistics_latest_reservation__car_label.Location = new System.Drawing.Point(157, 154);
            this.statistics_latest_reservation__car_label.Name = "statistics_latest_reservation__car_label";
            this.statistics_latest_reservation__car_label.Size = new System.Drawing.Size(0, 16);
            this.statistics_latest_reservation__car_label.TabIndex = 28;
            // 
            // statistics_total_reservation_car_label
            // 
            this.statistics_total_reservation_car_label.AutoSize = true;
            this.statistics_total_reservation_car_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.statistics_total_reservation_car_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statistics_total_reservation_car_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statistics_total_reservation_car_label.Location = new System.Drawing.Point(157, 110);
            this.statistics_total_reservation_car_label.Name = "statistics_total_reservation_car_label";
            this.statistics_total_reservation_car_label.Size = new System.Drawing.Size(0, 16);
            this.statistics_total_reservation_car_label.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Latest Reservation: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Total Reservations:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 430);
            this.Controls.Add(this.statistics_header_label);
            this.Controls.Add(this.statistics_background_panel);
            this.Controls.Add(this.statistics_top_panel);
            this.Name = "StatisticsForm";
            this.Text = "sectors";
            this.Load += new System.EventHandler(this.statistics_Load);
            this.statistics_top_panel.ResumeLayout(false);
            this.statistics_background_panel.ResumeLayout(false);
            this.statistics_background_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void statistics_Load(object sender, EventArgs e)
        {
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void statistics_header_label_Click(object sender, EventArgs e)
        {

        }

        #endregion
        private System.Windows.Forms.Label statistics_desciprtion_label;
        private System.Windows.Forms.Label statistics_textBox;
        private System.Windows.Forms.Label statistics_header_label;
        private FontAwesome.Sharp.IconButton statistics_closeButton;
        private System.Windows.Forms.Panel statistics_top_panel;
        private System.Windows.Forms.Panel statistics_background_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label statistics_total_reservation_car_label;
        private System.Windows.Forms.Label lateest_reservation_label;
        private System.Windows.Forms.Label statistics_latest_reservation__car_label;
    }
}
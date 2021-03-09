
namespace Flights_App
{
    partial class DemoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoForm));
            this.DepartureLabel = new System.Windows.Forms.Label();
            this.ReturnLabel = new System.Windows.Forms.Label();
            this.MonthCalendarButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Color_button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // DepartureLabel
            // 
            this.DepartureLabel.AutoSize = true;
            this.DepartureLabel.BackColor = System.Drawing.Color.Transparent;
            this.DepartureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.DepartureLabel.ForeColor = System.Drawing.Color.White;
            this.DepartureLabel.Location = new System.Drawing.Point(43, 348);
            this.DepartureLabel.Name = "DepartureLabel";
            this.DepartureLabel.Size = new System.Drawing.Size(134, 24);
            this.DepartureLabel.TabIndex = 0;
            this.DepartureLabel.Text = "DEPARTURE";
            // 
            // ReturnLabel
            // 
            this.ReturnLabel.AutoSize = true;
            this.ReturnLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReturnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.ReturnLabel.ForeColor = System.Drawing.Color.White;
            this.ReturnLabel.Location = new System.Drawing.Point(43, 434);
            this.ReturnLabel.Name = "ReturnLabel";
            this.ReturnLabel.Size = new System.Drawing.Size(94, 24);
            this.ReturnLabel.TabIndex = 1;
            this.ReturnLabel.Text = "RETURN";
            // 
            // MonthCalendarButton
            // 
            this.MonthCalendarButton.BackColor = System.Drawing.Color.Transparent;
            this.MonthCalendarButton.FlatAppearance.BorderSize = 0;
            this.MonthCalendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthCalendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.MonthCalendarButton.ForeColor = System.Drawing.Color.White;
            this.MonthCalendarButton.Location = new System.Drawing.Point(12, 12);
            this.MonthCalendarButton.Name = "MonthCalendarButton";
            this.MonthCalendarButton.Size = new System.Drawing.Size(356, 57);
            this.MonthCalendarButton.TabIndex = 2;
            this.MonthCalendarButton.Text = "Read about MonthCalendar";
            this.MonthCalendarButton.UseVisualStyleBackColor = false;
            this.MonthCalendarButton.Click += new System.EventHandler(this.MonthCalendarButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dateTimePicker1.CustomFormat = "dd, MM,yyyy - dddd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 375);
            this.dateTimePicker1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(323, 26);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BoldedDates = new System.DateTime[] {
        new System.DateTime(2021, 3, 12, 0, 0, 0, 0)};
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(118)))));
            this.monthCalendar1.Location = new System.Drawing.Point(47, 81);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2021, 3, 9, 0, 0, 0, 0), new System.DateTime(2021, 3, 11, 0, 0, 0, 0));
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(118)))));
            // 
            // Color_button1
            // 
            this.Color_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Color_button1.Location = new System.Drawing.Point(347, 152);
            this.Color_button1.Name = "Color_button1";
            this.Color_button1.Size = new System.Drawing.Size(136, 57);
            this.Color_button1.TabIndex = 6;
            this.Color_button1.Text = "Color Calendar!";
            this.Color_button1.UseVisualStyleBackColor = true;
            this.Color_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker2.CustomFormat = "dd, MM,yyyy - dddd, HH:mm";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(47, 470);
            this.dateTimePicker2.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowCheckBox = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(323, 26);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.CloseUp += new System.EventHandler(this.dateTimePicker2_CloseUp);
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 844);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.Color_button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.MonthCalendarButton);
            this.Controls.Add(this.ReturnLabel);
            this.Controls.Add(this.DepartureLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(118)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DemoForm";
            this.Text = "DemoForm";
            this.Load += new System.EventHandler(this.DemoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DepartureLabel;
        private System.Windows.Forms.Label ReturnLabel;
        private System.Windows.Forms.Button MonthCalendarButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Color_button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}
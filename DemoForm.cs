using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flights_App
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }

        private void DemoForm_Load(object sender, EventArgs e)
        {

        }

        private void MonthCalendarButton_Click(object sender, EventArgs e)
        {
            MonthCalendarControlDesc calendar = new MonthCalendarControlDesc();
            calendar.Show();
            calendar.TopMost = true;
            calendar.Activate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK) 
            {
                Color myColor = colorDialog1.Color;
                monthCalendar1.BackColor = myColor;
            }
            else 
            {
                MessageBox.Show("Ai dat cancel");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_CloseUp(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value <= dateTimePicker1.Value) 
            {
                MessageBox.Show("Return Date cannot be equal to or before Depart Date");
            }
        }
    }
}

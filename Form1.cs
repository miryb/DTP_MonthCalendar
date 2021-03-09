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

    public partial class Form1 : Form
    {
        List<Label> AnimatedLabels = new List<Label>();

        Timer myTimer;

        public Form1()
        {
            InitializeComponent();
            PopulateLabelList();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 3500;
            myTimer.Start();
        }

        void PopulateLabelList() 
        {
            AnimatedLabels.Add(DTPDescriptionBullet1);
            AnimatedLabels.Add(DTPDescriptionBullet2);
            AnimatedLabels.Add(DTPDescriptionBullet3);
            AnimatedLabels.Add(DTPDescriptionPropsBullet1);
            AnimatedLabels.Add(DTPDescriptionPropsBullet2);
            AnimatedLabels.Add(DTPDescriptionPropsBullet3);
            AnimatedLabels.Add(DTPDescriptionPropsBullet4);
            AnimatedLabels.Add(Note1);
            AnimatedLabels.Add(DTPDescriptionBullet4);
            AnimatedLabels.Add(DTPDescriptionEventsBullet1);
            AnimatedLabels.Add(DTPDescriptionEventsBullet2);
        }
        void TimerEventProcessor(Object MyObject, EventArgs myEventArgs)
        {
            if (AnimatedLabels.Count > 0)
            {
                AnimatedLabels[0].Visible = true;
                AnimatedLabels.RemoveAt(0);
            }

            else 
            {
                myTimer.Stop();
                DemoButton.Visible = true;
            }

        }

        private void DemoButton_Click(object sender, EventArgs e)
        {
            DemoForm DemoForm1 = new DemoForm();
            DemoForm1.Show();
            DemoForm1.TopMost = true;
            DemoForm1.Activate();
        }


    }
}

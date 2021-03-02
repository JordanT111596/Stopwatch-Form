using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch_Form
{
    public partial class Form1 : Form
    {

        int timeCenti, timeSec, timeMin;
        bool isActive;

        private void startButton_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            isActive = false;

            ResetTime();
        }

        private void ResetTime()
        {
            timeCenti = 0;
            timeSec = 0;
            timeMin = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeCenti++;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isActive = false;
            ResetTime();
        }
    }
}

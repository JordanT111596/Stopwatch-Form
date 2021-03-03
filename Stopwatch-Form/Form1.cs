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

        //initializes time tracking variables
        int timeCenti, timeSec, timeMin;

        //initializes timer controlling boolean value
        bool isActive;

        private void startButton_Click(object sender, EventArgs e)
        {
            //flips the boolean to true so that the timer begins
            isActive = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            //flips the boolean to false so that the timer stops
            isActive = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //flips the boolean to false so that the timer stops
            isActive = false;

            //calls the reset time function to set everything back to zero
            ResetTime();
        }

        private void ResetTime()
        {
            //function that changes all our time storing variables back to zero to begin again
            timeCenti = 0;
            timeSec = 0;
            timeMin = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //the timer only ticks when the isActive boolean is true
            if (isActive)
            {
                //every centisecond, the centisecond value increases by one
                timeCenti++;

                if (timeCenti >= 100)
                {
                    //when the centisecond value reaches 100, or one normal second, the second value increases by one
                    timeSec++;
                    //the centisecond value resets back to zero to begin counting again
                    timeCenti = 0;

                    if (timeSec >= 60)
                    {
                        //when the second value reaches 60, or one minute, the minute value increases by one
                        timeMin++;
                        //the second value resets back to zero to begin counting again
                        timeSec = 0;
                    }
                }
            }

            //the function to display the time on the form is called
            DisplayTime();
        }

        private void DisplayTime()
        {
            //function that sets the form text to each corresponding value for centisecond, second, and minute
            centiLabel.Text = String.Format("{0:00}", timeCenti);
            secondLabel.Text = String.Format("{0:00}", timeSec);
            minuteLabel.Text = String.Format("{0:00}", timeMin);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //When the form is first loaded, the timer is not active and the values reset to zero
            isActive = false;
            ResetTime();
        }
    }
}

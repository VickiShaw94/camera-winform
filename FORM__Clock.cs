using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

//use this if we also want minutes https://www.youtube.com/watch?v=lp9cJJUDUsk

namespace FAITool
{
    /// <summary>
    /// Displays a stopwatch that increments in seconds
    /// </summary>
    public partial class FORM__Clock : DevExpress.XtraEditors.XtraForm
    {

        int time = 0;

        public FORM__Clock()
        {
            InitializeComponent();
            timer1.Interval = 1;
        }

        /// <summary>
        /// starts the timer
        /// </summary>
        /// <param name="sender">the button click event</param>
        /// <param name="e">starts the timer on the button click</param>
        private void btn_startTimer_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        /// <summary>
        /// </summary>
        /// <param name="sender">the button click event</param>
        /// <param name="e">stops the timer on the button click</param>
        private void btn_pauseTimer_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        /// <summary>
        /// resets the timer
        /// </summary>
        /// <param name="sender">the button click event</param>
        /// <param name="e">resets the timer on the button click</param>
        private void btn_resetTimer_Click(object sender, EventArgs e)
        {

            timer1.Enabled = false;
            lbl_timer.Text = "00:00:00.00";
            time = 0;
        }

        /// <summary>
        /// increments the seconds on the stopwatch on the form
        /// </summary>
        /// <param name="sender">the increment on a timer</param>
        /// <param name="e">displays an increment on the stopwatch on the form</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //increments the time for every second
            time++;

            //splits the time into minutes, seconds, and milliseconds
            int milliseconds = time % 100;
            int seconds = (time % 3600) / 60 ; 
            int minutes = (time % (3600 * 3600)) / 3600;
            int hours = (time % (3600 ^ 3)) / (3600 * 60);

            //the strings that hold the times
            string millisecondsString = string.Empty;
            string secondsString = string.Empty;
            string minutesString = string.Empty;
            string hoursString = string.Empty;

            millisecondsString = milliseconds.ToString();
                      
            
            if (seconds < 10)
            {
                secondsString = "0" + seconds;
            }
            else
            {
                secondsString = seconds.ToString();
            }
            if (minutes < 10)
            {
                minutesString = "0" + minutes;
            }
            else
            {
                minutesString = seconds.ToString();
            }
            if (hours < 10)
            {
                hoursString = "0" + hours;
            }
            else
            {
                hoursString = seconds.ToString();
            }

            lbl_timer.Text = hours.ToString() + ":" + minutesString + ":" + secondsString + "." + millisecondsString;
        }

        /// <summary>
        /// stops the timer and saves the results
        /// </summary>
        /// <param name="sender">the button click</param>
        /// <param name="e">stops clock and saves results</param>
        private void btn_saveResults_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

        }

        /// <summary>
        /// returns the time displayed on the stopwatch as a double
        /// </summary>
        /// <returns>a double value representing the time in seconds</returns>
        public string getTime()
        {
            return lbl_timer.Text;
        }
    }
}
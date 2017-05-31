using System;
using System.Diagnostics;

//use this if we also want minutes https://www.youtube.com/watch?v=lp9cJJUDUsk

namespace FAITool
{
    /// <summary>
    /// Displays a stopwatch that increments in seconds
    /// </summary>
    public partial class FORM__Clock : DevExpress.XtraEditors.XtraForm
    {

        Stopwatch _stopwatch = new Stopwatch();

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
            _stopwatch.Start();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender">the button click event</param>
        /// <param name="e">stops the timer on the button click</param>
        private void btn_pauseTimer_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            _stopwatch.Stop();
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
        }

        /// <summary>
        /// increments the seconds on the stopwatch on the form
        /// </summary>
        /// <param name="sender">the increment on a timer</param>
        /// <param name="e">displays an increment on the stopwatch on the form</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = _stopwatch.Elapsed;

            lbl_timer.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
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
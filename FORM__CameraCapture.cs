using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Net;
using System.IO;

/// <summary>
/// Author: Soumya Bagade 
/// Author: Alex Boss
/// /// </summary>
namespace FAITool
{
    public partial class FORM__CameraCapture : XtraForm
    {
        //the image taken with the webcam 
        private Bitmap _imageCaptured;
        // Aforge Library
        private IVideoSource _videoSource;
        //the barcode of the system
        private string _barcode;

        public FORM__CameraCapture(string barcode)
        {
            InitializeComponent();
            _barcode = barcode;
        }

        public void FORM__CameraCapture_Load(object sender, EventArgs e)
        {
            btn_takeVideo.Text = "Start Recording";
        }

        private void btn_takePicture_Click(object sender, EventArgs e)
        {
            try
            {
                //takes the picture
                _imageCaptured = cameraControl1.TakeSnapshot();
                //creates the popup to save picture
                FORM__SavePicture popup = new FORM__SavePicture(_barcode, _imageCaptured);
                //runs the file without closing until the save is done or exit is clicked
                popup.ShowDialog();
                //disposes of the image
                _imageCaptured.Dispose();
            }
            catch (Exception ex)
            {
                //an error occurred
                throw ex;
            }
        }


        /// <summary>
        /// Called when user clicks on the take video button
        /// </summary>
        /// <param name="sender"> Button </param> 
        /// <param name="e"> Button click event </param>
        private void btn_takeVideo_Click(object sender, EventArgs e)
        {
            if (btn_takeVideo.Text == "Start Recording")
            {
                btn_takeVideo.Text = "Stop Recording";
            }
            else if (btn_takeVideo.Text == "Stop Recording")
            {
                btn_takeVideo.Text = "Start Recording";
            }
        }





























        /// <summary>
        /// 
        /// </summary>
        private void StartVideo()
        {
            _videoSource = new VideoCaptureDevice();
            //_videoSource.NewFrame += video_NewFrame;
            _videoSource.Start();
        }

        private void StopCamera()
        {
            if(_videoSource != null && _videoSource.IsRunning)
            {
                _videoSource.Stop();
                //_videoSource.NewFrame -= video_NewFrame;
            }
           // Image = null;
        }
        /**
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                using(var bitmap = (Bitmap)eventArgs.Frame.Clone())
                {
                    Image = bitmap.toBitmapImage();
                }
                Image.Freeze();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error in video_NewFrame method on line 78 of FORM__CameraCapture");
            }
        }
    */
    }
}
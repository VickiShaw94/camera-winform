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
using FluentFTP;
using System.IO;

namespace FAITool
{
    public partial class FORM__SavePicture : XtraForm
    {
        //the system's barcode
        private string _barcode;
        //the file name to save
        private string _fileName;
        //the image captured
        private Bitmap _imageCaptured;
        public FORM__SavePicture(string barcode, Bitmap imageCaptured)
        {
            InitializeComponent();
            _barcode = barcode;
            _imageCaptured = imageCaptured;
            createName();
        }

        public void createName()
        {
            //creates the file name
            _fileName = _barcode.Substring(2) + "_"+ DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss") + ".jpg";
            //stores the file name to the text box field
            txtbox_fileName.Text = _fileName;
        }

        /// <summary>
        /// saves the picture to the ftp site with the user's preferred file name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_saveName_Click(object sender, EventArgs e)
        {
            //if the file name does not end with jpg, don't save
            if (txtbox_fileName.Text.EndsWith(".jpg"))
            {
                try
                {
                    //connects to FTP
                    FtpClient client = new FtpClient(@"ftp://precious.lenovo.com/");
                    client.Credentials = new System.Net.NetworkCredential("csx_fai_user", "l3n0v0p3");
                    client.Connect();
                    
                    //creates the path to temporarily save the file to the user's computer
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                    //temporarily saves the converted image (bmp to jpg) to the computer
                    _imageCaptured.Save(path + txtbox_fileName.Text, ImageFormat.Jpeg);

                    //creates a folder for the mtm+serial num if the folder doesn't already exist
                    if (!client.DirectoryExists("/FAI/" + _barcode.Substring(2)))
                    {
                        client.CreateDirectory("/FAI/" + _barcode.Substring(2));
                    }

                    //gets the file path and uploads the file to ftp
                    string filePath = "/FAI/" + _barcode.Substring(2) + "/" + txtbox_fileName.Text;
                    client.UploadFile(path + txtbox_fileName.Text, filePath);

                    //deletes the temporary file made on the computer
                    File.Delete(path + txtbox_fileName.Text);

                    //disconnects from ftp and closes the form
                    client.Disconnect();
                    Close();
                }
                catch (Exception ex)
                {
                    //throws an error if there is an error in saving
                    MessageBox.Show(ex.Message, "Error Saving", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("File must end with a .jpg extension.", "Incorrect Extension", MessageBoxButtons.OK);
            }
        }

    }
}
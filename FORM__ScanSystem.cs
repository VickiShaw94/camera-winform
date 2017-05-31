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

namespace FAITool
{
    public partial class FORM__ScanSystem : XtraForm
    {
        //the barcode scanned by the user
        private string _barcode;
        //the next form to initialize
        private FORM__SystemDetails _ss;

        /// <summary>
        /// the constructor for the ScanSystem class
        /// sets the barcode as null in case it was previously set to a value and initializes the program to run
        /// </summary>
        public FORM__ScanSystem()
        {
            _barcode = null;
            InitializeComponent();
        }

        /// <summary>
        /// checks to make sure that there is something in the barcode textbox and returns an error if the field is empty
        /// sets the scanned barcode as a string local to the class
        /// </summary>
        /// <param name="sender">reference to the object that raised the event</param>
        /// <param name="e"> the event that triggers when the button is clicked is changed</param>
        private void btn_enter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBox_barcode.Text == string.Empty)
                {
                    lbl_welcome.Text = "Please scan a barcode before clicking enter.";
                }
                else
                {
                    _barcode = txtBox_barcode.Text;

                    if (!_barcode.StartsWith("1S"))
                    {
                        MessageBox.Show("Please scan a barcode that begins with 1S.");
                        txtBox_barcode.Text = string.Empty;
                    }
                    else if (_barcode.Length != 20)
                    {
                        MessageBox.Show("Please ensure the barcode is 20 characters long.");
                    }
                    else
                    {
                        //hides this form
                        Hide();

                        //shows the next form (the details page)
                        _ss = new FORM__SystemDetails(_barcode);
                        _ss.Show();

                        //closes this form
                        Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
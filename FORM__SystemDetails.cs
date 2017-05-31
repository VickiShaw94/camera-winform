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
using System.Data.SqlClient;

namespace FAITool
{
    public partial class FORM__SystemDetails : XtraForm
    {
        /**barcode strings*/
        //the barcode that was scanned in
        private string _barcode;
        //the machine type and model extracted from the barcode
        private string _mtm;
        //the system's machine type
        private string _machineType;
        //the system's serial number
        private string _serialNum;
        //list containing the rows/columns data
        private List<CLASS__SystemInfo> _listForTable;

        /// <summary>
        /// constructor for the class; in
        /// </summary>
        /// <param name="barcode">the barcode scanned by the user</param>
        public FORM__SystemDetails(string barcode)
        {
            InitializeComponent();

            _barcode = barcode;
        }

        /// <summary>
        /// breaks down information from the barcode and sets the different pieces (mtm, serial number, machine type) to fields in the class
        /// </summary>
        private void setBarcodeInfo()
        {
            try
            {
                _mtm = _barcode.Substring(2, 10);
                _machineType = _mtm.Substring(0, 4);
                _serialNum = _barcode.Substring(12, 8);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// gets the fields for the top part (common to the whole system) and populates the form's top part with the data
        /// </summary>
        private void getTopFields()
        {
            //creates fields for the class
            string str;
            SqlDataReader reader;
            //the sql connection string
            SqlConnection conn = new SqlConnection("Data Source=10.99.202.215,1458;Initial Catalog=DM_EXT_IT;User ID=chintand;Password=L3n0v0p3");
            //the sql query
            str = "SELECT DISTINCT COALESCE(B.BRAND_CODE, '') + ' ' + COALESCE(B.PROGRAM, '') + ' ' + COALESCE(B.SUB_SERIES, '') AS \"PROGRAM\", E.Mtype, RIGHT(E.PRODUCT_ID, 6) AS MODEL, E.SERIAL_NBR, E.BUILD_DATE, E.SHIP_DATE, C.CTRY_NAME, C.GEO_2012, C.FINANCE_REGION, P.PLANT,"
            + " E.COMPANY_CODE FROM DM_EXT_IT.dbo.Entitle_NonX86 E LEFT OUTER JOIN DM_EXT_IT.dbo.KOALA_BRAND_HIERARCHY_IDL B ON B.MACH_TYPE = E.MTYPE LEFT OUTER JOIN DM_EXT_IT.dbo.KOALA_COUNTRY_MAP_IDL C ON C.ISO2 = E.SHIP_TO_COUNTRY LEFT OUTER JOIN DM_QLTY_BIZ.dbo.Plant_Mapping P ON LEFT(E.Serial_nbr, 2) = "
                + "P.\"PLANT CODE\" WHERE E.MTYPE = '" + _machineType + "' AND E.SERIAL_NBR = '" + _serialNum + "' SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED";

            //creates the connection
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = str;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            try
            {
                //opens the connection
                conn.Open();
                reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("No records found for this serial number", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    while (reader.Read())
                    {
                        setTopFields((IDataReader)reader);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    //closes the connection
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// sets the top fields to their text boxes
        /// </summary>
        /// <param name="record">the record containing the data for the top fields</param>
        private void setTopFields(IDataRecord record)
        {
            try
            {
                txtbox_program.Text = string.Format("{0}", record[0]);
                txtbox_mtm.Text = string.Format("{0}", record[1]);
                txtbox_model.Text = string.Format("{0}", record[2]);
                txtbox_serialNum.Text = string.Format("{0}", record[3]);
                txtbox_buildDate.Text = string.Format("{0}", record[4]);
                txtbox_shipDate.Text = string.Format("{0}", record[5]);
                txtBox_country.Text = string.Format("{0}", record[6]);
                txtbox_geo.Text = string.Format("{0}", record[7]);
                txtbox_financeReg.Text = string.Format("{0}", record[8]);
                txtbox_manufacturingPlant.Text = string.Format("{0}", record[9]);
                txtbox_companyCode.Text = string.Format("{0}", record[10]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// gets the information for the grid and populates the data 
        /// the grid contains the data for each part (the id, barcode, part description, and the part type)
        /// </summary>
        private void getGridInfo()
        {
            //creates fields for the class
            string str;
            SqlDataReader reader;
            //the sql connection string
            SqlConnection conn = new SqlConnection("Data Source=10.99.202.215,1458;Initial Catalog=DM_EXT_IT;User ID=chintand;Password=L3n0v0p3");
            //the sql query
            str = "SELECT DISTINCT S.PART_ID, S.BARCODE, I.PART_DESC, I.\"PART TYPE\" FROM DM_EXT_IT.dbo.Entitle_NonX86 E LEFT OUTER LOOP JOIN DM_IBASE_IT.dbo.V_SV_IB_SUBASSEMBLY S ON E.MTYPE = S.MACHINE_TYPE AND E.SERIAL_NBR = S.SERIAL_NUMBER"// AND(LEFT(S.BARCODE, 3) = '11S' OR LEFT(S.BARCODE, 2) = '8S')"
                + " LEFT OUTER JOIN DM_EXT_IT.dbo.PN_COMMODITY I ON S.PART_ID = I.PART_NO WHERE E.MTYPE = '" + _machineType + "' AND E.SERIAL_NBR = '" + _serialNum + "' SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED";

            //creates the connection
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = str;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    _listForTable.Add(ReadSingleRow((IDataReader)reader));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    //closes the connection
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// reads the single row for the grid
        /// </summary>
        /// <param name="record">the record for one part</param>
        /// <returns>a CLASS__SystemInfo object to add to the list</returns>
        private CLASS__SystemInfo ReadSingleRow(IDataRecord record)
        {
            try
            {
                CLASS__SystemInfo si = new CLASS__SystemInfo();
                si.getSet_partId = string.Format("{0}", record[0]);
                si.getSet_barcodeForPart = string.Format("{0}", record[1]);
                si.getSet_partDesc = string.Format("{0}", record[2]);
                si.getSet_partType = string.Format("{0}", record[3]);
                return si;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// sets the data for the form and sets the list with part info to the grid
        /// </summary>
        /// <param name="sender">the form load</param>
        /// <param name="e">the form populates with data</param>
        private void FORM__SystemDetails_Load(object sender, EventArgs e)
        {
            try
            {
                //initializes the list for the grid/table
                _listForTable = new List<CLASS__SystemInfo>();

                //sets the data to the form
                setBarcodeInfo();
                getTopFields();
                getGridInfo();

                //populating the grid with part info
                gridControl1.DataSource = _listForTable;
                gridView1.Columns[0].Caption = "Part Id";
                gridView1.Columns[1].Caption = "Barcode for Part";
                gridView1.Columns[2].Caption = "Part Description";
                gridView1.Columns[3].Caption = "Part Type";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// goes to the next page after the user clicks the next page button
        /// </summary>
        /// <param name="sender">the next button click</param>
        /// <param name="e">the page changes</param>
        private void btn_nextPage_Click(object sender, EventArgs e)
        {

        }
    }
}
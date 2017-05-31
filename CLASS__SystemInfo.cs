using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAITool
{
    /// <summary>
    /// class containing the getters and setters for the columns of the SQL result table
    /// </summary>
    class CLASS__SystemInfo
    {
        //the part id
        private string _partId;
        //the barcode for the part
        private string _barcodeForPart;
        //the description of the part
        private string _partDesc;
        //the type of part
        private string _partType;

        public string getSet_partId
        {
            get { return _partId; }
            set { _partId = value; }
        }

        public string getSet_barcodeForPart
        {
            get { return _barcodeForPart; }
            set { _barcodeForPart = value; }
        }

        public string getSet_partDesc
        {
            get { return _partDesc; }
            set { _partDesc = value; }
        }

        public string getSet_partType
        {
            get { return _partType; }
            set { _partType = value; }
        }
    }
}

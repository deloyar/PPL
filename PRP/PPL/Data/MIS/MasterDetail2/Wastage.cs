using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRP.PPL.Data.MIS.MasterDetail2
{
    public class Wastage
    {
        public string ID { get; set; }
        public string Press { get; set; }
        public string Paper { get; set; }
        public string FormaQty { get; set; }
        public string PrintQty { get; set; }
        public string PaperQty { get; set; }
        public DateTime Date { get; set; }
        public string Seller { get; set; }
        public string Buyer { get; set; }
        public string Checker { get; set; }
        public string Remarks { get; set; }
    }
}

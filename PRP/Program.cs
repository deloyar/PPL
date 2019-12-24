using PRP.Data.Inventory.Challan;
using PRP.Data.Inventory.OpeningStock;
using PRP.PPL.Data.MIS.MasterDetail.Order;
using PRP.PPL.Data.MIS.MasterDetail2;
using PRP.PPL.Data.Production.PlateTransaction;
using PRP.PPL.Data.RND.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new PplDataMIS_MasterDetail());
            //Application.Run(new pplDataDistribution_Challan());
            //Application.Run(new PRP.PPL.Data.MIS.MasterDetail2.Form2());
            Application.Run(new PplDataProduction_PlateTransaction());
            //Application.Run(new PRP.PPL.Data.MIS.MasterDetail2.Hierarchy());
            //Application.Run(new PRP.PPL.Data.MIS.MasterDetail2.SampleBinding());
            //Application.Run(new Form8());

        }
    }
}

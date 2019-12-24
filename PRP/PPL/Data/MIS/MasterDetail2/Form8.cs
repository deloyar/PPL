using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRP.PPL.Data.MIS.MasterDetail2
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void pplDataNavigation1_Load(object sender, EventArgs e)
        {

        }

        
        private void pplDataNavigation1_NextButtonClick(object sender, EventArgs e)
        {

        }

        private void pplDataNavigation1_PrevButtonClick(object sender, EventArgs e)
        {

        }

        private void pplDataNavigation1_LastButtonClick(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            db_ppl Connstring = new db_ppl();
            DataTable dt = Connstring.SqlDataTable(@"SELECT * FROM [PPLDEV].[dbo].[Users]");
            this.pplDataNavigation1.Datatable = dt;
            
        }

        private void pplDataNavigation1_UpdateOnChange(object sender, EventArgs e)
        {
            Console.WriteLine("call update function");
        }

        private void pplDataNavigation1_UpdateOnChange_1(object sender, EventArgs e)
        {
            Console.WriteLine("call update function");
        }
    }
}

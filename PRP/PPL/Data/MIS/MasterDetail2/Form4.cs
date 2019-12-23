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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            db_ppl Connstring = new db_ppl();
                DataTable dt = Connstring.SqlDataTable(@"SELECT * FROM [PPLDEV].[hrd].[Employee]");
            pplDataGridView1.DataSource = dt;
        }
    }
}

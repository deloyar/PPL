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
    public partial class Form5 : Form
    {
        db_ppl Connstring = new db_ppl();
        public Form5()
        {
            InitializeComponent();
            //pplNavigation1.bindingSource = sampleBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = Connstring.SqlDataTable(@"SELECT * FROM [PPLDEV].[hrd].[Employee]");
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            pplNavigation1.BindingSource = bs;
            sampleBindingSource = bs;
            //var model = this.sampleBindingSource.DataSource as Sample;
            //var item = model.Count;
            //var AnotherSample = new Sample();
            //AnotherSample.Count = "ddddddddd";
            //AnotherSample.FirstName = "ddddddddd";
            //AnotherSample.LastName = "ddddddddd";
            //this.sampleBindingSource.DataSource = AnotherSample;


        }
    }
}

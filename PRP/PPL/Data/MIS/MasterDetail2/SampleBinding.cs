using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRP.PPL.Data.MIS.MasterDetail2
{
    public partial class SampleBinding : Form
    {
        public SampleBinding()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Sample> samples = new List<Sample>()
            {
                new Sample() {FirstName="sdfsdfsd", LastName="sdfsdf" }, new Sample()
                {
                    FirstName="xxxxxxx", LastName="yyyy"
                }
            };
            //pplNavigation1.DataSource = samples;
            var z = this.sampleBindingSource.DataSource as Sample;
            
            //PropertyInfo[] propertyInfo = type.GetProperties();
            var item = ModelState.IsValid<Object>(z);
            foreach (var i in ModelState.ErrorMessages)
            {
                var x = i;
            }
            z.FirstName = "600";
            z.LastName = "700";

        }

        private void SampleBinding_Load(object sender, EventArgs e)
        {

        }

        private void sampleBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Sample> samples = new List<Sample>()
            {
                new Sample() {FirstName="sdfsdfsd", LastName="sdfsdf", Count="kjghjk" }, new Sample()
                {
                    FirstName="xxxxxxx", LastName="yyyy", Count="yyyyyyy"
                }
            };
            //pplNavigation1.DataSource = samples;
            //var z = this.sampleBindingSource.DataSource as Sample;
        }
    }
}

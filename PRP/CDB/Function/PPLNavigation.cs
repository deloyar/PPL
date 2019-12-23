using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRP.PPL.Data.MIS.MasterDetail2;

namespace PRP.CDB.Function
{
    public partial class PPLNavigation : UserControl
    {
        public BindingSource ModelBindingSource { get; set; } = null;
        public Type ModelType { get; set; } = null;
        public PPLNavigation()
        {
            InitializeComponent();
        }
        public BindingSource BindingSource
        {
            get { return bindingNavigator.BindingSource; }
            set {
                    bindingNavigator.BindingSource = value;
                if (bindingNavigator.BindingSource != null)
                {
                    bindingNavigator.BindingSource.CurrentItemChanged += new System.EventHandler(this.BindingSource_CurrentItemChanged);
                }
            }
        }



        private void BindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            this.ModelBindingSource.DataSource = Convert.ChangeType(bindingNavigator.BindingSource.Current, ModelType);
        }
        public void SetModel<T>(ref BindingSource modelBindingSource) where T : class
        {
            this.ModelBindingSource = modelBindingSource;
            this.ModelType = typeof(T);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRP.CDB.Function
{
    public partial class PPLDataGridView : UserControl
    {
        private DataTable _datatable;
        public DataTable DataSource
        {
            get { return _datatable; }
            set
            {
                _datatable = value;
                SetPagedDataSource(value);
            }
        }

        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value;
            }
        }
        public int _pageSize = 10;


        BindingSource bs = new BindingSource();
        BindingList<DataTable> tables = new BindingList<DataTable>();




        public void SetPagedDataSource(DataTable dataTable)
        {
            DataTable dt = null;
            int counter = 1;
            foreach (DataRow dr in dataTable.Rows)
            {
                if (counter == 1)
                {
                    dt = dataTable.Clone();
                    tables.Add(dt);
                }
                dt.Rows.Add(dr.ItemArray);
                if (PageSize < ++counter)
                {
                    counter = 1;
                }
            }
            this.bindingNavigator.BindingSource = bs;
            bs.DataSource = tables;
            bs.PositionChanged += bs_PositionChanged;
            bs_PositionChanged(bs, EventArgs.Empty);
        }
        void bs_PositionChanged(object sender, EventArgs e)
        {
            this.dataGridView.DataSource = tables[bs.Position];
        }


        public PPLDataGridView()
        {
            _datatable = new DataTable();
            InitializeComponent();
        }
    }
}

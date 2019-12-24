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
    public partial class PPLDataNavigation : UserControl
    {
        
        int itemNumber;
        public int ItemNumber { get { return itemNumber; }
            set
            {
                itemNumber = value;
                CountLabelText = itemNumber + "/" + NumberofItems;
            }
        }
        private string countLabelText;
        private DataTable dataTable;

        public string CountLabelText {
            get
            {
                return countLabelText;
            }
            set
            {
                countLabelText = value;
                textBox.Text = countLabelText;
            }

        }
        private int NumberofItems { get
            {
                if (this.Datatable == null)
                {
                    return 0;
                }
                else
                {
                    return Datatable.Rows.Count;
                }
            } }
        public DataTable Datatable {
            get
            {
                return this.dataTable;
            }
            set
            {
                this.dataTable = value;
                ItemNumber = 0;
            }
        } 
        public PPLDataNavigation()
        {
            InitializeComponent();
            itemNumber = 0;
            
        }

        private void Updatelbl_Count_First(object sender, EventArgs e)
        {
            if (Datatable != null)
            {
                if (Datatable.Rows.Count > 0)
                    ItemNumber = 1;
                else
                    ItemNumber = 0;
            }
            else
            {
                ItemNumber = 0;
            }
        }
        private void Updatelbl_Count_Last(object sender, EventArgs e)
        {
            if (Datatable != null)
            {
                if (Datatable.Rows.Count > 0)
                    ItemNumber = Datatable.Rows.Count;
                else
                    ItemNumber = 0;
            }
            else
            {
                ItemNumber = 0;
            }
        }

        private void Updatelbl_Count_Next(object sender, EventArgs e)
        {
            if (Datatable != null)
            {
                if (Datatable.Rows.Count > 0 && Datatable.Rows.Count > ItemNumber)
                    ItemNumber++;
            }
            else
            {
                ItemNumber = 0;
            }
        }

        private void Updatelbl_Count_Prev(object sender, EventArgs e)
        {
            if (Datatable != null)
            {
                if (ItemNumber > 1)
                {
                    ItemNumber--;
                }
            }
            else
            {
                ItemNumber = 0;
            }
        }
    }
}

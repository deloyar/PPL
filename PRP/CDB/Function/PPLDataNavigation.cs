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
                CountLabelText = itemNumber+1 + "/" + NumberofItems;
                if (Datatable != null && Datatable.Rows.Count>0)
                {
                    if((itemNumber+1)== Datatable.Rows.Count)
                    {
                        this.btnNext.Enabled = false;
                        this.btnLast.Enabled = false;
                    }
                    else
                    {
                        this.btnNext.Enabled = true;
                        this.btnLast.Enabled = true;
                    }


                    if (itemNumber == 0)
                    {
                        btnFirst.Enabled = false;
                        btnPrevious.Enabled = false;
                    }
                    else
                    {
                        btnFirst.Enabled = true;
                        btnPrevious.Enabled = true;
                    }
                }
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
                ItemNumber = -1;
            }
        } 
        public PPLDataNavigation()
        {
            InitializeComponent();
            itemNumber = -1;
            
        }

        private void Updatelbl_Count_First(object sender, EventArgs e)
        {
            
            if (Datatable != null && Datatable.Rows.Count > 0)
            {

                if (Datatable.Rows.Count > 0)
                    ItemNumber = 0;
                else
                    ItemNumber = -1;
            }
            else
            {
                ItemNumber = -1;
                MessageBox.Show("No Item Found");
            }
        }
        private void Updatelbl_Count_Last(object sender, EventArgs e)
        {
            if (Datatable != null && Datatable.Rows.Count > 0)
            {
                if (Datatable.Rows.Count > 0)
                    ItemNumber = Datatable.Rows.Count-1;
                else
                    ItemNumber = -1;
            }
            else
            {
                ItemNumber = -1;
                MessageBox.Show("No Item Found");
            }
        }

        private void Updatelbl_Count_Next(object sender, EventArgs e)
        {
            if (Datatable != null && Datatable.Rows.Count > 0)
            {
                if (Datatable.Rows.Count > 0 && Datatable.Rows.Count -1> ItemNumber)
                    ItemNumber++;
            }
            else
            {
                ItemNumber = -1;
                MessageBox.Show("No Item Found");
            }
        }

        private void Updatelbl_Count_Prev(object sender, EventArgs e)
        {
            if (Datatable != null && Datatable.Rows.Count > 0)
            {
                if (ItemNumber > 0)
                {
                    ItemNumber--;
                }
            }
            else
            {
                ItemNumber = -1;
                MessageBox.Show("No Item Found");
            }
        }
    }
}

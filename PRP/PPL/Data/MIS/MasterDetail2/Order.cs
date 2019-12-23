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
    public partial class Order : Form
    {

        db_ppl Connstring = new db_ppl();
        DataTable dt = new DataTable();
        DataTable dt_Grid = new DataTable();
        DataTable dt_Grid2 = new DataTable();

        private DataTable AddNewRowToGridOrderItem()
        {
            DataTable data = dt;
            dt_Grid2 = dgvOrderData.DataSource as DataTable;
            DataRow dr = null;
            dr = dt_Grid2.NewRow();

            string ItemName = txtItemName.Text;
            string Quantity = txtQuantity.Text;

            if (ItemName != "" && Quantity != "0")
            {
                //Check Duplicate Value
                int status = 0;
                string searchValue = ItemName;
                foreach (DataGridViewRow row in dgvOrderData.Rows)
                {
                    if (dgvOrderData.Rows.Count > 0)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            MessageBox.Show("Duplicate row.");
                            status = 1;
                        }
                    }
                }

                if (status == 0)
                {
                    dr["Item Name"] = ItemName;
                    dr["Quantity"] = Quantity;
                    dr["Action"] = "Remove";

                    dt_Grid2.Rows.Add(dr);
                }
            }
            else
            {
                MessageBox.Show("Please input Item Name and subject.");
            }

            dgvOrderData.DataSource = dt_Grid2;
            return dt_Grid2;
        }
        public Order()
        {
            InitializeComponent();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewRowToGridOrderItem();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public void LoadDetailsData(string code)
        {
            DataTable dt = Connstring.SqlDataTable(@"SELECT   Item AS 'Item Name', Quantity, 'Remove' AS Action
                            FROM            dbo.OrderItem
                            WHERE        (OrderNo = '" + code + "')");
            dgvOrderData.DataSource = dt;
            dgvOrderData.Columns[0].Width = 212;
        }

        public void FindData(string Code)
        {
            if (Code != "")
            {
                try
                {
                    DataTable dt = Connstring.SqlDataTable(@"SELECT       OrderNo, Date, CustomerName
                                    FROM            dbo.[Order]
                                    WHERE        (OrderNo = '" + Code + "')");

                    if (dt.Rows.Count >= 1)
                    {
                        txtOrderNo.Text = dt.Rows[0]["OrderNo"].ToString();
                        txtDate.Text = dt.Rows[0]["Date"].ToString();
                        txtCustomerName.Text = dt.Rows[0]["CustomerName"].ToString();

                        LoadDetailsData(Code);
                    }
                    else
                    {
                        MessageBox.Show("Item not found.", "Alart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Problem in Data", "Alart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string code = txtFind.Text;
            if (code != "")
            {
                FindData(code);
            }
        }
        private void LoaderLoad(object sender, EventArgs e)
        {
            CreateGridViewOrder();
        }

        private void CreateGridViewOrder()
        {
            DataTable dt1 = new DataTable();

            dt1.Columns.Add(new DataColumn("Item Name", typeof(string)));
            dt1.Columns.Add(new DataColumn("Quantity", typeof(string)));
            dt1.Columns.Add(new DataColumn("Action", typeof(string)));

            dgvOrderData.DataSource = dt1;
            dgvOrderData.AllowUserToAddRows = false; //DataGrid Aditional Row Hide
            dgvOrderData.Columns[0].Width = 212;
        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

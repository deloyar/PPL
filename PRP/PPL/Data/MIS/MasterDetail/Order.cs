
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRP.PPL.Data.MIS.MasterDetail.Order
{
    public partial class PplDataMIS_MasterDetail : Form
    {
        db_ppl Connstring = new db_ppl();
        DataTable dt = new DataTable();
        DataTable dt_Grid = new DataTable();
        DataTable dt_Grid2 = new DataTable();

        public PplDataMIS_MasterDetail()
        {
            InitializeComponent();
        }

        private void PPLOrder_Load(object sender, EventArgs e)
        {
            CreateGridViewOrder();
        }

        //Reset & Refresh DataGrid
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

        //Temporary Load DataRow in DataGrid
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewRowToGridOrderItem();
        }

        private void dgvOrderData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult myResult;
            myResult = MessageBox.Show("Are you really remove the item?", "Remove Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                if (e.ColumnIndex == 2) //Action - Remove: Column Index
                {
                    dgvOrderData.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Code = txtOrderNo.Text;
            if (Code != "")
            {
                DataTable dt = Connstring.SqlDataTable(@"SELECT COUNT(*) AS CheckData FROM [dbo].[Order] WHERE (OrderNo = N'" + Code + "')");
                int CheckData = Convert.ToInt32(dt.Rows[0]["CheckData"].ToString());
                if (CheckData == 0)
                {
                    string CustomerName = txtCustomerName.Text;
                    string strDate = txtDate.Value.ToString("yyyy-MM-dd");

                    if (CustomerName != "" && strDate != "0")
                    {
                        string sql = @"INSERT INTO dbo.[Order]
                            (OrderNo, Date, CustomerName)
                            VALUES        (@OrderNo,@Date,@CustomerName)";

                        SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);

                        MyCommand.Parameters.AddWithValue("@OrderNo", Code);
                        MyCommand.Parameters.AddWithValue("@Date", strDate);
                        MyCommand.Parameters.AddWithValue("@CustomerName", CustomerName);

                        Connstring.conn.Open();
                        int Result = MyCommand.ExecuteNonQuery();
                        Connstring.conn.Close();

                        if (Result == 1)
                        {
                            SaveDetailsData(Code);
                            lblMessage.Text = "Successfully saved.";
                        }
                        else
                        {
                            MessageBox.Show("Save failed.");
                        }
                    }
                    else
                    {
                        lblMessage.Text = "Please fill all required fields.";
                    }
                }
                else
                {
                    MessageBox.Show("Already exist.");
                }
            }
            else {
                MessageBox.Show("Please select code.");
            }
        }

        //---------Save Details Data-----------------//
        private void SaveDetailsData(string Code) //Call Master Part
        {
            if (Code != "")
            {
                foreach (DataGridViewRow dgvRow in dgvOrderData.Rows)
                {
                    if (dgvRow.IsNewRow) break;
                    else
                    {
                        string sql = @"INSERT     
                                INTO              dbo.OrderItem(OrderNo, Item, Quantity)
                                VALUES        (@OrderNo,@Item,@Quantity)";
                        SqlCommand sqlCmd = new SqlCommand(sql, Connstring.conn);

                        sqlCmd.Parameters.AddWithValue("@OrderNo", Code);
                        sqlCmd.Parameters.AddWithValue("@Item", dgvRow.Cells["Item Name"].Value);
                        sqlCmd.Parameters.AddWithValue("@Quantity", dgvRow.Cells["Quantity"].Value);

                        Connstring.conn.Open();
                        sqlCmd.ExecuteNonQuery();
                        Connstring.conn.Close();
                    }
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

        //Find Function - Search বাটন এ কল করতে হবে।
        public void FindData(string Code)
        {
            if (Code != "")
            {
                try
                {
                    DataTable dt = Connstring.SqlDataTable(@"SELECT       OrderNo, Date, CustomerName
                                    FROM            dbo.[Order]
                                    WHERE        (OrderNo = '"+ Code + "')");

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
                catch
                {

                }
            }
        }

        //Load DataGrid
        public void LoadDetailsData(string code)
        {
            DataTable dt = Connstring.SqlDataTable(@"SELECT   Item AS 'Item Name', Quantity, 'Remove' AS Action
                            FROM            dbo.OrderItem
                            WHERE        (OrderNo = '" + code + "')");
            dgvOrderData.DataSource = dt;
            dgvOrderData.Columns[0].Width = 212;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Code = txtOrderNo.Text;
            string Date = txtDate.Value.ToString("yyyy-MM-dd");
            string CustomerName = txtCustomerName.Text;

            if (Code != "" && CustomerName != "" && Date!="")
            {
                string sql = @"UPDATE       dbo.[Order]
                             SET  Date =@Date, CustomerName =@CustomerName
                             WHERE (OrderNo = '" + Code + "')";

                SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);

                MyCommand.Parameters.AddWithValue("@Date", Date);
                MyCommand.Parameters.AddWithValue("@CustomerName", CustomerName);

                Connstring.conn.Open();
                int Result = MyCommand.ExecuteNonQuery();
                Connstring.conn.Close();

                if (Result == 1)
                {
                    //Delete Details Data
                    string sqlDelete = @"DELETE 
                            FROM            dbo.OrderItem
                            WHERE        (OrderNo = @OrderNo)";
                    SqlCommand MyCommand1 = new SqlCommand(sqlDelete, Connstring.conn);
                    MyCommand1.Parameters.AddWithValue("@OrderNo", Code);

                    Connstring.conn.Open();
                    MyCommand1.ExecuteNonQuery();
                    Connstring.conn.Close();
                    //-------------------------------//
                    SaveDetailsData(Code); //Save New Details Data
                    lblMessage.Text = "Updated successfully.";
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
            else
            {
                lblMessage.Text = "Please fill all required fields.";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Code = txtOrderNo.Text;

            DialogResult myResult;
            myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                //Confirm delete
                if (Code != "")
                {
                    

                    //Delete Details Data
                    string sqlDelete = @"DELETE 
                            FROM            dbo.OrderItem
                            WHERE        (OrderNo = @OrderNo)";
                    SqlCommand MyCommand1 = new SqlCommand(sqlDelete, Connstring.conn);
                    MyCommand1.Parameters.AddWithValue("@OrderNo", Code);

                    Connstring.conn.Open();
                    int Result = MyCommand1.ExecuteNonQuery();
                    Connstring.conn.Close();

                    if (Result>0)
                    {

                        string sql = @"DELETE 
                                FROM            dbo.[Order]
                                WHERE        (OrderNo = @OrderNo)";
                        SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);
                        MyCommand.Parameters.AddWithValue("@OrderNo", Code);

                        Connstring.conn.Open();
                        MyCommand.ExecuteNonQuery();
                        Connstring.conn.Close();

                        lblMessage.Text = "Deleted successfully.";
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed.");
                    }
                }
                else
                {
                    lblMessage.Text = "Please select item.";
                }
            }
        }

        private void dgvOrderData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

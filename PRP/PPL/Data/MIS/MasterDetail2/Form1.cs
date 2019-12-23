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

namespace PRP.PPL.Data.MIS.MasterDetail2
{
    public partial class Form1 : Form
    {

        db_ppl Connstring = new db_ppl();
        DataTable dt = new DataTable();
        DataTable dt_Grid = new DataTable();
        DataTable dt_Grid2 = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateGridViewOrder();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // add item to grid...


            AddNewRowToGridOrderItem();
        }

        private void CreateGridViewOrder()
        {
            DataTable dt1 = new DataTable();

            dt1.Columns.Add(new DataColumn("Item Name", typeof(string)));
            dt1.Columns.Add(new DataColumn("Quantity", typeof(string)));
            dt1.Columns.Add(new DataColumn("Action", typeof(string)));

            dataGridView1.DataSource = dt1;
            dataGridView1.AllowUserToAddRows = false; //DataGrid Aditional Row Hide
            dataGridView1.Columns[0].Width = 212;
        }

        private DataTable AddNewRowToGridOrderItem()
        {
            DataTable data = dt;
            dt_Grid2 = dataGridView1.DataSource as DataTable;
            DataRow dr = null;
            dr = dt_Grid2.NewRow();

            string ItemName = textBox3.Text;
            string Quantity = textBox4.Text;

            if (ItemName != "" && Quantity != "0")
            {
                //Check Duplicate Value
                int status = 0;
                string searchValue = ItemName;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (dataGridView1.Rows.Count > 0)
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

            dataGridView1.DataSource = dt_Grid2;
            return dt_Grid2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Code = textBox1.Text;
            if (Code != "")
            {
                DataTable dt = Connstring.SqlDataTable(@"SELECT COUNT(*) AS CheckData FROM [dbo].[Order] WHERE (OrderNo = N'" + Code + "')");
                int CheckData = Convert.ToInt32(dt.Rows[0]["CheckData"].ToString());
                if (CheckData == 0)
                {
                    string CustomerName = textBox2.Text;
                    string strDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

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
                            label6.Text = "Successfully saved.";
                        }
                        else
                        {
                            MessageBox.Show("Save failed.");
                        }
                    }
                    else
                    {
                        label6.Text = "Please fill all required fields.";
                    }
                }
                else
                {
                    MessageBox.Show("Already exist.");
                }
            }
            else
            {
                MessageBox.Show("Please select code.");
            }
        }

        private void SaveDetailsData(string Code) //Call Master Part
        {
            if (Code != "")
            {
                foreach (DataGridViewRow dgvRow in dataGridView1.Rows)
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

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult myResult;
            myResult = MessageBox.Show("Are you really remove the item?", "Remove Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                if (e.ColumnIndex == 2) //Action - Remove: Column Index
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string code = textBox6.Text;
            if (code != "")
            {
                FindData(code);
            }
        }

        public void LoadDetailsData(string code)
        {
            DataTable dt = Connstring.SqlDataTable(@"SELECT   Item AS 'Item Name', Quantity, 'Remove' AS Action
                            FROM            dbo.OrderItem
                            WHERE        (OrderNo = '" + code + "')");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 212;
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
                        textBox1.Text = dt.Rows[0]["OrderNo"].ToString();
                        //dateTimePicker1.Text = dt.Rows[0]["Date"].ToString();
                        textBox2.Text = dt.Rows[0]["CustomerName"].ToString();

                        LoadDetailsData(Code);
                    }
                    else
                    {
                        MessageBox.Show("Item not found.", "Alart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Code = textBox1.Text;

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

                    if (Result > 0)
                    {

                        string sql = @"DELETE 
                                FROM            dbo.[Order]
                                WHERE        (OrderNo = @OrderNo)";
                        SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);
                        MyCommand.Parameters.AddWithValue("@OrderNo", Code);

                        Connstring.conn.Open();
                        MyCommand.ExecuteNonQuery();
                        Connstring.conn.Close();

                        label6.Text = "Deleted successfully.";
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed.");
                    }
                }
                else
                {
                    label6.Text = "Please select item.";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Code = textBox1.Text;
            string Date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string CustomerName = textBox2.Text;

            if (Code != "" && CustomerName != "" && Date != "")
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
                    label6.Text = "Updated successfully.";
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
            else
            {
                label6.Text = "Please fill all required fields.";
            }
        }
    }
}

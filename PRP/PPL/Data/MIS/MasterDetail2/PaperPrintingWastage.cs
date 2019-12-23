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
using PRP.PPL.Data.MIS.MasterDetail2;

namespace PRP.PPL.Data.Production
{
    public partial class PaperPrintingWastage : Form
    {


        db_ppl Connstring = new db_ppl();
        DataTable dt = new DataTable();
        DataTable dt_Grid = new DataTable();
        DataTable dt_Grid2 = new DataTable();


        public PaperPrintingWastage()
        {
            InitializeComponent();
        }

        //.........Loading datas in the form.........
        private void PplDataProductionPaperPrintingWastage_Load(object sender, EventArgs e)
        {

        }

        //.........Making ID Each time.........
        public void MakeID()
        {
            string No = MethodOrFunction.GetInvoice("pw_no", "[prd].printing_wastage_info");
            txtWatageID.Text = No;
        }

        //.........Auto selected value for Press combobox(dropdown).........
        private void GetPressCodeData()
        {
            DataTable dt = Connstring.SqlDataTable(@"SELECT [Press Code] AS Code, [Press Name] AS Name
                            FROM prd.[Press Info]");
            DataRow Drw;
            Drw = dt.NewRow();
            Drw.ItemArray = new object[] { 0, " Please Select " };
            dt.Rows.InsertAt(Drw, 0);

            cboPressCode.ValueMember = "Code";
            cboPressCode.DisplayMember = "Name";
            cboPressCode.DataSource = dt;
        }

        //.........Auto selected value for Paper combobox(dropdown).........
        private void GetPaperCodeData()
        {
            DataTable dt = Connstring.SqlDataTable(@"SELECT        [Paper Code] AS Code, [Paper Name] AS Name
FROM            prd.[Paper Info]");
            DataRow Drw;
            Drw = dt.NewRow();
            Drw.ItemArray = new object[] { 0, " Please Select " };
            dt.Rows.InsertAt(Drw, 0);

            cboPaperCode.ValueMember = "Code";
            cboPaperCode.DisplayMember = "Name";
            cboPaperCode.DataSource = dt;
        }

        //.........Creating a grid view to show item and quantity and an action named Remove.........
        private void Creat_GridView()
        {
            DataTable dt1 = new DataTable();
            dt1.Columns.Add(new DataColumn("Item", typeof(string)));
            dt1.Columns.Add(new DataColumn("Quantity", typeof(string)));
            dt1.Columns.Add(new DataColumn("Action", typeof(string)));
            dgvOrderData.DataSource = dt1;
            dgvOrderData.Columns[0].Width = 170;
            dgvOrderData.Columns[1].Width = 170;


        }

        private void lblPrintQuantity_Click(object sender, EventArgs e)
        {

        }

        //.........Save Master Data.........
        private void btnSave_Click(object sender, EventArgs e)
        {

            var item =(Wastage)this.wastageBindingSource.DataSource;

            string WatageID = txtWatageID.Text;
            string Date = txtDate.Value.ToString("yyyy-MM-dd");
            string FormaQuantity = txtFormaQuantity.Text;
            string PrintQuantity = txtPrintQuantity.Text;
            string PaperQuantity = txtPaperQuantity.Text;
            string Seller = txtSeller.Text;
            string PressCode2 = cboPressCode.SelectedValue.ToString();
            string PaperCode2 = cboPaperCode.SelectedValue.ToString();
            string Buyer = txtBuyer.Text;
            string Checker = txtChecker.Text;
            string Remarks = txtRemarks.Text;

            // && FormaQuantity != "" && PrintQuantity != "" && PaperQuantity != "" && Seller != "" && Buyer != "" && Checker != "" && Remarks != ""
            if (WatageID != "")
            {
                string CheckSQL = @"SELECT COUNT(*) AS CheckData FROM prd.printing_wastage_info WHERE (pw_no = '" + WatageID + "')";
                DataTable dt = Connstring.SqlDataTable(CheckSQL);
                int CheckData = Convert.ToInt32(dt.Rows[0]["CheckData"].ToString());
                if (CheckData == 0)
                {

                    if (PressCode2 == "0")
                    {
                        MessageBox.Show("Insert Press Code");
                        return;
                    }
                    else if (PaperCode2 == "0")
                    {
                        MessageBox.Show("Insert Paper Code");
                        return;
                    }
                    else if (FormaQuantity == "")
                    {
                        MessageBox.Show("Insert Forma Quantity");
                        return;
                    }
                    else if (PrintQuantity == "")
                    {
                        MessageBox.Show("Insert Print Quantity");
                        return;
                    }
                    else if (PaperQuantity == "")
                    {
                        MessageBox.Show("Insert Paper Quantity");
                        return;
                    }
                    else if (Seller == "")
                    {
                        MessageBox.Show("Insert Seller");
                        return;
                    }
                    else if (Buyer == "")
                    {
                        MessageBox.Show("Insert Buyer");
                        return;
                    }
                    else if (Checker == "")
                    {
                        MessageBox.Show("Insert Checker");
                        return;
                    }

                    else

                    {
                        string sql = @"INSERT INTO  prd.printing_wastage_info
                                 (pw_no, date,press_code,paper_code, forma_qty, print_qty, paper_qty, seller, buyer, checker, remarks)
                                 VALUES (@pw_no,@date,@press_code,@paper_code,@forma_qty,@print_qty,@paper_qty,@seller,
                                  @buyer,@checker,@remarks)";

                        SqlCommand sqlCmd = new SqlCommand(sql, Connstring.conn);

                        sqlCmd.Parameters.AddWithValue("@pw_no", WatageID);
                        sqlCmd.Parameters.AddWithValue("@date", Date);
                        sqlCmd.Parameters.AddWithValue("@press_code", PressCode2);
                        sqlCmd.Parameters.AddWithValue("@paper_code", PaperCode2);
                        sqlCmd.Parameters.AddWithValue("@forma_qty", FormaQuantity);
                        sqlCmd.Parameters.AddWithValue("@print_qty", PrintQuantity);
                        sqlCmd.Parameters.AddWithValue("@paper_qty", PaperQuantity);
                        sqlCmd.Parameters.AddWithValue("@seller", Seller);
                        sqlCmd.Parameters.AddWithValue("@buyer", Buyer);
                        sqlCmd.Parameters.AddWithValue("@checker", Checker);
                        sqlCmd.Parameters.AddWithValue("@remarks", Remarks);

                        Connstring.conn.Open();
                        int Result = sqlCmd.ExecuteNonQuery();
                        Connstring.conn.Close();

                        if (Result == 1)
                        {
                            SaveDetailsData(WatageID);
                            lbl_sell.Text = "Saved Successfully.";

                            MakeID();
                        }
                        else
                        {
                            MessageBox.Show("Save failed.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Already Exist.");
                }
                                
            }
            else
            {
                MessageBox.Show("Please Select WatageID.");
            }

        }

        //.........Save details data.........
        private void SaveDetailsData(string WatageID) //Call Master Part
        {
            if (WatageID != "")
            {
                foreach (DataGridViewRow dgvRow in dgvOrderData.Rows)
                {
                    if (dgvRow.IsNewRow) break;
                    else
                    {
                        try
                        {
                            string sql = @"INSERT INTO prd.printing_wastage_details (pw_no, Item, Item_qty)
                                         VALUES (@pw_no, @Item, @Quantity)";

                            SqlCommand sqlCmd = new SqlCommand(sql, Connstring.conn);

                            sqlCmd.Parameters.AddWithValue("@pw_no", WatageID);
                            sqlCmd.Parameters.AddWithValue("@Item", dgvRow.Cells["Item"].Value);
                            sqlCmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(dgvRow.Cells["Quantity"].Value));

                            Connstring.conn.Open();
                            sqlCmd.ExecuteNonQuery();
                            Connstring.conn.Close();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
        }




        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lbl_sell.Text = "";
            cboPressCode.Text = "Please Select";
            cboPaperCode.Text = "Please Select";
            txtWatageID.Text = "";
            txtFormaQuantity.Text = "";
            txtPrintQuantity.Text = "";
            txtPaperQuantity.Text = "";
            txtSeller.Text = "";
            txtBuyer.Text = "";
            txtChecker.Text = "";
            txtRemarks.Text = "";

            MakeID();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {            
            AddNewRowToGridOrderItem();
        }

        private DataTable AddNewRowToGridOrderItem()
        {
            DataTable data = dt;
            dt_Grid2 = dgvOrderData.DataSource as DataTable;
            DataRow dr = null;
            dr = dt_Grid2.NewRow();

            string Item = txtItem.Text;
            string Quantity = txtQuantity.Text;

            dr["Item"] = Item;
            dr["Quantity"] = Quantity;
            dr["Action"] = "Remove";

            dt_Grid2.Rows.Add(dr);
            dgvOrderData.DataSource = dt_Grid2;
            return dt_Grid2;
        }


        //.........Removing item and quantity from grid view.........
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult myResult;
            
            if (e.ColumnIndex == 3) //Action - Remove: Column Index
            {
                myResult = MessageBox.Show("Are you really remove the item?", "Remove Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (myResult == DialogResult.OK)
                {
                    dgvOrderData.Rows.RemoveAt(e.RowIndex);
                }
            }
            
        }

        //.........Deleting datas.........
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string WatageID = txtWatageID.Text;

            DialogResult myResult;
            myResult = MessageBox.Show("Do you really want to delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                //Confirm delete
                if (WatageID != "")
                {


                    //Delete Details Data
                    string sqlDelete = @"DELETE 
                                   FROM  prd.printing_wastage_details
                                   WHERE   (pw_no = @WastageID)";

                    SqlCommand MyCommand1 = new SqlCommand(sqlDelete, Connstring.conn);


                    MyCommand1.Parameters.AddWithValue("@WastageID", WatageID);

                    Connstring.conn.Open();
                    int Result = MyCommand1.ExecuteNonQuery();
                    Connstring.conn.Close();

                    if (Result > 0)
                        // Master data
                    {

                        string sql = @"DELETE 
                                FROM            prd.printing_wastage_info
                                WHERE        (pw_no = @WatageID)";

                        SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);

                        MyCommand.Parameters.AddWithValue("@WatageID", WatageID);

                        Connstring.conn.Open();
                        MyCommand.ExecuteNonQuery();
                        Connstring.conn.Close();

                        lbl_sell.Text = "Deleted successfully.";
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed.");
                    }
                }
                else
                {
                    lbl_sell.Text = "Please select item.";
                }
            }
        }

        //.........Finding Datas.........
        private void txtFind_Click(object sender, EventArgs e)
        {
            string WatageID = txtFind.Text;
            if (WatageID != "")
            {
                FindData(WatageID);
            }
        }

        public void FindData(string WatageID)
        {
            string query = @"SELECT pw_no, date, press_code, paper_code, forma_qty, print_qty, paper_qty, seller, buyer, checker, remarks
                            FROM prd.printing_wastage_info
                            WHERE (pw_no = '" + WatageID + "')";
            if (WatageID != "")
            {
                try
                {
                    DataTable dt = Connstring.SqlDataTable(query);

                    if (dt.Rows.Count >= 1)
                    {
                        txtWatageID.Text = dt.Rows[0]["pw_no"].ToString();

                        cboPressCode.SelectedValue = dt.Rows[0]["press_code"].ToString();
                        cboPaperCode.SelectedValue = dt.Rows[0]["paper_code"].ToString();
                        txtDate.Text = dt.Rows[0]["date"].ToString();
                        txtFormaQuantity.Text = dt.Rows[0]["forma_qty"].ToString();
                        txtPrintQuantity.Text = dt.Rows[0]["print_qty"].ToString();
                        txtPaperQuantity.Text = dt.Rows[0]["paper_qty"].ToString();
                        txtSeller.Text = dt.Rows[0]["seller"].ToString();
                        txtBuyer.Text = dt.Rows[0]["buyer"].ToString();
                        txtChecker.Text = dt.Rows[0]["checker"].ToString();
                        txtRemarks.Text = dt.Rows[0]["remarks"].ToString();


                        LoadDetailsData(WatageID);
                      //  dt.Columns.Add(new DataColumn("Action", typeof(string)));
                     //   dgvOrderData.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Item not found.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {

                }
            }
        }


        //.........Loading details table data.........
        public void LoadDetailsData(string WatageID)
        {
            DataTable dt = Connstring.SqlDataTable(@"SELECT Item, Item_qty AS Quantity, pw_no, 'Remove' AS Action  
                                                  FROM            prd.printing_wastage_details
                                                  WHERE        (pw_no = '" + WatageID + "')");
              dgvOrderData.DataSource = dt;
           // dgvOrderData.Columns[0].Width = 212;
              dgvOrderData.Columns[2].Visible = false;
        }


        private void txtRemarks_TextChanged(object sender, EventArgs e)
        {

        }

        //.........Updating Datas.........
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string WatageID = txtWatageID.Text;
            string Date = txtDate.Value.ToString("yyyy-MM-dd");
            string FormaQuantity = txtFormaQuantity.Text;
            string PrintQuantity = txtPrintQuantity.Text;
            string PaperQuantity = txtPaperQuantity.Text;
            string Seller = txtSeller.Text;  
            string Buyer = txtBuyer.Text;
            string Checker = txtChecker.Text;
            string Remarks = txtRemarks.Text;
            string PressCode2 = cboPressCode.SelectedValue.ToString();
            string PaperCode2 = cboPaperCode.SelectedValue.ToString();



            if (WatageID != "")
            {
                string sql = @"UPDATE prd.printing_wastage_info
           SET pw_no =@WatageID, date =@Date, press_code =@PressCode2, paper_code =@PaperCode2, forma_qty =@FormaQuantity,
           print_qty =@PrintQuantity,paper_qty =@PaperQuantity, seller =@Seller, buyer =@Buyer, checker =@Checker, remarks =@Remarks
                             WHERE (pw_no = '" + WatageID + "')";

                SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);

                MyCommand.Parameters.AddWithValue("@WatageID", WatageID);
                MyCommand.Parameters.AddWithValue("@Date", Date);
                MyCommand.Parameters.AddWithValue("@PressCode2", PressCode2);
                MyCommand.Parameters.AddWithValue("@PaperCode2", PaperCode2);
                MyCommand.Parameters.AddWithValue("@FormaQuantity", FormaQuantity);
                MyCommand.Parameters.AddWithValue("@PrintQuantity", PrintQuantity);
                MyCommand.Parameters.AddWithValue("@PaperQuantity", PaperQuantity);
                MyCommand.Parameters.AddWithValue("@Seller", Seller);
                MyCommand.Parameters.AddWithValue("@Buyer", Buyer);
                MyCommand.Parameters.AddWithValue("@Checker", Checker);
                MyCommand.Parameters.AddWithValue("@Remarks", Remarks);

                Connstring.conn.Open();
                int Result = MyCommand.ExecuteNonQuery();
                Connstring.conn.Close();



                if (Result == 1)
                {
                    //Delete Details Data
                    string sqlDelete = @"DELETE 
                                      FROM prd.printing_wastage_details
                                      WHERE (pw_no = @WatageID)";

                    SqlCommand MyCommand1 = new SqlCommand(sqlDelete, Connstring.conn);

                    MyCommand1.Parameters.AddWithValue("@WatageID", WatageID);

                    Connstring.conn.Open();
                    MyCommand1.ExecuteNonQuery();
                    Connstring.conn.Close();

                    //Save New Details Data
                    SaveDetailsData(WatageID);
                    lbl_sell.Text = "Updated successfully.";
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
            else
            {
                lbl_sell.Text = "Please fill all required fields.";
            }
        }
            //.........Taking only numbers in forma quantity field.........

        private void txtFormaQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //.........Taking only numbers in Print quantity field.........
        private void txtPrintQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //.........Taking only numbers in paper quantity field.........
        private void txtPaperQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //.........Taking only numbers in quantity field.........
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void wastageBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
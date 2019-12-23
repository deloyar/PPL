
using CrystalDecisions.CrystalReports.Engine;
using PRP.PPL.Data.Distribution.Challan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRP.Data.Inventory.Challan
{
    public partial class pplDataDistribution_Challan : Form
    {
        public void PassValue(string strValue)
        {
            txt_item_code.Text = strValue;
            txt_item_code.Focus();
        }    
        DataTable dt = new DataTable();
        DataTable dt_Grid = new DataTable();
        DataTable dt_hold = new DataTable();
        report_viwer Rpt_Viewer = new report_viwer();
        db_ppl Connstring = new db_ppl();
        internal string showme;

        public pplDataDistribution_Challan()
        {
            InitializeComponent();
        }

        private void Challan_Load(object sender, EventArgs e)
        {
            Creat_GridView();      
            ToBranch();
            FromBranch();
            Category();
            voucher_no();
            txt_userid.Text = showme;
            lbl_sell.Text = "";
        }
        //---Grid View Column Initializing 
        private void Creat_GridView()
        {
            DataTable dt1 = new DataTable();
            dt1.Columns.Add(new DataColumn("SubItemCode", typeof(string)));
            dt1.Columns.Add(new DataColumn("SubItemName", typeof(string)));
            dt1.Columns.Add(new DataColumn("Quantity", typeof(float)));
            dt1.Columns.Add(new DataColumn("Action", typeof(string)));
            dt1.Columns.Add(new DataColumn("Purchase", typeof(string)));
            DT_GridView.DataSource = dt1;
        }
        //---Product Category Load
        public void Category()
        {

            try
            {
                cboCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
                DataTable dataTable = Connstring.SqlDataTable(@"SELECT ID, Name FROM Inv.ProductCategory ORDER BY ID");
                if (dataTable.Rows.Count > 0)
                {
                    cboCategory.DataSource = dataTable;
                    cboCategory.DisplayMember = "Name";
                    cboCategory.ValueMember = "ID";
                    cboCategory.SelectedIndex = cboCategory.FindString("Name of a item");
                    cboCategory.SelectedText = "";
                    cboCategory.SelectedText = "---- Select Please ----";
                    txtItemName.Text = "1";

                }
                else
                {
                    cboCategory.DataSource = dataTable;
                    cboCategory.ValueMember = "";
                }

            }
            catch
            {


            }
        }
        //--- Product  Load Based on Product Category
        public void CategoryWiseItem()
        {
            try
            {
                cboitemList.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboitemList.AutoCompleteSource = AutoCompleteSource.ListItems;
                DataTable dataTable = Connstring.SqlDataTable(@"SELECT  Code, Name FROM Inv.Product WHERE        (ProductCategoryID = '" + cboCategory.SelectedValue + "')");
                if (dataTable.Rows.Count > 0)
                {
                    m_combo.DataSource = dataTable;
                    m_combo.DisplayMember = "Name";
                    m_combo.ValueMember = "Code";
                    cboitemList.DataSource = dataTable;
                    cboitemList.DisplayMember = "Name";
                    cboitemList.ValueMember = "Code";
                }
                else
                {
                    m_combo.DataSource = dataTable;
                    m_combo.DisplayMember = "Name";
                    m_combo.ValueMember = "Code";
                    cboitemList.DataSource = dataTable;
                    cboitemList.DisplayMember = "";
                    cboitemList.ValueMember = "";
                }

            }
            catch
            {


            }

        }
        //---- Voucher No Load
        public void voucher_no()
        {
            try
            {
                string year = DateTime.Now.ToString("yy");
                string month = DateTime.Now.ToString("MM");
                string Newmonth = month;
                if (month == "11" || month == "12" || month == "10")
                {
                    Newmonth = month;
                }
                else
                {
                    Newmonth = month.Substring(1);
                }

                DataTable dt = Connstring.SqlDataTable(@"SELECT        MAX(No) AS Max, MONTH(AddDate) AS Month
FROM             Inv.Chalan
GROUP BY MONTH(AddDate)
HAVING        (MONTH(AddDate) = '" + Newmonth + "')");
                if (dt.Rows.Count >= 1)
                {
                    string sqldata = dt.Rows[0]["MAX"].ToString();
                    string[] tokens = sqldata.Split('-');
                    string middle = tokens[tokens.Length - 2];
                    string increment = Convert.ToString(Convert.ToInt32(middle.ToString()) + 1);
                    string zero = "000000";
                    int get_lengt = zero.Length - increment.Length;
                    string lenght = zero.Substring(0, get_lengt);
                    string cash_memo = lenght + increment;
                    Txt_cash_memo_no.Text = year + "-" + cash_memo + "-" + month;
                }
                else
                {
                    Txt_cash_memo_no.Text = year + "-" + "000001" + "-" + month;
                }

            }
            catch(Exception Ex)
            {
                MessageBox.Show("Database Connection Faild OR User is out of SalesCounter", "Alart", MessageBoxButtons.OK, MessageBoxIcon.Warning);               
            }
            Connstring.conn.Close();

        }
        //---- Branch combo Box Load
        public void ToBranch()
        {
            try
            {
                DataTable dataTableTobranch = Connstring.SqlDataTable(@"SELECT        Code, Name FROM            SalesCenter");
                if (dataTableTobranch.Rows.Count > 0)
                {
                    cboToBranch.DataSource = dataTableTobranch;
                    cboToBranch.DisplayMember = "Name";
                    cboToBranch.ValueMember = "Code";
                }
                else
                {
                    cboToBranch.DataSource = dataTableTobranch;
                    cboToBranch.DisplayMember = "";
                    cboToBranch.ValueMember = "";               
                }

            }
            catch
            {


            }
        }

        //---- Branch combo Box Load
        public void FromBranch()
        {
            try
            {
                DataTable dataTableFromBranch = Connstring.SqlDataTable(@"SELECT Code, Name FROM SalesCenter WHERE        (Code = N'101')");
                if (dataTableFromBranch.Rows.Count > 0)
                {
                    cboFromBranch.DataSource = dataTableFromBranch;
                    cboFromBranch.DisplayMember = "Name";
                    cboFromBranch.ValueMember = "Code";                  
                }
                else
                {
                    cboFromBranch.DataSource = dataTableFromBranch;
                    cboFromBranch.DisplayMember = "";
                    cboFromBranch.ValueMember = "";
                }

            }
            catch
            {


            }

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtItemName.Text == "1")
            {
                CategoryWiseItem();
            }
        }
        
        //---------------------Item Information------------//
         public void Item_entry()
        {
            dt = Connstring.SqlDataTable(@"SELECT        Code, Name,PurchasePrice
            FROM            Inv.Product
            WHERE        (Code = '" + cboitemList.SelectedValue +"')");
            if (dt.Rows.Count >= 1)
            {
                txt_rate.Text = dt.Rows[0]["PurchasePrice"].ToString();
                txt_book_name.Text = dt.Rows[0]["Name"].ToString();
                txt_book_name_bn.Text = dt.Rows[0]["Name"].ToString();
                txt_edition.Text = "0";
                txt_book_code.Text = dt.Rows[0]["Code"].ToString();
                if (Convert.ToDouble(dt.Rows[0]["PurchasePrice"].ToString()) <= 0)
                {
                    txt_rate.Focus();
                }
                else
                {
                  txt_quantity.Focus();
                }

                StockCheck();
            }
            else
            {

            }

        }

        private void cboitemList_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void cboitemList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                try
                {

                    Item_entry();
                }
                catch
                {
                    MessageBox.Show("Please Re-Try", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void cboitemList_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    Item_entry();
                }
                catch
                {
                    MessageBox.Show("Please Re-Try", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Item_entry();
            }
            catch
            {

            }
        }
        //------------------
        public void grid_edit()
        {
            if (txt_row_index.Text == "")
            {
                MessageBox.Show("Row index Missing ! Please select Quantity");
                return;
            }
            else
            {
                int row_index = Convert.ToInt32(txt_row_index.Text);
                DT_GridView.Rows[row_index].Cells["Com"].Value = txt_quantity.Text;               
                txt_quantity.BackColor = Color.White;
                float Total_quantity = float.Parse(dt_Grid.Compute("sum(Quantity)", string.Empty).ToString());
                txt_total_quantity.Text = Total_quantity.ToString();    

            }
        }
        //---
        public void grid_double_data_check()
        {
            string searchValue = txt_book_code.Text;
            foreach (DataGridViewRow row in DT_GridView.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(searchValue))
                {
                    //row.Selected = true;
                    //txt_quantity.Text = row.Cells[4].Value.ToString();
                    int cell_quantity = Convert.ToInt32(row.Cells[4].Value.ToString());
                    int new_quantity = Convert.ToInt32(txt_quantity.Text);
                    string result = (cell_quantity + new_quantity).ToString();
                    row.Cells[4].Value = result;
                    //For total and net summation and also total quantity
                    Double amount = Convert.ToDouble(row.Cells[3].Value.ToString()) * Convert.ToDouble(result);
                    row.Cells[5].Value = amount.ToString();
                    float TotalOrder = float.Parse(dt_Grid.Compute("sum(Amount)", string.Empty).ToString());
                    txt_total.Text = TotalOrder.ToString();
                    txt_net_amount.Text = txt_total.Text;
                    //discount 
                    double discount_per = Convert.ToDouble(txt_total.Text) / 100;
                    double total_discount = discount_per * Convert.ToDouble(txt_discount.Text);
                    txt_net_amount.Text = (Convert.ToDouble(txt_total.Text) - Convert.ToDouble(total_discount)).ToString();
                    //Quantity
                    float Total_quantity = float.Parse(dt_Grid.Compute("sum(Quantity)", string.Empty).ToString());
                    txt_total_quantity.Text = Total_quantity.ToString();
                    //amount to be paid//             
                    txt_memo_type.Text = "new";
                    txt_dup_book.Text = "Done";
                    return;
                }
            }

        }
        //-----
        public void blank_data()
        {
            txt_item_code.Text = "";
            txt_rate.Text = "0";
            txt_quantity.Text = "1";
            txt_edition.Text = "";
            txt_book_name.Text = "";
            txt_book_name_bn.Text = "";
            txt_book_code.Text = "";
            txt_row_index.Text = "";
            txt_dup_book.Text = "";
            txt_comments.Text = "";
            txt_item_code.Focus();
            // cboitemList.Focus();  
            lblCurentStock.Text = "0";

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        //--- Add temporary Data To GridView
        private DataTable AddNewRowToGrid()
        {
            string quanity = txt_quantity.Text;
            string rate = txt_rate.Text;
            double amount = Convert.ToDouble(rate) * Convert.ToDouble(quanity);
            double Commission = amount / 100 * Convert.ToDouble(txtCommission.Text);
            double FinalCommission = amount - Commission;
            double Price = Convert.ToDouble(txt_rate.Text) - Commission;
            DataTable data = dt;
            dt_Grid = DT_GridView.DataSource as DataTable;
            if (DT_GridView.Rows.Count == 0)
            {
                DataRow dr = null;
                dr = dt_Grid.NewRow();
                dr["SubItemCode"] = txt_book_code.Text;
                dr["SubItemName"] = txt_book_name.Text;
                dr["Quantity"] = txt_quantity.Text;              
                //---
                dr["Action"] = "Remove";
                dt_Grid.Rows.Add(dr);
            }
            else if (DT_GridView.Rows.Count > 0)
            {
                DataRow dr;
                dr = dt_Grid.NewRow();
                dr["SubItemCode"] = txt_book_code.Text;
                dr["SubItemName"] = txt_book_name.Text;
                dr["Quantity"] = txt_quantity.Text;             
                //---
                dr["Action"] = "Remove";
                dt_Grid.Rows.InsertAt(dr, 0);
                //dt_Grid.Rows.Add(dr);
                //dt_Grid.Rows(0).Selected = True

            }
            DT_GridView.DataSource = dt_Grid;           
            float Total_quantity = float.Parse(dt_Grid.Compute("sum(Quantity)", string.Empty).ToString());
            txt_total_quantity.Text = Total_quantity.ToString();
            txt_memo_type.Text = "new";
            //---
            double discount_per = Convert.ToDouble(txt_total.Text) / 100;
            double total_discount = discount_per * Convert.ToDouble(txt_discount.Text);
            // btn_sell.Enabled = true;
            cboFromBranch.Enabled = false;
            cboToBranch.Enabled = false;
            return dt_Grid;

        }
        //--- item laod
        public void item_load()
        {
            Connstring.conn.Close();
            dt = Connstring.SqlDataTable(@"SELECT        TOP (100) PERCENT Name, Code,PurchasePrice
            FROM            Inv.Product
            GROUP BY Name, Code,  PurchasePrice
            HAVING        (Code ='" + txt_item_code.Text + "')");
            if (dt.Rows.Count >= 2)
            {
                //isbn_entry isbn = new isbn_entry(this);
                //isbn.isbn_code = txt_item_code.Text;
                //isbn.Show();
                //return;
            }
            else
            {
                txt_book_code.Text = dt.Rows[0]["Code"].ToString();
                item_info();

            }
        }
        //----
        public void item_info()
        {
            try
            {
                dt = Connstring.SqlDataTable(@"SELECT        TOP (100) PERCENT Name, Code,PurchasePrice
            FROM            Inv.Product
            GROUP BY Name, Code,  PurchasePrice
            HAVING        (Code ='" + txt_item_code.Text + "')");
                if (dt.Rows.Count >= 2)
                {

                }
                else
                {
                    txt_rate.Text = dt.Rows[0]["PurchasePrice"].ToString();
                    txt_book_name.Text = dt.Rows[0]["Name"].ToString();
                    txt_book_name_bn.Text = dt.Rows[0]["Name"].ToString();
                    txt_edition.Text = "0";
                    txt_book_code.Text = dt.Rows[0]["Code"].ToString();
                    txt_quantity.Focus();                   

                }
            }

            catch
            {
                MessageBox.Show("Please Re-Try", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Connstring.conn.Close();
            }
            Connstring.conn.Close();

        }

        private void txt_item_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyChar) == 13)
                {
                    // txt_entry_type.Text ="texbox";
                    item_load();
                    StockCheck();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Item Code", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void StockCheck()
        {
            //            try
            //            {
            //                string ItemCode = txt_item_code.Text;
            //                dt = Connstring.SqlDataTable(@"SELECT        dbo.SalesCenter.Name AS BranchName, vinv.BranchWiseItem.Stock, vinv.BranchWiseItem.ProductCode, vinv.BranchWiseItem.BranchCode
            //FROM            vinv.BranchWiseItem INNER JOIN
            //                         dbo.SalesCenter ON vinv.BranchWiseItem.BranchCode = dbo.SalesCenter.Code
            //WHERE        (vinv.BranchWiseItem.ProductCode = N'" + txt_book_code.Text + "') AND (vinv.BranchWiseItem.BranchCode = N'" + cboFromBranch.SelectedValue + "')");
            //                if (dt.Rows.Count > 0)
            //                {
            //                   // lblCurentStock.Text = dt.Rows[0]["Stock"].ToString();
            //                    lblCurentStock.Text = "80";
            //                }
            //                else
            //                {
            //                    lblCurentStock.Text = "0";
            //                }
            //            }
            //            catch
            //            {

            //            }
            lblCurentStock.Text = "80";


        }
        private void btn_item_load_Click(object sender, EventArgs e)
        {

        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
           try
           {
            int Quantity = Convert.ToInt32(txt_quantity.Text);            
            if (Quantity < 1)
            {
                    MessageBox.Show("Insert Quantity Properly");
            }
            else
            {
                 if (txt_book_name.Text == "" && txt_book_code.Text == "" && txt_book_code.Text == "" && txt_rate.Text == "0")
                    {
                        grid_edit();
                    }
                    else
                    {
                    if (txt_book_name.Text == "" && txt_book_code.Text == "" && txt_book_code.Text == "" && txt_rate.Text == "0")
                    {
                        MessageBox.Show("Please Re-try");
                        return;
                    }
                        //  Grid Double Data Check
                        string searchValue = txt_book_code.Text;
                        foreach (DataGridViewRow row in DT_GridView.Rows)
                        {
                            if (row.Cells[0].Value.ToString().Equals(searchValue))
                            {
                                int cell_quantity = Convert.ToInt32(row.Cells[2].Value.ToString());
                                int new_quantity = Convert.ToInt32(txt_quantity.Text);
                                string result = (cell_quantity + new_quantity).ToString();                           
                                int ChalalnQuantity =Convert.ToInt32(result);
                                int CurrentStock = Convert.ToInt32(lblCurentStock.Text);
                                if (ChalalnQuantity <= CurrentStock)
                                {
                                    row.Cells[2].Value = result;
                                }
                                else
                                {                                
                                    MessageBox.Show("not enough stock");
                                 
                                }
                                    txt_item_code.Focus();
                                    blank_data();
                                    return;
                                }
                        }
                     if (txt_dup_book.Text != "Done")
                    {
                                //----Check Code And Name
                                if (txt_book_name.Text != "" && txt_book_code.Text != "")
                                {
                                    int ChalalnQuantity = Convert.ToInt32(txt_quantity.Text);
                                    int CurrentStock = Convert.ToInt32(lblCurentStock.Text);
                                    if (ChalalnQuantity <= CurrentStock)
                                    {
                                        AddNewRowToGrid();
                                        blank_data();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Not Enough Stock");
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please Insert Data Properly !! Item Code or Name is Blank");                                   
                                }
                            
                     }
                        blank_data();
                    }   

                }          
            }
            catch
            {
                MessageBox.Show("Please Re-try");
            }
            }
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {

        }

        private void Txt_cash_memo_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                date_start.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete is Disable !! Please Communicate with MIS Department");
        }

        private void date_start_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                cboFromBranch.Focus();
            }
        }

        private void cboFromBranch_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void cboFromBranch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboToBranch.Focus();
            }

      }

        private void cboToBranch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_item_code.Focus();
            }
       }

        private void DT_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DT_GridView.Rows.RemoveAt(e.RowIndex);
            }
            if (e.ColumnIndex == 2)
            {
                txt_quantity.Text = DT_GridView.Rows[e.RowIndex].Cells["Com"].Value.ToString();
                txt_row_index.Text = e.RowIndex.ToString();
                txt_quantity.Focus();
                txt_quantity.BackColor = Color.Yellow;
                txt_quantity.ForeColor = Color.Red;
            }
            if (dt_Grid.Rows.Count != 0)
            {
                float TotalOrder = float.Parse(dt_Grid.Compute("sum(Quantity)", string.Empty).ToString());
                txt_total.Text = TotalOrder.ToString();
                //txtTotal.Text = TotalOrder.ToString();
                // txt_net_amount.Text = TotalOrder.ToString();
                // float Total_Quantity = float.Parse(dt_Grid.Compute("sum(Quantity)", string.Empty).ToString());
                //  txtQuantity.Text = Total_Quantity.ToString();
                // double result = 0;
                // result = Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(txtTotalDiscount.Text) + Convert.ToDouble(txtSellReturn.Text) + Convert.ToDouble(txtAdjust.Text) + Convert.ToDouble(txtPackingCost.Text) + Convert.ToDouble(txtTransportCost.Text);
                //  txt_net_amount.Text = result.ToString();

            }
            if (dt_Grid.Rows.Count == 0)
            {
                txt_total.Text = "0";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            voucher_no();
            Creat_GridView();
           // Sales_Counter();
            txt_total.Text = "0";
        }

        private void lbl_sell_Click(object sender, EventArgs e)
        {

        }
        //-- Save master Information
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cboFromBranch.Text == cboToBranch.Text)
            {
                MessageBox.Show("Please Check Branch Name");
                return;
            }
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Save", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (;;)
                {
                    voucher_no();
                    DataTable dt = Connstring.SqlDataTable(@"SELECT  No FROM  Inv.Chalan WHERE (No= '" + Txt_cash_memo_no.Text + "')");
                    if (dt.Rows.Count == 0)
                    {
                        dt_Grid = DT_GridView.DataSource as DataTable;
                       
                            string computer_name = System.Net.Dns.GetHostName();
                            if (DT_GridView.RowCount >= 1)
                            {
                                string sql = @"INSERT INTO Inv.Chalan
                         (No, Date, FromBranchCode, ToBranchCode, Remark, AddUser, ComputerName)
                    VALUES(@No, @Date, @FromBranchCode, @ToBranchCode, @Remark, @AddUser, @ComputerName)";
                                SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);
                                MyCommand.Parameters.AddWithValue("@No", Txt_cash_memo_no.Text);
                                string date = date_start.Value.ToString("yyyy-MM-dd");
                                MyCommand.Parameters.AddWithValue("@Date", date);
                                MyCommand.Parameters.AddWithValue("@FromBranchCode", cboFromBranch.SelectedValue);
                                MyCommand.Parameters.AddWithValue("@ToBranchCode", cboToBranch.SelectedValue);
                                MyCommand.Parameters.AddWithValue("@Remark", txt_comments.Text);
                                MyCommand.Parameters.AddWithValue("@ComputerName", computer_name);
                                MyCommand.Parameters.AddWithValue("@AddUser", txt_userid.Text);
                                Connstring.conn.Open();
                                int a = MyCommand.ExecuteNonQuery();
                                Connstring.conn.Close();
                                if (a == 1)
                                {
                                    save_details();
                                }
                                else
                                {
                                    MessageBox.Show("Save Faild");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Insert Data Properly");
                            }
                            break;
                        }
                    }

                }
            }

            catch
            {
                Connstring.conn.Close();

            }

        }
        //--- Save Detail Information
        public void save_details()
        {
            dt_Grid = DT_GridView.DataSource as DataTable;
            for (int i = 0; i < dt_Grid.Rows.Count; i++)
            {
                string sql = @"INSERT INTO Inv.ChalanDetail
                         (ChalanNo, ProductCode, Quantity) 
                    VALUES(@ChalanNo, @ProductCode, @Quantity)";
                SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);
                MyCommand.Parameters.AddWithValue("@ChalanNo", Txt_cash_memo_no.Text);
                MyCommand.Parameters.AddWithValue("@ProductCode", dt_Grid.Rows[i]["SubItemCode"].ToString().Trim());     
                MyCommand.Parameters.AddWithValue("@Quantity", dt_Grid.Rows[i]["Quantity"].ToString().Trim());    
                Connstring.conn.Open();
                MyCommand.ExecuteNonQuery();
                Connstring.conn.Close();
            }
            blank_data();
            dt_Grid.Clear();
           // voucher_no();
            txt_total.Text = "0";
            lbl_sell.Text = "Done";
            cboFromBranch.Enabled = true;
            cboToBranch.Enabled = true;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Chalan sal = new Chalan();
            ReportDocument cryRpt = new ReportDocument();
            cryRpt = sal;
            DataTable formula = Connstring.SqlDataTable(@"SELECT  No, CONVERT(CHAR(10), Date, 103) AS Date, FromBranch, ToBranch, Remark, ProductCode, ProductName, Quantity
            FROM vinv.Chalan WHERE (No = '" + Txt_cash_memo_no.Text + "')");
            cryRpt.SetDataSource(formula);
            Rpt_Viewer.RptDoc = cryRpt;
            Rpt_Viewer.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void btn_voucher_find_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = false;
            dt_Grid.Clear();
            DataTable dt = Connstring.SqlDataTable(@"SELECT Inv.Chalan.No, Inv.Chalan.Date, Inv.Chalan.FromBranchCode, Inv.Chalan.ToBranchCode, Inv.Chalan.Remark, Inv.Product.Name, Inv.ChalanDetail.ProductCode, Inv.ChalanDetail.Quantity
            FROM            Inv.Chalan INNER JOIN
            Inv.ChalanDetail ON Inv.Chalan.No = Inv.ChalanDetail.ChalanNo INNER JOIN
            Inv.Product ON Inv.ChalanDetail.ProductCode = Inv.Product.Code
            WHERE        (Inv.Chalan.No = N'"+ Txt_cash_memo_no .Text + "')");
            if (dt.Rows.Count >= 1)
            {
                dt_Grid = DT_GridView.DataSource as DataTable;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = null;
                    dr = dt_Grid.NewRow();
                    dr["SubItemCode"] = dt.Rows[i]["ProductCode"].ToString();
                    dr["SubItemName"] = dt.Rows[i]["Name"].ToString();
                    dr["Quantity"] = dt.Rows[i]["Quantity"].ToString();    
                    dr["Action"] = "Remove";
                    dt_Grid.Rows.Add(dr);                    
                    //txt_net_amount.Text = txt_total.Text;
                    date_start.Text = dt.Rows[0]["Date"].ToString();
                    cboFromBranch.SelectedValue = dt.Rows[0]["FromBranchCode"].ToString();
                    cboToBranch.SelectedValue = dt.Rows[0]["ToBranchCode"].ToString();
                    float TotalOrder = float.Parse(dt_Grid.Compute("sum(Quantity)", string.Empty).ToString());
                    txt_comments.Text = dt.Rows[0]["Remark"].ToString();
                    txt_total.Text = TotalOrder.ToString();
                }
            }
            else
            {
                MessageBox.Show("No Item Found !!", "Alart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_memo_Click(object sender, EventArgs e)
        {
            //DataTable dt = Connstring.SqlDataTable(@"SELECT ChalanNo FROM  Inv.ChalanReceive WHERE  (ChalanNo = N'"+ Txt_cash_memo_no.Text + "')");
            //if (dt.Rows.Count >= 1)
            //{
            //    MessageBox.Show("আপানার চালানটি Update করতে পারবেন না !! কারন এটি রিসিভ হয়ে গিয়েছে । সঠিক কারণ উল্লেখ করে Requisition দিয়ে Update করতে হবে ।");
            //    return;
            //}

            if (DT_GridView.RowCount >= 1)
            {
                update_master();
            }
            else
            {
                MessageBox.Show("Insert Data Properly");
            }
               
           
          
        }
        //--- Update Master Information 
        public void update_master()
        {
            string sql = @"UPDATE       Inv.Chalan
SET               Date =@Date, FromBranchCode =@FromBranchCode, ToBranchCode =@ToBranchCode, Remark =@Remark, EditDate =@EditDate, EditUser =@EditUser
WHERE        (No = @No)";
            SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);
            MyCommand.Parameters.AddWithValue("@No", Txt_cash_memo_no.Text.ToString());
            string date = date_start.Value.ToString("yyyy-MM-dd");
            MyCommand.Parameters.AddWithValue("@Date", date.ToString());
            MyCommand.Parameters.AddWithValue("@Remark", txt_comments.Text);         
            MyCommand.Parameters.AddWithValue("@FromBranchCode", cboFromBranch.SelectedValue);
            MyCommand.Parameters.AddWithValue("@ToBranchCode", cboToBranch.SelectedValue);
            MyCommand.Parameters.AddWithValue("@EditUser", txt_userid.Text);
            MyCommand.Parameters.AddWithValue("@EditDate", DateTime.Now);
            Connstring.conn.Open();
            MyCommand.ExecuteNonQuery();
            Connstring.conn.Close();
            deatails_update();
        }
        //--- Update Dertail Information
        public void deatails_update()
        {
            string qurey = "DELETE FROM Inv.ChalanDetail WHERE  (ChalanNo = '" + Txt_cash_memo_no.Text + "')";
            Connstring.insert(qurey);
            dt_Grid = DT_GridView.DataSource as DataTable;
            for (int i = 0; i < dt_Grid.Rows.Count; i++)
            {
                string sql = @"INSERT INTO Inv.ChalanDetail
                         (ChalanNo, ProductCode, Quantity) 
                    VALUES(@ChalanNo, @ProductCode, @Quantity)";
                SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);
                MyCommand.Parameters.AddWithValue("@ChalanNo", Txt_cash_memo_no.Text);
                MyCommand.Parameters.AddWithValue("@ProductCode", dt_Grid.Rows[i]["SubItemCode"].ToString().Trim());
                MyCommand.Parameters.AddWithValue("@Quantity", dt_Grid.Rows[i]["Quantity"].ToString().Trim());
                Connstring.conn.Open();
                MyCommand.ExecuteNonQuery();
                Connstring.conn.Close();
            }   
            txt_total.Text = "0";
            lbl_sell.Text = "Data Updated";

        }
        private void btn_last_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            blank_data();
            voucher_no();
            dt_Grid.Clear();
            lbl_sell.Text = "";
            cboFromBranch.Enabled = true;
            cboToBranch.Enabled = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
         //   FindItemCodeChalan SearchProduct = new FindItemCodeChalan(this);
           // SearchProduct.Show();
        }

        private void txtPurchaseNo_KeyPress(object sender, KeyPressEventArgs e)
        {
      }

        private void txt_quantity_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnItemUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete is Disable !! Please Communicate with MIS Department");
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            Chalan sal = new Chalan();
            ReportDocument cryRpt = new ReportDocument();
            cryRpt = sal;
            DataTable formula = Connstring.SqlDataTable(@"SELECT  No, CONVERT(CHAR(10), Date, 103) AS Date, FromBranch, ToBranch, Remark, ProductCode, ProductName, Quantity
            FROM vinv.Chalan WHERE (No = '" + Txt_cash_memo_no.Text + "')");
            cryRpt.SetDataSource(formula);
            Rpt_Viewer.RptDoc = cryRpt;
            Rpt_Viewer.ShowDialog();
            Cursor.Current = Cursors.Default;
        }



        //Convert Datatable to list
        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        //Get item using reflection
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

        private void cboitemListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Value changed");
            var abc = new List<String>();
            abc.Add("sdfs");
            abc.Add("dsfs");
            this.cboitemList.DataSource = abc;
            //DataTable(this.cboitemList.DataSource)
        }
    }
}

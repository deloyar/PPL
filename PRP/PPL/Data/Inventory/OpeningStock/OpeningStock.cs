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

namespace PRP.Data.Inventory.OpeningStock
{
    public partial class PplDataInventory_OpeningStock : Form
    {
       
        DataTable dt = new DataTable();
        DataTable dt_Grid = new DataTable();
        DataTable dt_hold = new DataTable();
        report_viwer Rpt_Viewer = new report_viwer();

        db_ppl Connstring = new db_ppl();
        internal string showme;

        public PplDataInventory_OpeningStock()
        {
            InitializeComponent();
        }

        private void OpeningStock_Load(object sender, EventArgs e)
        {
            //voucher_no();
            //Creat_GridView();
            //Sales_Counter();
            //txt_userid.Text = showme;
          
        }
        //------------

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
FROM             Inv.OpeningStock
GROUP BY MONTH(AddDate)
HAVING        (MONTH(AddDate) = '" + Newmonth + "')");
                if (dt.Rows.Count >= 1)
                {
                    string sqldata = dt.Rows[0]["MAX"].ToString();
                    string[] tokens = sqldata.Split('-');
                    string middle = tokens[tokens.Length - 2];
                    string increment = Convert.ToString(Convert.ToInt32(middle.ToString()) + 1);
                    string zero = "00000";
                    int get_lengt = zero.Length - increment.Length;
                    string lenght = zero.Substring(0, get_lengt);
                    string cash_memo = lenght + increment;
                    Txt_cash_memo_no.Text = year + "-" + cash_memo + "-" + month;
                }
                else
                {
                    Txt_cash_memo_no.Text = year + "-" + "00001" + "-" + month;
                }

            }
            catch
            {
                MessageBox.Show("Database Connection Faild OR User is out of SalesCounter", "Alart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //btn_save.Enabled = false;
                //btn_report.Enabled = false;
            }
            Connstring.conn.Close();

        }
        //--------
     
        public void Sales_Counter()
        {
            DataTable dataTable = Connstring.SqlDataTable(@"SELECT Code, Name FROM SalesCenter");
            SalesCounter.DataSource = dataTable;
            SalesCounter.DisplayMember = "Name";
            SalesCounter.ValueMember = "Code";
            //cmb_library_code.SelectedIndex = cmb_library_code.FindString("Name of a item");
            //cmb_library_code.SelectedText = "-----------   Select Please  -----------";          
            SalesCounter.SelectedIndex = SalesCounter.FindString("Shantinagar Branch");
            SalesCounter.SelectedText = "Select Please";

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_item_load_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    dt = Connstring.SqlDataTable(@"SELECT        TOP (100) PERCENT Inv.Product.Name, Inv.ProductPrice.Price, MAX(Inv.ProductPrice.Date) AS Date, Inv.Product.Code, Inv.Unit.Code AS Unit, Inv.Product.ExistingItemCode
            //        FROM            Inv.Product INNER JOIN  Inv.ProductPrice ON Inv.Product.Code = Inv.ProductPrice.ProductCode INNER JOIN
            //        Inv.Unit ON Inv.Product.UnitID = Inv.Unit.ID  GROUP BY Inv.ProductPrice.Price, Inv.Product.Name, Inv.Product.Code, Inv.Unit.Code, Inv.Product.ExistingItemCode
            //        HAVING (Inv.Product.Code = '" + txt_item_code.Text + "') OR (Inv.Product.ExistingItemCode = '" + txt_item_code.Text + "')ORDER BY Date DESC");             
            //    txt_item_name.Text = dt.Rows[0]["Name"].ToString();
            //    Unit.Text = dt.Rows[0]["Unit"].ToString();
            //    txt_quantity.Focus();

            //}
            //catch
            //{
            //    MessageBox.Show("Invalid Product Code", "Alart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void btnQuantity_Click(object sender, EventArgs e)
        {
            double Price = Convert.ToDouble(txt_rate.Text);
            if (Price <= 0)
            {
                MessageBox.Show("Please Check Price");
                return;
            }
            //--
            if (Convert.ToInt32(txt_quantity.Text) > 5)
            {
                MessageBox.Show("Entry Limit Exceeded");
            }
            else
            {
                if (txt_quantity.Text != "")
                {
                    AddNewRowToGrid();
                }
                else
                {

                    MessageBox.Show("Please Insert Quantity");
                }
            }
          
        }
        private DataTable AddNewRowToGrid()
        {
            if (txt_item_code.Text != "" && txt_item_name.Text != "" && txt_rate.Text != "")
            {
                //---Total amount
                string quanity = txt_quantity.Text;
                string rate = txt_rate.Text;
                double amount = Convert.ToDouble(rate) * Convert.ToDouble(quanity);
                //-------             
                //-----
                DataTable data = dt;
                dt_Grid = DT_GridView.DataSource as DataTable;
                if (DT_GridView.Rows.Count == 0)
                {
                    DataRow dr = null;
                    dr = dt_Grid.NewRow();
                    dr["SubItemCode"] = txt_item_code.Text;
                    dr["SubItemName"] = txt_item_name.Text;
                    dr["Quantity"] = txt_quantity.Text;
                    dr["ClosingPrice"] = txt_rate.Text;                   
                    dr["Amount"] = amount;
                    dr["Unit"] = Unit.Text;
                    dr["Supplier"] = txtSupplier.Text;
                    dr["Action"] = "Remove";
                    dt_Grid.Rows.Add(dr);
                }
                else if (DT_GridView.Rows.Count > 0)
                {
                    DataRow dr;
                    dr = dt_Grid.NewRow();
                    dr["SubItemCode"] = txt_item_code.Text;
                    dr["SubItemName"] = txt_item_name.Text;
                    dr["Quantity"] = txt_quantity.Text;
                    dr["ClosingPrice"] = txt_rate.Text;                  
                    dr["Amount"] = amount;
                    dr["Unit"] = Unit.Text;
                    dr["Supplier"] = txtSupplier.Text;
                    dr["Action"] = "Remove";
                    dt_Grid.Rows.InsertAt(dr, 0);
                    // ViewState["CurrentTable"] = dt;
                }
                DT_GridView.DataSource = dt_Grid;
                float TotalOrder = float.Parse(dt_Grid.Compute("sum(Amount)", string.Empty).ToString());
                txt_total.Text = TotalOrder.ToString();
               // float Total_commission = float.Parse(dt_Grid.Compute("sum(CommTotal)", string.Empty).ToString());
               // float Total_Quantity = float.Parse(dt_Grid.Compute("sum(Quantity)", string.Empty).ToString());
                //txtQuantity.Text = Total_Quantity.ToString();
                //txtTotalDiscount.Text = Convert.ToString(float.Parse(dt_Grid.Compute("sum(CommTotal)", string.Empty).ToString()));
                //txt_net_amount.Text = Convert.ToString(Convert.ToDouble(txt_total.Text) - Convert.ToDouble(txtTotalDiscount.Text));
                blank_data();
            }
            else
            {
                MessageBox.Show("Insert Data Properly");
            }
            return dt_Grid;
        }
        //-----
        public void blank_data()
        {
            txt_item_code.Text = "";
            txt_rate.Text = "";
            txt_quantity.Text = "1";
            txt_rate.Text = "";
            txtSupplier.Text = "";
            txt_item_code.Focus();
            txt_item_name.Text = "";    
        }

        private void txt_item_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyChar) == 13)

                {
                    dt = Connstring.SqlDataTable(@"SELECT        TOP (100) PERCENT Inv.Product.Name, Inv.Product.Code, Inv.Unit.Code AS Unit, Inv.Product.ExistingItemCode, Inv.Product.PurchasePrice, Inv.Product.SupplierCode
                    FROM Inv.Product INNER JOIN Inv.Unit ON Inv.Product.UnitID = Inv.Unit.ID GROUP BY Inv.Product.Name, Inv.Product.Code, Inv.Unit.Code, Inv.Product.ExistingItemCode, Inv.Product.PurchasePrice, Inv.Product.SupplierCode  HAVING (Inv.Product.Code = '" + txt_item_code.Text + "') OR (Inv.Product.ExistingItemCode = '" + txt_item_code.Text + "')");                  
                    txt_item_name.Text = dt.Rows[0]["Name"].ToString();
                    Unit.Text = dt.Rows[0]["Unit"].ToString();
                    txt_item_code.Text = dt.Rows[0]["Code"].ToString();
                    txt_rate.Text = dt.Rows[0]["PurchasePrice"].ToString();
                    txtSupplier.Text = dt.Rows[0]["SupplierCode"].ToString();
                    txt_rate.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Product Code", "Alart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {          
           
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                //---Entry Restriction----//
                double Price = Convert.ToDouble(txt_rate.Text);
                if (Price <= 0)
                {
                    MessageBox.Show("Please Check Price");
                    return;
                }
                if (Convert.ToInt32(txt_quantity.Text) > 5)
                {
                    MessageBox.Show("Entry Limit Exceeded");
                    return;
                }
                //---Entry Restriction END ----//
                if (txt_quantity.Text != "")
                {
                     AddNewRowToGrid();
                }

            }
            
        
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                for (;;)
                {
                    voucher_no();
                    DataTable dt = Connstring.SqlDataTable(@"SELECT  No FROM   Inv.OpeningStock WHERE (No= '" + Txt_cash_memo_no.Text + "')");
                    if (dt.Rows.Count == 0)
                    {
                        dt_Grid = DT_GridView.DataSource as DataTable;
                        DialogResult dialogResult = MessageBox.Show("Do you want to Save", "", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            string computer_name = System.Net.Dns.GetHostName();
                            if (DT_GridView.RowCount >= 1)
                            {
                                string sql = @"INSERT INTO Inv.OpeningStock
                         (No, Date, SalesCenterCode, Remark,ComputerName,AddUser)
                    VALUES(@No, @Date, @SalesCenterCode,@Remark,@ComputerName,@AddUser)";
                                SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);
                                MyCommand.Parameters.AddWithValue("@No", Txt_cash_memo_no.Text);
                                string date = date_start.Value.ToString("yyyy-MM-dd");
                                MyCommand.Parameters.AddWithValue("@Date", date);
                                MyCommand.Parameters.AddWithValue("@SalesCenterCode", SalesCounter.SelectedValue);
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
        public void save_details()
        {
            dt_Grid = DT_GridView.DataSource as DataTable;
            for (int i = 0; i < dt_Grid.Rows.Count; i++)
            {
                string sql = @"INSERT INTO Inv.OpeningStockDetail
                         (OpeningStockNo, ProductCode, UnitID, Qunatity, Price,SupplierCode) 
                    VALUES(@OpeningStockNo, @ProductCode, @UnitID, @Qunatity, @Price,@SupplierCode)";
                SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);
                MyCommand.Parameters.AddWithValue("@OpeningStockNo", Txt_cash_memo_no.Text);
                MyCommand.Parameters.AddWithValue("@ProductCode", dt_Grid.Rows[i]["SubItemCode"].ToString().Trim());
                MyCommand.Parameters.AddWithValue("@UnitID", "1");
                MyCommand.Parameters.AddWithValue("@Qunatity", dt_Grid.Rows[i]["Quantity"].ToString().Trim());
                MyCommand.Parameters.AddWithValue("@Price", dt_Grid.Rows[i]["ClosingPrice"].ToString().Trim());
                MyCommand.Parameters.AddWithValue("@SupplierCode", dt_Grid.Rows[i]["Supplier"].ToString().Trim());
                Connstring.conn.Open();
                MyCommand.ExecuteNonQuery();
                Connstring.conn.Close();
            }
            blank_data();
            dt_Grid.Clear();
            voucher_no();
            txt_total.Text = "0";



        }

        private void DT_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                DT_GridView.Rows.RemoveAt(e.RowIndex);
            }
            if (dt_Grid.Rows.Count != 0)
            {
                float TotalOrder = float.Parse(dt_Grid.Compute("sum(Amount)", string.Empty).ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_report_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            voucher_no();
            Creat_GridView();
            Sales_Counter();
            txt_total.Text = "0";
           
        }
        private void Creat_GridView()
        {
            DataTable dt1 = new DataTable();
            dt1.Columns.Add(new DataColumn("SubItemCode", typeof(string)));
            dt1.Columns.Add(new DataColumn("SubItemName", typeof(string)));
            dt1.Columns.Add(new DataColumn("Quantity", typeof(float)));
            dt1.Columns.Add(new DataColumn("ClosingPrice", typeof(float)));
            dt1.Columns.Add(new DataColumn("Unit", typeof(string)));
            dt1.Columns.Add(new DataColumn("Amount", typeof(float)));
            dt1.Columns.Add(new DataColumn("Action", typeof(string)));
            dt1.Columns.Add(new DataColumn("Supplier", typeof(string)));
            DT_GridView.DataSource = dt1;
        }
        private void btn_voucher_find_Click(object sender, EventArgs e)
        {
            dt_Grid.Clear();
            DataTable dt = Connstring.SqlDataTable(@"SELECT Inv.OpeningStock.Date, Inv.OpeningStock.SalesCenterCode, Inv.OpeningStockDetail.ProductCode, Inv.OpeningStockDetail.UnitID, Inv.OpeningStockDetail.Qunatity, Inv.OpeningStockDetail.Price, 
                         Inv.Product.Name, Inv.OpeningStockDetail.Qunatity * Inv.OpeningStockDetail.Price AS Amount, Inv.OpeningStock.No
FROM            Inv.OpeningStock INNER JOIN
                         Inv.OpeningStockDetail ON Inv.OpeningStock.No = Inv.OpeningStockDetail.OpeningStockNo INNER JOIN
                         Inv.Product ON Inv.OpeningStockDetail.ProductCode = Inv.Product.Code
WHERE        (Inv.OpeningStock.No = '" + Txt_cash_memo_no.Text + "')");
            if (dt.Rows.Count >= 1)
            {
                dt_Grid = DT_GridView.DataSource as DataTable;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = null;
                    dr = dt_Grid.NewRow();
                    dr["SubItemCode"] = dt.Rows[i]["ProductCode"].ToString();
                    dr["SubItemName"] = dt.Rows[i]["Name"].ToString();
                    dr["Quantity"] = dt.Rows[i]["Qunatity"].ToString();
                    dr["ClosingPrice"] = dt.Rows[i]["Price"].ToString();                   
                    dr["Amount"] = dt.Rows[i]["Amount"].ToString();
                    dr["Unit"] = dt.Rows[i]["UnitID"].ToString(); ;
                    dr["Action"] = "Remove";
                    dt_Grid.Rows.Add(dr);
                    //float TotalOrder = float.Parse(dt_Grid.Compute("sum(Amount)", string.Empty).ToString());
                    //txt_total.Text = TotalOrder.ToString();
                    //lbl_success.Text = "";
                    //txt_net_amount.Text = txt_total.Text;
                    date_start.Text = dt.Rows[0]["Date"].ToString();
                    SalesCounter.SelectedValue= dt.Rows[0]["SalesCenterCode"].ToString();
                    float TotalOrder = float.Parse(dt_Grid.Compute("sum(Amount)", string.Empty).ToString());
                    txt_total.Text = TotalOrder.ToString();                   
                }
            }
            else
            {
                MessageBox.Show("No Item Found !!", "Alart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_item_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                txt_quantity.Focus();
            }
        }
    }
}

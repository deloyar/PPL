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

namespace PRP.PPL.Data.Production.PlateTransaction
{
    public partial class PplDataProduction_PlateTransaction : Form
    {
        DataTable dt = new DataTable();
        DataTable dt_Grid = new DataTable();
        DataTable dt_Grid1 = new DataTable();
        DataTable dt_hold = new DataTable();
        db_ppl Connstring = new db_ppl();
        public PplDataProduction_PlateTransaction()
        {
            InitializeComponent();

        }

        private void LoadPlateMakingManufacture()
        {
            DataTable dt = Connstring.SqlDataTable(@"SELECT [Plate Code] AS Code, [Plate Name] AS Name
                           FROM prd.[Plate Info]");
            DataRow Drw;
            Drw = dt.NewRow();
            Drw.ItemArray = new object[] { 0, "---ALL---" };
            dt.Rows.InsertAt(Drw, 0);
            cboPlateMakeManufacture.ValueMember = "Code";
            cboPlateMakeManufacture.DisplayMember = "Name";
            cboPlateMakeManufacture.DataSource = dt;
        }


        private void PplDataProductionPlateTransaction_KeyUp(object sender, KeyEventArgs e)
        {
            //
        }


        private void LoadPlateMakingPlateType()
        {
            DataTable dt = Connstring.SqlDataTable(@"SELECT [Plate Type Code] AS Code, [Plate Type Name] AS Name
                           FROM prd.[Plate Type Info]");
            DataRow Drw;
            Drw = dt.NewRow();
            Drw.ItemArray = new object[] { 0, "---ALL---" };
            dt.Rows.InsertAt(Drw, 0);
            cboPlateMakingPlateType.ValueMember = "Code";
            cboPlateMakingPlateType.DisplayMember = "Name";
            cboPlateMakingPlateType.DataSource = dt;
        }



        private void LoadPlateMakingBookInfo()
        {
            DataTable dt = Connstring.SqlDataTable(@"SELECT [Plate Code] AS Code, [Plate Name] AS Name
                            FROM [prd].[Plate Info];");
            DataRow Drw;
            Drw = dt.NewRow();
            Drw.ItemArray = new object[] { 0, "---ALL---" };
            dt.Rows.InsertAt(Drw, 0);
            cboPlateMakeWorkBookInfo.ValueMember = "Code";
            cboPlateMakeWorkBookInfo.DisplayMember = "Name";
            cboPlateMakeWorkBookInfo.DataSource = dt;
        }
        private void HideItemsOnLoad()
        {
            cboPlateMakeWorkBookInfo.Visible = false;
            PlateMakingItemName.Visible = false;
            txtPlateMakeEdition.Visible = false;
            labelcboPlateMakeWorkBookInfo.Visible = false;
            labeltxtPlateMakeEdition.Visible = false;
            labeltxtPlateMakeBookType.Visible = false;
        }

        private void PlateTypeCreat_GridView()
        {
            DataTable dt1 = new DataTable();
            dt1.Columns.Add(new DataColumn("PlateTypeCode", typeof(string)));
            dt1.Columns.Add(new DataColumn("PlateTypeName", typeof(string)));
            dt1.Columns.Add(new DataColumn("PlateWidth", typeof(string)));
            dt1.Columns.Add(new DataColumn("PlateLength", typeof(string)));
            dt1.Columns.Add(new DataColumn("PlateSize", typeof(string)));
            dt1.Columns.Add(new DataColumn("BookPaperSize", typeof(string)));
            dt1.Columns.Add(new DataColumn("PlateRate", typeof(string)));
            dt1.Columns.Add(new DataColumn("PlateMakingCharge", typeof(string)));
            dataGridView1.DataSource = dt1;
        }

        public void PlateTypeDataList()
        {
            dt_Grid1.Clear();
            DataTable dt = Connstring.SqlDataTable(@"SELECT [Plate Type Code] AS PlateTypeCode, [Plate Type Name] AS PlateTypeName,
                            [Plate Width] AS PlateWidth, [Plate Length] AS PlateLength, [Plate Size] AS PlateSize, 
                            [Book Paper Size] AS BookPaperSize, [Plate Rate] AS PlateRate, [Plate Making Charge] AS PlateMakingCharge
                            FROM prd.[Plate Type Info]
                            ORDER BY [Plate Type Code] DESC");
            dt_Grid1 = dataGridView1.DataSource as DataTable;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = null;
                dr = dt_Grid1.NewRow();
                dr["PlateTypeCode"] = dt.Rows[i]["PlateTypeCode"].ToString();
                dr["PlateTypeName"] = dt.Rows[i]["PlateTypeName"].ToString();
                dr["PlateWidth"] = dt.Rows[i]["PlateWidth"].ToString();
                dr["PlateLength"] = dt.Rows[i]["PlateLength"].ToString();
                dr["PlateSize"] = dt.Rows[i]["PlateSize"].ToString();
                dr["BookPaperSize"] = dt.Rows[i]["BookPaperSize"].ToString();
                dr["PlateRate"] = dt.Rows[i]["PlateRate"].ToString();
                dr["PlateMakingCharge"] = dt.Rows[i]["PlateMakingCharge"].ToString();
                dt_Grid1.Rows.Add(dr);
            }
        }
        private void PplDataProductionPlateTransaction_Load(object sender, EventArgs e)
        {

            LoadPlateMakingManufacture();

            LoadPlateMakingBookInfo();
            LoadPlateMakingPlateType();
            LoadDropdownAccountCode();
            PlateMakingWorkOrderDataList();
            PlateTypeCreat_GridView();
            PlateTypeDataList();
            PlateInfoDataList();
            PlateMakingWorkOrderDataList();
            HideItemsOnLoad();

            cboPlateMakeItemType.Text = "---ALL---";

            txtPlateMakePlateBill.ReadOnly = true;
            txtPlateMakeMakingBill.ReadOnly = true;
            txtPlateMakeTotalBill.ReadOnly = true;
            txtPlateMakeCode.ReadOnly = true;

            txtPlateMakeBookType.ReadOnly = true;
            txtPlateMakeEdition.ReadOnly = true;
            //LoadDropdownAccountCode();
            MakeCodePWO();
            ButtonVisibilityUpdate(0);
            ButtonVisibilityPlateType(0);
            ButtonVisibilityPlateInfo(0);
            ClearField(true);
        }
        public void ButtonVisibilityUpdate(int status)
        {
            if (status == 0)
            {
                btnPMWOSave.Enabled = true;
                btnPMWOUpdate.Enabled = false;
                btnPMWODelete.Enabled = false;
            }
            else
            {
                btnPMWOSave.Enabled = false;
                btnPMWOUpdate.Enabled = true;
                btnPMWODelete.Enabled = true;
            }
        }

        public void ButtonVisibilityPlateType(int status)
        {
            if (status == 0)
            {
                btnPlateTypeSave.Enabled = true;
                btnPlateTypeUpdate.Enabled = false;
                btnPlateTypeDelete.Enabled = false;
            }
            else
            {
                btnPlateTypeSave.Enabled = false;
                btnPlateTypeUpdate.Enabled = true;
                btnPlateTypeDelete.Enabled = true;
            }
        }


        public void ButtonVisibilityPlateInfo(int status)
        {
            if (status == 0)
            {
                btnSave.Enabled = true;
                PlateInfoUpdate.Enabled = false;
                PlateInfoDelete.Enabled = false;
            }
            else
            {
                btnSave.Enabled = false;
                PlateInfoUpdate.Enabled = true;
                PlateInfoDelete.Enabled = true;
            }
        }

        public string PIRequredValidation()
        {
            var result = "";
            if (txtPlateCode.Text == "")
            {
                result = "Plate Code, ";
            }
            if (txtPlateName.Text == "")
            {
                result = result + "Plate Name";
            }
            return result;
        }

        //Plate info new Save click
        private void PlateInfoSave_Click(object sender, EventArgs e)
        {

            var message = PIRequredValidation();
            if (message.Length > 0)
            {
                PlateInfoLabelMessage.Text = "Please fill " + message;
                return;
            }
            string PlateCode = txtPlateCode.Text;
            if (PlateCode != "" && txtPlateName.Text!="")
            {
                DataTable dt = Connstring.SqlDataTable(@"SELECT COUNT(*) AS CheckData FROM prd.[Plate Info] WHERE ([Plate Code] = N'" + PlateCode + "')");
                int CheckData = Convert.ToInt32(dt.Rows[0]["CheckData"].ToString());
                if (CheckData == 0)
                {
                    string PlateNameBn = txtPlateNameBn.Text;
                    string PlateTelephone = txtPlateTelephone.Text;

                    string PlatePropritor = txtPlatePropritor.Text;
                    string PlateColorMachineQty = txtPlateColorMachineQty.Text;
                    string PlateCapacityColor = txtPlateCapacityColor.Text;

                    string PlateAccountCode = cboPlateAccountCode.SelectedValue.ToString();
                    string PlateAboutPress = txtPlateAboutPress.Text;
                    string PlateStatus = cboPlateStatus.Text;

                    string PlateName = txtPlateName.Text;
                    string PlateAddress = txtPlateAddress.Text;
                    string PlateManager = txtPlateManager.Text;

                    string PlateBlackMachineQty = txtPlateBlackMachineQty.Text;
                    string PlateCapacityBlack = txtPlateCapacityBlack.Text;
                    string PlateFacility = txtPlateFacility.Text;

                    string PlateBalance = txtPlateBalance.Text;
                    string PlateRemarks = txtPlateRemarks.Text;

                    if (PlateCode != "" && PlateName != "")
                    {
                        string sql = @"INSERT INTO prd.[Plate Info]
                            ([Plate Code], [Plate Name], [Plate NameB], [Plate Address], 
                            [Plate Telephone], [Plate Manager], [Plate Propritor], [Plate Black Machine Qty], 
                            [Plate Color Machine Qty], [Plate Capacity Black], [Plate Capacity Color], 
                            [Plate Facility], [Account Code], [Plate Balance], [About Press], Remarks, Status)
                            VALUES (@PlateCode,@PlateName,@PlateNameB,@PlateAddress,@PlateTelephone,@PlateManager,
                            @PlatePropritor,@PlateBlackMachineQty,@PlateColorMachineQty,@PlateCapacityBlack,
                            @PlateCapacityColor,@PlateFacility,@AccountCode,@PlateBalance,@AboutPress,@Remarks,@Status)";

                        SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);

                        MyCommand.Parameters.AddWithValue("@PlateCode", PlateCode);
                        MyCommand.Parameters.AddWithValue("@PlateName", PlateName);
                        MyCommand.Parameters.AddWithValue("@PlateNameB", PlateNameBn);

                        MyCommand.Parameters.AddWithValue("@PlateAddress", PlateAddress);
                        MyCommand.Parameters.AddWithValue("@PlateTelephone", PlateTelephone);
                        MyCommand.Parameters.AddWithValue("@PlateManager", PlateManager);

                        MyCommand.Parameters.AddWithValue("@PlatePropritor", PlatePropritor);
                        MyCommand.Parameters.AddWithValue("@PlateBlackMachineQty", PlateBlackMachineQty);
                        MyCommand.Parameters.AddWithValue("@PlateColorMachineQty", PlateColorMachineQty);

                        MyCommand.Parameters.AddWithValue("@PlateCapacityBlack", PlateCapacityBlack);
                        MyCommand.Parameters.AddWithValue("@PlateCapacityColor", PlateCapacityColor);
                        MyCommand.Parameters.AddWithValue("@PlateFacility", PlateFacility);

                        MyCommand.Parameters.AddWithValue("@AccountCode", PlateAccountCode);
                        MyCommand.Parameters.AddWithValue("@PlateBalance", PlateBalance);
                        MyCommand.Parameters.AddWithValue("@AboutPress", PlateAboutPress);

                        MyCommand.Parameters.AddWithValue("@Remarks", PlateRemarks);
                        MyCommand.Parameters.AddWithValue("@Status", PlateStatus);

                        Connstring.conn.Open();
                        int Result = MyCommand.ExecuteNonQuery();
                        Connstring.conn.Close();

                        if (Result == 1)
                        {
                            PlateInfoLabelMessage.Text = "Save successfully.";
                            ClearPlateInfo();
                        }
                        else
                        {
                            PlateInfoLabelMessage.Text = "Save failed.";
                            
                        }
                    }
                    else
                    {
                        PlateInfoLabelMessage.Text = "Please fill all required fields.";

                    }
                }
                else
                {
                    PlateInfoLabelMessage.Text = "Already exist.";
                }
            }
            else
            {
                PlateInfoLabelMessage.Text = "Please fill all required fields.";
            }

            PlateInfoDataList();
        }

        private void PlateInfoDataList()
        {
            DataTable dt = Connstring.SqlDataTable(@"SELECT       
                    [Plate Code] AS PlateCode, [Plate Name], 
                    [Plate NameB], [Plate Address], [Plate Telephone], [Plate Manager], 
                    [Plate Propritor], [Plate Black Machine Qty],
                     [Plate Color Machine Qty], [Plate Capacity Black], [Plate Capacity Color], 
                     [Plate Facility], [Account Code], [Plate Balance], [About Press], Remarks, Status
                    FROM            prd.[Plate Info]
                    ORDER BY [Plate Code] DESC");

            dataGridView2.DataSource = dt;
        }

        //Plate info Update button click
        private void PlateInfoUpdate_Click(object sender, EventArgs e)
        {
            var message = PIRequredValidation();
            if (message.Length > 0)
            {
                PlateInfoLabelMessage.Text = "Please fill " + message;
                return;
            }

            try
            {
                string PlateCode = txtPlateCode.Text;
                string PlateNameBn = txtPlateNameBn.Text;
                string PlateTelephone = txtPlateTelephone.Text;

                string PlatePropritor = txtPlatePropritor.Text;
                string PlateColorMachineQty = txtPlateColorMachineQty.Text;
                string PlateCapacityColor = txtPlateCapacityColor.Text;

                string PlateAccountCode = cboPlateAccountCode.SelectedValue.ToString();
                string PlateAboutPress = txtPlateAboutPress.Text;
                string PlateStatus = cboPlateStatus.Text;

                string PlateName = txtPlateName.Text;
                string PlateAddress = txtPlateAddress.Text;
                string PlateManager = txtPlateManager.Text;

                string PlateBlackMachineQty = txtPlateBlackMachineQty.Text;
                string PlateCapacityBlack = txtPlateCapacityBlack.Text;
                string PlateFacility = txtPlateFacility.Text;

                string PlateBalance = txtPlateBalance.Text;
                string PlateRemarks = txtPlateRemarks.Text;

                if (PlateCode != "" && PlateName != "")
                {
                    string sql = @"UPDATE prd.[Plate Info]
                            SET [Plate Name]=@PlateName, 
                            [Plate NameB]=@PlateNameB, [Plate Address]=@PlateAddress, 
                            [Plate Telephone]=@PlateTelephone, [Plate Manager]=@PlateManager, 
                            [Plate Propritor]=@PlatePropritor, [Plate Black Machine Qty]=@PlateBlackMachineQty, 
                            [Plate Color Machine Qty]=@PlateColorMachineQty, [Plate Capacity Black]=@PlateCapacityBlack,
                            [Plate Capacity Color]=@PlateCapacityColor, [Plate Facility]=@PlateFacility,
                            [Account Code]=@AccountCode, [Plate Balance]=@PlateBalance, [About Press]=@AboutPress,
                            Remarks=@Remarks, Status=@Status WHERE [Plate Code]=@PlateCode";

                    SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);

                    MyCommand.Parameters.AddWithValue("@PlateCode", PlateCode);
                    MyCommand.Parameters.AddWithValue("@PlateName", PlateName);
                    MyCommand.Parameters.AddWithValue("@PlateNameB", PlateNameBn);

                    MyCommand.Parameters.AddWithValue("@PlateAddress", PlateAddress);
                    MyCommand.Parameters.AddWithValue("@PlateTelephone", PlateTelephone);
                    MyCommand.Parameters.AddWithValue("@PlateManager", PlateManager);

                    MyCommand.Parameters.AddWithValue("@PlatePropritor", PlatePropritor);
                    MyCommand.Parameters.AddWithValue("@PlateBlackMachineQty", PlateBlackMachineQty);
                    MyCommand.Parameters.AddWithValue("@PlateColorMachineQty", PlateColorMachineQty);

                    MyCommand.Parameters.AddWithValue("@PlateCapacityBlack", PlateCapacityBlack);
                    MyCommand.Parameters.AddWithValue("@PlateCapacityColor", PlateCapacityColor);
                    MyCommand.Parameters.AddWithValue("@PlateFacility", PlateFacility);

                    MyCommand.Parameters.AddWithValue("@AccountCode", PlateAccountCode);
                    MyCommand.Parameters.AddWithValue("@PlateBalance", PlateBalance);
                    MyCommand.Parameters.AddWithValue("@AboutPress", PlateAboutPress);

                    MyCommand.Parameters.AddWithValue("@Remarks", PlateRemarks);
                    MyCommand.Parameters.AddWithValue("@Status", PlateStatus);

                    Connstring.conn.Open();
                    int Result = MyCommand.ExecuteNonQuery();
                    Connstring.conn.Close();

                    if (Result == 1)
                    {
                        PlateInfoLabelMessage.Text = "Update successfully.";
                    }
                    else
                    {
                        PlateInfoLabelMessage.Text = "Update failed.";
                    }
                }
                else
                {
                    PlateInfoLabelMessage.Text = "Please fill the form carefully.";
                }
            }
            catch (Exception ex)
            {
                PlateInfoLabelMessage.Text = "Please fill the form carefully.";
            }

            PlateInfoDataList();
        }


        private void LoadDropdownAccountCode()
        {
            var sql = @"SELECT        acc.Account.Code AS AccountCode, acc.Account.Name
                            FROM acc.Account INNER JOIN
                                                     acc.AccountHead ON acc.Account.AccountHeadCode = acc.AccountHead.Code
                            WHERE(acc.AccountHead.Code = N'C006')";
            DataTable dt = Connstring.SqlDataTable(sql);
            DataRow Drw;
            Drw = dt.NewRow();
            Drw.ItemArray = new object[] { 0, "---ALL---" };
            dt.Rows.InsertAt(Drw, 0);
            cboPlateAccountCode.ValueMember = "AccountCode";
            cboPlateAccountCode.DisplayMember = "Name";
            cboPlateAccountCode.DataSource = dt;
        }

        public void ClearPlateInfo()
        {
            PlateInfoLabelMessage.Text = "";

            txtPlateCode.Text = "";
            txtPlateNameBn.Text = "";
            txtPlateTelephone.Text = "";

            txtPlatePropritor.Text = "";
            txtPlateColorMachineQty.Text = "";
            txtPlateCapacityColor.Text = "";

            cboPlateAccountCode.SelectedIndex = 0;
            txtPlateAboutPress.Text = "";
            cboPlateStatus.Text = "Active";

            txtPlateName.Text = "";
            txtPlateAddress.Text = "";
            txtPlateManager.Text = "";

            txtPlateBlackMachineQty.Text = "";
            txtPlateCapacityBlack.Text = "";
            txtPlateFacility.Text = "";

            txtPlateBalance.Text = "";
            txtPlateRemarks.Text = "";
            txtPlateInfoSearch.Text = "";
            txtPlateTypeCode.ReadOnly = false;
            txtPlateTypeCode.Focus();
            ButtonVisibilityPlateInfo(0);
        }
        //Plate info new button click
        private void btnPlateInfoNew_Click(object sender, EventArgs e)
        {
            ClearPlateInfo();
            txtPlateCode.ReadOnly = false;

        }


        //Plate info Delete button click
        private void PlateInfoDelete_Click(object sender, EventArgs e)
        {
            string Code = txtPlateCode.Text;

            DialogResult myResult;
            myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                // confirm delete
                if (Code != "")
                {
                    string sql = @"DELETE FROM  prd.[Plate Info] WHERE [Plate Code]=@PlateCode";
                    SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);
                    MyCommand.Parameters.AddWithValue("@PlateCode", Code);

                    Connstring.conn.Open();
                    int Result = MyCommand.ExecuteNonQuery();
                    Connstring.conn.Close();

                    if (Result == 1)
                    {
                        PlateInfoLabelMessage.Text = "Deleted successfully.";
                        ButtonVisibilityPlateInfo(1);
                        //Clear Textbox
                        PlateInfoLabelMessage.Text = "";

                        txtPlateCode.Text = "";
                        txtPlateNameBn.Text = "";
                        txtPlateTelephone.Text = "";

                        txtPlatePropritor.Text = "";
                        txtPlateColorMachineQty.Text = "";
                        txtPlateCapacityColor.Text = "";

                        cboPlateAccountCode.SelectedIndex = -1;
                        txtPlateAboutPress.Text = "";
                        cboPlateStatus.Text = "Active";

                        txtPlateName.Text = "";
                        txtPlateAddress.Text = "";
                        txtPlateManager.Text = "";

                        txtPlateBlackMachineQty.Text = "";
                        txtPlateCapacityBlack.Text = "";
                        txtPlateFacility.Text = "";

                        txtPlateBalance.Text = "";
                        txtPlateRemarks.Text = "";

                        txtPlateTypeCode.ReadOnly = false;
                        txtPlateTypeCode.Focus();
                    }
                    else
                    {
                        PlateInfoLabelMessage.Text = "Delete failed.";
                    }
                }
                else
                {
                    PlateInfoLabelMessage.Text = "Please select item.";
                }
                PlateInfoDataList();
            }
            else
            {
                PlateInfoLabelMessage.Text = "Delete failed.";
            }
        }

     


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];

                txtPlateCode.ReadOnly = true;
                txtPlateCode.Text = row.Cells[0].Value.ToString();
                txtPlateName.Text = row.Cells[1].Value.ToString();
                txtPlateNameBn.Text = row.Cells[2].Value.ToString();

                txtPlateAddress.Text = row.Cells[3].Value.ToString();
                txtPlateTelephone.Text = row.Cells[4].Value.ToString();
                txtPlateManager.Text = row.Cells[5].Value.ToString();

                txtPlatePropritor.Text = row.Cells[6].Value.ToString();
                txtPlateBlackMachineQty.Text = row.Cells[7].Value.ToString();
                txtPlateColorMachineQty.Text = row.Cells[8].Value.ToString();

                txtPlateCapacityBlack.Text = row.Cells[9].Value.ToString();
                txtPlateCapacityColor.Text = row.Cells[10].Value.ToString();
                txtPlateFacility.Text = row.Cells[11].Value.ToString();

                cboPlateAccountCode.SelectedValue = row.Cells[12].Value.ToString();
                txtPlateBalance.Text = row.Cells[13].Value.ToString();
                txtPlateAboutPress.Text = row.Cells[14].Value.ToString();

                txtPlateRemarks.Text = row.Cells[15].Value.ToString();
                cboPlateStatus.Text = row.Cells[16].Value.ToString();
                ButtonVisibilityPlateInfo(1);
            }
        }

        private void btnPlateInfoSearch_Click(object sender, EventArgs e)
        {
            if (txtPlateInfoSearch.Text == "")
            {
                PlateInfoLabelMessage.Text = "Invalid input";
                return;
            }

            var sql = @"SELECT [ID] ,[Plate Code],[Plate Name],[Plate NameB],[Plate Address],[Plate Telephone],[Plate Manager],
                        [Plate Propritor],[Plate Black Machine Qty],[Plate Color Machine Qty],[Plate Capacity Black],[Plate Capacity Color],[Plate Facility],[Account Code],[Plate Balance],[About Press],[Remarks],[Status]
                       FROM [prd].[Plate Info] WHERE [Plate Code]="+ txtPlateInfoSearch.Text+";";
            DataTable dt = Connstring.SqlDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                txtPlateCode.ReadOnly = true;
                ButtonVisibilityPlateInfo(1);
                txtPlateCode.Text = dt.Rows[0]["Plate Code"].ToString();
                txtPlateName.Text = dt.Rows[0]["Plate Name"].ToString();
                txtPlateNameBn.Text = dt.Rows[0]["Plate NameB"].ToString();

                txtPlateAddress.Text = dt.Rows[0]["Plate Address"].ToString();
                txtPlateTelephone.Text = dt.Rows[0]["Plate Telephone"].ToString();
                txtPlateManager.Text = dt.Rows[0]["Plate Manager"].ToString();

                txtPlatePropritor.Text = dt.Rows[0]["Plate Propritor"].ToString();
                txtPlateBlackMachineQty.Text = dt.Rows[0]["Plate Black Machine Qty"].ToString();
                txtPlateColorMachineQty.Text = dt.Rows[0]["Plate Color Machine Qty"].ToString();

                txtPlateCapacityBlack.Text = dt.Rows[0]["Plate Capacity Black"].ToString();
                txtPlateCapacityColor.Text = dt.Rows[0]["Plate Capacity Color"].ToString();
                txtPlateFacility.Text = dt.Rows[0]["Plate Facility"].ToString();

                cboPlateAccountCode.SelectedValue = dt.Rows[0]["Account Code"].ToString();
                txtPlateBalance.Text = dt.Rows[0]["Plate Balance"].ToString();
                txtPlateAboutPress.Text = dt.Rows[0]["About Press"].ToString();

                txtPlateRemarks.Text = dt.Rows[0]["Remarks"].ToString();
                cboPlateStatus.Text = dt.Rows[0]["Status"].ToString();

            }
            else
            {
                PlateInfoLabelMessage.Text = "Item not found";
            }
            
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            //
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            //
        }

        private void btn_nxt_Click(object sender, EventArgs e)
        {
            //
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            //
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            //
        }
        public string PTIRequredValidation()
        {
            var result = "";
            if (txtPlateTypeCode.Text == "")
            {
                result = "Plate Type Code, ";
            }
            if (txtPlateTypeName.Text == "")
            {
                result = result + "Plate Type Name";
            }
            return result;
        }

        //Plate Type info save button click
        private void btnPlateTypeSave_Click(object sender, EventArgs e)
        {
            var message = PTIRequredValidation();
            if (message.Length > 0)
            {
                PlateTypeLebelMessage.Text = "Please fill " + message;
                return;
            }
            string Code = txtPlateTypeCode.Text;
            if (Code != "" && txtPlateTypeName.Text!="")
            {
                DataTable dt = Connstring.SqlDataTable(@"SELECT COUNT(*) AS CheckData FROM prd.[Plate Type Info] WHERE ([Plate Type Code] = N'" + Code + "')");
                int CheckData = Convert.ToInt32(dt.Rows[0]["CheckData"].ToString());
                if (CheckData == 0)
                {
                    string Name = txtPlateTypeName.Text;
                    string PlateWidth = txtPlateWidth.Text;
                    string PlateLength = txtPlateLength.Text;
                    string PlateSize = txtPlateSize.Text;
                    string BookPaperSize = txtBookPaperSize.Text;
                    string PlateRate = txtPlateRate.Text;
                    string PlateMakingCharge = txtPlateMakingCharge.Text;

                    if (Code != "" && Name != "")
                    {
                        string sql = @"INSERT INTO prd.[Plate Type Info]([Plate Type Code], [Plate Type Name],
                              [Plate Width], [Plate Length], [Plate Size], [Book Paper Size], [Plate Rate], [Plate Making Charge])
                              VALUES (@PlateTypeCode,@PlateTypeName,@PlateWidth,@PlateLength,@PlateSize,@BookPaperSize,
                              @PlateRate,@PlateMakingCharge)";

                        SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);

                        MyCommand.Parameters.AddWithValue("@PlateTypeCode", Code);
                        MyCommand.Parameters.AddWithValue("@PlateTypeName", Name);
                        MyCommand.Parameters.AddWithValue("@PlateWidth", PlateWidth);
                        MyCommand.Parameters.AddWithValue("@PlateLength", PlateLength);
                        MyCommand.Parameters.AddWithValue("@PlateSize", PlateSize);
                        MyCommand.Parameters.AddWithValue("@BookPaperSize", BookPaperSize);
                        MyCommand.Parameters.AddWithValue("@PlateRate", PlateRate);
                        MyCommand.Parameters.AddWithValue("@PlateMakingCharge", PlateMakingCharge);

                        Connstring.conn.Open();
                        int Result = MyCommand.ExecuteNonQuery();
                        Connstring.conn.Close();

                        if (Result == 1)
                        {
                            PlateTypeLebelMessage.Text = "Save successfully.";
                            ClearDataPlateTypeInfo();
                        }
                        else
                        {
                            PlateTypeLebelMessage.Text = "Save failed.";
                        }
                    }
                    else
                    {
                        PlateTypeLebelMessage.Text = "Please fill all required fields.";
                    }
                }
                else
                {
                    PlateTypeLebelMessage.Text = "Already exist.";
                }
            }
            else
            {
                PlateTypeLebelMessage.Text = "Please fill required field carefully.";
            }
            
            PlateTypeDataList();
        }


        public void ClearDataPlateTypeInfo()
        {
            PlateTypeLebelMessage.Text = "";
            txtPlateTypeCode.Text = "";
            txtPlateTypeName.Text = "";
            txtPlateWidth.Text = "";
            txtPlateLength.Text = "";
            txtPlateSize.Text = "";
            txtBookPaperSize.Text = "";
            txtPlateRate.Text = "";
            txtPlateMakingCharge.Text = "";
            txtPlateTypeSearch.Text = "";
            txtPlateTypeCode.ReadOnly = false;
            txtPlateTypeCode.Focus();
            ButtonVisibilityPlateType(0);
        }
        //Plate Type info new button click
        private void btnPlateTypeNew_Click(object sender, EventArgs e)
        {
            ClearDataPlateTypeInfo();
        }


        //Plate Type info Update button click
        private void btnPlateTypeUpdate_Click(object sender, EventArgs e)
        {
            var message = PTIRequredValidation();
            if (message.Length > 0)
            {
                PlateTypeLebelMessage.Text = "Please fill " + message;
                return;
            }
            string Code = txtPlateTypeCode.Text;
            string Name = txtPlateTypeName.Text;
            string PlateWidth = txtPlateWidth.Text;
            string PlateLength = txtPlateLength.Text;
            string PlateSize = txtPlateSize.Text;
            string BookPaperSize = txtBookPaperSize.Text;
            string PlateRate = txtPlateRate.Text;
            string PlateMakingCharge = txtPlateMakingCharge.Text;

            if (Code != "" && Name != "")
            {
                string sql = @"UPDATE  prd.[Plate Type Info] SET [Plate Type Name]=@PlateTypeName,
                                [Plate Width]=@PlateWidth, [Plate Length]=@PlateLength, [Plate Size]=@PlateSize,
                                [Book Paper Size]=@BookPaperSize, [Plate Rate]=@PlateRate, [Plate Making Charge]=@PlateMakingCharge 
                                WHERE [Plate Type Code]=@PlateTypeCode";

                SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);

                MyCommand.Parameters.AddWithValue("@PlateTypeCode", Code);
                MyCommand.Parameters.AddWithValue("@PlateTypeName", Name);
                MyCommand.Parameters.AddWithValue("@PlateWidth", PlateWidth);
                MyCommand.Parameters.AddWithValue("@PlateLength", PlateLength);
                MyCommand.Parameters.AddWithValue("@PlateSize", PlateSize);
                MyCommand.Parameters.AddWithValue("@BookPaperSize", BookPaperSize);
                MyCommand.Parameters.AddWithValue("@PlateRate", PlateRate);
                MyCommand.Parameters.AddWithValue("@PlateMakingCharge", PlateMakingCharge);

                Connstring.conn.Open();
                int Result = MyCommand.ExecuteNonQuery();
                Connstring.conn.Close();

                if (Result == 1)
                {
                    PlateTypeLebelMessage.Text = "Update successfully.";
                }
                else
                {
                    PlateTypeLebelMessage.Text = "Update failed.";
                }
            }
            else
            {
                PlateTypeLebelMessage.Text= "Please fill required field carefully";
            }

            PlateTypeDataList();
        }

        //Plate Type info Delete button click
        private void btnPlateTypeDelete_Click(object sender, EventArgs e)
        {
            string Code = txtPlateTypeCode.Text;

            DialogResult myResult;
            myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                // confirm delete
                if (Code != "")
                {
                    string sql = @"DELETE FROM  prd.[Plate Type Info] WHERE [Plate Type Code]=@PlateTypeCode";
                    SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);
                    MyCommand.Parameters.AddWithValue("@PlateTypeCode", Code);

                    Connstring.conn.Open();
                    int Result = MyCommand.ExecuteNonQuery();
                    Connstring.conn.Close();

                    if (Result == 1)
                    {
                        PlateTypeLebelMessage.Text = "Delete successfull.";
                        ButtonVisibilityPlateType(1);

                        //Clear Textbox
                        PlateTypeLebelMessage.Text = "";
                        txtPlateTypeCode.Text = "";
                        txtPlateTypeName.Text = "";
                        txtPlateWidth.Text = "";
                        txtPlateLength.Text = "";
                        txtPlateSize.Text = "";
                        txtBookPaperSize.Text = "";
                        txtPlateRate.Text = "";
                        txtPlateMakingCharge.Text = "";

                        txtPlateTypeCode.ReadOnly = false;
                        txtPlateTypeCode.Focus();
                    }
                    else
                    {
                        PlateTypeLebelMessage.Text = "Delete failed.";
                    }
                }
                else
                {
                    PlateTypeLebelMessage.Text = "Please select item.";
                }
                PlateTypeDataList();
            }
            else
            {
                PlateTypeLebelMessage.Text = "Delete failed.";
            }
        }

 

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtPlateTypeCode.ReadOnly = true;
            ButtonVisibilityPlateType(1);
            txtPlateTypeCode.Text = dataGridView1.Rows[e.RowIndex].Cells["PlateTypeCode"].Value.ToString();
            txtPlateTypeName.Text = dataGridView1.Rows[e.RowIndex].Cells["PlateTypeName"].Value.ToString();
            txtPlateWidth.Text = dataGridView1.Rows[e.RowIndex].Cells["PlateWidth"].Value.ToString();
            txtPlateLength.Text = dataGridView1.Rows[e.RowIndex].Cells["PlateLength"].Value.ToString();
            txtPlateSize.Text = dataGridView1.Rows[e.RowIndex].Cells["PlateSize"].Value.ToString();
            txtBookPaperSize.Text = dataGridView1.Rows[e.RowIndex].Cells["BookPaperSize"].Value.ToString();
            txtPlateRate.Text = dataGridView1.Rows[e.RowIndex].Cells["PlateRate"].Value.ToString();
            txtPlateMakingCharge.Text = dataGridView1.Rows[e.RowIndex].Cells["PlateMakingCharge"].Value.ToString();

        }

        private void label46_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnPlateTypeSearch_Click(object sender, EventArgs e)
        {
            if (txtPlateTypeSearch.Text == "")
            {
                PlateTypeLebelMessage.Text = "Invalid input";
                return;
            }

            var sql = @"SELECT[Plate Type Code],[Plate Type Name],[Plate Width],[Plate Length],[Plate Size],[Book Paper Size],
                        [Plate Rate],[Plate Making Charge],[Done]FROM[prd].[Plate Type Info] WHERE [Plate Type Code]="+ txtPlateTypeSearch.Text;
            DataTable dt = Connstring.SqlDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                ButtonVisibilityPlateType(1);
                txtPlateTypeCode.ReadOnly = true;
                txtPlateTypeCode.Text = dt.Rows[0]["Plate Type Code"].ToString();
                txtPlateTypeName.Text = dt.Rows[0]["Plate Type Name"].ToString();
                txtPlateWidth.Text = dt.Rows[0]["Plate Width"].ToString();
                txtPlateLength.Text = dt.Rows[0]["Plate Length"].ToString();
                txtPlateSize.Text = dt.Rows[0]["Plate Size"].ToString();
                txtBookPaperSize.Text = dt.Rows[0]["Book Paper Size"].ToString();
                txtPlateRate.Text = dt.Rows[0]["Plate Rate"].ToString();
                txtPlateMakingCharge.Text = dt.Rows[0]["Plate Making Charge"].ToString();
            }else
            {
                PlateMakingMessageLabel.Text = "Item not found";
                
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void cboPlateMakeItemType_SelectedValueChanged(object sender, EventArgs e)
        {
            var diffTypeItem = new List<string> { "Cover", "Inner", "Main" };

            string value = cboPlateMakeItemType.Text;
            if (value == "---ALL---")
            {
                //
            }else if(!diffTypeItem.Contains(value))
            {
                cboPlateMakeWorkBookInfo.Visible = false;
                PlateMakingItemName.Visible = false;
                txtPlateMakeEdition.Visible = false;
                labelcboPlateMakeWorkBookInfo.Visible = false;
                labeltxtPlateMakeEdition.Visible = false;
                labeltxtPlateMakeBookType.Visible = false;

            }
            else
            {
                cboPlateMakeWorkBookInfo.Visible = true;
                PlateMakingItemName.Visible = true;
                txtPlateMakeEdition.Visible = true;
                labelcboPlateMakeWorkBookInfo.Visible = true;
                labeltxtPlateMakeEdition.Visible = true;
                labeltxtPlateMakeBookType.Visible = true;
            }


        }



        private void txtPlateMakeMakingBill_TextChanged(object sender, EventArgs e)
        {
            //
        }

        public void TableItemUpdate()
        {
            double Qty = 0, PlateRate = 0, PlateBill = 0, MakingRate = 0, MakingBill = 0, MakeTotalBill = 0;

            if (txtPlateMakePlateQty.Text != "")
            {
                double.TryParse(txtPlateMakePlateQty.Text, out Qty);
            }

            if (txtPlateMakePlateRate.Text != "")
            {
                double.TryParse(txtPlateMakePlateRate.Text, out PlateRate);
            }

            if (txtPlateMakePlateBill.Text != "")
            {
                double.TryParse(txtPlateMakePlateBill.Text, out PlateBill);
            }

            if (txtPlateMakeMakingRate.Text!="")
            {
                double.TryParse(txtPlateMakeMakingRate.Text, out MakingRate);
            }

            if (txtPlateMakeMakingBill.Text != "")
            {
                double.TryParse(txtPlateMakeMakingBill.Text, out MakingBill);
            }

            if (txtPlateMakeTotalBill.Text != "")
            {
                double.TryParse(txtPlateMakeTotalBill.Text, out MakeTotalBill);
            }

            
            
            txtPlateMakePlateBill.Text = (Qty * PlateRate).ToString();
            txtPlateMakeMakingBill.Text = (Qty * MakingRate).ToString();
            txtPlateMakeTotalBill.Text = ((Qty * PlateRate) + (Qty * MakingRate)).ToString();
        }

        private void txtPlateMakeMakingRate_TextChanged(object sender, EventArgs e)
        {
            TableItemUpdate();
        }

        private void txtPlateMakePlateBill_TextChanged(object sender, EventArgs e)
        {
            //
        }



        private void txtPlateMakePlateSize_TextChanged(object sender, EventArgs e)
        {
            //
        }

        

        private void cboPlateMakingPlateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboPlateMakingPlateType.Text== "---ALL---")
            {
                txtPlateMakePlateTypeName.Text = "";
                txtPlateMakePlateWidth.Text = "";
                txtPlateMakePlateSize.Text = "";
            }else
            {
                var sql = "SELECT [Plate Type Code], [Plate Type Name], [Plate Width], [Plate Size], [Plate Rate], [Plate Making Charge] FROM [PPLDEV].[prd].[Plate Type Info] WHERE [Plate Type Code]=" + cboPlateMakingPlateType.SelectedValue.ToString() + ";";
                DataTable dt = Connstring.SqlDataTable(sql);
                txtPlateMakePlateTypeName.Text=dt.Rows[0]["Plate Type Name"].ToString();
                txtPlateMakePlateWidth.Text = dt.Rows[0]["Plate Width"].ToString();
                txtPlateMakePlateSize.Text = dt.Rows[0]["Plate Size"].ToString();
            }
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        public string PMWOEmptyCheck()
        {
            var result ="";
            if (txtPlateMakeCode.Text == "")
            {
                result = result + "PWO no,";
            }
            if (cboPlateMakeItemType.Text == "---ALL---")
            {
                result = result + " Item Type,";
            }
            if(cboPlateMakeManufacture.Text == "---ALL---")
            {
                result = result + " Plate Manufacture,";
            }
            if(cboPlateMakingPlateType.Text == "---ALL---")
            {
                result = result + " Plate Type, ";
            }
            if(txtPlateMakePlateQty.Text == "")
            {
                result = result + " Plate Qty,";
            }
            if(txtPlateMakePlateRate.Text == "")
            {
                result = result + " Plate Rate,";
            }
            if(txtPlateMakeMakingRate.Text == "")
            {
                result = result + " Making Rate";
            }
            if (result.EndsWith(","))
            {
                result=result.TrimEnd(',');
            }
            return result;
        }


        //Plate Making Work Order Save button click
        private void btnPMWOSave_Click(object sender, EventArgs e)
        {

            var message =PMWOEmptyCheck();
            if (message.Length > 0)
            {
                PlateMakingMessageLabel.Text = "Please fill "+ message;
                return;
            }

            string Code = txtPlateMakeCode.Text;
                
            if (Code != "")
            {
                DataTable dt = Connstring.SqlDataTable(@"SELECT COUNT(*) AS CheckData FROM prd.[PlateMaking Work Order] WHERE ([Plate Work Order No] = N'" + Code + "')");
                int CheckData = Convert.ToInt32(dt.Rows[0]["CheckData"].ToString());
                if (CheckData == 0)
                {
                    string PlateMakeManufacture = cboPlateMakeManufacture.SelectedValue.ToString(); //Plate Code
                    string PlateMakeItemType = cboPlateMakeItemType.Text;
                    string PlateMakeDate = txtPlateMakeDate.Text;
                    string PlateMakeSerial = txtPlateMakeSerial.Text;
                    string PlateMakeRemarks = txtPlateMakeRemarks.Text;
                    string PMItemName = PlateMakingItemName.Text;
                    string PlateMakeWorkBookCode = cboPlateMakeWorkBookInfo.SelectedValue.ToString();
                    string PlateMakePlateQty = txtPlateMakePlateQty.Text;
                    int plateQty = 0;
                    int.TryParse(PlateMakePlateQty, out plateQty);
                    if (plateQty<=0)
                    {
                        PlateMakingMessageLabel.Text = "Plate Qty should be greater than 0";
                        return;
                    }
                    string PlateMakingPlateTypeCode = cboPlateMakingPlateType.SelectedValue.ToString();
                    string PlateMakePlateRate = txtPlateMakePlateRate.Text;
                    string PlateMakeMakingRate = txtPlateMakeMakingRate.Text;
                    string PlateMakePlateBill = txtPlateMakePlateBill.Text;
                    string PlateMakeMakingBill = txtPlateMakeMakingBill.Text;

                    if (Code != "" && PlateMakeManufacture != "0")
                    {
                        string sql = @"INSERT INTO prd.[PlateMaking Work Order]
                         ([Plate Work Order No], [Plate Work Order Serial], [Plate Work Order Date], [Item Type], [Plate Code],
                         [Item Name], [Book Code], [Plate Qty], [Plate Type Code], PlateRate,
                         [Making Rate], [Plate Bill], [PWO Remarks], Requiredplate, MakingBill)
                         VALUES (@PlateWorkOrderCode,@PlateWorkOrderSerial,@PlateWorkOrderDate,@ItemType,@PlateCode,@ItemName,
                         @BookCode,@PlateQty,@PlateTypeCode,@PlateRate,@MakingRate,@PlateBill,@PWORemarks,@Requiredplate,@MakingBill)";

                        SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);

                        MyCommand.Parameters.AddWithValue("@PlateWorkOrderCode", Code);
                        MyCommand.Parameters.AddWithValue("@PlateWorkOrderSerial", PlateMakeSerial);
                        MyCommand.Parameters.AddWithValue("@PlateWorkOrderDate", PlateMakeDate);
                        MyCommand.Parameters.AddWithValue("@ItemType", PlateMakeItemType);
                        MyCommand.Parameters.AddWithValue("@PlateCode", PlateMakeManufacture);
                        MyCommand.Parameters.AddWithValue("@ItemName", PMItemName);
                        MyCommand.Parameters.AddWithValue("@BookCode", PlateMakeWorkBookCode);
                        MyCommand.Parameters.AddWithValue("@PlateQty", PlateMakePlateQty);
                        MyCommand.Parameters.AddWithValue("@PlateTypeCode", PlateMakingPlateTypeCode);
                        MyCommand.Parameters.AddWithValue("@PlateRate", PlateMakePlateRate);
                        MyCommand.Parameters.AddWithValue("@MakingRate", PlateMakeMakingRate);
                        MyCommand.Parameters.AddWithValue("@PlateBill", PlateMakePlateBill);
                        MyCommand.Parameters.AddWithValue("@PWORemarks", PlateMakeRemarks);
                        MyCommand.Parameters.AddWithValue("@Requiredplate", "");
                        MyCommand.Parameters.AddWithValue("@MakingBill", PlateMakeMakingBill);

                        Connstring.conn.Open();
                        int Result = MyCommand.ExecuteNonQuery();
                        Connstring.conn.Close();

                        if (Result == 1)
                        {
                            PlateMakingMessageLabel.Text = "Successfully saved.";
                            
                            MakeCodePWO();
                        }
                        else
                        {
                            PlateMakingMessageLabel.Text = "Save failed.";
                        }
                    }
                    else
                    {
                        PlateMakingMessageLabel.Text = "Please fill all required fields.";
                    }
                }
                else
                {
                    PlateMakingMessageLabel.Text = "Already exist.";
                }
            }
            ClearField();
            PlateMakingWorkOrderDataList();
        }

        public void PlateMakingWorkOrderDataList()
        {
            DataTable dt = Connstring.SqlDataTable(@"SELECT        prd.[PlateMaking Work Order].[Plate Work Order No], prd.[PlateMaking Work Order].[Plate Work Order Date], prd.[PlateMaking Work Order].[Item Type], prd.[Plate Info].[Plate Name], 
                            prd.[PlateMaking Work Order].[Plate Work Order Serial], prd.[PlateMaking Work Order].[Item Name], prd.[PlateMaking Work Order].MakingBill
                            FROM            prd.[PlateMaking Work Order] INNER JOIN
                            prd.[Plate Info] ON prd.[PlateMaking Work Order].[Plate Code] = prd.[Plate Info].[Plate Code]
                            ORDER BY prd.[PlateMaking Work Order].ID DESC");
            dataGridView3.DataSource = dt;
        }

        public void ClearField(bool IsClearAll=false)
        {
            MakeCodePWO(); //Make a Code

            //txtPlateMakeCode.Text = "";
            txtPlateMakeDate.Value = DateTime.Today;
            cboPlateMakeManufacture.SelectedIndex = 0;
            txtPlateMakeSerial.Text = "";
            cboPlateMakeItemType.Text = "---ALL---";
            PlateMakingItemName.Text = "";
            txtPlateMakingWorkOrderSearch.Text = "";
            cboPlateMakeWorkBookInfo.SelectedIndex = 0;
            txtPlateMakeBookType.Text = "";
            txtPlateMakeEdition.Text = "";

            cboPlateMakingPlateType.SelectedIndex = 0;
            txtPlateMakePlateTypeName.Text = "";
            txtPlateMakePlateWidth.Text = "";
            txtPlateMakePlateSize.Text = "";
            txtPlateMakePlateQty.Text = "0";
            txtPlateMakePlateRate.Text = "0";
            txtPlateMakePlateBill.Text = "0";
            txtPlateMakeMakingRate.Text = "0";
            txtPlateMakeMakingBill.Text = "0";
            txtPlateMakeTotalBill.Text = "0";

            txtPlateMakeRemarks.Text = "";
            if (IsClearAll == true)
            {
                PlateMakingMessageLabel.Text = "";
            }

            txtPlateMakeCode.ReadOnly = true;
            cboPlateMakeManufacture.Focus();
            ButtonVisibilityUpdate(0);
        }

        //Plate Making Work Order New button click
        private void btnPMWONew_Click(object sender, EventArgs e)
        {
            ClearField(true);
        }


        //Plate Making Work Order Update button click
        private void btnPMWOUpdate_Click(object sender, EventArgs e)
        {
            var message = PMWOEmptyCheck();
            if (message.Length > 0)
            {
                PlateMakingMessageLabel.Text = "Please fill " + message;
                return;
            }
            string Code = txtPlateMakeCode.Text;
      
            if (Code != "")
            {
                DataTable dt = Connstring.SqlDataTable(@"SELECT COUNT(*) AS CheckData FROM prd.[PlateMaking Work Order] WHERE ([Plate Work Order No] = '" + Code + "')");
                int CheckData = Convert.ToInt32(dt.Rows[0]["CheckData"].ToString());
                if (CheckData != 0)
                {
                    string PlateMakeManufacture = cboPlateMakeManufacture.SelectedValue.ToString(); //Plate Code
                    string PlateMakeItemType = cboPlateMakeItemType.Text;
                    string PlateMakeDate = txtPlateMakeDate.Text;
                    string PlateMakeSerial = txtPlateMakeSerial.Text;
                    string PlateMakeRemarks = txtPlateMakeRemarks.Text;
                    string PMItemName = PlateMakingItemName.Text;
                    string PlateMakeWorkBookCode = cboPlateMakeWorkBookInfo.SelectedValue.ToString();
                    string PlateMakePlateQty = txtPlateMakePlateQty.Text;
                    int plateQty = 0;
                    int.TryParse(PlateMakePlateQty, out plateQty);
                    if (plateQty <= 0)
                    {
                        PlateMakingMessageLabel.Text = "Plate Qty should be greater than 0";
                        return;
                    }
                    string PlateMakingPlateTypeCode = cboPlateMakingPlateType.SelectedValue.ToString();
                    string PlateMakePlateRate = txtPlateMakePlateRate.Text;
                    string PlateMakeMakingRate = txtPlateMakeMakingRate.Text;
                    string PlateMakePlateBill = txtPlateMakePlateBill.Text;
                    string PlateMakeMakingBill = txtPlateMakeMakingBill.Text;

                    if (Code != "" && PlateMakeManufacture != "0")
                    {
                        string sql = @"UPDATE prd.[PlateMaking Work Order] SET [Plate Work Order Serial]=@PlateWorkOrderSerial, [Plate Work Order Date] =@PlateWorkOrderDate,
                                    [Item Type]=@ItemType, [Plate Code]=@PlateCode, [Item Name]=@ItemName, [Book Code]= @BookCode,
                                    [Plate Qty]=@PlateQty, [Plate Type Code]=@PlateTypeCode, PlateRate= @PlateRate, [Making Rate]=@MakingRate, [Plate Bill]=@PlateBill, [PWO Remarks]=@PWORemarks,
                                    Requiredplate=@Requiredplate, MakingBill=@MakingBill WHERE [Plate Work Order No]=@PlateWorkOrderCode";

                        SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);

                        MyCommand.Parameters.AddWithValue("@PlateWorkOrderCode", Code);
                        MyCommand.Parameters.AddWithValue("@PlateWorkOrderSerial", PlateMakeSerial);
                        MyCommand.Parameters.AddWithValue("@PlateWorkOrderDate", PlateMakeDate);
                        MyCommand.Parameters.AddWithValue("@ItemType", PlateMakeItemType);
                        MyCommand.Parameters.AddWithValue("@PlateCode", PlateMakeManufacture);
                        MyCommand.Parameters.AddWithValue("@ItemName", PMItemName);
                        MyCommand.Parameters.AddWithValue("@BookCode", PlateMakeWorkBookCode);
                        MyCommand.Parameters.AddWithValue("@PlateQty", PlateMakePlateQty);
                        MyCommand.Parameters.AddWithValue("@PlateTypeCode", PlateMakingPlateTypeCode);
                        MyCommand.Parameters.AddWithValue("@PlateRate", PlateMakePlateRate);
                        MyCommand.Parameters.AddWithValue("@MakingRate", PlateMakeMakingRate);
                        MyCommand.Parameters.AddWithValue("@PlateBill", PlateMakePlateBill);
                        MyCommand.Parameters.AddWithValue("@PWORemarks", PlateMakeRemarks);
                        MyCommand.Parameters.AddWithValue("@Requiredplate", "");
                        MyCommand.Parameters.AddWithValue("@MakingBill", PlateMakeMakingBill);

                        Connstring.conn.Open();
                        int Result = MyCommand.ExecuteNonQuery();
                        Connstring.conn.Close();

                        if (Result == 1)
                        {
                            PlateMakingMessageLabel.Text = "Successfully Updated.";
                            MakeCodePWO();
                        }
                        else
                        {
                            PlateMakingMessageLabel.Text = "Update Failed failed.";
                        }
                    }
                    else
                    {
                        PlateMakingMessageLabel.Text = "Please fill all required fields.";
                    }
                }
                else
                {
                    PlateMakingMessageLabel.Text = "Item not exists.";
                }
            }

            PlateMakingWorkOrderDataList();
        }

        //Plate Making Work Order delete button click
        private void btnPMWODelete_Click(object sender, EventArgs e)
        {

        }


        private void cboPlateMakeWorkBookInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string PlateMakeWorkBookInfo = cboPlateMakeWorkBookInfo.SelectedValue.ToString();

                DataTable dt = Connstring.SqlDataTable(@"SELECT  RND.[Book Type Information].[Book Type Name], RND.[Book Information].Edition
                FROM  RND.[Book Information] INNER JOIN  RND.[Book Type Information] ON 
                RND.[Book Information].[Book Type] = RND.[Book Type Information].[Book Type]
                WHERE (RND.[Book Information].[Book Code] = N'" + PlateMakeWorkBookInfo + "')");

                if (dt.Rows.Count >= 1)
                {
                    txtPlateMakeBookType.Text = dt.Rows[0]["Book Type Name"].ToString();
                    txtPlateMakeEdition.Text = dt.Rows[0]["Edition"].ToString();
                }
            }
            catch
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MakeCodePWO();
        }

        private void MakeCodePWO()
        {
            try
            {
                Connstring.conn.Close();
                string year_name = DateTime.Now.ToString("yy");
                string year = year_name;
                string month_name = DateTime.Today.ToString("MM");
                string month = month_name;

                DataTable dt = Connstring.SqlDataTable(@"SELECT MAX(ID) AS MAX FROM prd.[PlateMaking Work Order]");
                if (dt.Rows.Count >= 1)
                {
                    string auto_serial = dt.Rows[0]["MAX"].ToString();
                    DataTable dt_memo_no = Connstring.SqlDataTable(@"SELECT [Plate Work Order No] FROM  prd.[PlateMaking Work Order] WHERE (ID = '" + auto_serial + "')");
                    if (dt_memo_no.Rows.Count >= 1)
                    {
                        string sqldata = dt_memo_no.Rows[0]["Plate Work Order No"].ToString();
                        string[] tokens = sqldata.Split('-');
                        string middle = tokens[tokens.Length - 2];
                        string increment = Convert.ToString(Convert.ToInt32(middle.ToString()) + 1);
                        string zero = "0000";
                        int CodeLength = zero.Length - increment.Length;
                        string lenght = zero.Substring(0, CodeLength);
                        string NewMiddleCode = lenght + increment;

                        txtPlateMakeCode.Text = year + "-" + NewMiddleCode + "-" + month;
                    }
                }
                else
                {
                    txtPlateMakeCode.Text = year + "-" + "0001" + "-" + month;
                }
            }
            catch
            {
                string year_name = DateTime.Now.ToString("yy");
                string year = year_name;
                string month_name = DateTime.Today.ToString("MM");
                string month = month_name;

                txtPlateMakeCode.Text = year + "-" + "0001" + "-" + month;
            }
        }


        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ClearField(true);
                DataGridViewRow row = this.dataGridView3.Rows[e.RowIndex];

                txtPlateMakeCode.ReadOnly = true;
                string PlateMakeCode = row.Cells[0].Value.ToString();
                if (PlateMakeCode != "")
                {
                    try
                    {
                        DataTable dt = Connstring.SqlDataTable(@"SELECT      ID, [Plate Work Order No], [Plate Work Order Serial], [Plate Work Order Date],
                                    [Item Type], [Plate Code], [Item Name], [Book Code], [Plate Qty], 
                                    [Plate Type Code], PlateRate, [Making Rate], [Plate Bill], 
                                    [PWO Remarks], Requiredplate, MakingBill
                                    FROM            prd.[PlateMaking Work Order]
                                    WHERE        ([Plate Work Order No] = N'" + PlateMakeCode + "')");

                        if (dt.Rows.Count >= 1)
                        {
                            ButtonVisibilityUpdate(1);
                            txtPlateMakeCode.Text = dt.Rows[0]["Plate Work Order No"].ToString();
                            txtPlateMakeSerial.Text = dt.Rows[0]["Plate Work Order Serial"].ToString();
                            txtPlateMakeDate.Text = dt.Rows[0]["Plate Work Order Date"].ToString();

                            cboPlateMakeManufacture.SelectedValue = dt.Rows[0]["Plate Code"].ToString();
                            cboPlateMakeItemType.Text = dt.Rows[0]["Item Type"].ToString();

                            //Set Book Info
                            cboPlateMakeWorkBookInfo.Text = dt.Rows[0]["Book Code"].ToString();
                            DataTable dtBookInfo = Connstring.SqlDataTable(@"SELECT  RND.[Book Type Information].[Book Type Name], RND.[Book Information].Edition
                            FROM  RND.[Book Information] INNER JOIN  RND.[Book Type Information] ON 
                            RND.[Book Information].[Book Type] = RND.[Book Type Information].[Book Type]
                            WHERE (RND.[Book Information].[Book Code] = N'" + dt.Rows[0]["Book Code"].ToString() + "')");

                            if (dtBookInfo.Rows.Count >= 1)
                            {
                                txtPlateMakeBookType.Text = dtBookInfo.Rows[0]["Book Type Name"].ToString();
                                txtPlateMakeEdition.Text = dtBookInfo.Rows[0]["Edition"].ToString();
                            }

                            PlateMakingItemName.Text = dt.Rows[0]["Item Name"].ToString();

                            cboPlateMakingPlateType.SelectedValue = dt.Rows[0]["Plate Type Code"].ToString();
                            txtPlateMakePlateQty.Text = dt.Rows[0]["Plate Qty"].ToString();
                            txtPlateMakePlateRate.Text = dt.Rows[0]["PlateRate"].ToString();
                            txtPlateMakeMakingRate.Text = dt.Rows[0]["Making Rate"].ToString();
                            txtPlateMakePlateBill.Text = dt.Rows[0]["Plate Bill"].ToString();
                            txtPlateMakeMakingBill.Text = dt.Rows[0]["MakingBill"].ToString();

                            txtPlateMakeRemarks.Text = dt.Rows[0]["PWO Remarks"].ToString();
                            
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void btnPlateMakingWorkOrderSearch_Click(object sender, EventArgs e)
        {
            string code = txtPlateMakingWorkOrderSearch.Text;   
            if (code != "")
            {
                PlateMakeFind(code);
            }
            else
            {
                PlateMakingMessageLabel.Text = "Invalid input";
            }
        }

        private void PlateMakeFind(string Code)
        {
            if (Code != "")
            {
                try
                {
                    var sql = @"SELECT      ID, [Plate Work Order No], [Plate Work Order Serial], [Plate Work Order Date],
                                    [Item Type], [Plate Code], [Item Name], [Book Code], [Plate Qty], 
                                    [Plate Type Code], PlateRate, [Making Rate], [Plate Bill], 
                                    [PWO Remarks], Requiredplate, MakingBill
                                    FROM            prd.[PlateMaking Work Order]
                                    WHERE        ([Plate Work Order No] = '" + Code + "')";
                    DataTable dt = Connstring.SqlDataTable(sql);

                    if (dt.Rows.Count >= 1)
                    {
                        ButtonVisibilityUpdate(1);
                        txtPlateMakeCode.Text = dt.Rows[0]["Plate Work Order No"].ToString();
                        txtPlateMakeSerial.Text = dt.Rows[0]["Plate Work Order Serial"].ToString();
                        txtPlateMakeDate.Text = dt.Rows[0]["Plate Work Order Date"].ToString();

                        cboPlateMakeManufacture.SelectedValue = dt.Rows[0]["Plate Code"].ToString();
                        cboPlateMakeItemType.Text = dt.Rows[0]["Item Type"].ToString();

                        //Set Book Info
                        cboPlateMakeWorkBookInfo.Text = dt.Rows[0]["Book Code"].ToString();
                        sql = @"SELECT  RND.[Book Type Information].[Book Type Name], RND.[Book Information].Edition
                            FROM  RND.[Book Information] INNER JOIN  RND.[Book Type Information] ON 
                            RND.[Book Information].[Book Type] = RND.[Book Type Information].[Book Type]
                            WHERE (RND.[Book Information].[Book Code] = N'" + dt.Rows[0]["Book Code"].ToString() + "')";
                        DataTable dtBookInfo = Connstring.SqlDataTable(sql);

                        if (dtBookInfo.Rows.Count >= 1)
                        {
                            txtPlateMakeBookType.Text = dtBookInfo.Rows[0]["Book Type Name"].ToString();
                            txtPlateMakeEdition.Text = dtBookInfo.Rows[0]["Edition"].ToString();
                        }

                        PlateMakingItemName.Text = dt.Rows[0]["Item Name"].ToString();

                        cboPlateMakingPlateType.SelectedValue = dt.Rows[0]["Plate Type Code"].ToString();
                        txtPlateMakePlateQty.Text = dt.Rows[0]["Plate Qty"].ToString();
                        txtPlateMakePlateRate.Text = dt.Rows[0]["PlateRate"].ToString();
                        txtPlateMakeMakingRate.Text = dt.Rows[0]["Making Rate"].ToString();
                        txtPlateMakePlateBill.Text = dt.Rows[0]["Plate Bill"].ToString();
                        txtPlateMakeMakingBill.Text = dt.Rows[0]["MakingBill"].ToString();

                        txtPlateMakeRemarks.Text = dt.Rows[0]["PWO Remarks"].ToString();

                        

                    }
                    else
                    {
                        MessageBox.Show("Item not found.", "Alart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        clearDataFromPMWOTableLayoutPanel();
                    }
                }
                catch(Exception ex)
                {
                    clearDataFromPMWOTableLayoutPanel();
                }
            }
        }

        private void clearDataFromPMWOTableLayoutPanel()
        {
            cboPlateMakingPlateType.SelectedIndex = 0;
            txtPlateMakePlateTypeName.Text = "";
            txtPlateMakePlateWidth.Text = "";
            txtPlateMakePlateSize.Text = "";
            txtPlateMakePlateQty.Text = "";
            txtPlateMakePlateRate.Text = "";
            txtPlateMakePlateBill.Text = "";
            txtPlateMakeMakingRate.Text = "";
            txtPlateMakeMakingBill.Text = "";
            txtPlateMakeTotalBill.Text = "";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //
        }

        private void txtPlateMakeSerial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPlateMakePlateQty_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPlateMakePlateRate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPlateMakeMakingRate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPlateMakePlateRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlateMakePlateQty_TextChanged(object sender, EventArgs e)
        {
            TableItemUpdate();
        }

        private void txtPlateMakePlateRate_TextChanged_1(object sender, EventArgs e)
        {
            TableItemUpdate();
        }

        private void txtPlateMakePlateQty_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void txtPlateColorMachineQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPlateBlackMachineQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPlateCapacityBlack_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPlateCapacityColor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPlateBalance_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPlateWidth_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPlateLength_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPlateRate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPlateMakingCharge_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPlateTypeCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void txtPlateCode_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}

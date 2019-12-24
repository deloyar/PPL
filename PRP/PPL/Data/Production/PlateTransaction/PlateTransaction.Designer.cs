using System;
using System.Windows.Forms;

namespace PRP.PPL.Data.Production.PlateTransaction
{
    partial class PplDataProduction_PlateTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PlateMakingMessageLabel = new System.Windows.Forms.Label();
            this.btnPlateMakingWorkOrderSearch = new System.Windows.Forms.Button();
            this.txtPlateMakingWorkOrderSearch = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelcboPlateMakeWorkBookInfo = new System.Windows.Forms.Label();
            this.cboPlateMakeWorkBookInfo = new System.Windows.Forms.ComboBox();
            this.PlateMakingItemName = new System.Windows.Forms.TextBox();
            this.txtPlateMakeTotalBill = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.btnPMWODelete = new System.Windows.Forms.Button();
            this.btnPMWOUpdate = new System.Windows.Forms.Button();
            this.btnPMWONew = new System.Windows.Forms.Button();
            this.btnPMWOSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboPlateMakingPlateType = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txtPlateMakePlateTypeName = new System.Windows.Forms.TextBox();
            this.txtPlateMakePlateWidth = new System.Windows.Forms.TextBox();
            this.txtPlateMakePlateSize = new System.Windows.Forms.TextBox();
            this.txtPlateMakePlateQty = new System.Windows.Forms.TextBox();
            this.txtPlateMakePlateRate = new System.Windows.Forms.TextBox();
            this.txtPlateMakePlateBill = new System.Windows.Forms.TextBox();
            this.txtPlateMakeMakingRate = new System.Windows.Forms.TextBox();
            this.txtPlateMakeMakingBill = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.txtPlateMakeRemarks = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtPlateMakeEdition = new System.Windows.Forms.TextBox();
            this.labeltxtPlateMakeEdition = new System.Windows.Forms.Label();
            this.txtPlateMakeBookType = new System.Windows.Forms.TextBox();
            this.labeltxtPlateMakeBookType = new System.Windows.Forms.Label();
            this.labelPlateMakingItemName = new System.Windows.Forms.Label();
            this.cboPlateMakeItemType = new System.Windows.Forms.ComboBox();
            this.cboPlateMakeManufacture = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtPlateMakeSerial = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtPlateMakeCode = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtPlateMakeDate = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPlateTypeSearch = new System.Windows.Forms.Button();
            this.txtPlateTypeSearch = new System.Windows.Forms.TextBox();
            this.PlateTypeLebelMessage = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PlateTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPaperSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateMakingCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPlateMakingCharge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPlateRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBookPaperSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlateSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlateLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlateWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlateTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlateTypeCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlateTypeDelete = new System.Windows.Forms.Button();
            this.btnPlateTypeUpdate = new System.Windows.Forms.Button();
            this.btnPlateTypeNew = new System.Windows.Forms.Button();
            this.btnPlateTypeSave = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pplDataNavigation1 = new PRP.CDB.Function.PPLDataNavigation();
            this.PlateInfoLabelMessage = new System.Windows.Forms.Label();
            this.cboPlateStatus = new System.Windows.Forms.ComboBox();
            this.cboPlateAccountCode = new System.Windows.Forms.ComboBox();
            this.btnPlateInfoSearch = new System.Windows.Forms.Button();
            this.txtPlateInfoSearch = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label26 = new System.Windows.Forms.Label();
            this.txtPlateAddress = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPlateManager = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPlateBlackMachineQty = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPlateCapacityBlack = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtPlateFacility = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPlateBalance = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtPlateRemarks = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtPlateName = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtPlateNameBn = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPlateTelephone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPlatePropritor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPlateColorMachineQty = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPlateCapacityColor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPlateAboutPress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPlateCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PlateInfoDelete = new System.Windows.Forms.Button();
            this.PlateInfoUpdate = new System.Windows.Forms.Button();
            this.PlateInfoNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pplDataNavigation2 = new PRP.CDB.Function.PPLDataNavigation();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 584);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.pplDataNavigation2);
            this.tabPage1.Controls.Add(this.PlateMakingMessageLabel);
            this.tabPage1.Controls.Add(this.btnPlateMakingWorkOrderSearch);
            this.tabPage1.Controls.Add(this.txtPlateMakingWorkOrderSearch);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.labelcboPlateMakeWorkBookInfo);
            this.tabPage1.Controls.Add(this.cboPlateMakeWorkBookInfo);
            this.tabPage1.Controls.Add(this.PlateMakingItemName);
            this.tabPage1.Controls.Add(this.txtPlateMakeTotalBill);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.btnPMWODelete);
            this.tabPage1.Controls.Add(this.btnPMWOUpdate);
            this.tabPage1.Controls.Add(this.btnPMWONew);
            this.tabPage1.Controls.Add(this.btnPMWOSave);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.txtPlateMakeRemarks);
            this.tabPage1.Controls.Add(this.label35);
            this.tabPage1.Controls.Add(this.txtPlateMakeEdition);
            this.tabPage1.Controls.Add(this.labeltxtPlateMakeEdition);
            this.tabPage1.Controls.Add(this.txtPlateMakeBookType);
            this.tabPage1.Controls.Add(this.labeltxtPlateMakeBookType);
            this.tabPage1.Controls.Add(this.labelPlateMakingItemName);
            this.tabPage1.Controls.Add(this.cboPlateMakeItemType);
            this.tabPage1.Controls.Add(this.cboPlateMakeManufacture);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.txtPlateMakeSerial);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.txtPlateMakeCode);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.txtPlateMakeDate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plate Making Work Order";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // PlateMakingMessageLabel
            // 
            this.PlateMakingMessageLabel.AutoSize = true;
            this.PlateMakingMessageLabel.Location = new System.Drawing.Point(130, 538);
            this.PlateMakingMessageLabel.Name = "PlateMakingMessageLabel";
            this.PlateMakingMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.PlateMakingMessageLabel.TabIndex = 10321;
            this.PlateMakingMessageLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnPlateMakingWorkOrderSearch
            // 
            this.btnPlateMakingWorkOrderSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlateMakingWorkOrderSearch.Image = global::PRP.Properties.Resources.find;
            this.btnPlateMakingWorkOrderSearch.Location = new System.Drawing.Point(602, 5);
            this.btnPlateMakingWorkOrderSearch.Name = "btnPlateMakingWorkOrderSearch";
            this.btnPlateMakingWorkOrderSearch.Size = new System.Drawing.Size(27, 25);
            this.btnPlateMakingWorkOrderSearch.TabIndex = 10320;
            this.btnPlateMakingWorkOrderSearch.UseVisualStyleBackColor = false;
            this.btnPlateMakingWorkOrderSearch.Click += new System.EventHandler(this.btnPlateMakingWorkOrderSearch_Click);
            // 
            // txtPlateMakingWorkOrderSearch
            // 
            this.txtPlateMakingWorkOrderSearch.Location = new System.Drawing.Point(496, 6);
            this.txtPlateMakingWorkOrderSearch.Multiline = true;
            this.txtPlateMakingWorkOrderSearch.Name = "txtPlateMakingWorkOrderSearch";
            this.txtPlateMakingWorkOrderSearch.Size = new System.Drawing.Size(100, 24);
            this.txtPlateMakingWorkOrderSearch.TabIndex = 10318;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(17, 310);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(607, 187);
            this.dataGridView3.TabIndex = 10316;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.ErrorImage = global::PRP.Properties.Resources.reloadicon3;
            this.pictureBox1.Image = global::PRP.Properties.Resources.find;
            this.pictureBox1.Location = new System.Drawing.Point(299, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 20);
            this.pictureBox1.TabIndex = 10315;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelcboPlateMakeWorkBookInfo
            // 
            this.labelcboPlateMakeWorkBookInfo.AutoSize = true;
            this.labelcboPlateMakeWorkBookInfo.Location = new System.Drawing.Point(32, 127);
            this.labelcboPlateMakeWorkBookInfo.Name = "labelcboPlateMakeWorkBookInfo";
            this.labelcboPlateMakeWorkBookInfo.Size = new System.Drawing.Size(32, 13);
            this.labelcboPlateMakeWorkBookInfo.TabIndex = 10314;
            this.labelcboPlateMakeWorkBookInfo.Text = "Book";
            // 
            // cboPlateMakeWorkBookInfo
            // 
            this.cboPlateMakeWorkBookInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlateMakeWorkBookInfo.DropDownWidth = 250;
            this.cboPlateMakeWorkBookInfo.FormattingEnabled = true;
            this.cboPlateMakeWorkBookInfo.Location = new System.Drawing.Point(139, 124);
            this.cboPlateMakeWorkBookInfo.Name = "cboPlateMakeWorkBookInfo";
            this.cboPlateMakeWorkBookInfo.Size = new System.Drawing.Size(156, 21);
            this.cboPlateMakeWorkBookInfo.TabIndex = 10313;
            this.cboPlateMakeWorkBookInfo.SelectedIndexChanged += new System.EventHandler(this.cboPlateMakeWorkBookInfo_SelectedIndexChanged);
            // 
            // PlateMakingItemName
            // 
            this.PlateMakingItemName.Location = new System.Drawing.Point(418, 97);
            this.PlateMakingItemName.Name = "PlateMakingItemName";
            this.PlateMakingItemName.Size = new System.Drawing.Size(154, 20);
            this.PlateMakingItemName.TabIndex = 10311;
            // 
            // txtPlateMakeTotalBill
            // 
            this.txtPlateMakeTotalBill.Location = new System.Drawing.Point(516, 235);
            this.txtPlateMakeTotalBill.Name = "txtPlateMakeTotalBill";
            this.txtPlateMakeTotalBill.ReadOnly = true;
            this.txtPlateMakeTotalBill.Size = new System.Drawing.Size(108, 20);
            this.txtPlateMakeTotalBill.TabIndex = 10310;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(452, 238);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(65, 13);
            this.label45.TabIndex = 10309;
            this.label45.Text = "Total Bill: ";
            // 
            // btnPMWODelete
            // 
            this.btnPMWODelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPMWODelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPMWODelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPMWODelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPMWODelete.Image = global::PRP.Properties.Resources.delete;
            this.btnPMWODelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPMWODelete.Location = new System.Drawing.Point(401, 503);
            this.btnPMWODelete.Name = "btnPMWODelete";
            this.btnPMWODelete.Size = new System.Drawing.Size(88, 30);
            this.btnPMWODelete.TabIndex = 10308;
            this.btnPMWODelete.Text = "Delete";
            this.btnPMWODelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPMWODelete.UseVisualStyleBackColor = false;
            this.btnPMWODelete.Click += new System.EventHandler(this.btnPMWODelete_Click);
            // 
            // btnPMWOUpdate
            // 
            this.btnPMWOUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPMWOUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPMWOUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPMWOUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPMWOUpdate.Image = global::PRP.Properties.Resources.save;
            this.btnPMWOUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPMWOUpdate.Location = new System.Drawing.Point(307, 503);
            this.btnPMWOUpdate.Name = "btnPMWOUpdate";
            this.btnPMWOUpdate.Size = new System.Drawing.Size(88, 30);
            this.btnPMWOUpdate.TabIndex = 10307;
            this.btnPMWOUpdate.Text = "Update";
            this.btnPMWOUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPMWOUpdate.UseVisualStyleBackColor = false;
            this.btnPMWOUpdate.Click += new System.EventHandler(this.btnPMWOUpdate_Click);
            // 
            // btnPMWONew
            // 
            this.btnPMWONew.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPMWONew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPMWONew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPMWONew.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPMWONew.Image = global::PRP.Properties.Resources._new;
            this.btnPMWONew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPMWONew.Location = new System.Drawing.Point(119, 503);
            this.btnPMWONew.Name = "btnPMWONew";
            this.btnPMWONew.Size = new System.Drawing.Size(88, 30);
            this.btnPMWONew.TabIndex = 10306;
            this.btnPMWONew.Text = "New";
            this.btnPMWONew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPMWONew.UseVisualStyleBackColor = false;
            this.btnPMWONew.Click += new System.EventHandler(this.btnPMWONew_Click);
            // 
            // btnPMWOSave
            // 
            this.btnPMWOSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPMWOSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPMWOSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPMWOSave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPMWOSave.Image = global::PRP.Properties.Resources.save;
            this.btnPMWOSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPMWOSave.Location = new System.Drawing.Point(213, 503);
            this.btnPMWOSave.Name = "btnPMWOSave";
            this.btnPMWOSave.Size = new System.Drawing.Size(88, 30);
            this.btnPMWOSave.TabIndex = 10305;
            this.btnPMWOSave.Text = "Save";
            this.btnPMWOSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPMWOSave.UseVisualStyleBackColor = false;
            this.btnPMWOSave.Click += new System.EventHandler(this.btnPMWOSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.Controls.Add(this.cboPlateMakingPlateType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label43, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label42, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label41, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label40, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label39, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label36, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label37, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPlateMakePlateTypeName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPlateMakePlateWidth, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPlateMakePlateSize, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPlateMakePlateQty, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPlateMakePlateRate, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPlateMakePlateBill, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPlateMakeMakingRate, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPlateMakeMakingBill, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.label38, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label44, 8, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 165);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 58);
            this.tableLayoutPanel1.TabIndex = 22;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // cboPlateMakingPlateType
            // 
            this.cboPlateMakingPlateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlateMakingPlateType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlateMakingPlateType.FormattingEnabled = true;
            this.cboPlateMakingPlateType.Location = new System.Drawing.Point(4, 32);
            this.cboPlateMakingPlateType.Name = "cboPlateMakingPlateType";
            this.cboPlateMakingPlateType.Size = new System.Drawing.Size(67, 21);
            this.cboPlateMakingPlateType.TabIndex = 36;
            this.cboPlateMakingPlateType.SelectedIndexChanged += new System.EventHandler(this.cboPlateMakingPlateType_SelectedIndexChanged);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(421, 1);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(45, 26);
            this.label43.TabIndex = 34;
            this.label43.Text = "Making Rate";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(357, 1);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(47, 13);
            this.label42.TabIndex = 33;
            this.label42.Text = "Plate Bill";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(285, 1);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(57, 13);
            this.label41.TabIndex = 32;
            this.label41.Text = "Plate Rate";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(212, 1);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(50, 13);
            this.label40.TabIndex = 31;
            this.label40.Text = "Plate Qty";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(144, 1);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(54, 13);
            this.label39.TabIndex = 30;
            this.label39.Text = "Plate Size";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(4, 1);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(58, 13);
            this.label36.TabIndex = 0;
            this.label36.Text = "Plate Type";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(78, 1);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(1, 13);
            this.label37.TabIndex = 1;
            this.label37.Text = "Plate Type Name";
            // 
            // txtPlateMakePlateTypeName
            // 
            this.txtPlateMakePlateTypeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlateMakePlateTypeName.Location = new System.Drawing.Point(78, 32);
            this.txtPlateMakePlateTypeName.Multiline = true;
            this.txtPlateMakePlateTypeName.Name = "txtPlateMakePlateTypeName";
            this.txtPlateMakePlateTypeName.ReadOnly = true;
            this.txtPlateMakePlateTypeName.Size = new System.Drawing.Size(1, 20);
            this.txtPlateMakePlateTypeName.TabIndex = 21;
            // 
            // txtPlateMakePlateWidth
            // 
            this.txtPlateMakePlateWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlateMakePlateWidth.Location = new System.Drawing.Point(85, 32);
            this.txtPlateMakePlateWidth.Multiline = true;
            this.txtPlateMakePlateWidth.Name = "txtPlateMakePlateWidth";
            this.txtPlateMakePlateWidth.ReadOnly = true;
            this.txtPlateMakePlateWidth.Size = new System.Drawing.Size(52, 20);
            this.txtPlateMakePlateWidth.TabIndex = 22;
            // 
            // txtPlateMakePlateSize
            // 
            this.txtPlateMakePlateSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlateMakePlateSize.Location = new System.Drawing.Point(144, 32);
            this.txtPlateMakePlateSize.Multiline = true;
            this.txtPlateMakePlateSize.Name = "txtPlateMakePlateSize";
            this.txtPlateMakePlateSize.ReadOnly = true;
            this.txtPlateMakePlateSize.Size = new System.Drawing.Size(61, 20);
            this.txtPlateMakePlateSize.TabIndex = 23;
            this.txtPlateMakePlateSize.TextChanged += new System.EventHandler(this.txtPlateMakePlateSize_TextChanged);
            // 
            // txtPlateMakePlateQty
            // 
            this.txtPlateMakePlateQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlateMakePlateQty.Location = new System.Drawing.Point(212, 32);
            this.txtPlateMakePlateQty.Multiline = true;
            this.txtPlateMakePlateQty.Name = "txtPlateMakePlateQty";
            this.txtPlateMakePlateQty.Size = new System.Drawing.Size(66, 20);
            this.txtPlateMakePlateQty.TabIndex = 24;
            this.txtPlateMakePlateQty.TextChanged += new System.EventHandler(this.txtPlateMakePlateQty_TextChanged);
            this.txtPlateMakePlateQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateMakePlateQty_KeyPress_1);
            // 
            // txtPlateMakePlateRate
            // 
            this.txtPlateMakePlateRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlateMakePlateRate.Location = new System.Drawing.Point(285, 32);
            this.txtPlateMakePlateRate.Multiline = true;
            this.txtPlateMakePlateRate.Name = "txtPlateMakePlateRate";
            this.txtPlateMakePlateRate.Size = new System.Drawing.Size(65, 20);
            this.txtPlateMakePlateRate.TabIndex = 25;
            this.txtPlateMakePlateRate.TextChanged += new System.EventHandler(this.txtPlateMakePlateRate_TextChanged_1);
            this.txtPlateMakePlateRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateMakePlateRate_KeyPress);
            // 
            // txtPlateMakePlateBill
            // 
            this.txtPlateMakePlateBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlateMakePlateBill.Location = new System.Drawing.Point(357, 32);
            this.txtPlateMakePlateBill.Multiline = true;
            this.txtPlateMakePlateBill.Name = "txtPlateMakePlateBill";
            this.txtPlateMakePlateBill.ReadOnly = true;
            this.txtPlateMakePlateBill.Size = new System.Drawing.Size(57, 20);
            this.txtPlateMakePlateBill.TabIndex = 26;
            this.txtPlateMakePlateBill.TextChanged += new System.EventHandler(this.txtPlateMakePlateBill_TextChanged);
            // 
            // txtPlateMakeMakingRate
            // 
            this.txtPlateMakeMakingRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlateMakeMakingRate.Location = new System.Drawing.Point(421, 32);
            this.txtPlateMakeMakingRate.Multiline = true;
            this.txtPlateMakeMakingRate.Name = "txtPlateMakeMakingRate";
            this.txtPlateMakeMakingRate.Size = new System.Drawing.Size(59, 20);
            this.txtPlateMakeMakingRate.TabIndex = 27;
            this.txtPlateMakeMakingRate.TextChanged += new System.EventHandler(this.txtPlateMakeMakingRate_TextChanged);
            this.txtPlateMakeMakingRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateMakeMakingRate_KeyPress);
            // 
            // txtPlateMakeMakingBill
            // 
            this.txtPlateMakeMakingBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlateMakeMakingBill.Location = new System.Drawing.Point(487, 32);
            this.txtPlateMakeMakingBill.Multiline = true;
            this.txtPlateMakeMakingBill.Name = "txtPlateMakeMakingBill";
            this.txtPlateMakeMakingBill.ReadOnly = true;
            this.txtPlateMakeMakingBill.Size = new System.Drawing.Size(54, 20);
            this.txtPlateMakeMakingBill.TabIndex = 28;
            this.txtPlateMakeMakingBill.TextChanged += new System.EventHandler(this.txtPlateMakeMakingBill_TextChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(85, 1);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(35, 26);
            this.label38.TabIndex = 29;
            this.label38.Text = "Plate Width";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(487, 1);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(58, 13);
            this.label44.TabIndex = 35;
            this.label44.Text = "Making Bill";
            // 
            // txtPlateMakeRemarks
            // 
            this.txtPlateMakeRemarks.Location = new System.Drawing.Point(139, 275);
            this.txtPlateMakeRemarks.Name = "txtPlateMakeRemarks";
            this.txtPlateMakeRemarks.Size = new System.Drawing.Size(366, 20);
            this.txtPlateMakeRemarks.TabIndex = 21;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(32, 278);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 13);
            this.label35.TabIndex = 20;
            this.label35.Text = "Remarks";
            // 
            // txtPlateMakeEdition
            // 
            this.txtPlateMakeEdition.Location = new System.Drawing.Point(418, 124);
            this.txtPlateMakeEdition.Name = "txtPlateMakeEdition";
            this.txtPlateMakeEdition.Size = new System.Drawing.Size(154, 20);
            this.txtPlateMakeEdition.TabIndex = 19;
            // 
            // labeltxtPlateMakeEdition
            // 
            this.labeltxtPlateMakeEdition.AutoSize = true;
            this.labeltxtPlateMakeEdition.Location = new System.Drawing.Point(352, 127);
            this.labeltxtPlateMakeEdition.Name = "labeltxtPlateMakeEdition";
            this.labeltxtPlateMakeEdition.Size = new System.Drawing.Size(39, 13);
            this.labeltxtPlateMakeEdition.TabIndex = 18;
            this.labeltxtPlateMakeEdition.Text = "Edition";
            // 
            // txtPlateMakeBookType
            // 
            this.txtPlateMakeBookType.Location = new System.Drawing.Point(418, 97);
            this.txtPlateMakeBookType.Name = "txtPlateMakeBookType";
            this.txtPlateMakeBookType.Size = new System.Drawing.Size(154, 20);
            this.txtPlateMakeBookType.TabIndex = 17;
            // 
            // labeltxtPlateMakeBookType
            // 
            this.labeltxtPlateMakeBookType.AutoSize = true;
            this.labeltxtPlateMakeBookType.Location = new System.Drawing.Point(351, 101);
            this.labeltxtPlateMakeBookType.Name = "labeltxtPlateMakeBookType";
            this.labeltxtPlateMakeBookType.Size = new System.Drawing.Size(63, 13);
            this.labeltxtPlateMakeBookType.TabIndex = 16;
            this.labeltxtPlateMakeBookType.Text = "Book Type*";
            // 
            // labelPlateMakingItemName
            // 
            this.labelPlateMakingItemName.AutoSize = true;
            this.labelPlateMakingItemName.Location = new System.Drawing.Point(351, 100);
            this.labelPlateMakingItemName.Name = "labelPlateMakingItemName";
            this.labelPlateMakingItemName.Size = new System.Drawing.Size(58, 13);
            this.labelPlateMakingItemName.TabIndex = 14;
            this.labelPlateMakingItemName.Text = "Item Name";
            // 
            // cboPlateMakeItemType
            // 
            this.cboPlateMakeItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlateMakeItemType.FormattingEnabled = true;
            this.cboPlateMakeItemType.Items.AddRange(new object[] {
            "---ALL---",
            "5th Cover Color",
            "5th Inner Color",
            "Cover",
            "Inner",
            "Main",
            "Marketing & Admin",
            "Rebinding Forma",
            "Short Forma",
            "Others"});
            this.cboPlateMakeItemType.Location = new System.Drawing.Point(139, 95);
            this.cboPlateMakeItemType.Name = "cboPlateMakeItemType";
            this.cboPlateMakeItemType.Size = new System.Drawing.Size(156, 21);
            this.cboPlateMakeItemType.TabIndex = 13;
            this.cboPlateMakeItemType.SelectedValueChanged += new System.EventHandler(this.cboPlateMakeItemType_SelectedValueChanged);
            // 
            // cboPlateMakeManufacture
            // 
            this.cboPlateMakeManufacture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlateMakeManufacture.DropDownWidth = 200;
            this.cboPlateMakeManufacture.FormattingEnabled = true;
            this.cboPlateMakeManufacture.Location = new System.Drawing.Point(139, 68);
            this.cboPlateMakeManufacture.Name = "cboPlateMakeManufacture";
            this.cboPlateMakeManufacture.Size = new System.Drawing.Size(156, 21);
            this.cboPlateMakeManufacture.TabIndex = 12;
            this.cboPlateMakeManufacture.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(32, 98);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(58, 13);
            this.label31.TabIndex = 9;
            this.label31.Text = "Item Type*";
            // 
            // txtPlateMakeSerial
            // 
            this.txtPlateMakeSerial.Location = new System.Drawing.Point(418, 72);
            this.txtPlateMakeSerial.Name = "txtPlateMakeSerial";
            this.txtPlateMakeSerial.Size = new System.Drawing.Size(154, 20);
            this.txtPlateMakeSerial.TabIndex = 8;
            this.txtPlateMakeSerial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateMakeSerial_KeyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(350, 74);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(50, 13);
            this.label30.TabIndex = 7;
            this.label30.Text = "Serial No";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(32, 72);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(98, 13);
            this.label29.TabIndex = 4;
            this.label29.Text = "Plate Manufacture*";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(351, 47);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(30, 13);
            this.label28.TabIndex = 2;
            this.label28.Text = "Date";
            // 
            // txtPlateMakeCode
            // 
            this.txtPlateMakeCode.Location = new System.Drawing.Point(139, 42);
            this.txtPlateMakeCode.Name = "txtPlateMakeCode";
            this.txtPlateMakeCode.ReadOnly = true;
            this.txtPlateMakeCode.Size = new System.Drawing.Size(156, 20);
            this.txtPlateMakeCode.TabIndex = 1;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(32, 45);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "PWO No*";
            // 
            // txtPlateMakeDate
            // 
            this.txtPlateMakeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtPlateMakeDate.Location = new System.Drawing.Point(418, 44);
            this.txtPlateMakeDate.Name = "txtPlateMakeDate";
            this.txtPlateMakeDate.Size = new System.Drawing.Size(154, 20);
            this.txtPlateMakeDate.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPlateTypeSearch);
            this.tabPage2.Controls.Add(this.txtPlateTypeSearch);
            this.tabPage2.Controls.Add(this.PlateTypeLebelMessage);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.txtPlateMakingCharge);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtPlateRate);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtBookPaperSize);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtPlateSize);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtPlateLength);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtPlateWidth);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtPlateTypeName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtPlateTypeCode);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnPlateTypeDelete);
            this.tabPage2.Controls.Add(this.btnPlateTypeUpdate);
            this.tabPage2.Controls.Add(this.btnPlateTypeNew);
            this.tabPage2.Controls.Add(this.btnPlateTypeSave);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plate Type Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnPlateTypeSearch
            // 
            this.btnPlateTypeSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlateTypeSearch.Image = global::PRP.Properties.Resources.find;
            this.btnPlateTypeSearch.Location = new System.Drawing.Point(598, 16);
            this.btnPlateTypeSearch.Name = "btnPlateTypeSearch";
            this.btnPlateTypeSearch.Size = new System.Drawing.Size(27, 25);
            this.btnPlateTypeSearch.TabIndex = 10322;
            this.btnPlateTypeSearch.UseVisualStyleBackColor = false;
            this.btnPlateTypeSearch.Click += new System.EventHandler(this.btnPlateTypeSearch_Click);
            // 
            // txtPlateTypeSearch
            // 
            this.txtPlateTypeSearch.Location = new System.Drawing.Point(456, 17);
            this.txtPlateTypeSearch.Multiline = true;
            this.txtPlateTypeSearch.Name = "txtPlateTypeSearch";
            this.txtPlateTypeSearch.Size = new System.Drawing.Size(136, 24);
            this.txtPlateTypeSearch.TabIndex = 10321;
            // 
            // PlateTypeLebelMessage
            // 
            this.PlateTypeLebelMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlateTypeLebelMessage.AutoSize = true;
            this.PlateTypeLebelMessage.Location = new System.Drawing.Point(223, 531);
            this.PlateTypeLebelMessage.Name = "PlateTypeLebelMessage";
            this.PlateTypeLebelMessage.Size = new System.Drawing.Size(0, 13);
            this.PlateTypeLebelMessage.TabIndex = 10305;
            this.PlateTypeLebelMessage.Click += new System.EventHandler(this.label46_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlateTypeCode,
            this.PlateTypeName,
            this.PlateWidth,
            this.PlateLength,
            this.PlateSize,
            this.BookPaperSize,
            this.PlateRate,
            this.PlateMakingCharge});
            this.dataGridView1.Location = new System.Drawing.Point(22, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(602, 295);
            this.dataGridView1.TabIndex = 10300;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // PlateTypeCode
            // 
            this.PlateTypeCode.DataPropertyName = "PlateTypeCode";
            this.PlateTypeCode.HeaderText = "Code";
            this.PlateTypeCode.Name = "PlateTypeCode";
            // 
            // PlateTypeName
            // 
            this.PlateTypeName.DataPropertyName = "PlateTypeName";
            this.PlateTypeName.HeaderText = "Name";
            this.PlateTypeName.Name = "PlateTypeName";
            // 
            // PlateWidth
            // 
            this.PlateWidth.DataPropertyName = "PlateWidth";
            this.PlateWidth.HeaderText = "Plate Width";
            this.PlateWidth.Name = "PlateWidth";
            // 
            // PlateLength
            // 
            this.PlateLength.DataPropertyName = "PlateLength";
            this.PlateLength.HeaderText = "Plate Length";
            this.PlateLength.Name = "PlateLength";
            // 
            // PlateSize
            // 
            this.PlateSize.DataPropertyName = "PlateSize";
            this.PlateSize.HeaderText = "Plate Size";
            this.PlateSize.Name = "PlateSize";
            // 
            // BookPaperSize
            // 
            this.BookPaperSize.DataPropertyName = "BookPaperSize";
            this.BookPaperSize.HeaderText = "Paper Size";
            this.BookPaperSize.Name = "BookPaperSize";
            // 
            // PlateRate
            // 
            this.PlateRate.DataPropertyName = "PlateRate";
            this.PlateRate.HeaderText = "Plate Rate";
            this.PlateRate.Name = "PlateRate";
            // 
            // PlateMakingCharge
            // 
            this.PlateMakingCharge.DataPropertyName = "PlateMakingCharge";
            this.PlateMakingCharge.HeaderText = "Plate Making Charge";
            this.PlateMakingCharge.Name = "PlateMakingCharge";
            // 
            // txtPlateMakingCharge
            // 
            this.txtPlateMakingCharge.Location = new System.Drawing.Point(456, 125);
            this.txtPlateMakingCharge.Name = "txtPlateMakingCharge";
            this.txtPlateMakingCharge.Size = new System.Drawing.Size(169, 20);
            this.txtPlateMakingCharge.TabIndex = 10299;
            this.txtPlateMakingCharge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateMakingCharge_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 10298;
            this.label8.Text = "Plate Making Charge";
            // 
            // txtPlateRate
            // 
            this.txtPlateRate.Location = new System.Drawing.Point(455, 99);
            this.txtPlateRate.Name = "txtPlateRate";
            this.txtPlateRate.Size = new System.Drawing.Size(169, 20);
            this.txtPlateRate.TabIndex = 10297;
            this.txtPlateRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateRate_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 10296;
            this.label7.Text = "Plate Rate";
            // 
            // txtBookPaperSize
            // 
            this.txtBookPaperSize.Location = new System.Drawing.Point(456, 73);
            this.txtBookPaperSize.Name = "txtBookPaperSize";
            this.txtBookPaperSize.Size = new System.Drawing.Size(169, 20);
            this.txtBookPaperSize.TabIndex = 10295;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 10294;
            this.label6.Text = "Book Paper Size";
            // 
            // txtPlateSize
            // 
            this.txtPlateSize.Location = new System.Drawing.Point(144, 70);
            this.txtPlateSize.Name = "txtPlateSize";
            this.txtPlateSize.Size = new System.Drawing.Size(169, 20);
            this.txtPlateSize.TabIndex = 10293;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10292;
            this.label5.Text = "Plate Size";
            // 
            // txtPlateLength
            // 
            this.txtPlateLength.Location = new System.Drawing.Point(144, 123);
            this.txtPlateLength.Name = "txtPlateLength";
            this.txtPlateLength.Size = new System.Drawing.Size(169, 20);
            this.txtPlateLength.TabIndex = 10291;
            this.txtPlateLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateLength_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10290;
            this.label4.Text = "Plate Length";
            // 
            // txtPlateWidth
            // 
            this.txtPlateWidth.Location = new System.Drawing.Point(144, 97);
            this.txtPlateWidth.Name = "txtPlateWidth";
            this.txtPlateWidth.Size = new System.Drawing.Size(169, 20);
            this.txtPlateWidth.TabIndex = 10289;
            this.txtPlateWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateWidth_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10288;
            this.label3.Text = "Plate Width";
            // 
            // txtPlateTypeName
            // 
            this.txtPlateTypeName.Location = new System.Drawing.Point(455, 47);
            this.txtPlateTypeName.Name = "txtPlateTypeName";
            this.txtPlateTypeName.Size = new System.Drawing.Size(169, 20);
            this.txtPlateTypeName.TabIndex = 10287;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10286;
            this.label2.Text = "Plate Type Name*";
            // 
            // txtPlateTypeCode
            // 
            this.txtPlateTypeCode.Location = new System.Drawing.Point(144, 44);
            this.txtPlateTypeCode.Name = "txtPlateTypeCode";
            this.txtPlateTypeCode.Size = new System.Drawing.Size(169, 20);
            this.txtPlateTypeCode.TabIndex = 10285;
            this.txtPlateTypeCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateTypeCode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 10284;
            this.label1.Text = "Plate Type Code*";
            // 
            // btnPlateTypeDelete
            // 
            this.btnPlateTypeDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlateTypeDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlateTypeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlateTypeDelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPlateTypeDelete.Image = global::PRP.Properties.Resources.delete;
            this.btnPlateTypeDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlateTypeDelete.Location = new System.Drawing.Point(396, 489);
            this.btnPlateTypeDelete.Name = "btnPlateTypeDelete";
            this.btnPlateTypeDelete.Size = new System.Drawing.Size(88, 30);
            this.btnPlateTypeDelete.TabIndex = 10304;
            this.btnPlateTypeDelete.Text = "Delete";
            this.btnPlateTypeDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlateTypeDelete.UseVisualStyleBackColor = false;
            this.btnPlateTypeDelete.Click += new System.EventHandler(this.btnPlateTypeDelete_Click);
            // 
            // btnPlateTypeUpdate
            // 
            this.btnPlateTypeUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlateTypeUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlateTypeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlateTypeUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPlateTypeUpdate.Image = global::PRP.Properties.Resources.save;
            this.btnPlateTypeUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlateTypeUpdate.Location = new System.Drawing.Point(302, 489);
            this.btnPlateTypeUpdate.Name = "btnPlateTypeUpdate";
            this.btnPlateTypeUpdate.Size = new System.Drawing.Size(88, 30);
            this.btnPlateTypeUpdate.TabIndex = 10303;
            this.btnPlateTypeUpdate.Text = "Update";
            this.btnPlateTypeUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlateTypeUpdate.UseVisualStyleBackColor = false;
            this.btnPlateTypeUpdate.Click += new System.EventHandler(this.btnPlateTypeUpdate_Click);
            // 
            // btnPlateTypeNew
            // 
            this.btnPlateTypeNew.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlateTypeNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlateTypeNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlateTypeNew.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPlateTypeNew.Image = global::PRP.Properties.Resources._new;
            this.btnPlateTypeNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlateTypeNew.Location = new System.Drawing.Point(114, 489);
            this.btnPlateTypeNew.Name = "btnPlateTypeNew";
            this.btnPlateTypeNew.Size = new System.Drawing.Size(88, 30);
            this.btnPlateTypeNew.TabIndex = 10302;
            this.btnPlateTypeNew.Text = "New";
            this.btnPlateTypeNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlateTypeNew.UseVisualStyleBackColor = false;
            this.btnPlateTypeNew.Click += new System.EventHandler(this.btnPlateTypeNew_Click);
            // 
            // btnPlateTypeSave
            // 
            this.btnPlateTypeSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlateTypeSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlateTypeSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlateTypeSave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPlateTypeSave.Image = global::PRP.Properties.Resources.save;
            this.btnPlateTypeSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlateTypeSave.Location = new System.Drawing.Point(208, 489);
            this.btnPlateTypeSave.Name = "btnPlateTypeSave";
            this.btnPlateTypeSave.Size = new System.Drawing.Size(88, 30);
            this.btnPlateTypeSave.TabIndex = 10301;
            this.btnPlateTypeSave.Text = "Save";
            this.btnPlateTypeSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlateTypeSave.UseVisualStyleBackColor = false;
            this.btnPlateTypeSave.Click += new System.EventHandler(this.btnPlateTypeSave_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pplDataNavigation1);
            this.tabPage3.Controls.Add(this.PlateInfoLabelMessage);
            this.tabPage3.Controls.Add(this.cboPlateStatus);
            this.tabPage3.Controls.Add(this.cboPlateAccountCode);
            this.tabPage3.Controls.Add(this.btnPlateInfoSearch);
            this.tabPage3.Controls.Add(this.txtPlateInfoSearch);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.txtPlateAddress);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.txtPlateManager);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.txtPlateBlackMachineQty);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.txtPlateCapacityBlack);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.txtPlateFacility);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.txtPlateBalance);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.txtPlateRemarks);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.txtPlateName);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.txtPlateNameBn);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.txtPlateTelephone);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.txtPlatePropritor);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.txtPlateColorMachineQty);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.txtPlateCapacityColor);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtPlateAboutPress);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtPlateCode);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.PlateInfoDelete);
            this.tabPage3.Controls.Add(this.PlateInfoUpdate);
            this.tabPage3.Controls.Add(this.PlateInfoNew);
            this.tabPage3.Controls.Add(this.btnSave);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(646, 558);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Plate Info";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // pplDataNavigation1
            // 
            this.pplDataNavigation1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pplDataNavigation1.CountLabelText = "1/0";
            this.pplDataNavigation1.Datatable = null;
            this.pplDataNavigation1.ItemNumber = 0;
            this.pplDataNavigation1.Location = new System.Drawing.Point(134, 518);
            this.pplDataNavigation1.Name = "pplDataNavigation1";
            this.pplDataNavigation1.Size = new System.Drawing.Size(328, 26);
            this.pplDataNavigation1.TabIndex = 10331;
            this.pplDataNavigation1.UpdateOnChange += new System.EventHandler(this.pplDataNavigation1_UpdateOnChange);
            // 
            // PlateInfoLabelMessage
            // 
            this.PlateInfoLabelMessage.AutoSize = true;
            this.PlateInfoLabelMessage.Location = new System.Drawing.Point(219, 528);
            this.PlateInfoLabelMessage.Name = "PlateInfoLabelMessage";
            this.PlateInfoLabelMessage.Size = new System.Drawing.Size(0, 13);
            this.PlateInfoLabelMessage.TabIndex = 10330;
            // 
            // cboPlateStatus
            // 
            this.cboPlateStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlateStatus.FormattingEnabled = true;
            this.cboPlateStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboPlateStatus.Location = new System.Drawing.Point(154, 250);
            this.cboPlateStatus.Name = "cboPlateStatus";
            this.cboPlateStatus.Size = new System.Drawing.Size(121, 21);
            this.cboPlateStatus.TabIndex = 10329;
            // 
            // cboPlateAccountCode
            // 
            this.cboPlateAccountCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlateAccountCode.DropDownWidth = 250;
            this.cboPlateAccountCode.FormattingEnabled = true;
            this.cboPlateAccountCode.Location = new System.Drawing.Point(154, 198);
            this.cboPlateAccountCode.Name = "cboPlateAccountCode";
            this.cboPlateAccountCode.Size = new System.Drawing.Size(121, 21);
            this.cboPlateAccountCode.TabIndex = 10328;
            // 
            // btnPlateInfoSearch
            // 
            this.btnPlateInfoSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlateInfoSearch.Image = global::PRP.Properties.Resources.find;
            this.btnPlateInfoSearch.Location = new System.Drawing.Point(604, 6);
            this.btnPlateInfoSearch.Name = "btnPlateInfoSearch";
            this.btnPlateInfoSearch.Size = new System.Drawing.Size(27, 25);
            this.btnPlateInfoSearch.TabIndex = 10322;
            this.btnPlateInfoSearch.UseVisualStyleBackColor = false;
            this.btnPlateInfoSearch.Click += new System.EventHandler(this.btnPlateInfoSearch_Click);
            // 
            // txtPlateInfoSearch
            // 
            this.txtPlateInfoSearch.Location = new System.Drawing.Point(498, 7);
            this.txtPlateInfoSearch.Multiline = true;
            this.txtPlateInfoSearch.Name = "txtPlateInfoSearch";
            this.txtPlateInfoSearch.Size = new System.Drawing.Size(100, 24);
            this.txtPlateInfoSearch.TabIndex = 10321;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(32, 277);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(579, 194);
            this.dataGridView2.TabIndex = 10309;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(29, 253);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 13);
            this.label26.TabIndex = 32;
            this.label26.Text = "Status";
            // 
            // txtPlateAddress
            // 
            this.txtPlateAddress.Location = new System.Drawing.Point(432, 68);
            this.txtPlateAddress.Name = "txtPlateAddress";
            this.txtPlateAddress.Size = new System.Drawing.Size(179, 20);
            this.txtPlateAddress.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(294, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Plate Address";
            // 
            // txtPlateManager
            // 
            this.txtPlateManager.Location = new System.Drawing.Point(432, 94);
            this.txtPlateManager.Name = "txtPlateManager";
            this.txtPlateManager.Size = new System.Drawing.Size(100, 20);
            this.txtPlateManager.TabIndex = 29;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(294, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 28;
            this.label19.Text = "Plate Manager";
            // 
            // txtPlateBlackMachineQty
            // 
            this.txtPlateBlackMachineQty.Location = new System.Drawing.Point(432, 120);
            this.txtPlateBlackMachineQty.Name = "txtPlateBlackMachineQty";
            this.txtPlateBlackMachineQty.Size = new System.Drawing.Size(100, 20);
            this.txtPlateBlackMachineQty.TabIndex = 27;
            this.txtPlateBlackMachineQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateBlackMachineQty_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(294, 123);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(124, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "Plate Black Machine Qty";
            // 
            // txtPlateCapacityBlack
            // 
            this.txtPlateCapacityBlack.Location = new System.Drawing.Point(432, 146);
            this.txtPlateCapacityBlack.Name = "txtPlateCapacityBlack";
            this.txtPlateCapacityBlack.Size = new System.Drawing.Size(100, 20);
            this.txtPlateCapacityBlack.TabIndex = 25;
            this.txtPlateCapacityBlack.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateCapacityBlack_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(294, 149);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 13);
            this.label21.TabIndex = 24;
            this.label21.Text = "Plate Capacity Black";
            // 
            // txtPlateFacility
            // 
            this.txtPlateFacility.Location = new System.Drawing.Point(432, 172);
            this.txtPlateFacility.Name = "txtPlateFacility";
            this.txtPlateFacility.Size = new System.Drawing.Size(100, 20);
            this.txtPlateFacility.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(294, 175);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 13);
            this.label22.TabIndex = 22;
            this.label22.Text = "Plate Facility";
            // 
            // txtPlateBalance
            // 
            this.txtPlateBalance.Location = new System.Drawing.Point(432, 198);
            this.txtPlateBalance.Name = "txtPlateBalance";
            this.txtPlateBalance.Size = new System.Drawing.Size(100, 20);
            this.txtPlateBalance.TabIndex = 21;
            this.txtPlateBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateBalance_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(294, 201);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 13);
            this.label23.TabIndex = 20;
            this.label23.Text = "Plate Balance";
            // 
            // txtPlateRemarks
            // 
            this.txtPlateRemarks.Location = new System.Drawing.Point(432, 224);
            this.txtPlateRemarks.Multiline = true;
            this.txtPlateRemarks.Name = "txtPlateRemarks";
            this.txtPlateRemarks.Size = new System.Drawing.Size(179, 42);
            this.txtPlateRemarks.TabIndex = 19;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(294, 227);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 13);
            this.label24.TabIndex = 18;
            this.label24.Text = "Remarks";
            // 
            // txtPlateName
            // 
            this.txtPlateName.Location = new System.Drawing.Point(432, 42);
            this.txtPlateName.Name = "txtPlateName";
            this.txtPlateName.Size = new System.Drawing.Size(100, 20);
            this.txtPlateName.TabIndex = 17;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(294, 45);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(66, 13);
            this.label25.TabIndex = 16;
            this.label25.Text = "Plate Name*";
            // 
            // txtPlateNameBn
            // 
            this.txtPlateNameBn.Location = new System.Drawing.Point(154, 68);
            this.txtPlateNameBn.Name = "txtPlateNameBn";
            this.txtPlateNameBn.Size = new System.Drawing.Size(100, 20);
            this.txtPlateNameBn.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Plate Name (Bn)";
            // 
            // txtPlateTelephone
            // 
            this.txtPlateTelephone.Location = new System.Drawing.Point(154, 94);
            this.txtPlateTelephone.Name = "txtPlateTelephone";
            this.txtPlateTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtPlateTelephone.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Plate Telephone";
            // 
            // txtPlatePropritor
            // 
            this.txtPlatePropritor.Location = new System.Drawing.Point(154, 120);
            this.txtPlatePropritor.Name = "txtPlatePropritor";
            this.txtPlatePropritor.Size = new System.Drawing.Size(100, 20);
            this.txtPlatePropritor.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Plate Proprietor";
            // 
            // txtPlateColorMachineQty
            // 
            this.txtPlateColorMachineQty.Location = new System.Drawing.Point(154, 146);
            this.txtPlateColorMachineQty.Name = "txtPlateColorMachineQty";
            this.txtPlateColorMachineQty.Size = new System.Drawing.Size(100, 20);
            this.txtPlateColorMachineQty.TabIndex = 9;
            this.txtPlateColorMachineQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateColorMachineQty_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Plate Color Machine Qty";
            // 
            // txtPlateCapacityColor
            // 
            this.txtPlateCapacityColor.Location = new System.Drawing.Point(154, 172);
            this.txtPlateCapacityColor.Name = "txtPlateCapacityColor";
            this.txtPlateCapacityColor.Size = new System.Drawing.Size(100, 20);
            this.txtPlateCapacityColor.TabIndex = 7;
            this.txtPlateCapacityColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateCapacityColor_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Plate Capacity Color";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Account Code";
            // 
            // txtPlateAboutPress
            // 
            this.txtPlateAboutPress.Location = new System.Drawing.Point(154, 224);
            this.txtPlateAboutPress.Name = "txtPlateAboutPress";
            this.txtPlateAboutPress.Size = new System.Drawing.Size(100, 20);
            this.txtPlateAboutPress.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "About Press";
            // 
            // txtPlateCode
            // 
            this.txtPlateCode.Location = new System.Drawing.Point(154, 42);
            this.txtPlateCode.Name = "txtPlateCode";
            this.txtPlateCode.Size = new System.Drawing.Size(100, 20);
            this.txtPlateCode.TabIndex = 1;
            this.txtPlateCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateCode_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Plate Code*";
            // 
            // PlateInfoDelete
            // 
            this.PlateInfoDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PlateInfoDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlateInfoDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlateInfoDelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PlateInfoDelete.Image = global::PRP.Properties.Resources.delete;
            this.PlateInfoDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlateInfoDelete.Location = new System.Drawing.Point(396, 482);
            this.PlateInfoDelete.Name = "PlateInfoDelete";
            this.PlateInfoDelete.Size = new System.Drawing.Size(88, 30);
            this.PlateInfoDelete.TabIndex = 10308;
            this.PlateInfoDelete.Text = "Delete";
            this.PlateInfoDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlateInfoDelete.UseVisualStyleBackColor = false;
            this.PlateInfoDelete.Click += new System.EventHandler(this.PlateInfoDelete_Click);
            // 
            // PlateInfoUpdate
            // 
            this.PlateInfoUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PlateInfoUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlateInfoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlateInfoUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PlateInfoUpdate.Image = global::PRP.Properties.Resources.save;
            this.PlateInfoUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlateInfoUpdate.Location = new System.Drawing.Point(302, 482);
            this.PlateInfoUpdate.Name = "PlateInfoUpdate";
            this.PlateInfoUpdate.Size = new System.Drawing.Size(88, 30);
            this.PlateInfoUpdate.TabIndex = 10307;
            this.PlateInfoUpdate.Text = "Update";
            this.PlateInfoUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlateInfoUpdate.UseVisualStyleBackColor = false;
            this.PlateInfoUpdate.Click += new System.EventHandler(this.PlateInfoUpdate_Click);
            // 
            // PlateInfoNew
            // 
            this.PlateInfoNew.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PlateInfoNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlateInfoNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlateInfoNew.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PlateInfoNew.Image = global::PRP.Properties.Resources._new;
            this.PlateInfoNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlateInfoNew.Location = new System.Drawing.Point(114, 482);
            this.PlateInfoNew.Name = "PlateInfoNew";
            this.PlateInfoNew.Size = new System.Drawing.Size(88, 30);
            this.PlateInfoNew.TabIndex = 10306;
            this.PlateInfoNew.Text = "New";
            this.PlateInfoNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlateInfoNew.UseVisualStyleBackColor = false;
            this.PlateInfoNew.Click += new System.EventHandler(this.btnPlateInfoNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Image = global::PRP.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(208, 482);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 30);
            this.btnSave.TabIndex = 10305;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.PlateInfoSave_Click);
            // 
            // pplDataNavigation2
            // 
            this.pplDataNavigation2.CountLabelText = null;
            this.pplDataNavigation2.Datatable = null;
            this.pplDataNavigation2.ItemNumber = -1;
            this.pplDataNavigation2.Location = new System.Drawing.Point(122, 231);
            this.pplDataNavigation2.Name = "pplDataNavigation2";
            this.pplDataNavigation2.Size = new System.Drawing.Size(299, 30);
            this.pplDataNavigation2.TabIndex = 10322;
            this.pplDataNavigation2.UpdateOnChange += new System.EventHandler(this.pplDataNavigation2_UpdateOnChange_4);
            // 
            // PplDataProduction_PlateTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 619);
            this.Controls.Add(this.tabControl1);
            this.Name = "PplDataProduction_PlateTransaction";
            this.Text = "Plate Transaction";
            this.Load += new System.EventHandler(this.PplDataProductionPlateTransaction_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PplDataProductionPlateTransaction_KeyUp);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtPlateMakingCharge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPlateRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBookPaperSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlateSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlateLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlateWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlateTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlateTypeCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateTypeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPaperSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateMakingCharge;
        private System.Windows.Forms.TextBox txtPlateCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPlateTypeDelete;
        private System.Windows.Forms.Button btnPlateTypeUpdate;
        private System.Windows.Forms.Button btnPlateTypeNew;
        private System.Windows.Forms.Button btnPlateTypeSave;
        private System.Windows.Forms.TextBox txtPlateAddress;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPlateManager;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPlateBlackMachineQty;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtPlateCapacityBlack;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtPlateBalance;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtPlateRemarks;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtPlateName;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtPlateNameBn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPlateTelephone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPlatePropritor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPlateColorMachineQty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPlateCapacityColor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPlateAboutPress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button PlateInfoDelete;
        private System.Windows.Forms.Button PlateInfoUpdate;
        private System.Windows.Forms.Button PlateInfoNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtPlateMakeCode;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DateTimePicker txtPlateMakeDate;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtPlateMakeSerial;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cboPlateMakeItemType;
        private System.Windows.Forms.ComboBox cboPlateMakeManufacture;
        private System.Windows.Forms.Label labelPlateMakingItemName;
        private System.Windows.Forms.TextBox txtPlateMakeBookType;
        private System.Windows.Forms.Label labeltxtPlateMakeBookType;
        private System.Windows.Forms.TextBox txtPlateMakeEdition;
        private System.Windows.Forms.Label labeltxtPlateMakeEdition;
        private System.Windows.Forms.TextBox txtPlateMakeRemarks;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtPlateMakePlateTypeName;
        private System.Windows.Forms.TextBox txtPlateMakePlateWidth;
        private System.Windows.Forms.TextBox txtPlateMakePlateSize;
        private System.Windows.Forms.TextBox txtPlateMakePlateQty;
        private System.Windows.Forms.TextBox txtPlateMakePlateRate;
        private System.Windows.Forms.TextBox txtPlateMakePlateBill;
        private System.Windows.Forms.TextBox txtPlateMakeMakingRate;
        private System.Windows.Forms.TextBox txtPlateMakeMakingBill;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtPlateMakeTotalBill;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox PlateMakingItemName;
        private System.Windows.Forms.ComboBox cboPlateMakingPlateType;
        private System.Windows.Forms.Label PlateTypeLebelMessage;
        private System.Windows.Forms.TextBox txtPlateFacility;
        private System.Windows.Forms.Label labelcboPlateMakeWorkBookInfo;
        private System.Windows.Forms.ComboBox cboPlateMakeWorkBookInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnPMWODelete;
        private System.Windows.Forms.Button btnPMWOUpdate;
        private System.Windows.Forms.Button btnPMWONew;
        private System.Windows.Forms.Button btnPMWOSave;
        private System.Windows.Forms.TextBox txtPlateMakingWorkOrderSearch;
        private System.Windows.Forms.Button btnPlateMakingWorkOrderSearch;
        private System.Windows.Forms.Button btnPlateTypeSearch;
        private System.Windows.Forms.TextBox txtPlateTypeSearch;
        private System.Windows.Forms.Button btnPlateInfoSearch;
        private System.Windows.Forms.TextBox txtPlateInfoSearch;
        private System.Windows.Forms.ComboBox cboPlateAccountCode;
        private System.Windows.Forms.ComboBox cboPlateStatus;
        private Label PlateInfoLabelMessage;
        private Label PlateMakingMessageLabel;
        private CDB.Function.PPLDataNavigation pplDataNavigation1;
        private CDB.Function.PPLDataNavigation pplDataNavigation2;
    }
}
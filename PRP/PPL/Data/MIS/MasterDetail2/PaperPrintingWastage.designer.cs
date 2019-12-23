namespace PRP.PPL.Data.Production
{
    partial class PaperPrintingWastage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        PRP.PPL.Data.MIS.MasterDetail2.Wastage wastage = new MIS.MasterDetail2.Wastage();
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
            this.components = new System.ComponentModel.Container();
            this.lblWatageID = new System.Windows.Forms.Label();
            this.lblPressCode = new System.Windows.Forms.Label();
            this.lblPaperCode = new System.Windows.Forms.Label();
            this.lblFormaQuantity = new System.Windows.Forms.Label();
            this.lblPrintQuantity = new System.Windows.Forms.Label();
            this.lblSeller = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.lblPaperQuantity = new System.Windows.Forms.Label();
            this.lblChecker = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtWatageID = new System.Windows.Forms.TextBox();
            this.txtFormaQuantity = new System.Windows.Forms.TextBox();
            this.txtPrintQuantity = new System.Windows.Forms.TextBox();
            this.txtPaperQuantity = new System.Windows.Forms.TextBox();
            this.txtSeller = new System.Windows.Forms.TextBox();
            this.txtBuyer = new System.Windows.Forms.TextBox();
            this.txtChecker = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.cboPressCode = new System.Windows.Forms.ComboBox();
            this.cboPaperCode = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.dgvOrderData = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbl_sell = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();

            this.wastageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            wastageBindingSource.DataSource = wastage;
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderData)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wastageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWatageID
            // 
            this.lblWatageID.AutoSize = true;
            this.lblWatageID.Location = new System.Drawing.Point(30, 18);
            this.lblWatageID.Name = "lblWatageID";
            this.lblWatageID.Size = new System.Drawing.Size(59, 13);
            this.lblWatageID.TabIndex = 0;
            this.lblWatageID.Text = "Watage ID";
            // 
            // lblPressCode
            // 
            this.lblPressCode.AutoSize = true;
            this.lblPressCode.Location = new System.Drawing.Point(30, 44);
            this.lblPressCode.Name = "lblPressCode";
            this.lblPressCode.Size = new System.Drawing.Size(36, 13);
            this.lblPressCode.TabIndex = 1;
            this.lblPressCode.Text = "Press ";
            // 
            // lblPaperCode
            // 
            this.lblPaperCode.AutoSize = true;
            this.lblPaperCode.Location = new System.Drawing.Point(30, 71);
            this.lblPaperCode.Name = "lblPaperCode";
            this.lblPaperCode.Size = new System.Drawing.Size(38, 13);
            this.lblPaperCode.TabIndex = 2;
            this.lblPaperCode.Text = "Paper ";
            // 
            // lblFormaQuantity
            // 
            this.lblFormaQuantity.AutoSize = true;
            this.lblFormaQuantity.Location = new System.Drawing.Point(30, 98);
            this.lblFormaQuantity.Name = "lblFormaQuantity";
            this.lblFormaQuantity.Size = new System.Drawing.Size(78, 13);
            this.lblFormaQuantity.TabIndex = 3;
            this.lblFormaQuantity.Text = "Forma Quantity";
            // 
            // lblPrintQuantity
            // 
            this.lblPrintQuantity.AutoSize = true;
            this.lblPrintQuantity.Location = new System.Drawing.Point(30, 124);
            this.lblPrintQuantity.Name = "lblPrintQuantity";
            this.lblPrintQuantity.Size = new System.Drawing.Size(70, 13);
            this.lblPrintQuantity.TabIndex = 4;
            this.lblPrintQuantity.Text = "Print Quantity";
            this.lblPrintQuantity.Click += new System.EventHandler(this.lblPrintQuantity_Click);
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            this.lblSeller.Location = new System.Drawing.Point(351, 79);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(33, 13);
            this.lblSeller.TabIndex = 5;
            this.lblSeller.Text = "Seller";
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Location = new System.Drawing.Point(351, 105);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(34, 13);
            this.lblBuyer.TabIndex = 6;
            this.lblBuyer.Text = "Buyer";
            // 
            // lblPaperQuantity
            // 
            this.lblPaperQuantity.AutoSize = true;
            this.lblPaperQuantity.Location = new System.Drawing.Point(30, 153);
            this.lblPaperQuantity.Name = "lblPaperQuantity";
            this.lblPaperQuantity.Size = new System.Drawing.Size(77, 13);
            this.lblPaperQuantity.TabIndex = 7;
            this.lblPaperQuantity.Text = "Paper Quantity";
            // 
            // lblChecker
            // 
            this.lblChecker.AutoSize = true;
            this.lblChecker.Location = new System.Drawing.Point(351, 130);
            this.lblChecker.Name = "lblChecker";
            this.lblChecker.Size = new System.Drawing.Size(47, 13);
            this.lblChecker.TabIndex = 8;
            this.lblChecker.Text = "Checker";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(351, 153);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(49, 13);
            this.lblRemarks.TabIndex = 9;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtWatageID
            // 
            this.txtWatageID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wastageBindingSource, "ID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, wastage, "N0"));
            this.txtWatageID.Location = new System.Drawing.Point(124, 18);
            this.txtWatageID.Name = "txtWatageID";
            this.txtWatageID.Size = new System.Drawing.Size(142, 20);
            this.txtWatageID.TabIndex = 10;
            // 
            // txtFormaQuantity
            // 
            this.txtFormaQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wastageBindingSource, "FormaQty", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, wastage, "N0"));
            this.txtFormaQuantity.Location = new System.Drawing.Point(124, 98);
            this.txtFormaQuantity.Name = "txtFormaQuantity";
            this.txtFormaQuantity.Size = new System.Drawing.Size(142, 20);
            this.txtFormaQuantity.TabIndex = 11;
            this.txtFormaQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFormaQuantity_KeyPress);
            // 
            // txtPrintQuantity
            // 
            this.txtPrintQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wastageBindingSource, "PrintQty", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPrintQuantity.Location = new System.Drawing.Point(124, 124);
            this.txtPrintQuantity.Name = "txtPrintQuantity";
            this.txtPrintQuantity.Size = new System.Drawing.Size(142, 20);
            this.txtPrintQuantity.TabIndex = 12;
            this.txtPrintQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrintQuantity_KeyPress);
            // 
            // txtPaperQuantity
            // 
            this.txtPaperQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wastageBindingSource, "PaperQty", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPaperQuantity.Location = new System.Drawing.Point(124, 153);
            this.txtPaperQuantity.Name = "txtPaperQuantity";
            this.txtPaperQuantity.Size = new System.Drawing.Size(142, 20);
            this.txtPaperQuantity.TabIndex = 13;
            this.txtPaperQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaperQuantity_KeyPress);
            // 
            // txtSeller
            // 
            this.txtSeller.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wastageBindingSource, "Seller", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSeller.Location = new System.Drawing.Point(421, 75);
            this.txtSeller.Name = "txtSeller";
            this.txtSeller.Size = new System.Drawing.Size(140, 20);
            this.txtSeller.TabIndex = 14;
            // 
            // txtBuyer
            // 
            this.txtBuyer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wastageBindingSource, "Buyer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBuyer.Location = new System.Drawing.Point(421, 101);
            this.txtBuyer.Name = "txtBuyer";
            this.txtBuyer.Size = new System.Drawing.Size(140, 20);
            this.txtBuyer.TabIndex = 15;
            // 
            // txtChecker
            // 
            this.txtChecker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wastageBindingSource, "Checker", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtChecker.Location = new System.Drawing.Point(421, 127);
            this.txtChecker.Name = "txtChecker";
            this.txtChecker.Size = new System.Drawing.Size(140, 20);
            this.txtChecker.TabIndex = 16;
            // 
            // txtRemarks
            // 
            this.txtRemarks.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wastageBindingSource, "Remarks", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRemarks.Location = new System.Drawing.Point(421, 153);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(140, 20);
            this.txtRemarks.TabIndex = 17;
            this.txtRemarks.TextChanged += new System.EventHandler(this.txtRemarks_TextChanged);
            // 
            // cboPressCode
            // 
            this.cboPressCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wastageBindingSource, "Press", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cboPressCode.FormattingEnabled = true;
            this.cboPressCode.Location = new System.Drawing.Point(124, 44);
            this.cboPressCode.Name = "cboPressCode";
            this.cboPressCode.Size = new System.Drawing.Size(142, 21);
            this.cboPressCode.TabIndex = 18;
            // 
            // cboPaperCode
            // 
            this.cboPaperCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wastageBindingSource, "Paper", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cboPaperCode.FormattingEnabled = true;
            this.cboPaperCode.Location = new System.Drawing.Point(124, 71);
            this.cboPaperCode.Name = "cboPaperCode";
            this.cboPaperCode.Size = new System.Drawing.Size(142, 21);
            this.cboPaperCode.TabIndex = 19;
            // 
            // txtDate
            // 
            this.txtDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wastageBindingSource, "Date", true));
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDate.Location = new System.Drawing.Point(421, 48);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(140, 20);
            this.txtDate.TabIndex = 20;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(351, 48);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "Date";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // dgvOrderData
            // 
            this.dgvOrderData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderData.Location = new System.Drawing.Point(29, 249);
            this.dgvOrderData.Name = "dgvOrderData";
            this.dgvOrderData.Size = new System.Drawing.Size(532, 163);
            this.dgvOrderData.TabIndex = 22;
            this.dgvOrderData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgvOrderData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Image = global::PRP.Properties.Resources.save;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(295, 422);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 31);
            this.btnUpdate.TabIndex = 10266;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.Image = global::PRP.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(383, 422);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 31);
            this.btnDelete.TabIndex = 10265;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNew.Image = global::PRP.Properties.Resources._new;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(101, 422);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(82, 31);
            this.btnNew.TabIndex = 10264;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Image = global::PRP.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(195, 422);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 31);
            this.btnSave.TabIndex = 10263;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbl_sell
            // 
            this.lbl_sell.AutoSize = true;
            this.lbl_sell.Location = new System.Drawing.Point(258, 471);
            this.lbl_sell.Name = "lbl_sell";
            this.lbl_sell.Size = new System.Drawing.Size(80, 13);
            this.lbl_sell.TabIndex = 10267;
            this.lbl_sell.Text = "Show Message";
            this.lbl_sell.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(425, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10268;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(68, 19);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(126, 20);
            this.txtItem.TabIndex = 10271;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(280, 19);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(139, 20);
            this.txtQuantity.TabIndex = 10272;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(219, 21);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 10273;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(22, 22);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 10274;
            this.lblItem.Text = "Item";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(354, 15);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(139, 20);
            this.txtFind.TabIndex = 10275;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(499, 13);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(62, 23);
            this.btnFind.TabIndex = 10276;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.txtFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(89, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 10277;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(63, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 10278;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(61, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 10279;
            this.label3.Text = "*";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(106, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 10281;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(97, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 10282;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(103, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 10283;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(378, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 10284;
            this.label7.Text = "*";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(382, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 10285;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(383, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 10286;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(395, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 10287;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(47, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 10288;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(260, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 13);
            this.label12.TabIndex = 10289;
            this.label12.Text = "*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblItem);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtItem);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(29, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 54);
            this.groupBox1.TabIndex = 10290;
            this.groupBox1.TabStop = false;
            // 
            // wastageBindingSource
            // 
            this.wastageBindingSource.DataSource = typeof(PRP.PPL.Data.MIS.MasterDetail2.Wastage);
            this.wastageBindingSource.CurrentChanged += new System.EventHandler(this.wastageBindingSource_CurrentChanged);
            // 
            // PaperPrintingWastage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lbl_sell);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvOrderData);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.cboPaperCode);
            this.Controls.Add(this.cboPressCode);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtChecker);
            this.Controls.Add(this.txtBuyer);
            this.Controls.Add(this.txtSeller);
            this.Controls.Add(this.txtPaperQuantity);
            this.Controls.Add(this.txtPrintQuantity);
            this.Controls.Add(this.txtFormaQuantity);
            this.Controls.Add(this.txtWatageID);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblChecker);
            this.Controls.Add(this.lblPaperQuantity);
            this.Controls.Add(this.lblBuyer);
            this.Controls.Add(this.lblSeller);
            this.Controls.Add(this.lblPrintQuantity);
            this.Controls.Add(this.lblFormaQuantity);
            this.Controls.Add(this.lblPaperCode);
            this.Controls.Add(this.lblPressCode);
            this.Controls.Add(this.lblWatageID);
            this.Name = "PaperPrintingWastage";
            this.Text = "Paper Printing Wastage";
            this.Load += new System.EventHandler(this.PplDataProductionPaperPrintingWastage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wastageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWatageID;
        private System.Windows.Forms.Label lblPressCode;
        private System.Windows.Forms.Label lblPaperCode;
        private System.Windows.Forms.Label lblFormaQuantity;
        private System.Windows.Forms.Label lblPrintQuantity;
        private System.Windows.Forms.Label lblSeller;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.Label lblPaperQuantity;
        private System.Windows.Forms.Label lblChecker;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtWatageID;
        private System.Windows.Forms.TextBox txtFormaQuantity;
        private System.Windows.Forms.TextBox txtPrintQuantity;
        private System.Windows.Forms.TextBox txtPaperQuantity;
        private System.Windows.Forms.TextBox txtSeller;
        private System.Windows.Forms.TextBox txtBuyer;
        private System.Windows.Forms.TextBox txtChecker;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.ComboBox cboPressCode;
        private System.Windows.Forms.ComboBox cboPaperCode;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dgvOrderData;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbl_sell;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource wastageBindingSource;
    }
}
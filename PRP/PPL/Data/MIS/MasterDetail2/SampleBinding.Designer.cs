namespace PRP.PPL.Data.MIS.MasterDetail2
{
    partial class SampleBinding
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sampleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Phone = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pplNavigation1 = new PRP.CDB.Function.PPLNavigation();
            this.pplTextOnlyTextBox1 = new PRP.CDB.Function.PPLTextOnlyTextBox();
            this.pplNumericTextBox2 = new PRP.CDB.Function.PPLNumericTextBox();
            this.pplDecimalTextBox2 = new PRP.CDB.Function.PPLDecimalTextBox();
            this.pplComboBox2 = new PRP.CDB.Function.PPLComboBox();
            this.pplComboBox1 = new PRP.CDB.Function.PPLComboBox();
            this.pplDecimalTextBox1 = new PRP.CDB.Function.PPLDecimalTextBox();
            this.pplNumericTextBox1 = new PRP.CDB.Function.PPLNumericTextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sampleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleBindingSource, "FirstName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(96, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // sampleBindingSource
            // 
            this.sampleBindingSource.AllowNew = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleBindingSource, "LastName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(96, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(20, 147);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(38, 13);
            this.Phone.TabIndex = 7;
            this.Phone.Text = "Phone";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(96, 135);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Count";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(96, 179);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nothing";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(96, 211);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Number Only";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Decimal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "PPLCombobox";
            // 
            // pplNavigation1
            // 
            
            this.pplNavigation1.Location = new System.Drawing.Point(147, 386);
            this.pplNavigation1.Name = "pplNavigation1";
            this.pplNavigation1.Size = new System.Drawing.Size(191, 28);
            this.pplNavigation1.TabIndex = 0;
            // 
            // pplTextOnlyTextBox1
            // 
            this.pplTextOnlyTextBox1.Location = new System.Drawing.Point(263, 160);
            this.pplTextOnlyTextBox1.Name = "pplTextOnlyTextBox1";
            this.pplTextOnlyTextBox1.Size = new System.Drawing.Size(100, 20);
            this.pplTextOnlyTextBox1.TabIndex = 25;
            // 
            // pplNumericTextBox2
            // 
            this.pplNumericTextBox2.Location = new System.Drawing.Point(338, 293);
            this.pplNumericTextBox2.Name = "pplNumericTextBox2";
            this.pplNumericTextBox2.Size = new System.Drawing.Size(100, 20);
            this.pplNumericTextBox2.TabIndex = 24;
            // 
            // pplDecimalTextBox2
            // 
            this.pplDecimalTextBox2.Location = new System.Drawing.Point(338, 244);
            this.pplDecimalTextBox2.Name = "pplDecimalTextBox2";
            this.pplDecimalTextBox2.Size = new System.Drawing.Size(100, 20);
            this.pplDecimalTextBox2.TabIndex = 23;
            // 
            // pplComboBox2
            // 
            this.pplComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pplComboBox2.FormattingEnabled = true;
            this.pplComboBox2.Location = new System.Drawing.Point(338, 186);
            this.pplComboBox2.Name = "pplComboBox2";
            this.pplComboBox2.Size = new System.Drawing.Size(121, 21);
            this.pplComboBox2.TabIndex = 22;
            // 
            // pplComboBox1
            // 
            this.pplComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pplComboBox1.FormattingEnabled = true;
            this.pplComboBox1.Items.AddRange(new object[] {
            "ghjugh",
            "gug",
            "ug",
            "guy"});
            this.pplComboBox1.Location = new System.Drawing.Point(304, 48);
            this.pplComboBox1.Name = "pplComboBox1";
            this.pplComboBox1.Size = new System.Drawing.Size(121, 21);
            this.pplComboBox1.TabIndex = 21;
            // 
            // pplDecimalTextBox1
            // 
            this.pplDecimalTextBox1.Location = new System.Drawing.Point(96, 293);
            this.pplDecimalTextBox1.Name = "pplDecimalTextBox1";
            this.pplDecimalTextBox1.Size = new System.Drawing.Size(100, 20);
            this.pplDecimalTextBox1.TabIndex = 15;
            // 
            // pplNumericTextBox1
            // 
            this.pplNumericTextBox1.Location = new System.Drawing.Point(96, 254);
            this.pplNumericTextBox1.Name = "pplNumericTextBox1";
            this.pplNumericTextBox1.Size = new System.Drawing.Size(100, 20);
            this.pplNumericTextBox1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SampleBinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 426);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pplNavigation1);
            this.Name = "SampleBinding";
            this.Load += new System.EventHandler(this.SampleBinding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sampleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
       // private System.Windows.Forms.BindingSource sampleBindingSource;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private CDB.Function.PPLNumericTextBox pplNumericTextBox1;
        private System.Windows.Forms.Label label6;
        private CDB.Function.PPLDecimalTextBox pplDecimalTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private CDB.Function.PPLComboBox pplComboBox1;
        private CDB.Function.PPLComboBox pplComboBox2;
        private CDB.Function.PPLDecimalTextBox pplDecimalTextBox2;
        private CDB.Function.PPLNumericTextBox pplNumericTextBox2;
        private CDB.Function.PPLTextOnlyTextBox pplTextOnlyTextBox1;
        public System.Windows.Forms.BindingSource sampleBindingSource;
        private CDB.Function.PPLNavigation pplNavigation1;
        private System.Windows.Forms.Button button2;
    }
}
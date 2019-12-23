namespace PRP.PPL.Data.MIS.MasterDetail2
{
    partial class Form6
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
            this.pplComboBox1 = new PRP.CDB.Function.PPLComboBox();
            this.pplNumericTextBox1 = new PRP.CDB.Function.PPLNumericTextBox();
            this.pplTextOnlyTextBox1 = new PRP.CDB.Function.PPLTextOnlyTextBox();
            this.pplDecimalTextBox1 = new PRP.CDB.Function.PPLDecimalTextBox();
            this.SuspendLayout();
            // 
            // pplComboBox1
            // 
            this.pplComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pplComboBox1.FormattingEnabled = true;
            this.pplComboBox1.Location = new System.Drawing.Point(85, 35);
            this.pplComboBox1.Name = "pplComboBox1";
            this.pplComboBox1.Size = new System.Drawing.Size(121, 21);
            this.pplComboBox1.TabIndex = 0;
            // 
            // pplNumericTextBox1
            // 
            this.pplNumericTextBox1.Location = new System.Drawing.Point(47, 85);
            this.pplNumericTextBox1.Name = "pplNumericTextBox1";
            this.pplNumericTextBox1.Size = new System.Drawing.Size(100, 20);
            this.pplNumericTextBox1.TabIndex = 1;
            // 
            // pplTextOnlyTextBox1
            // 
            this.pplTextOnlyTextBox1.Location = new System.Drawing.Point(61, 134);
            this.pplTextOnlyTextBox1.Name = "pplTextOnlyTextBox1";
            this.pplTextOnlyTextBox1.Size = new System.Drawing.Size(100, 20);
            this.pplTextOnlyTextBox1.TabIndex = 2;
            // 
            // pplDecimalTextBox1
            // 
            this.pplDecimalTextBox1.Location = new System.Drawing.Point(302, 85);
            this.pplDecimalTextBox1.Name = "pplDecimalTextBox1";
            this.pplDecimalTextBox1.Size = new System.Drawing.Size(100, 20);
            this.pplDecimalTextBox1.TabIndex = 3;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 411);
            this.Controls.Add(this.pplDecimalTextBox1);
            this.Controls.Add(this.pplTextOnlyTextBox1);
            this.Controls.Add(this.pplNumericTextBox1);
            this.Controls.Add(this.pplComboBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CDB.Function.PPLComboBox pplComboBox1;
        private CDB.Function.PPLNumericTextBox pplNumericTextBox1;
        private CDB.Function.PPLTextOnlyTextBox pplTextOnlyTextBox1;
        private CDB.Function.PPLDecimalTextBox pplDecimalTextBox1;
    }
}
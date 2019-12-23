namespace PRP.PPL.Data.MIS.MasterDetail2
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pplDataGridView1 = new PRP.CDB.Function.PPLDataGridView();
            this.SuspendLayout();
            // 
            // pplDataGridView1
            // 
            this.pplDataGridView1.Location = new System.Drawing.Point(48, 51);
            this.pplDataGridView1.Name = "pplDataGridView1";
            this.pplDataGridView1.PageSize = 10;
            this.pplDataGridView1.Size = new System.Drawing.Size(468, 311);
            this.pplDataGridView1.TabIndex = 0;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 464);
            this.Controls.Add(this.pplDataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CDB.Function.PPLDataGridView pplDataGridView1;
    }
}
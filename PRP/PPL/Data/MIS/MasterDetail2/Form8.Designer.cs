namespace PRP.PPL.Data.MIS.MasterDetail2
{
    partial class Form8
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
            this.pplDataNavigation1 = new PRP.CDB.Function.PPLDataNavigation();
            this.SuspendLayout();
            // 
            // pplDataNavigation1
            // 
            this.pplDataNavigation1.CountLabelText = null;
            this.pplDataNavigation1.Datatable = null;
            this.pplDataNavigation1.ItemNumber = 0;
            this.pplDataNavigation1.Location = new System.Drawing.Point(-1, 48);
            this.pplDataNavigation1.Name = "pplDataNavigation1";
            this.pplDataNavigation1.Size = new System.Drawing.Size(327, 25);
            this.pplDataNavigation1.TabIndex = 0;
            this.pplDataNavigation1.UpdateOnChange += new System.EventHandler(this.pplDataNavigation1_UpdateOnChange_1);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 322);
            this.Controls.Add(this.pplDataNavigation1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CDB.Function.PPLDataNavigation pplDataNavigation1;
    }
}
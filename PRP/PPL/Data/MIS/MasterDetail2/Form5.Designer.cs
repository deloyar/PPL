namespace PRP.PPL.Data.MIS.MasterDetail2
{
    partial class Form5
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
            PRP.PPL.Data.MIS.MasterDetail2.Sample sample2 = new PRP.PPL.Data.MIS.MasterDetail2.Sample();
            this.pplTextOnlyTextBox1 = new PRP.CDB.Function.PPLTextOnlyTextBox();
            this.sampleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pplTextOnlyTextBox2 = new PRP.CDB.Function.PPLTextOnlyTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pplTextOnlyTextBox3 = new PRP.CDB.Function.PPLTextOnlyTextBox();
            this.pplNavigation1 = new PRP.CDB.Function.PPLNavigation();
            ((System.ComponentModel.ISupportInitialize)(this.sampleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pplTextOnlyTextBox1
            // 
            this.pplTextOnlyTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleBindingSource, "FirstName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pplTextOnlyTextBox1.Location = new System.Drawing.Point(89, 95);
            this.pplTextOnlyTextBox1.Name = "pplTextOnlyTextBox1";
            this.pplTextOnlyTextBox1.Size = new System.Drawing.Size(100, 20);
            this.pplTextOnlyTextBox1.TabIndex = 0;
            // 
            // sampleBindingSource
            // 
            sample2.Count = null;
            sample2.Email = null;
            sample2.FirstName = null;
            sample2.LastName = null;
            sample2.Nothing = null;
            sample2.Phone = null;
            this.sampleBindingSource.DataSource = sample2;
            this.sampleBindingSource.Position = 0;
            // 
            // pplTextOnlyTextBox2
            // 
            this.pplTextOnlyTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleBindingSource, "LastName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pplTextOnlyTextBox2.Location = new System.Drawing.Point(89, 153);
            this.pplTextOnlyTextBox2.Name = "pplTextOnlyTextBox2";
            this.pplTextOnlyTextBox2.Size = new System.Drawing.Size(100, 20);
            this.pplTextOnlyTextBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pplTextOnlyTextBox3
            // 
            this.pplTextOnlyTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sampleBindingSource, "Count", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pplTextOnlyTextBox3.Location = new System.Drawing.Point(89, 192);
            this.pplTextOnlyTextBox3.Name = "pplTextOnlyTextBox3";
            this.pplTextOnlyTextBox3.Size = new System.Drawing.Size(100, 20);
            this.pplTextOnlyTextBox3.TabIndex = 3;
            // 
            // pplNavigation1
            // 
            //this.pplNavigation1.DataBindings = null;
            this.pplNavigation1.Location = new System.Drawing.Point(89, 249);
            this.pplNavigation1.Name = "pplNavigation1";
            this.pplNavigation1.Size = new System.Drawing.Size(381, 34);
            this.pplNavigation1.TabIndex = 4;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 403);
            this.Controls.Add(this.pplNavigation1);
            this.Controls.Add(this.pplTextOnlyTextBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pplTextOnlyTextBox2);
            this.Controls.Add(this.pplTextOnlyTextBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.sampleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CDB.Function.PPLTextOnlyTextBox pplTextOnlyTextBox1;
        private System.Windows.Forms.BindingSource sampleBindingSource;
        private CDB.Function.PPLTextOnlyTextBox pplTextOnlyTextBox2;
        private System.Windows.Forms.Button button1;
        private CDB.Function.PPLTextOnlyTextBox pplTextOnlyTextBox3;
        private CDB.Function.PPLNavigation pplNavigation1;
    }
}
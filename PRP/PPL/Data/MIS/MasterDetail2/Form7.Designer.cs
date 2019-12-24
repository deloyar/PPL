namespace PRP.PPL.Data.MIS.MasterDetail2
{
    partial class Form7
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
            PRP.PPL.Data.MIS.MasterDetail2.User user1 = new PRP.PPL.Data.MIS.MasterDetail2.User();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pplNavigation1 = new PRP.CDB.Function.PPLNavigation();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pplNavigation2 = new PRP.CDB.Function.PPLNavigation();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Id", true));
            this.textBox1.Location = new System.Drawing.Point(22, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.textBox2.Location = new System.Drawing.Point(22, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Age", true));
            this.textBox3.Location = new System.Drawing.Point(22, 164);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pplNavigation1
            // 
            this.pplNavigation1.BindingSource = null;
            this.pplNavigation1.Location = new System.Drawing.Point(22, 25);
            this.pplNavigation1.ModelBindingSource = null;
            this.pplNavigation1.ModelType = null;
            this.pplNavigation1.Name = "pplNavigation1";
            this.pplNavigation1.Size = new System.Drawing.Size(206, 34);
            this.pplNavigation1.TabIndex = 4;
            // 
            // userBindingSource
            // 
            user1.Age = null;
            user1.Id = null;
            user1.Name = null;
            this.userBindingSource.DataSource = user1;
            this.userBindingSource.Position = 0;
            // 
            // pplNavigation2
            // 
            this.pplNavigation2.BindingSource = null;
            this.pplNavigation2.Location = new System.Drawing.Point(35, 298);
            this.pplNavigation2.ModelBindingSource = null;
            this.pplNavigation2.ModelType = null;
            this.pplNavigation2.Name = "pplNavigation2";
            this.pplNavigation2.Size = new System.Drawing.Size(371, 28);
            this.pplNavigation2.TabIndex = 6;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 445);
            this.Controls.Add(this.pplNavigation2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pplNavigation1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Button button1;
        private CDB.Function.PPLNavigation pplNavigation1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button button2;
        private CDB.Function.PPLNavigation pplNavigation2;
    }
}
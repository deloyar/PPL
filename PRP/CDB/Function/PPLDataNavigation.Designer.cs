using System;

namespace PRP.CDB.Function
{
    partial class PPLDataNavigation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PPLDataNavigation));
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLast
            // 
            resources.ApplyResources(this.btnLast, "btnLast");
            this.btnLast.BackColor = System.Drawing.SystemColors.Control;
            this.btnLast.Name = "btnLast";
            this.btnLast.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            resources.ApplyResources(this.btnPrevious, "btnPrevious");
            this.btnPrevious.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnFirst
            // 
            resources.ApplyResources(this.btnFirst, "btnFirst");
            this.btnFirst.BackColor = System.Drawing.SystemColors.Control;
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.UseVisualStyleBackColor = false;
            // 
            // textBox
            // 
            resources.ApplyResources(this.textBox, "textBox");
            this.textBox.BackColor = System.Drawing.SystemColors.Control;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            // 
            // PPLDataNavigation
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            resources.ApplyResources(this, "$this");
            this.Name = "PPLDataNavigation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.TextBox textBox;

        public event EventHandler UpdateOnChange
        {
            add
            {
                //UpdateOnChange += value;
                FirstButtonClick += value;
                PrevButtonClick += value;
                NextButtonClick += value;
                LastButtonClick += value;
            }
            remove
            {
                UpdateOnChange -= value;
            }
        }


        private event EventHandler FirstButtonClick
        {
            add
            {
                this.btnFirst.Click += Updatelbl_Count_First;
                this.btnFirst.Click += value;
                
            }
            remove
            {
                this.btnFirst.Click -= value;
            }
        }



        private event EventHandler PrevButtonClick
        {
            add
            {
                this.btnPrevious.Click += Updatelbl_Count_Prev;
                this.btnPrevious.Click += value;
                
            }
            remove
            {
                this.btnPrevious.Click -= value;
            }
        }



        private event EventHandler NextButtonClick
        {
            add
            {
                this.btnNext.Click += Updatelbl_Count_Next;
                this.btnNext.Click += value;
                
            }
            remove
            {
                this.btnNext.Click -= value;
            }
        }

        private event EventHandler LastButtonClick
        {
            add
            {
                this.btnLast.Click += Updatelbl_Count_Last;
                this.btnLast.Click += value;
                
            }
            remove
            {
                this.btnLast.Click -= value;
            }
        }

        
    }
}

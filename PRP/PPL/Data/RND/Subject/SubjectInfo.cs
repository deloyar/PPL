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

namespace PRP.PPL.Data.RND.Subject
{
    public partial class PplDataRnd_SubjectInformation : Form
    {

        db_ppl Connstring = new db_ppl();
        DataTable dt = new DataTable();
        DataTable dt_Grid = new DataTable();

        public PplDataRnd_SubjectInformation()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Code = txtSubjectCode.Text;
            string Name = txtSubjectName.Text;

            if (Code != "" && Name != "")
            {
                DataTable dt = Connstring.SqlDataTable(@"SELECT      [Subject Code], [Subject Name]
FROM            RND.[Subject Information]
WHERE        ([Subject Code] = N'"+ Code + "') AND ([Subject Name] = N'"+ Name + "')");

                if (dt.Rows.Count == 0)
                {
                    string sql = @"INSERT    
                    INTO              RND.[Subject Information]([Subject Code], [Subject Name])
                    VALUES        (@SubjectCode,@SubjectName)";
                    SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);
                    MyCommand.Parameters.AddWithValue("@SubjectCode", Code);
                    MyCommand.Parameters.AddWithValue("@SubjectName", Name);

                    Connstring.conn.Open();
                    int a = MyCommand.ExecuteNonQuery();
                    Connstring.conn.Close();

                    if (a == 1)
                    {
                        lbl_sell.Text = "Save Successfully.";
                    }
                    else
                    {
                        MessageBox.Show("Save Faild.");
                    }
                }
                else
                {
                    MessageBox.Show("Already exist.");
                }
            }
            else {
                lbl_sell.Text = "Please fill all required fields.";
            }

            SubjectList();
        }

        private void PplDataRndSubjectInfo_Load(object sender, EventArgs e)
        {
            Creat_GridView();
            SubjectList();
        }
        public void SubjectList()
        {
            dt_Grid.Clear();
            DataTable dt = Connstring.SqlDataTable(@"SELECT        [Subject Code] AS Code, [Subject Name] AS Name
FROM            RND.[Subject Information] ORDER BY [Subject Code] DESC");
            dt_Grid = dataGridView1.DataSource as DataTable;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = null;
                dr = dt_Grid.NewRow();
                dr["SubjectCode"] = dt.Rows[i]["Code"].ToString();
                dr["SubjectName"] = dt.Rows[i]["Name"].ToString();                
                dt_Grid.Rows.Add(dr);
            }
        }
        private void Creat_GridView()
        {
            DataTable dt1 = new DataTable();
            dt1.Columns.Add(new DataColumn("SubjectCode", typeof(string)));
            dt1.Columns.Add(new DataColumn("SubjectName", typeof(string)));
            dataGridView1.DataSource = dt1;
        }

        private void lbl_sell_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            lbl_sell.Text = "";
            txtSubjectCode.Text = "";
            txtSubjectName.Text = "";
            txtSubjectCode.ReadOnly = false;
            txtSubjectCode.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSubjectCode.ReadOnly = true;
            txtSubjectCode.Text = dataGridView1.Rows[e.RowIndex].Cells["SubjectCode"].Value.ToString();
            txtSubjectName.Text = dataGridView1.Rows[e.RowIndex].Cells["SubjectName"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Code = txtSubjectCode.Text;
            string Name = txtSubjectName.Text;

            if (Code != "" && Name != "")
            {
                DialogResult myResult;
                myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (myResult == DialogResult.OK)
                {
                    // confirm delete
                    if (Code != "" && Name != "")
                    {
                        string sql = @"DELETE FROM  RND.[Subject Information] WHERE [Subject Code]=@SubjectCode ";
                        SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);
                        MyCommand.Parameters.AddWithValue("@SubjectCode", Code);

                        Connstring.conn.Open();
                        int a = MyCommand.ExecuteNonQuery();
                        Connstring.conn.Close();

                        if (a == 1)
                        {
                            lbl_sell.Text = "Delete Successfull.";
                            btn_new.PerformClick(); //Reset all elements.
                        }
                        else
                        {
                            MessageBox.Show("Delete Faild.");
                        }
                    }
                    else
                    {
                        lbl_sell.Text = "Please select item.";
                    }

                    SubjectList();
                }
                else
                {
                    //No delete
                }
            }
            else
            {
                lbl_sell.Text = "Please select data.";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Code = txtSubjectCode.Text;
            string Name = txtSubjectName.Text;

            if (Code != "" && Name != "")
            {
                string sql = @"UPDATE RND.[Subject Information] 
                    SET [Subject Name]=@SubjectName WHERE [Subject Code]=@SubjectCode";
                SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);
                MyCommand.Parameters.AddWithValue("@SubjectCode", Code);
                MyCommand.Parameters.AddWithValue("@SubjectName", Name);

                Connstring.conn.Open();
                int a = MyCommand.ExecuteNonQuery();
                Connstring.conn.Close();

                if (a == 1)
                {
                    lbl_sell.Text = "Update Successfully.";
                }
                else
                {
                    MessageBox.Show("Update Faild.");
                }
            }
            else
            {
                lbl_sell.Text = "Please select data.";
            }

            SubjectList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSubjectCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
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

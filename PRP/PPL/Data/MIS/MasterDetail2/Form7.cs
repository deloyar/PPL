using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRP.PPL.Data.MIS.MasterDetail2
{
    public partial class Form7 : Form
    {
        db_ppl Connstring = new db_ppl();
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pPLDEVDataSet.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.pPLDEVDataSet.Users);
            pplNavigation1.SetModel<User>(ref userBindingSource);
            pplNavigation2.SetModel<User>(ref userBindingSource);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = Connstring.SqlDataTable(@"SELECT * FROM [PPLDEV].[dbo].[Users]");
            BindingSource bs = new BindingSource();
            DataNamesMapper<User> mappaer = new DataNamesMapper<User>();
            List<User> users = mappaer.Map(dt).ToList();



            bs.DataSource = users;
            pplNavigation1.BindingSource = bs;
            pplNavigation2.BindingSource = bs;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            userBindingSource.DataSource = pplNavigation1.BindingSource.Current as  User ;
        }
    }
}

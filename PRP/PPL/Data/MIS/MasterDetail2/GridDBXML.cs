using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PRP.PPL.Data.MIS.MasterDetail2
{
    public partial class GridDBXML : Form
    {
        db_ppl Connstring = new db_ppl();
        public GridDBXML()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBtoXMLAll();
        }

        //Genarate XML and insert into another table one by one row.
        public bool DBtoXML()
        {
            try
            {
                int count = 0;
                DataTable dt = Connstring.SqlDataTable(@"SELECT id, name, age
                            FROM           dbo.Users");
                List<User> Users = new List<User>();
                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("No data found");
                    return false;
                }
                foreach (DataRow row in dt.Rows)
                {
                    var user = new User();
                    int id;
                    int age;
                    int.TryParse(row["id"].ToString(), out id);
                    user.Name = row["name"].ToString();
                    int.TryParse(row["age"].ToString(), out age);
                    user.Age = age.ToString();
                    var XmlData = XmlManager.SerializetoXML<User>(user);
                    string sql = @"INSERT INTO dbo.[Xml]
                            (xmldata, userID)
                            VALUES        (@XmlData, @userID)";

                    SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);
                    MyCommand.Parameters.AddWithValue("@XmlData", XmlData);
                    MyCommand.Parameters.AddWithValue("@userID", id);

                    Connstring.conn.Open();
                    int Result = MyCommand.ExecuteNonQuery();
                    Connstring.conn.Close();


                    if (Result == 1)
                    {
                        count++;
                        label2.Text = count + " data updated";
                    }
                    else
                    {
                        label2.Text = "Data Sync failed";
                    }
                }

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        //Method for insert xml from another DB multiple row in a single row.
        public void DBtoXMLAll()
        {
            DataSet dataSet = new DataSet();
            string[] tableNames = { "Order", "OrderItem" };
            string finalXml = "";
            foreach (var tableName in tableNames)
            {
                DataTable dt = Connstring.SqlDataTable(@"SELECT *
                            FROM           dbo.[" + tableName + "] for xml path ('" + tableName + "'), root ('" + tableName + "')");
                DataRow row = dt.Rows[0];
                string xml = row[0].ToString();

                finalXml = finalXml + xml;

            }
            finalXml = finalXml.Trim();
            var cleanXML = Regex.Replace(finalXml, @"\s\s+", "");

            string sql = @"INSERT INTO dbo.[Xml]
                            (xmldata)
                            VALUES        (@cleanXML)";

            SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);
            MyCommand.Parameters.AddWithValue("@cleanXML", cleanXML);

            Connstring.conn.Open();
            int Result = MyCommand.ExecuteNonQuery();
            Connstring.conn.Close();


        }



        //xml to object (Deserialization)
        public bool XMLtoObject()
        {
            try
            {
                DataTable dt = Connstring.SqlDataTable(@"SELECT xmldata
                            FROM           dbo.Xml");
                List<User> Users = new List<User>();
                foreach (DataRow row in dt.Rows)
                {
                    String rawXML = row["xmldata"].ToString();
                    XmlSerializer ser = new XmlSerializer(typeof(User));

                    var user = (User)new XmlSerializer(typeof(User)).Deserialize(new StringReader(rawXML));
                    Users.Add(user);
                }
                dataGridView1.DataSource = Users;
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }


        //Update grid from xml
        public void loadGridfromXMLDB()
        {
            DataTable dt1 = new DataTable();
            string tableName = "Xml";
            DataTable dt = Connstring.SqlDataTable(@"SELECT xmldata
                            FROM           dbo.[" + tableName + "]");

            foreach (DataRow row in dt.Rows)
            {
                string temp = row["xmldata"].ToString();
                XDocument doc = XDocument.Parse(temp);
                XmlReader reader = doc.CreateReader();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(reader);
                dataGridView1.DataSource = dataSet.Tables[0];
            }


        }
    }
}

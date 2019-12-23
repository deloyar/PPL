using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace PRP.PPL.Data.MIS.MasterDetail2
{
    public partial class Hierarchy : Form
    {

        db_ppl Connstring = new db_ppl();
        public Hierarchy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenarateHierarchy();
        }


        public void GenarateHierarchy()
        {
            var root = new RootItem();
            DataTable dt = Connstring.SqlDataTable(@"SELECT [id], RTRIM(LTRIM([name])) AS name, RTRIM(LTRIM([parentID])) AS parentID, weight
                                                FROM [PPLDEV].[dbo].[hierarchy];");
            var parents = GetTopLevelRows(dt);
            root.nodeStructure = CreateItem(dt, parents);

            var serializer = new JavaScriptSerializer();
            serializer.RegisterConverters(new JavaScriptConverter[] { new NullPropertiesConverter() });
            var json = serializer.Serialize(root);

        }


        IEnumerable<DataRow> GetChildren(DataTable dataTable, int parentId)
        {

            string pid = "0";
            pid = parentId.ToString();
            var v = dataTable
            .Rows
            .Cast<DataRow>()
            .Where(row => row.Field<string>("ParentId").Trim() == pid);
            return v;
        }


        ChildNodeStructure CreateItem(DataTable dataTable, DataRow row)
        {
            var id = row.Field<int>("id");
            var name = row.Field<String>("name");
            var weight = row.Field<int>("weight");
            var childrens = GetChildren(dataTable, id)
              .Select(r => CreateItem(dataTable, r))
              .ToList();
            var masterChildNode = new ChildNodeStructure();
            if (weight != 0)
            {
                masterChildNode.pseudo = true;
                var tempitem = masterChildNode;
                for (int i = 0; i < weight; i++)
                {
                    var abcnode = new ChildNodeStructure
                    {
                        pseudo = true

                    };
                    tempitem.children = new List<ChildNodeStructure>()
                    {
                        abcnode
                    };

                    if (i + 1 == weight)
                    {
                        tempitem.children[0].children = new List<ChildNodeStructure>
                        {
                            new ChildNodeStructure
                            {
                                text= new Text {name = name },
                                children=childrens

                            }
                        };
                    }
                    else
                    {
                        tempitem = abcnode;
                    }
                }
            }
            else
            {
                masterChildNode.text = new Text { name = name };
                if (childrens.Count > 0)
                    masterChildNode.children = childrens;
            }

            return masterChildNode;
        }

        DataRow GetTopLevelRows(DataTable dataTable)
        {
            return dataTable
              .Rows
              .Cast<DataRow>()
              .Where(row => row.Field<string>("parentID").Trim() == "0").First();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Web.Script.Serialization;

namespace PRP.PPL.Data.MIS.MasterDetail2
{
    public partial class Form2 : Form
    {
        db_ppl Connstring = new db_ppl();
        DataTable dt = new DataTable();
        DataTable dt_Grid = new DataTable();
        DataTable dt_Grid2 = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string XmlData = XmlTextBox.Text;

            if (XmlData != "")
            {
                string sql = @"INSERT INTO dbo.[Xml]
                            (xmldata)
                            VALUES        (@XmlData)";

                SqlCommand MyCommand = new SqlCommand(sql, Connstring.conn);
                MyCommand.Parameters.AddWithValue("@XmlData", XmlData);

                Connstring.conn.Open();
                int Result = MyCommand.ExecuteNonQuery();
                Connstring.conn.Close();

                if (Result == 1)
                {
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show("Save failed.");
                }
            }
            else
            {
                MessageBox.Show("Please fill all required fields.");
            }

        }

        private void XmlTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Method for xml to gridview
        


        

        

        private void btnUpdateGrid_Click(object sender, EventArgs e)
        {
            //XMLtoObject();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CustomJson();
            //GenarateHierarchy();
            // DBtoXML();
            //Test2();
            //loadGridfromXMLDB();
        }

        


        public void CustomJson()
        {
            var obj = new RootItem();
            obj.chart = new Chart();
            obj.chart.container = "#example";
            obj.chart.nodeAlign = "BOTTOM";
            obj.chart.connectors = new ConnectorsType();
            obj.chart.connectors.type = "step";
            obj.chart.node = new Node();
            obj.chart.node.HTMLclass = "nodeExample1";
            obj.scrollbar = "fancy";
            obj.animateOnInit = true;
            obj.node = new Node();
            obj.node.collapsable = true;
            obj.animation = new Animation();
            obj.animation.nodeAnimation = "easeOutBounce";
            obj.animation.nodeSpeed = "nodeSpeed";
            obj.animation.connectorsAnimation = "bounce";
            obj.animation.connectorsSpeed = 700;
            obj.nodeStructure = new ChildNodeStructure();
            obj.nodeStructure.text = new Text();
            obj.nodeStructure.text.name = "MKT (CMO)";
            obj.nodeStructure.HTMLclass = "blue";
            obj.nodeStructure.image = "images/no_member.png";

            var child1 = new ChildNodeStructure()
            {
                connectors =
                    new Connector()
                    {
                        style = new Style()
                        {
                            stroke = "#000000"
                        }
                    },
                text = new Text()
                {
                    name = "Sales",
                },
                HTMLclass = "blue",
                image = "images/no_member.png"


            };

            var subchild1 = new ChildNodeStructure()
            {
                connectors = new Connector()
                {
                    style = new Style()
                    {
                        stroke = "#000000"
                    }
                },
                text = new Text()
                {
                    name = "SLM (HOD)",
                },
                HTMLclass = "blue",
                image = "images/no_member.png"
            };

            var subchild2 = new ChildNodeStructure()
            {
                connectors = new Connector()
                {
                    style = new Style()
                    {
                        stroke = "#000000"
                    }
                },
                text = new Text()
                {
                    name = "PPL & AKP (HOD)"
                },
                HTMLclass = "blue",
                image = "images/no_member.png"


            };
            var subchild3 = new ChildNodeStructure()
            {
                connectors = new Connector()
                {
                    style = new Style()
                    {
                        stroke = "#000000"
                    }
                },
                text = new Text()
                {
                    name = "DP (HOD)"
                },
                HTMLclass = "blue",
                image = "images/no_member.png"
            };
            var subchild4 = new ChildNodeStructure()
            {
                connectors = new Connector()
                {
                    style = new Style()
                    {
                        stroke = "#000000"
                    }
                },
                text = new Text()
                {
                    name = "CRE & Others (HOD)"
                },
                HTMLclass = "blue",
                image = "images/no_member.png"
            };

            var sublist = new List<ChildNodeStructure>();
            sublist.Add(subchild1);
            sublist.Add(subchild2);
            sublist.Add(subchild3);
            sublist.Add(subchild4);

            child1.children = sublist;


            var child2 = new ChildNodeStructure()
            {
                connectors = new Connector()
                {
                    style = new Style()
                    {
                        stroke = "#000000"
                    }
                },
                pseudo = true,
                children = new List<ChildNodeStructure>() {
                    new ChildNodeStructure { text=new Text {
                    name="Distribution (HOD)"
                }, HTMLclass="blue", image = "images/no_member.png"
                } }
            };
            var child3 = new ChildNodeStructure()
            {
                connectors = new Connector()
                {
                    style = new Style()
                    {
                        stroke = "#000000"
                    }
                },
                text = new Text()
                {
                    name = "Marketing"
                },
                HTMLclass = "blue",
                image = "images/no_member.png",
                link = new Link()
                {
                    href = "www.google.com",
                    target = "_blank"
                },
                children = new List<ChildNodeStructure>()
                {
                    new ChildNodeStructure()
                    {
                        children = new List<ChildNodeStructure>()
                        {
                            new ChildNodeStructure()
                            {
                                pseudo=true,
                                connectors = new Connector(),
                                children=new List<ChildNodeStructure>()
                                {
                                    new ChildNodeStructure()
                                    {
                                        pseudo=true,
                                        connectors = new Connector(),
                                        children = new List<ChildNodeStructure>()
                                        {
                                            new ChildNodeStructure()
                                            {
                                                pseudo=true,
                                                connectors = new Connector(),
                                                children = new List<ChildNodeStructure>()
                                                {
                                                    new ChildNodeStructure()
                                                    {
                                                        text=new Text()
                                                        {
                                                            name ="Final Test :D"
                                                        },
                                                        HTMLclass="blue",
                                                        image ="images/no_member.png"
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                            }
                        }
                    },

                    new ChildNodeStructure()
                    {
                        connectors=
                            new Connector()
                        {
                            style = new Style()
                            {
                                stroke = "#000000"
                            }
                        },
                        text=new Text()
                        {
                            name="Com (HOD)"
                        },
                        HTMLclass = "blue",
                        image="images/no_member.png"
                    },

                    new ChildNodeStructure()
                    {
                        connectors=
                            new Connector()
                        {
                            style = new Style()
                            {
                                stroke = "#000000"
                            }
                        },
                        text=new Text()
                        {
                            name="BRD (HOD)"
                        },
                        HTMLclass = "blue",
                        image="images/no_member.png"
                    }


                }
            };
            var childlist = new List<ChildNodeStructure>();
            childlist.Add(child1);
            childlist.Add(child2);
            childlist.Add(child3);
            obj.nodeStructure.children = childlist;

            //var serializer = new JavaScriptSerializer();
            //var serializedResult = serializer.Serialize(obj);


            var serializer = new JavaScriptSerializer();
            serializer.RegisterConverters(new JavaScriptConverter[] { new NullPropertiesConverter() });
            var json = serializer.Serialize(obj);


        }



        
    }
}

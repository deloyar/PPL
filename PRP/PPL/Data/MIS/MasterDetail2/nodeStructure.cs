using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRP.PPL.Data.MIS.MasterDetail2
{

    public class RootItem
    {
        public RootItem()
        {
            this.chart = new Chart();
            this.scrollbar = "fancy";
            this.animateOnInit = true;
            this.node = new Node
            {
                collapsable = true
            };
            this.animation = new Animation();

        }
        public Chart chart { get; set; }
        public string scrollbar { get; set; }
        public bool animateOnInit { get; set; }
        public Node node { get; set; }
        public Animation animation { get; set; }
        public ChildNodeStructure nodeStructure { get; set; }

    }
    
    public class Chart
    {
        public Chart()
        {
            this.container = "#example";
            this.nodeAlign = "BOTTOM";
            this.connectors = new ConnectorsType()
            {
                type = "step"
            };
            this.node = new Node()
            {
                HTMLclass = "nodeExample1"
            };
        }
        public string container { get; set; }
        public string nodeAlign { get; set; }
        public ConnectorsType connectors { get; set; }
        public string scrollbar { get; set; }
        public bool animateOnInit { get; set; }
        public Node node { get; set; }
    }
    public class Animation
    {
        public Animation()
        {
            this.nodeAnimation = "easeOutBounce";
            this.nodeSpeed = "nodeSpeed";
            this.connectorsAnimation = "bounce";
            this.connectorsSpeed = 700;
        }
        public string nodeAnimation { get; set; }
        public string nodeSpeed { get; set; }
        public string connectorsAnimation { get; set; }
        public int connectorsSpeed { get; set; }

    }
    public class Node
    {
        public string HTMLclass { get; set; }
        public bool collapsable { get; set; }
    }

    public class ConnectorsType
    {
        public string type { get; set; }
    }

    public class Text
    {
        public string name { get; set; }
    }
    public class Style
    {
        public string stroke { get; set; }
    }

    public class Link
    {
        public string href { get; set; }
        public string target { get; set; }
    }
    public class Connector
    {
        public Connector()
        {
            this.style = new Style()
            {
                stroke = "#000000"
            };
        }
        public Style style { get; set; }
    }
    public class NodeStructure
    {
        public NodeStructure()
        {
            this.HTMLclass = "blue";
            this.image="images/no_member.png";
        }
        public Text text { get; set; }
        public string HTMLclass { get; set; }
        public string image { get; set; }
        public List<ChildNodeStructure> children { get; set; }

    }
    public class ChildNodeStructure : NodeStructure
    {
        public ChildNodeStructure()
        {
            this.HTMLclass = "blue";
            this.image = "images/no_member.png";
            this.connectors = new Connector();
        }
        public Connector connectors { get; set; }
        public bool pseudo { get; set; }
        public Link link { get; set; }
    }
}

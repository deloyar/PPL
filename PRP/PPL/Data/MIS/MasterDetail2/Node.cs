using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRP.PPL.Data.MIS.MasterDetail2
{
    class Item
    {

        public int Id { get; set; }

        public String Name { get; set; }

        public IEnumerable<Item> Children { get; set; }
    }
}

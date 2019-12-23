using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRP.CDB.Function
{
    public class PPLComboBox:ComboBox
    {
        public PPLComboBox()
        {
            base.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Text = "---ALL---";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRP.CDB.Function
{
    class PPLTextOnlyTextBox: TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            var regex = new Regex(@"[^a-zA-Z.0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            //  to Call the implementation in the base TextBox class,
            // which raises the KeyPress event.
            base.OnKeyPress(e);
        }
    }
}

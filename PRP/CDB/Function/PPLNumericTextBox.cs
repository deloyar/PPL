using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRP.CDB.Function
{
    public class PPLNumericTextBox : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            // Ignore all non-control and non-numeric key presses.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //  to Call the implementation in the base TextBox class,
            // which raises the KeyPress event.
            base.OnKeyPress(e);
        }
    }
}

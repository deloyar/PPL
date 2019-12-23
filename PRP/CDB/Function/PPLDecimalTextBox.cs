using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRP.CDB.Function
{
    public class PPLDecimalTextBox: TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && (this.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            //  to Call the implementation in the base TextBox class,
            // which raises the KeyPress event.
            base.OnKeyPress(e);
        }
    }
}

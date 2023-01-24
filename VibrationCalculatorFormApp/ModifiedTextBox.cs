using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VibrationCalculatorFormApp {
    public enum Access {
        UnLock,
        Blocked
    }
    class ModifiedTextBox:TextBox {
        private string LastText;
        public Access Access = Access.UnLock;
        protected override void OnTextChanged(EventArgs e) {
            if (Access == Access.UnLock) {
                if (!double.TryParse(Text, out double result) && Text != "") {
                    Access = Access.Blocked;
                    Text = LastText;
                    Access = Access.UnLock;
                    this.SelectionStart = Text.Length;
                    return;
                }
                LastText = Text;
                base.OnTextChanged(e);
            }
        }
        protected override void OnKeyPress(KeyPressEventArgs e) {
            if (e.KeyChar =='.'|| e.KeyChar == ',') {
                e.KeyChar = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            }
            if (char.IsWhiteSpace(e.KeyChar)) {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
    }
}

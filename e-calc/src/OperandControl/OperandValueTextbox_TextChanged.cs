using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_calc.src
{
    partial class OperandControl
    {
        private int PrevCursorPosition;
        
        private void OperandValueTextbox_TextChanged(object sender, EventArgs e)
        {
            if (this.OperandValueTextbox.Text == "")
            { return; }

            System.Globalization.NumberFormatInfo info = new System.Globalization.NumberFormatInfo();
            string Separator = info.NumberDecimalSeparator;
            string OutputText = "";
            PrevCursorPosition = this.OperandValueTextbox.SelectionStart;

            bool IsSuccess = Double.TryParse(this.OperandValueTextbox.Text, out double result);
            if (IsSuccess)
            {
                this._MainWindow.PerformConversion();
            }
            else
            {
                foreach (char c in OperandValueTextbox.Text)
                {
                    if (char.IsDigit(c) || c.ToString() == Separator || c.ToString() == "-")
                    {
                        OutputText = OutputText + c;
                    }
                }
                this.OperandValueTextbox.TextChanged -= OperandValueTextbox_TextChanged;
                this.OperandValueTextbox.Text = OutputText;
                this.OperandValueTextbox.TextChanged += OperandValueTextbox_TextChanged;
                this.OperandValueTextbox.SelectionStart = PrevCursorPosition;
            }
        }
    }
}
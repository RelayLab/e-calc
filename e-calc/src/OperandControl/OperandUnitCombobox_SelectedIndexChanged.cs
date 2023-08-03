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
        private void OperandUnitCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._MainWindow.PerformConversion();
        }
    }
}
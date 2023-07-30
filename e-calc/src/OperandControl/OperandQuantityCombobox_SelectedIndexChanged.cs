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
        /// <summary>
        /// Это событие появляется при изменении
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperandQuantityCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> Units =
                this._MainWindow.UpdateUnits(
                (string)
                this.OperandQuantityCombobox.SelectedItem);
        }
    }
}
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
        /// Это событие появляется при изменении типа физической величины.
        /// При этом должен измениться комбобокс со списком единиц измерения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperandQuantityCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //из модели получить список единиц измерения для выбранной в комбобоксе физической величины
            List<string> Units =
                this._MainWindow.UpdateUnits(
                (string)
                this.OperandQuantityCombobox.SelectedItem);

            //загрузить это в комбобокс с единицами измерения
            OperandUnitCombobox.Items.Clear();
            OperandUnitCombobox.Items.AddRange(
                Units.ToArray());
            OperandUnitCombobox.SelectedIndex = 0;
        }
    }
}
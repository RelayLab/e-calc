using e_calc.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_calc
{
    partial class MainWindow
    {

        private void ResultQuantityCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SuspendLayout();

            ResultUnitCombobox.Items.Clear();

            List<string> Units = this.MainModel.UpdateUnits(
                    (string)this.ResultQuantityCombobox.SelectedItem);

            ResultUnitCombobox.Items.AddRange(Units.ToArray());
            ResultUnitCombobox.SelectedIndex = 0;

            Helper.ResizeCombobox(ResultUnitCombobox);

            this.ResumeLayout();
        }
    }
}
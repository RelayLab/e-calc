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
        /// <summary>
        /// Эта функция вызывается при выборе любого элемента из комбобокса (нового типа преобразования)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConversionCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SuspendLayout();

            string ActiveConversion = (string)this.ConversionCombobox.SelectedItem;

            this.OperandsPanel.Controls.Clear();

            //получаем из модели список операндов (окон Величина 1,2...), которые будут отображаться на экране
            List<string> QuantitiesAsString = this.MainModel.ConversionChanged(ActiveConversion);
            int OperandsCount               = this.MainModel.GetOperandsCount(ActiveConversion);

            //добавлем на экран новые окошки для каждой физической величины
            for (int i = 0; i < OperandsCount; i++)
            {
                OperandControl oc = new OperandControl(i, QuantitiesAsString, this);
                OperandsPanel.Controls.Add(oc);
            }

            ResultQuantityCombobox.Items.Clear();
            
            ResultQuantityCombobox.Items.AddRange(
                this.MainModel.GetResultQuantities(ActiveConversion).ToArray());
            ResultQuantityCombobox.SelectedIndex = 0;
            Helper.ResizeCombobox(ResultQuantityCombobox);

            //записать в комбобоксы величины, которые используются например в первой формуле
            //чтобы сразу на экране был какой-то результат
            List<string> DefaultQuantities = this.MainModel.GetDefaultQuantities(ActiveConversion);
            int j = 0;
            foreach(OperandControl oc in this.OperandsPanel.Controls)
            {
                oc.SelectItem(DefaultQuantities[j]);
                j++;
            }
            ResultQuantityCombobox.SelectedItem = DefaultQuantities.Last();
            


            InfoTextbox.Text = MainModel.GetConversionInfo(ActiveConversion);


            this.ResumeLayout();
        }



    }
}
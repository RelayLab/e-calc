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

            InfoTextbox.Text = MainModel.GetConversionInfo(ActiveConversion);


            this.ResumeLayout();
        }

        /// <summary>
        /// Эта функция для заданной физической величины обновляет список единиц измерения из модели
        /// </summary>
        /// <param name="SelectedItem"></param>
        /// <returns></returns>
        public List<string> UpdateUnits(string SelectedItem)
        {
            return this.MainModel.UpdateUnits(SelectedItem);

        }

    }
}
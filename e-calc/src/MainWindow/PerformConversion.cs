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
        /// Эта функция посылает сигнал из главного окна в модель для главного вычисления преобразования. В результате в текстбокс записывается результат
        /// </summary>
        public void PerformConversion()
        {
            //проверяем, что во всех окнах введены данные

            if (this.OperandsPanel.Controls.Count == 0)
                return;

            foreach (OperandControl oc in this.OperandsPanel.Controls)
            {
                if (oc.Value == "" || oc.Value == null)
                { return; }
            }
            //сведения обо всех введенных на экранах величинах кладём в список
            List<OperandInfo> Infos = new List<OperandInfo>();
            int i = 0;
            foreach (OperandControl oc in this.OperandsPanel.Controls)
            {
                OperandInfo oi = new OperandInfo(
                    i++,
                    oc.Quantity,
                    oc.Value,
                    oc.Unit);

                Infos.Add(oi);

            }
            //сведения о требуемом результате кладём в отдельный объект
            OperandInfo ResultInfo = new OperandInfo(
                0,
                this.ResultQuantityCombobox.Text,
                this.ResultValueTextbox.Text,
                this.ResultUnitCombobox.Text);

            //запускаем вычисление
            string Result = 
                this.MainModel.PerformConversion(
                    Infos,
                    ResultInfo,
                    this.ConversionCombobox.Text);

            if (Result == null) 
            {
                this.ResultValueTextbox.Text = "Ошибка!";
                this.ResultValueTextbox.BackColor = Color.Tomato;
            }
            else
            {
                this.ResultValueTextbox.Text = Result;
                this.ResultValueTextbox.BackColor = Color.FromKnownColor(System.Drawing.KnownColor.Control);
            }
        }

    }
}
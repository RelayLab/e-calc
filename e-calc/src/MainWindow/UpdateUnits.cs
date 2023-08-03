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
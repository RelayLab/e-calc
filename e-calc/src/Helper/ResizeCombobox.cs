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
    internal  class Helper
    {

        /// <summary>
        /// Эта функция подгоняет ширину Combobox под его содержимое. Такой стандартной функции WinForms нет.
        /// </summary>
        /// <param name="cb"></param>
        public static void ResizeCombobox(ComboBox cb)
        {
            int ItemSize = 0;
            int MaxItemSize = 0;

            //в цикле проходим по всем элементам и с помощью стандартной фукнции TextRenderer.MeasureText определяем ширину всех элементов.
            //затем ширину комбобокса задаём по максимальной величине
            foreach (string item in cb.Items)
            {
                ItemSize = TextRenderer.MeasureText(
                    item,
                    cb.Font).Width;

                MaxItemSize = ItemSize > MaxItemSize ?
                    ItemSize :
                    MaxItemSize;
            }

            cb.Width = MaxItemSize + 20;
        }

    }
}

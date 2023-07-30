using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace e_calc
{
    partial class Model
    {

        /// <summary>
        /// Эта функция возвращает количество физических величин, которые нужны для выбранного преобразования
        /// </summary>
        /// <param name="SelectedItem">название нужного преобразования</param>
        /// <returns>количество физических величин, которые нужны для выбранного преобразования</returns>
        public int GetQuantitiesCount(string SelectedItem)
        {
            foreach (Conversion1 c in this.Conversions)
            {
                if (c.Name == SelectedItem)
                    return c.OperandsCount;
            }
            return 0;
        }

    }
}
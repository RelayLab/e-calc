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
        /// Эта функция передаёт в окно список возможных физических величин при выборе пользователем нового типа преобразования
        /// </summary>
        /// <param name="SelectedItem">название нужного преобразования</param>
        /// <returns>список возможных физических величин</returns>
        public List<string> ConversionChanged(string SelectedItem)
        {
            foreach (Conversion1 c in this.ConversionsReference)
            {
                if (c.Name == SelectedItem)
                    return c.QuantitiesAsString;
            }
            return null;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace e_calc
{

    
    enum PhysicalQuantity { Voltage, Current, Power, Energy };

    /// <summary>
    /// Вспомогательный класс, который содержит некоторые общие методы для разных классов, например, доступ к строковому значению по заданному enum 
    /// </summary>
    static class Helper
    {
        /// <summary>
        /// Этот словарь преобразует enum к их текстовому представлению
        /// </summary>
        private static Dictionary<PhysicalQuantity, String> QuantityDictionary =
            new Dictionary<PhysicalQuantity, string>
            {
                { PhysicalQuantity.Voltage, "Напряжение" },
                { PhysicalQuantity.Current, "Ток"        },
                { PhysicalQuantity.Power  , "Мощность"   }
            };

        /// <summary>
        /// Эта функция преобразует enum к их строковому представлению с помощью словаря Dictionary, определённого в этом же классе Helper
        /// </summary>
        /// <param name="quantities">Список из нескольких enum</param>
        /// <returns>Те же enum, но в виде строк</returns> 
        public static List<string> QuantitiesAsString(List<PhysicalQuantity> quantities)
        {

            List<string> OutputList = new List<string>();

            foreach (PhysicalQuantity item in quantities)
            {
                string QuantityAsString;
                bool IsSuccess = QuantityDictionary.TryGetValue(item, out QuantityAsString);
                if (!IsSuccess)
                {
                    QuantityAsString = "ошибка!";
                }
            }
            return OutputList;
        }
    }


}
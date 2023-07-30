using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace e_calc
{

    
    enum PhysicalQuantity { Voltage, Current, ActivePower, Energy };
    enum UnitsVoltage { V, kV };
    enum UnitsCurrent { A, kA };
    enum UnitsActivePower { W, kW, MW };

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
                { PhysicalQuantity.Voltage,     "Напряжение"        },
                { PhysicalQuantity.Current,     "Ток"               },
                { PhysicalQuantity.ActivePower, "Активная мощность" }
            };

        private static Dictionary<UnitsVoltage, String> UnitsVoltageDictionary =
            new Dictionary<UnitsVoltage, string>
            {
                { UnitsVoltage.V,     "В"       },
                { UnitsVoltage.kV,    "кВ"      }
            };

        private static Dictionary<UnitsCurrent, String> UnitsCurrentDictionary =
            new Dictionary<UnitsCurrent, string>
            {
                { UnitsCurrent.A,     "А"       },
                { UnitsCurrent.kA,    "кА"      }
            };

        private static Dictionary<UnitsActivePower, String> UnitsActivePowerDictionary =
            new Dictionary<UnitsActivePower, string>
            {
                { UnitsActivePower.W,     "Вт"       },
                { UnitsActivePower.kW,    "кВт"      },
                { UnitsActivePower.MW,    "МВт"      }
            };


        /// <summary>
        /// Эта функция возвращает тип физической величины по заданной строке
        /// </summary>
        /// <param name="QuantityAsString">тип в формате строки</param>
        /// <returns>тип в формате enum PhysicalQuantity</returns>
        public static PhysicalQuantity GetQuantityByString(string QuantityAsString)
        {
            return QuantityDictionary.Where(x => x.Value == QuantityAsString).Select(x => x.Key).First();
        }

        public static Type GetUnitsByQuantity(PhysicalQuantity quantity)
        {
            Type VoltageType     = UnitsVoltageDictionary.GetType();
            Type CurrentType     = UnitsCurrentDictionary.GetType();
            Type ActivePowerType = UnitsActivePowerDictionary.GetType();

            if (quantity.GetType() == VoltageType)
                return VoltageType;

            if (quantity.GetType() == CurrentType)
                return CurrentType;

            if (quantity.GetType() == ActivePowerType)
                return ActivePowerType;

            return null;
        }

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
                else
                {
                    OutputList.Add(QuantityAsString);
                }
            }
            return OutputList;
        }

    }


}
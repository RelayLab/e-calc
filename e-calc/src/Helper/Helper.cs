using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace e_calc
{
    /// <summary>
    /// Все основные типы используемых величин.
    /// ДОЛЖНО СОВПАДАТЬ С Helper.QuantitiesReference
    /// </summary>
    enum PhysicalQuantityEnum 
    {
        Voltage, 
        Current, 
        ActivePower, 
        Energy 
    };

    enum Units 
    { 
        V, 
        kV, 
        A, 
        kA,
        W, 
        kW, 
        MW
    };

    /// <summary>
    /// Вспомогательный класс, который содержит некоторые общие методы для разных классов, например, доступ к строковому значению по заданному enum 
    /// </summary>
    static partial class Helper
    {
        /// <summary>
        /// Это переменная, которая хранит пример каждой физической величины для того, чтобы можно было взять список единиц измерения, названия и т.п.
        /// ДОЛЖНО СОВПАДАТЬ С PhysicalQuantityEnum!!! 
        /// </summary>
        private static List<IPhysicalQuantity> QuantitiesReference =
            new List<IPhysicalQuantity>
        {
            new QuantityVoltage(),
            new QuantityCurrent(),
            new QuantityActivePower()
            //new QuantityEnergy()
        };

        //{ UnitsCurrent.A,     "А"       },
        //{ UnitsCurrent.kA,    "кА"      }
        //{ UnitsActivePower.W,     "Вт"       },
        //{ UnitsActivePower.kW,    "кВт"      },
        //{ UnitsActivePower.MW,    "МВт"      }


        /// <summary>
        /// Эта функция возвращает список единиц измерения физической величины по заданной строке
        /// </summary>
        /// <param name="SelectedItem">тип в формате строки</param>
        /// <returns>список единиц измерения физической величины </returns>
        public static List<string> GetUnitsByString(string SelectedItem)
        {
            return QuantitiesReference.
                Where(x => x.Name == SelectedItem).
                Select(x => x.Units).
                First();
        }



    }


}
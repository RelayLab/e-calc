using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace e_calc
{

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
            new QuantityActivePower(),
            new QuantityHeatPower()
            //new QuantityEnergy()
        };


        

        /// <summary>
        /// Эта функция возвращает список единиц измерения физической величины по заданной строке
        /// </summary>
        /// <param name="SelectedItem">тип в формате строки</param>
        /// <returns>список единиц измерения физической величины </returns>
        public static List<string> GetUnitsByQuantity(string SelectedItem)
        {
            return QuantitiesReference.
                Where(x => x.Name == SelectedItem).
                Select(x => x.UnitsAsString).
                First();
        }

        public static PhysicalQuantityEnum GetQuantityEnumByString(string SelectedItem)
        {
            return QuantitiesReference.
                Where(x => x.Name == SelectedItem).
                Select(x => x.NameAsEnum).
                First();
        }

        public static string GetQuantityStringByEnum(PhysicalQuantityEnum SelectedItem)
        {
            return QuantitiesReference.
                Where(x => x.NameAsEnum == SelectedItem).
                Select(x => x.Name).
                First();
        }

        public static double NormalizeQuantity(PhysicalQuantityEnum q, double v, string u)
        {
            return QuantitiesReference.
                Where(x => x.NameAsEnum == q).Select(x => x.Normalize(v, u)).First();
        }

        public static double ReverseQuantity(PhysicalQuantityEnum q, double v, string u)
        {
            return QuantitiesReference.
                Where(x => x.NameAsEnum == q).Select(x => x.Reverse(v, u)).First();
        }

    }


}
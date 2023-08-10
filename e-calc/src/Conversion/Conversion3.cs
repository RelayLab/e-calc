using System.Collections.Generic;

namespace e_calc
{
    /// <summary>
    /// Преобразование "Градусы Цельсия - Фаренгейта - Кельвина".
    /// </summary>
    internal class Conversion3 : Conversion
    {

        /// <summary>
        /// В этом конструкторе задаются все нужные формулы, описания, величины для преобразования. Все остальные функции находятся в базовом классе Conversion
        /// </summary>
        public Conversion3()
        {
            //Количество операндов, то есть окон Величина 1,2,3, которые будет отображаться.
            OperandsCount = 1;
            //Глобальное название задачи, которая решается с помощью этого преобразователя.
            Name = "Градусы Цельсия - Фаренгейта - Кельвина";
            // Набор физических величин, которые могут быть выбраны в качестве одного из операндов (не путать с количеством операндов!).
            Quantities = new List<IPhysicalQuantity>()
            {
                new QuantityTemperature()
            };
            // Любая информация: формулы, описание доп. опций и т.п.
            ConversionInfo =
                "Формула перевода: t_C = 5/9 * ( t_F - 32 ) = t_K - 273,15\n";

            Formulas.Add(
                new Formula(
                    x => x[0],
                    PhysicalQuantityEnum.Temperature,
                    PhysicalQuantityEnum.Temperature));
        }
    }
}
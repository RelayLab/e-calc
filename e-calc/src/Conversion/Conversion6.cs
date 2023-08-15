using System;
using System.Collections.Generic;

namespace e_calc
{
    /// <summary>
    /// Преобразование "косинус(cos φ) - тангенс(tg φ) коэффициента мощности"
    /// </summary>
    internal class Conversion6 : Conversion
    {

        /// <summary>
        /// В этом конструкторе задаются все нужные формулы, описания, величины для преобразования. Все остальные функции находятся в базовом классе Conversion
        /// </summary>
        public Conversion6()
        {
            //Количество операндов, то есть окон Величина 1,2,3, которые будет отображаться.
            OperandsCount = 1;
            //Глобальное название задачи, которая решается с помощью этого преобразователя.
            Name = "Косинус(cosφ) - синус(sinφ) - тангенс(tgφ)";
            // Набор физических величин, которые могут быть выбраны в качестве одного из операндов (не путать с количеством операндов!).
            Quantities = new List<IPhysicalQuantity>()
            {
                new QuantityPowerFactor(),
                new QuantityPowerFactorSin(),
                new QuantityPowerFactorTg()
            };
            // Любая информация: формулы, описание доп. опций и т.п.
            ConversionInfo =
                "Коэффициент мощности cosф (без размерности) - коэффициент между активной и полной мощностью, аналог КПД\n" +
                "cosφ, sinφ, tgφ";

            Formulas.Add(
                new Formula(
                    x => Math.Sin(Math.Acos(x[0])),
                    PhysicalQuantityEnum.PowerFactorSin,
                    PhysicalQuantityEnum.PowerFactor
                    ));

            Formulas.Add(
                new Formula(
                    x => Math.Sin(Math.Atan(x[0])),
                    PhysicalQuantityEnum.PowerFactorSin,
                    PhysicalQuantityEnum.PowerFactorTg
                    ));

            Formulas.Add(
                new Formula(
                    x => Math.Tan(Math.Acos(x[0])),
                    PhysicalQuantityEnum.PowerFactorTg,
                    PhysicalQuantityEnum.PowerFactor
                    ));

            Formulas.Add(
                new Formula(
                    x => Math.Tan(Math.Asin(x[0])),
                    PhysicalQuantityEnum.PowerFactorTg,
                    PhysicalQuantityEnum.PowerFactorSin
                    ));

            Formulas.Add(
                new Formula(
                    x => Math.Cos(Math.Asin(x[0])),
                    PhysicalQuantityEnum.PowerFactor,
                    PhysicalQuantityEnum.PowerFactorSin
                    ));

            Formulas.Add(
                new Formula(
                    x => Math.Cos(Math.Atan(x[0])),
                    PhysicalQuantityEnum.PowerFactor,
                    PhysicalQuantityEnum.PowerFactorTg
                    ));

        }
    }
}
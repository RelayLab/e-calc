using System;
using System.Collections.Generic;

namespace e_calc
{
    /// <summary>
    /// Преобразование  "ток(А) - напряжение(В) - сопротивление(Ом) - мощность(кВт)"
    /// </summary>
    internal class Conversion7 : Conversion
    {

        /// <summary>
        /// В этом конструкторе задаются все нужные формулы, описания, величины для преобразования. Все остальные функции находятся в базовом классе Conversion
        /// </summary>
        public Conversion7()
        {
            //Количество операндов, то есть окон Величина 1,2,3, которые будет отображаться.
            OperandsCount = 3;
            //Глобальное название задачи, которая решается с помощью этого преобразователя.
            Name = "Ток(А) - напряжение(В) - сопротивление(Ом) - мощность(кВт)";
            // Набор физических величин, которые могут быть выбраны в качестве одного из операндов (не путать с количеством операндов!).
            Quantities = new List<IPhysicalQuantity>()
            {
                new QuantityVoltage(),
                new QuantityCurrent(),
                new QuantityPowerFactor(),
                new QuantityActivePower(),
                new QuantityReactivePower(),
                new QuantityResistance(),
                new QuantityReactance()
            };

            // Любая информация: формулы, описание доп. опций и т.п.
            ConversionInfo =
                "В трёхфазной системе есть два вида напряжения - фазное (фаза-ноль) и междуфазное (фаза-фаза).\n" +
                "В схеме соединения обмоток «треугольник» эти напряжения равны.\n" +
                "Ток и сопротивления всегда фазные, измеряются только в одной фазе.\n" +
                "Формулы:\n";

            Formulas.Add(
                new Formula(
                    x => x[0]* x[1]* x[2],
                    PhysicalQuantityEnum.ActivePower,
                    PhysicalQuantityEnum.Voltage,
                    PhysicalQuantityEnum.Current,
                    PhysicalQuantityEnum.PowerFactor
                    ));

            Formulas.Add(
                new Formula(
                    x => x[0] * x[1] * Math.Sin(Math.Acos(x[2])),
                    PhysicalQuantityEnum.ReactivePower,
                    PhysicalQuantityEnum.Voltage,
                    PhysicalQuantityEnum.Current,
                    PhysicalQuantityEnum.PowerFactor
                    ));

            Formulas.Add(
                new Formula(
                    x => x[0] / x[1] * x[2],
                    PhysicalQuantityEnum.Resistance,
                    PhysicalQuantityEnum.Voltage,
                    PhysicalQuantityEnum.Current,
                    PhysicalQuantityEnum.PowerFactor
                    ));

            Formulas.Add(
                new Formula(
                    x => x[0] / x[1] * Math.Sin(Math.Acos(x[2])),
                    PhysicalQuantityEnum.Reactance,
                    PhysicalQuantityEnum.Voltage,
                    PhysicalQuantityEnum.Current,
                    PhysicalQuantityEnum.PowerFactor
                    ));
        }
    }
}
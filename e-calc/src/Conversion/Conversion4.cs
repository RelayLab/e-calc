using System.Collections.Generic;

namespace e_calc
{
    /// <summary>
    /// Преобразование "мощность(кВт) - энергия(кАч)".
    /// </summary>
    internal class Conversion4 : Conversion
    {

        /// <summary>
        /// В этом конструкторе задаются все нужные формулы, описания, величины для преобразования. Все остальные функции находятся в базовом классе Conversion
        /// </summary>
        public Conversion4()
        {
            //Количество операндов, то есть окон Величина 1,2,3, которые будет отображаться.
            OperandsCount = 2;
            //Глобальное название задачи, которая решается с помощью этого преобразователя.
            Name = "Мощность(кВт) - энергия(кАч)";
            // Набор физических величин, которые могут быть выбраны в качестве одного из операндов (не путать с количеством операндов!).
            Quantities = new List<IPhysicalQuantity>()
            {
                new QuantityActivePower(),
                new QuantityEnergy(),
                new QuantityTime()
            };
            // Любая информация: формулы, описание доп. опций и т.п.
            ConversionInfo =
                "Формула перевода: энергия = мощность * время\n";

            Formulas.Add(
                new Formula(
                    x => x[0] * x[1],
                    PhysicalQuantityEnum.Energy,
                    PhysicalQuantityEnum.ActivePower, 
                    PhysicalQuantityEnum.Time       
                    ));

            Formulas.Add(
                new Formula(
                    x => x[0] * x[1],
                    PhysicalQuantityEnum.Energy,
                    PhysicalQuantityEnum.Time,
                    PhysicalQuantityEnum.ActivePower
                    ));

            Formulas.Add(
                new Formula(
                    x => x[0] / x[1],
                    PhysicalQuantityEnum.ActivePower,
                    PhysicalQuantityEnum.Energy,
                    PhysicalQuantityEnum.Time
                    ));

            Formulas.Add(
                new Formula(
                    x => x[1] / x[0],
                    PhysicalQuantityEnum.ActivePower,
                    PhysicalQuantityEnum.Time,
                    PhysicalQuantityEnum.Energy
                    ));

            Formulas.Add(
                new Formula(
                    x => x[0] / x[1],
                    PhysicalQuantityEnum.Time,
                    PhysicalQuantityEnum.Energy,
                    PhysicalQuantityEnum.ActivePower
                    ));

            Formulas.Add(
                new Formula(
                    x => x[1] / x[0],
                    PhysicalQuantityEnum.Time,
                    PhysicalQuantityEnum.ActivePower,
                    PhysicalQuantityEnum.Energy
                    ));
        }
    }
}
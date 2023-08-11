using System.Collections.Generic;

namespace e_calc
{
    /// <summary>
    /// Преобразование "активная(кВт) - реактивная(кВА) мощность"
    /// </summary>
    internal class Conversion5 : Conversion
    {

        /// <summary>
        /// В этом конструкторе задаются все нужные формулы, описания, величины для преобразования. Все остальные функции находятся в базовом классе Conversion
        /// </summary>
        public Conversion5()
        {
            //Количество операндов, то есть окон Величина 1,2,3, которые будет отображаться.
            OperandsCount = 3;
            //Глобальное название задачи, которая решается с помощью этого преобразователя.
            Name = "Активная(Вт) - реактивная(ВАр) - полная (ВА) мощность";
            // Набор физических величин, которые могут быть выбраны в качестве одного из операндов (не путать с количеством операндов!).
            Quantities = new List<IPhysicalQuantity>()
            {
                new QuantityActivePower(),
                new QuantityReactivePower(),
                new QuantityComplexPower(),
                new QuantityPowerFactor(),

            };
            // Любая информация: формулы, описание доп. опций и т.п.
            ConversionInfo =
                "Активная мощность P (Ватт) совершает работу, преобразуется в тепловую, механическую или химическую энергию\n" +
                "Реактивная мощность Q (Воль-Ампер реактивный) только для переменного тока, «запасается» в электромагнитном поле\n" +
                "Полная мощность S (Воль-Ампер) - кажущаяся мощность, геометрическая сумма активной и реактивной мощности\n" +
                "Коэффициент мощности cosф (без размерности) - коэффициент между активной и полной мощностью, аналог КПД\n" +
                "Формулы перевода: S = P + jQ*\n" +
                "P = S cosф\n";

            Formulas.Add(
                new Formula(
                    x => x[0] * x[1],
                    PhysicalQuantityEnum.ComplexPower,
                    PhysicalQuantityEnum.ActivePower,
                    PhysicalQuantityEnum.ReactivePower,
                    PhysicalQuantityEnum.PowerFactor       
                    ));

            
        }
    }
}
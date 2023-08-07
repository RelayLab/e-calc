using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_calc
{
    /// <summary>
    /// Преобразование "электрическая(Вт) - тепловая(кал/ч) мощность".
    /// </summary>
    class Conversion2 : Conversion
    {

        /// <summary>
        /// В этом конструкторе задаются все нужные формулы, описания, величины для преобразования. Все остальные функции находятся в базовом классе Conversion
        /// </summary>
        public Conversion2()
        {
            //Количество операндов, то есть окон Величина 1,2,3, которые будет отображаться.
            OperandsCount = 1;
            //Глобальное название задачи, которая решается с помощью этого преобразователя.
            Name = "электрическая(Вт) - тепловая(кал/ч) мощность";
            // Набор физических величин, которые могут быть выбраны в качестве одного из операндов (не путать с количеством операндов!).
            Quantities = new List<IPhysicalQuantity>()
            {
                new QuantityActivePower(),
                new QuantityHeatPower(),
            };
            // Любая информация: формулы, описание доп. опций и т.п.
            ConversionInfo = 
                "Тепловая мощность - энергия сжигаемого топлива за 1 секунду.\n" +
                "Электрическая мощность - энергия потребляемого или генерируемого электричества за 1 секунду.\n" +
                "Обе величины можно измерять в одних и тех же единицах, но принято тепловую мощность измерять в калориях/час, а электрическую - в Ваттах." +
                "Например, если электрическая мощность электростанции P = 100 МВт и КПД электростанции 50%, то тепловая мощность будет равна Q = 200 МВт = 200 МВт * 0,86 ккал/ч/Вт = 172 Гкал/ч.";

            Formulas.Add(
                new Formula(
                    x => x[0],
                    PhysicalQuantityEnum.HeatPower,
                    PhysicalQuantityEnum.ActivePower));

            Formulas.Add(
                new Formula(
                    x => x[0],
                    PhysicalQuantityEnum.ActivePower,
                    PhysicalQuantityEnum.HeatPower));

            Formulas.Add(
                new Formula(
                    x => x[0],
                    PhysicalQuantityEnum.ActivePower,
                    PhysicalQuantityEnum.ActivePower));

            Formulas.Add(
                new Formula(
                    x => x[0],
                    PhysicalQuantityEnum.HeatPower,
                    PhysicalQuantityEnum.HeatPower));
            //1 кал = 4,1868 Дж. 

        }
    }
}

//    "любые величины",
//    "ток(А) - напряжение(В) - сопротивление(Ом) - мощность(кВт)" ,
//    "мощность(кВт) - энергия(кАч)",

//    "активная(кВт) - полная(кВА) мощность",
//    "активная(кВт) - реактивная(кВА) мощность",
//    "косинус(cos φ) - тангенс(tg φ) коэффициента мощности"
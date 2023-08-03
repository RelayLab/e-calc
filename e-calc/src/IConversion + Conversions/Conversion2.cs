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
    /// Преобразование "любые величины"
    /// </summary>
    class Conversion2 : Conversion
    {
        public Conversion2()
        {
            OperandsCount = 1;
            Name = "электрическая(Вт) - тепловая(кал/ч) мощность";
            Quantities = new List<IPhysicalQuantity>
            {
                new QuantityActivePower(),
                new QuantityHeatPower(),
            };

            QuantitiesAsString = 
                Quantities.Select(x => x.Name).ToList();

            ConversionInfo = 
                "Тепловая мощность - энергия сжигаемого топлива за 1 секунду.\n" +
                "Электрическая мощность - энергия потребляемого или генерируемого электричества за 1 секунду.\n" +
                "Обе величины можно измерять в одних и тех же единицах, но принято тепловую мощность измерять в калориях/час, а электрическую - в Ваттах." +
                "Например, если электрическая мощность электростанции P = 100 МВт и КПД электростанции 50%, то тепловая мощность будет равна Q = 200 МВт = 200 МВт * 0,86 ккал/ч/Вт = 172 Гкал/ч.";

            Formulas = new List<Formula>();

            Formulas.Add(
                new Formula(
                    x => x[0] * 0.85,
                    PhysicalQuantityEnum.HeatPower,
                    PhysicalQuantityEnum.ActivePower));

            Formulas.Add(
                new Formula(
                    x => x[0] / 0.85,
                    PhysicalQuantityEnum.ActivePower,
                    PhysicalQuantityEnum.HeatPower));

        }
    }
}

//    "любые величины",
//    "ток(А) - напряжение(В) - сопротивление(Ом) - мощность(кВт)" ,
//    "мощность(кВт) - энергия(кАч)",

//    "активная(кВт) - полная(кВА) мощность",
//    "активная(кВт) - реактивная(кВА) мощность",
//    "косинус(cos φ) - тангенс(tg φ) коэффициента мощности"
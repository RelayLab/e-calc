using System.Collections.Generic;

namespace e_calc
{
    /// <summary>
    /// Физическая единица - Энергия
    /// </summary>
    internal class QuantityEnergy : PhysicalQuantity
    {
        public QuantityEnergy()
        {
            Name = "Энергия";
            NameAsEnum = PhysicalQuantityEnum.Energy;

            double cal = 4.1868;
            double Wh = 3600;

            Units = new List<Unit>()
            {
                new Unit(   "кВт•ч",    UnitsEnum.cal,  1e3*Wh, 0),
                new Unit(   "Вт•ч",     UnitsEnum.kcal, Wh,     0),
                new Unit(   "МВт•ч",    UnitsEnum.Gcal, 1e6*Wh, 0),
                new Unit(   "ГВт•ч",    UnitsEnum.Gcal, 1e9*Wh, 0),
                new Unit(   "Дж",       UnitsEnum.J,    1,      0),
                new Unit(   "кДж",      UnitsEnum.kJ,   1e3,    0),
                new Unit(   "МДж",      UnitsEnum.MJ,   1e6,    0),
                new Unit(   "ГДж",      UnitsEnum.GJ,   1e9,    0),
                new Unit(   "кал",      UnitsEnum.cal,  cal,    0),
                new Unit(   "ккал",     UnitsEnum.kcal, 1e3*cal,0),
                new Unit(   "Мкал",     UnitsEnum.Mcal, 1e6*cal,0),
                new Unit(   "Гкал",     UnitsEnum.Gcal, 1e9*cal,0),
            };
        }

    }
}
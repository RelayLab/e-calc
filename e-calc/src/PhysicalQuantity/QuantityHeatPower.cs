using System.Collections.Generic;

namespace e_calc
{
    /// <summary>
    /// Физическая единица - Тепловая мощность
    /// </summary>
    internal class QuantityHeatPower : PhysicalQuantity
    {
        public QuantityHeatPower()
        {
            Name = "Тепловая мощность";
            NameAsEnum = PhysicalQuantityEnum.HeatPower;

            double cal = 4.1868;
            Units = new List<Unit>()
            {
                new Unit(   "кал/ч",    UnitsEnum.cal,   cal, 0),
                new Unit(   "ккал/ч",   UnitsEnum.kcal,  1e3*cal, 0),
                new Unit(   "Мкал/ч",   UnitsEnum.Mcal,  1e6*cal, 0),
                new Unit(   "Гкал/ч",   UnitsEnum.Gcal,  1e9*cal, 0)
            };
        }
    }
}
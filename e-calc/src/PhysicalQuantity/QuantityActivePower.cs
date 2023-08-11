using System.Collections.Generic;

namespace e_calc
{
    /// <summary>
    /// Физическая единица - Активная мощность
    /// </summary>
    internal class QuantityActivePower : PhysicalQuantity
    {
        public QuantityActivePower()
        {
            Name = "Активная мощность";
            NameAsEnum = PhysicalQuantityEnum.ActivePower;
            Units = new List<Unit>()
            {
                new Unit(   "Вт",    UnitsEnum.W,   1, 0),
                new Unit(   "кВт",   UnitsEnum.kW,  1e3, 0),
                new Unit(   "МВт",   UnitsEnum.MW,  1e6, 0),
                new Unit(   "ГВт",   UnitsEnum.GW,  1e9, 0)
            };
        }

    }
}
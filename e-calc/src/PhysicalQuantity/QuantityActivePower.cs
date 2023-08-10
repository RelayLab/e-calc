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
                new Unit(   "Вт",    UnitsEnum.A,   1, 0),
                new Unit(   "кВт",   UnitsEnum.kA,  1e3, 0),
                new Unit(   "МВт",   UnitsEnum.kA,  1e6, 0),
                new Unit(   "ГВт",   UnitsEnum.kA,  1e9, 0)
            };
        }

    }
}
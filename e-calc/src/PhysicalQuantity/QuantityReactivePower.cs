using System.Collections.Generic;

namespace e_calc
{
    /// <summary>
    /// Физическая единица - Активная мощность
    /// </summary>
    internal class QuantityReactivePower : PhysicalQuantity
    {
        public QuantityReactivePower()
        {
            Name = "Реактивная мощность";
            NameAsEnum = PhysicalQuantityEnum.ReactivePower;
            Units = new List<Unit>()
            {
                new Unit(   "ВАр",    UnitsEnum.var,   1, 0),
                new Unit(   "кВАр",   UnitsEnum.kvar,  1e3, 0),
                new Unit(   "МВАр",   UnitsEnum.Mvar,  1e6, 0)
            };
        }

    }
}
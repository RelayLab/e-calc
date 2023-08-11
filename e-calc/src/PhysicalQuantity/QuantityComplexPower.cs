using System.Collections.Generic;

namespace e_calc
{
    /// <summary>
    /// Физическая единица - Полная мощность
    /// </summary>
    internal class QuantityComplexPower : PhysicalQuantity
    {
        public QuantityComplexPower()
        {
            Name = "Полная мощность";
            NameAsEnum = PhysicalQuantityEnum.ComplexPower;
            Units = new List<Unit>()
            {
                new Unit(   "ВА",    UnitsEnum.VA,   1, 0),
                new Unit(   "кВА",   UnitsEnum.kVA,  1e3, 0),
                new Unit(   "МВА",   UnitsEnum.MVA,  1e6, 0)
            };
        }

    }
}
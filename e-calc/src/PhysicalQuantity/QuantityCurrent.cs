using System.Collections.Generic;

namespace e_calc
{

    /// <summary>
    /// Физическая единица - Ток
    /// </summary>
    internal class QuantityCurrent : PhysicalQuantity
    {
        public QuantityCurrent()
        {
            Name = "Ток";
            NameAsEnum = PhysicalQuantityEnum.Current;

            Units = new List<Unit>()
            {
                new Unit(   "А",    UnitsEnum.A,   1),
                new Unit(   "кА",   UnitsEnum.kA,  1e3)
            };
        }
    }
}
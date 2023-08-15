using System.Collections.Generic;

namespace e_calc
{
    /// <summary>
    /// Физическая единица - Сопротивление
    /// </summary>
    internal class QuantityResistance : PhysicalQuantity
    {
        public QuantityResistance()
        {
            Name = "Активное сопротивление";
            NameAsEnum = PhysicalQuantityEnum.Resistance;

            Units = new List<Unit>()
            {
                new Unit(   "Ом",   UnitsEnum.Ohm,    1,    0),
                new Unit(   "кОм" , UnitsEnum.kOhm,   1e3,  0),
                new Unit(   "МОм",  UnitsEnum.MOhm,   1e6,  0)
            };
        }

    }

    internal class QuantityReactance : PhysicalQuantity
    {
        public QuantityReactance()
        {
            Name = "Реактивное сопротивление";
            NameAsEnum = PhysicalQuantityEnum.Reactance;

            Units = new List<Unit>()
            {
                new Unit(   "Ом",   UnitsEnum.Ohm,    1,    0),
                new Unit(   "кОм" , UnitsEnum.kOhm,   1e3,  0),
                new Unit(   "МОм",  UnitsEnum.MOhm,   1e6,  0)
            };
        }

    }
}
using System.Collections.Generic;

namespace e_calc
{
    /// <summary>
    /// Физическая единица - Активная мощность
    /// </summary>
    internal class QuantityTemperature : PhysicalQuantity
    {
        public QuantityTemperature()
        {
            Name = "Температура";
            NameAsEnum = PhysicalQuantityEnum.Temperature;
            Units = new List<Unit>()
            {
                new Unit(   "ºC",   UnitsEnum.C,   1  , 0),
                new Unit(   "ºF",   UnitsEnum.F, 5.0/9.0, -32.0*5.0/9.0),
                new Unit(   "К",    UnitsEnum.K,  1, -273.15)
            };
        }

    }
}
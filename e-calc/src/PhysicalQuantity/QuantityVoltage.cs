using System.Collections.Generic;

namespace e_calc
{
    /// <summary>
    /// Физическая единица - Напряжение
    /// </summary>
    internal class QuantityVoltage : PhysicalQuantity
    {
        public QuantityVoltage()
        {
            Name = "Напряжение";
            NameAsEnum = PhysicalQuantityEnum.Voltage;

            Units = new List<Unit>()
            {
                new Unit(   "мВ",   UnitsEnum.mV,   0.001, 0),
                new Unit(   "В" ,   UnitsEnum.V,    1, 0),
                new Unit(   "кВ",   UnitsEnum.kV,   1000,0)
            };
        }

    }
}
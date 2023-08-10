using System.Collections.Generic;

namespace e_calc
{
    /// <summary>
    /// Физическая единица - Время
    /// </summary>
    internal class QuantityTime : PhysicalQuantity
    {
        public QuantityTime()
        {
            Name = "Время";
            NameAsEnum = PhysicalQuantityEnum.Time;
            Units = new List<Unit>()
            {
                new Unit(   "с",    UnitsEnum.second,   1, 0),
                new Unit(   "мин",  UnitsEnum.minute,   60, 0),
                new Unit(   "ч",    UnitsEnum.hour,     3600, 0),
                new Unit(   "день", UnitsEnum.day,      86400, 0),
            };
        }

    }
}
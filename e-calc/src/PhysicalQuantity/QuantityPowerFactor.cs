﻿using System.Collections.Generic;

namespace e_calc
{
    /// <summary>
    /// Физическая единица - Полная мощность
    /// </summary>
    internal class QuantityPowerFactor : PhysicalQuantity
    {
        public QuantityPowerFactor()
        {
            Name = "Коэф. мощности cosφ";
            NameAsEnum = PhysicalQuantityEnum.PowerFactor;
            Units = new List<Unit>()
            {
                new Unit(   "-",    UnitsEnum.pu,   1, 0)
            };
        }

    }
}
﻿namespace e_calc
{
    /// <summary>
    /// Все основные типы используемых величин.
    /// ДОЛЖНО СОВПАДАТЬ С Helper.QuantitiesReference
    /// </summary>
    enum PhysicalQuantityEnum
    {
        Voltage,
        Current,
        ActivePower,
        ReactivePower,
        ComplexPower,
        PowerFactor,
        HeatPower,
        Temperature,
        Time,
        Energy
    };
}
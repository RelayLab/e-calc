namespace e_calc
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
        PowerFactorSin,
        PowerFactorTg,
        HeatPower,
        Temperature,
        Time,
        Energy,
        Resistance,
        Reactance
    };
}
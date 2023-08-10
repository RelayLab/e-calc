namespace e_calc
{
    /// <summary>
    /// Класс Размерности единицы измерения (В, кВ, А, кА). Содержит информацию о коэффициенте преобразования к стандартной размерности (например, для Вольта k=1, для кВ k=1000)
    /// </summary>
    internal class Unit
    {
        public string AsString { get; private set; }
        public UnitsEnum AsEnum { get; private set; }
        public double MulKoef { get; private set; }
        public double AddKoef { get; private set; }

        public Unit(string asString, UnitsEnum asEnum, double mulKoef,double addKoef)
        {
            AsString = asString;
            AsEnum = asEnum;
            MulKoef = mulKoef;
            AddKoef = addKoef;
        }

    }
}
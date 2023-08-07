using System.Collections.Generic;
using System.Linq;

namespace e_calc
{
    /// <summary>
    /// Физическая единица - базовый класс, должен быть унаследован
    /// </summary>
    internal class PhysicalQuantity : IPhysicalQuantity
    {
        public string Name { get; protected set; }
        public PhysicalQuantityEnum NameAsEnum { get; protected set; }
        protected List<Unit> Units { get; set; }
        public List<string> UnitsAsString => Units.Select(x => x.AsString).ToList();
        public List<UnitsEnum> UnitsAsEnum => Units.Select(x => x.AsEnum).ToList();

        public double Normalize(double v, string u)
        {
            return
                Units.
                Where(x => x.AsString == u).
                Select(x => x.NormKoef * v).First();
        }

        public double Reverse(double v, string u)
        {
            return
                Units.
                Where(x => x.AsString == u).
                Select(x => v/(x.NormKoef)).First();
        }
    }
}
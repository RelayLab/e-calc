using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace e_calc
{
    /// <summary>
    /// Физическая единица - Тепловая мощность
    /// </summary>
    internal class QuantityHeatPower : IPhysicalQuantity
    {
        public string Name { get; }
        public PhysicalQuantityEnum NameAsEnum { get; }
        public List<string> Units { get; }
        public List<Units> UnitsAsEnum { get; }
        public QuantityHeatPower()
        {
            this.Name = "Тепловая мощность";
            this.NameAsEnum = PhysicalQuantityEnum.HeatPower;
            this.Units = new List<string>
            {
                "кал/ч",
                "ккал/ч",
                "Мкал/ч",
                "Гкал/ч",
            };
            //this.UnitsAsEnum = new List<Units>
            //{
            //    Units.V,
            //    Units.kV
            //};
        }
    }
}
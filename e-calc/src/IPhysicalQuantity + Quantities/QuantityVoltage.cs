using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace e_calc
{
    /// <summary>
    /// Физическая единица - Напряжение
    /// </summary>
    internal class QuantityVoltage : IPhysicalQuantity
    {
        public string Name { get; }
        public PhysicalQuantityEnum NameAsEnum { get; }
        public List<string> Units { get; }
        public List<Units> UnitsAsEnum { get; }
        public QuantityVoltage()
        {
            this.Name = "Напряжение";
            this.NameAsEnum = PhysicalQuantityEnum.Voltage;
            this.Units = new List<string>
            {
                "В",
                "кВ"
            };
            //this.UnitsAsEnum = new List<Units>
            //{
            //    Units.V,
            //    Units.kV
            //};
        }
    }
}
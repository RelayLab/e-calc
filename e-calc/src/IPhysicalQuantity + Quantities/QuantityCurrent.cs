using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace e_calc
{

    /// <summary>
    /// Физическая единица - Ток
    /// </summary>
    internal class QuantityCurrent : IPhysicalQuantity
    {
        public string Name { get; }
        public PhysicalQuantityEnum NameAsEnum { get; }
        public List<string> Units { get; }
        public List<Units> UnitsAsEnum { get; }
        public QuantityCurrent()
        {
            this.Name = "Ток";
            this.NameAsEnum = PhysicalQuantityEnum.Voltage;
            this.Units = new List<string>
            {
                "А",
                "кА"
            };
            //this.UnitsAsEnum = new List<Units>
            //{
            //    Units,
            //    Units.kA
            //};
        }
    }
}
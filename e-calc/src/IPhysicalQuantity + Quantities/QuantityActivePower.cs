using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace e_calc
{
    /// <summary>
    /// Физическая единица - Активная мощность
    /// </summary>
    internal class QuantityActivePower : IPhysicalQuantity
    {
        public string Name { get; }
        public PhysicalQuantityEnum NameAsEnum { get; }
        public List<string> Units { get; }
        public List<Units> UnitsAsEnum { get; }
        public QuantityActivePower()
        {
            this.Name = "Активная мощность";
            this.NameAsEnum = PhysicalQuantityEnum.ActivePower;
            this.Units = new List<string>
            {
                "Вт",
                "кВт",
                "МВт"
            };
            //this.UnitsAsEnum = new List<Units>
            //{
            //    Units.V,
            //    Units.kV
            //};
        }
    }
}
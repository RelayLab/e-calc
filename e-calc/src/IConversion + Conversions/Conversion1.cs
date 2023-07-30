using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace e_calc
{
    /// <summary>
    /// Преобразование "любые величины"
    /// </summary>
    class Conversion1 : IConversion
    {
        public string Name { get; }
        
        public List<IPhysicalQuantity> Quantities { get; }
        public List<string> QuantitiesAsString { get; }

        public int OperandsCount { get; }

        /// <summary>
        /// 
        /// </summary>
        public Conversion1()
        {
            OperandsCount = 2;
            Name = "любые величины";
            Quantities = new List<IPhysicalQuantity>
            {
                new QuantityVoltage(),
                new QuantityCurrent(),
                new QuantityActivePower()
            };

            QuantitiesAsString = 
                Quantities.Select(x => x.Name).ToList();
        }
    }

}
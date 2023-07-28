using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace e_calc
{

    /// <summary>
    /// Общий для всех типов преобразований класс, который позволяет связывать графику с моделью данных.
    /// </summary>
    internal interface IConversion
    {
        string Name { get; }
        List<PhysicalQuantity> Quantities { get; }

        List<string> QuantitiesAsString { get; }

    }

}
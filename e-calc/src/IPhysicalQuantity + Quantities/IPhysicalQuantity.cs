using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace e_calc
{
    /// <summary>
    /// Интерфейс, с помощью которого информация о физических величинах (напряжение, ток, мощность и т.п.) передаётся в ВИД в комбобокс.
    /// Нужен для 
    /// </summary>
    internal interface IPhysicalQuantity
    {
        /// <summary>
        /// Название, которое будет выводиться в комбобоксе ("Напряжение")
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Название, которое будет использоваться в коде (.Voltage)
        /// </summary>
        PhysicalQuantityEnum NameAsEnum { get; }
        /// <summary>
        /// Список единиц измерения (должен биться с UnitsAsEnum! ) в виде строк для этой физ. величины ("В", "кВ")
        /// </summary>
        List<string> Units { get; }
        /// <summary>
        /// Список единиц измерения для использования в коде (enum)
        /// </summary>
        List<Units> UnitsAsEnum { get; }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace e_calc
{

    /// <summary>
    /// Вспомогательный класс, который содержит некоторые общие методы для разных классов, например, доступ к строковому значению по заданному enum 
    /// </summary>
    internal static class QuantitiesReferenceSingleton
    {
        /// <summary>
        /// Это переменная, которая хранит пример каждой физической величины для того, чтобы можно было взять список единиц измерения, названия и т.п.
        /// </summary>
        public static readonly List<IPhysicalQuantity> QuantitiesReference = new List<IPhysicalQuantity>();
    }
}
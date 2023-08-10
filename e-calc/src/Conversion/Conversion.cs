using System.Collections.Generic;
using System.Linq;

namespace e_calc
{

    /// <summary>
    /// Общий для всех типов преобразований класс, который позволяет связывать графику с моделью данных.
    /// </summary>
    internal partial class Conversion : IConversion
    {
        public Conversion()
        {
            Formulas = new List<Formula>();
        }
        /// <summary>
        /// Глобальное название задачи, которая решается с помощью этого преобразователя. Задаётся в конструкторе наследуемого класса.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Набор физических величин, которые могут быть выбраны в качестве одного из операндов (не путать с количеством операндов!). Задаётся в конструкторе наследуемого класса.
        /// </summary>
        public List<IPhysicalQuantity> Quantities { get; protected set; }

        /// <summary>
        /// То же, что Quantities, но в форме строк
        /// </summary>
        public List<string> QuantitiesAsString => Quantities.Select(x => x.Name).ToList();

        /// <summary>
        /// Количество операндов, то есть окон Величина 1,2,3, которые будет отображаться. Задаётся в конструкторе наследуемого класса.
        /// </summary>
        public int OperandsCount { get; protected set; }

        /// <summary>
        /// Любая информация: формулы, описание доп. опций и т.п.
        /// </summary>
        public string ConversionInfo { get; protected set; }

        protected List<Formula> Formulas { get; set; }


        public List<double> NormalizeUnits(List<PhysicalQuantityEnum> QuantitiesAsEnum, List<double> Values, List<string> Units)
        {
            List<double> OutputList = new List<double>();

            for (int i = 0; i < QuantitiesAsEnum.Count; i++)
            {
                double val = PhysicalQuantity.NormalizeQuantity(
                    QuantitiesAsEnum[i],
                    Values[i],
                    Units[i]);

                OutputList.Add(val);
            }
            return OutputList;
        }

        public double ReverseUnit(PhysicalQuantityEnum QuantityAsEnum, double Value, string Unit)
        {
            return PhysicalQuantity.ReverseQuantity(
                    QuantityAsEnum,
                    Value,
                    Unit);
        }

    }

}
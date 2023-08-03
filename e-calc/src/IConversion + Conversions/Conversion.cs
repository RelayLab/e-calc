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
    internal class Conversion : IConversion
    {
        /// <summary>
        /// Глобальное нНазвание задачи, которая решается с помощью этого преобразователя. Задаётся в конструкторе наследуемого класса.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Набор физических величин, которые могут быть выбраны в качестве одного из операндов (не путать с количеством операндов!). Задаётся в конструкторе наследуемого класса.
        /// </summary>
        public List<IPhysicalQuantity> Quantities { get; protected set; }

        /// <summary>
        /// То же, что Quantities, но в форме строк
        /// </summary>
        public List<string> QuantitiesAsString { get; protected set; }

        /// <summary>
        /// Количество операндов, то есть окон Величина 1,2,3, которые будет отображаться. Задаётся в конструкторе наследуемого класса.
        /// </summary>
        public int OperandsCount { get; protected set; }

        /// <summary>
        /// Любая информация: формулы, описание доп. опций и т.п.
        /// </summary>
        public string ConversionInfo { get; protected set; }

        protected List<Formula> Formulas { get; set; }

        /// <summary>
        /// Эта функция выполняет требуемое преобразвание по заданным данным
        /// </summary>
        /// <returns></returns>
        public string PerformConversion(List<OperandInfo> Infos, OperandInfo ResultInfo)
        {
            IEnumerable<string> ValuesAsString = Infos.Select(x => x.Value);
            IEnumerable<double> Values = ValuesAsString.Select(x => Double.Parse(x));
            IEnumerable<string> Quantities = Infos.Select(x => x.Quantity);

            List<PhysicalQuantityEnum> QuantitiesAsEnum =
                Quantities.Select(
                    x => Helper.GetQuantityByString(x)
                    ).ToList();

            //для заданных в infos величин найти нужную формулу в списке
            foreach (Formula f in this.Formulas)
            {
                if (f.UsesOperands(QuantitiesAsEnum))
                {
                    List<double> SortedValues =
                        f.SortValuesByType(
                            QuantitiesAsEnum,
                            Values.ToList());

                    double Result = f.Execute(
                        SortedValues.ToArray());
                    return Result.ToString();
                }

            }
            //преобразовать все значения к одной системе единиц
            //вычислить по формуле
            //преобразовать результат к нужным единицам, указанным в ResultInfo
            throw new NotImplementedException();
        }

        public List<string> GetDefaultQuantities()
        {
            return this.Formulas[0].GetDefaultQuantities();
        }
    }

}
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
        /// <summary>
        /// Глобальное нНазвание задачи, которая решается с помощью этого преобразователя. Задаётся в конструкторе наследуемого класса.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Набор физических величин, которые могут быть выбраны в качестве одного из операндов (не путать с количеством операндов!). Задаётся в конструкторе наследуемого класса.
        /// </summary>
        List<IPhysicalQuantity> Quantities { get; }

        /// <summary>
        /// То же, что Quantities, но в форме строк
        /// </summary>
        List<string> QuantitiesAsString { get; }

        /// <summary>
        /// Количество операндов, то есть окон Величина 1,2,3, которые будет отображаться. Задаётся в конструкторе наследуемого класса.
        /// </summary>
        int OperandsCount { get; }

        /// <summary>
        /// Любая информация: формулы, описание доп. опций и т.п.
        /// </summary>
        string ConversionInfo { get; }

        private List<Formula> Formulas { get; set; }

        /// <summary>
        /// Эта функция выполняет требуемое преобразвание по заданным данным
        /// </summary>
        /// <returns></returns>
        string PerformConversion(List<OperandInfo> Infos, OperandInfo ResultInfo);
    }

}
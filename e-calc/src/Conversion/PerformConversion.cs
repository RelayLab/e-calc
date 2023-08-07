using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace e_calc
{
    partial class Conversion
    {
        

        /// <summary>
        /// Эта функция выполняет требуемое преобразвание по заданным данным
        /// </summary>
        /// <returns></returns>
        public string PerformConversion(List<OperandInfo> Infos, OperandInfo ResultInfo)
        {
            List<string> ValuesAsString  = Infos.Select(x => x.Value).ToList();
            List<double> Values          = ValuesAsString.Select(x => Double.Parse(x)).ToList();
            List<string> Quantities      = Infos.Select(x => x.Quantity).ToList();
            List<string> Units           = Infos.Select(x => x.Unit).ToList();
            PhysicalQuantityEnum ResultQuantity = Helper.GetQuantityEnumByString(ResultInfo.Quantity);

            List<PhysicalQuantityEnum> QuantitiesAsEnum =
                Quantities.Select(
                    x => Helper.GetQuantityEnumByString(x)
                    ).ToList();

            //для заданных в infos величин найти нужную формулу в списке
            foreach (Formula f in this.Formulas)
            {
                if (f.UsesOperands(QuantitiesAsEnum,ResultQuantity))
                {
                    List<double> SortedValues =
                        f.SortValuesByType(
                            QuantitiesAsEnum,
                            Values.ToList());

                    //преобразовать все значения к одной системе единиц
                    List<double> NormalizedValues = this.NormalizeUnits(QuantitiesAsEnum, SortedValues, Units);

                    //вычислить по формуле
                    double Result = f.Execute(
                        NormalizedValues.ToArray());



                    //преобразовать результат к нужным единицам, указанным в ResultInfo
                    double ReversedValue = this.ReverseUnit(ResultQuantity, Result, ResultInfo.Unit);

                    return ReversedValue.ToString();
                }

            }
            
            return null;
        }

        public List<string> GetDefaultQuantities()
        {
            return this.Formulas[0].GetDefaultQuantities();
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;

namespace e_calc
{
    internal class Formula
    {
        public Formula(
            Func<double[], double> execute,
            PhysicalQuantityEnum resultType,
            params PhysicalQuantityEnum[] operandsType)
        {
            OperandsType = operandsType.ToList();
            ResultType = resultType;
            Execute = execute;
        }

        private readonly List<PhysicalQuantityEnum> OperandsType;
        private readonly PhysicalQuantityEnum ResultType;
        public List<double> Values;
        public double Result;
        public Func<double[], double> Execute;

        public bool UsesOperands(List<PhysicalQuantityEnum> Quantities, PhysicalQuantityEnum ResultQuantity)
        {
            foreach (PhysicalQuantityEnum q in Quantities)
            {
                if (!OperandsType.Contains(q))
                {
                    return false;
                }
            }

            return ResultQuantity == ResultType;
        }

        public List<string> GetDefaultQuantities()
        {
            List<PhysicalQuantityEnum> OutputList = new List<PhysicalQuantityEnum>();
            OutputList.AddRange(OperandsType.ToArray());
            OutputList.Add(ResultType);
            return
                OutputList.
                Select(x => PhysicalQuantity.GetQuantityStringByEnum(x)).
                ToList();

        }
        public List<double> SortValuesByType(
                            List<PhysicalQuantityEnum> Quantities,
                            List<double> Values)
        {
            List<double> SortedValues = new List<double>();

            foreach (PhysicalQuantityEnum q1 in OperandsType)
            {
                int i = 0;
                foreach (PhysicalQuantityEnum q2 in Quantities)
                {
                    if (q1 == q2)
                    { SortedValues.Add(Values[i]); }
                    i++;
                }
            }

            return SortedValues;
        }
    }
}
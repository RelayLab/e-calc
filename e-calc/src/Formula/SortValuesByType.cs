using System;
using System.Collections.Generic;
using System.Linq;
namespace e_calc
{
    partial class Formula
    {

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
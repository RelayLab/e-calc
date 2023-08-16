using System;
using System.Collections.Generic;
using System.Linq;
namespace e_calc
{
    partial class Formula
    {
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
    }
}
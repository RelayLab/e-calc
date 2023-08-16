using System;
using System.Collections.Generic;
using System.Linq;
namespace e_calc
{
    partial class Formula
    {
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
    }
}
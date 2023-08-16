using System;
using System.Collections.Generic;
using System.Linq;

namespace e_calc
{
    internal partial class Formula
    {
        private readonly List<PhysicalQuantityEnum> OperandsType;
        private readonly PhysicalQuantityEnum ResultType;
        public List<double> Values;
        public double Result;
        public Func<double[], double> Execute;

        public Formula(
            Func<double[], double> execute,
            PhysicalQuantityEnum resultType,
            params PhysicalQuantityEnum[] operandsType)
        {
            OperandsType = operandsType.ToList();
            ResultType = resultType;
            Execute = execute;
        }

    }
}
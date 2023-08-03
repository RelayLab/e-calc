using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_calc
{
    class Formula
    {
        public Formula(
            Func<double[], double> execute,
            PhysicalQuantityEnum resultType,
            params PhysicalQuantityEnum[] operandsType)
        {
            this.OperandsType = operandsType.ToList();
            this.ResultType = resultType;
            this.Execute = execute;
        }
        List<PhysicalQuantityEnum> OperandsType;
        PhysicalQuantityEnum ResultType;
        public List<double> Values;
        public double Result;
        public Func<double[], double> Execute;

        public bool UsesOperands(List<PhysicalQuantityEnum> Quantities)
        { 
            foreach(PhysicalQuantityEnum q in Quantities)
            {
                if (!this.OperandsType.Contains(q))
                    return false;
            }
            return true;
        }

        public List<string> GetDefaultQuantities()
        {
            List<PhysicalQuantityEnum> OutputList = new List<PhysicalQuantityEnum>();
            OutputList.AddRange(OperandsType.ToArray());
            OutputList.Add(ResultType);
            return 
                OutputList.
                Select(x => Helper.GetQuantityByEnum(x)).
                ToList();

        }
        public List<double> SortValuesByType(
                            List<PhysicalQuantityEnum> Quantities,
                            List<double> Values)
        {
            List<double> SortedValues = new List<double>();

            foreach(PhysicalQuantityEnum q1 in this.OperandsType)
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
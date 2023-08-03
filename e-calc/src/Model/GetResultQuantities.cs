using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace e_calc
{
    partial class Model
    {

        public List<string> GetResultQuantities(string ActiveConversion)
        {
            return this.ConversionsReference.
                Where(x => x.Name == ActiveConversion).
                Select(x => x.QuantitiesAsString).
                First();

        }
    }
}
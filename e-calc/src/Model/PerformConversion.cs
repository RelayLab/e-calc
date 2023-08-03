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
        /// <summary>
        /// Эта функция запускает расчёт
        /// </summary>
        /// <param name="info"></param>
        public string PerformConversion(List<OperandInfo> Infos, OperandInfo ResultInfo, string ActiveConversion)
        {
            IConversion conv = this.ConversionsReference.
                Where(x => x.Name == ActiveConversion).First();

            string Result = conv.PerformConversion(
                    Infos,
                    ResultInfo);

            return Result;
        }
    }
}
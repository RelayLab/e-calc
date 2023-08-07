using e_calc.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_calc
{

    public class OperandInfo
    {
        /// <summary>
        /// Порядковый номер операнда в главном окне
        /// </summary>
        readonly int SequenceNumber;
        /// <summary>
        /// Физическая величина (ток, напряжение и т.п.)
        /// </summary>
        public string Quantity { get; private set; }
        /// <summary>
        /// Численное значение величины
        /// </summary>
        public string Value { get; private set; }
        /// <summary>
        /// Единицы измерения (мВ, В, кВ и т.п.)
        /// </summary>
        public readonly string Unit;

        public OperandInfo(int sequenceNumber, string quantity, string value, string unit)
        {
            this.SequenceNumber = sequenceNumber;
            this.Quantity = quantity;
            this.Value = value;
            this.Unit = unit;
        }
    }
}
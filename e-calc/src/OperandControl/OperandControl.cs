using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_calc.src
{
    public partial class OperandControl : UserControl
    {
        public OperandControl()
        {
            InitializeComponent();
        }
        public OperandControl(int SequenceNumber)
        {
            InitializeComponent();
            SequenceNumber++;
            this.OperandGroupbox.Text = "Величина " + SequenceNumber;
        }
    }
}

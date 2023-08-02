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
    /// <summary>
    /// Это маленькое окошечно Величина 1,2, которое отображается в главном окне
    /// </summary>
    public partial class OperandControl : UserControl
    {
        private MainWindow _MainWindow;
        private int OperandNumber;
        public string Quantity
        {
            get 
            { return this.OperandQuantityCombobox.Text; }
        }
        public string Value
        {
            get 
            { return this.OperandValueTextbox.Text; }
        }
        public string Unit 
        {
            get 
            { return this.OperandUnitCombobox.Text; } 
        }

        /// <summary>
        /// Конструктор по умолчанию. Здесь ничего не меняем, нужен для работы дизайнера
        /// </summary>
        public OperandControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Конструктор, который даёт номер новому окошку и загружает нужные физические величины
        /// </summary>
        /// <param name="SequenceNumber"></param>
        /// <param name="QuantitiesAsString"></param>
        public OperandControl(int SequenceNumber, List<string> QuantitiesAsString, MainWindow main_window)
        {
            InitializeComponent();
            this.SuspendLayout();

            _MainWindow = main_window;

            //добавляем название для этого элемента "Величина 1,2 ..."
            this.OperandNumber = SequenceNumber + 1;
            this.OperandGroupbox.Text = "Величина " + OperandNumber;

            //добавляем в список Combobox все возможные физические величины
            this.OperandQuantityCombobox.Items.Clear();
            if (QuantitiesAsString != null && QuantitiesAsString.Count!=0) 
            {
                this.OperandQuantityCombobox.Items.AddRange(
                    QuantitiesAsString.ToArray());
                this.OperandQuantityCombobox.SelectedIndex = 0; 
            }

            Helper.ResizeCombobox(this.OperandQuantityCombobox);

            this.ResumeLayout();
            //выпадающий список с единицами измерения заполняется в другом событии OperandQuantityCombobox_SelectedIndexChanged
        }

        private void OperandUnitCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._MainWindow.PerformConversion();
        }

        private string PrevText;
        private int PrevCursorPosition;
        private void OperandValueTextbox_TextChanged(object sender, EventArgs e)
        {
            if (this.OperandValueTextbox.Text == "")
                return;

            PrevCursorPosition = this.OperandValueTextbox.SelectionStart;

            bool IsSuccess = Double.TryParse(this.OperandValueTextbox.Text, out double result);
            if (IsSuccess)
            {
                PrevText = this.OperandValueTextbox.Text;
                this._MainWindow.PerformConversion(); 
            }
            else
            {
                this.OperandValueTextbox.TextChanged -= OperandValueTextbox_TextChanged;
                this.OperandValueTextbox.Text = PrevText;
                this.OperandValueTextbox.SelectionStart = PrevCursorPosition-1;
                this.OperandValueTextbox.TextChanged += OperandValueTextbox_TextChanged;
            }
                
            
        }
    }
}

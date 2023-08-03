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
        private readonly List<string> Quantities;

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

            this.Quantities = QuantitiesAsString;
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

        public void SelectItem(string item) 
        {
            this.OperandQuantityCombobox.SelectedItem = item;
        }



    }
}

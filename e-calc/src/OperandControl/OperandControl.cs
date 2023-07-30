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
            SequenceNumber++;
            this.OperandGroupbox.Text = "Величина " + SequenceNumber;

            //добавляем в список Combobox все возможные физические величины
            this.OperandQuantityCombobox.Items.Clear();
            if (QuantitiesAsString != null && QuantitiesAsString.Count!=0) 
            {
                this.OperandQuantityCombobox.Items.AddRange(
                    QuantitiesAsString.ToArray());
                this.OperandQuantityCombobox.SelectedIndex = 0; 
            }

            this.ResumeLayout();
            //выпадающий список с единицами измерения заполняется в другом событии OperandQuantityCombobox_SelectedIndexChanged
        }

        /// <summary>
        /// Это событие появляется при изменении
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperandQuantityCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> Units = 
                this._MainWindow.UpdateUnits(
                (string)
                this.OperandQuantityCombobox.SelectedItem);
        }
    }
}

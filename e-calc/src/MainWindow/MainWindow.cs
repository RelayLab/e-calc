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
    public partial class MainWindow : Form
    {
        private Model MainModel;
        /// <summary>
        /// Конструктор по умолчанию, здесь ничего не пишем, т.к. он используется конструктором WinForms
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Наш конструктор, который используется моделью для вывода данных при запуске приложения
        /// </summary>
        /// <param name="TaskList"></param>
        public MainWindow(Model model)
        {
            //стандартная строчка
            InitializeComponent();

            MainModel = model;

            //Загружаем список всех конверторов в первый комбобокс на экране
            this.ConversionCombobox.Items.AddRange(
                MainModel.ConversionsAsString.ToArray());
            this.ConversionCombobox.SelectedIndex = 0;
            Helper.ResizeCombobox(ConversionCombobox);

            //дальнейшая инициализация происходит через функцию обновления этого комбобокса ConversionCombobox_SelectedIndexChanged
        }

        private void ResultQuantityCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SuspendLayout();

            ResultUnitCombobox.Items.Clear();

            List<string> Units = this.MainModel.UpdateUnits(
                    (string)this.ResultQuantityCombobox.SelectedItem);

            ResultUnitCombobox.Items.AddRange(Units.ToArray());
            ResultUnitCombobox.SelectedIndex = 0;

            Helper.ResizeCombobox(ResultUnitCombobox);

            this.ResumeLayout();
        }

        /// <summary>
        /// Эта функция посылает сигнал из главного окна в модель для главного вычисления преобразования. В результате в текстбокс записывается результат
        /// </summary>
        public void PerformConversion()
        {
            //сведения обо всех введенных на экранах величинах кладём в список
            List<OperandInfo> Infos = new List<OperandInfo>();
            int i = 0;
            foreach (OperandControl oc in this.OperandsPanel.Controls)
            {
                OperandInfo oi = new OperandInfo(
                    i++,
                    oc.Quantity,
                    oc.Value,
                    oc.Unit);

                Infos.Add(oi);
                    
            }
            //сведения о требуемом результате кладём в отдельный объект
            OperandInfo ResultInfo = new OperandInfo(
                0,
                this.ResultQuantityCombobox.Text,
                this.ResultValueTextbox.Text,
                this.ResultUnitCombobox.Text) ; 
            
            //запускаем вычисление
            this.ResultValueTextbox.Text = 
                this.MainModel.PerformConversion(
                    Infos, 
                    ResultInfo, 
                    this.ConversionCombobox.Text);
        }

    }

    public class OperandInfo
    {
        /// <summary>
        /// Порядковый номер операнда в главном окне
        /// </summary>
        readonly int SequenceNumber;
        /// <summary>
        /// Физическая величина (ток, напряжение и т.п.)
        /// </summary>
        readonly string Quantity;
        /// <summary>
        /// Численное значение величины
        /// </summary>
        readonly string Value;
        /// <summary>
        /// Единицы измерения (мВ, В, кВ и т.п.)
        /// </summary>
        readonly string Unit;

        public OperandInfo(int sequenceNumber, string quantity, string value, string unit)
        {
            this.SequenceNumber = sequenceNumber;
            this.Quantity       = quantity;
            this.Value          = value;
            this.Unit           = unit;
        }
    }

}

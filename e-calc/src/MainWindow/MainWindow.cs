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
        Model MainModel;
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
            this.TaskCombobox.DataSource = MainModel.TaskList;
            this.TaskCombobox.SelectedIndex = 0;
            ResizeCombobox(TaskCombobox);

            //дальнейшая инициализация происходит через функцию обновления этого комбобокса TaskCombobox_SelectedIndexChanged
        }

        /// <summary>
        /// Эта функция вызывается при выборе любого элемента из комбобокса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SuspendLayout();

            this.OperandsPanel.Controls.Clear();

            //получаем из модели количество операндов (окон Величина 1,2...), которые будут отображаться на экране
            int QuantitiesCount = MainModel.GetQuantitiesCount(
                this.TaskCombobox.SelectedItem.ToString());

            for (int i = 0; i < QuantitiesCount; i++)
            {
                OperandControl oc = new OperandControl(i);
                OperandsPanel.Controls.Add(oc);
            }

            this.ResumeLayout();
        }

        


    }
}

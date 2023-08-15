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

        private void ResultUnitCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PerformConversion();
        }

        bool IsShown = false;
        private void MainWindow_Shown(object sender, EventArgs e)
        {
            IsShown = true;
        }

        private void InfoTextbox_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            this.InfoTextbox.Height = e.NewRectangle.Height+5;
        }
    }


}

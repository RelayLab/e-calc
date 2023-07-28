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
        public MainWindow(List<String> TaskList)
        {
            InitializeComponent();
            this.TaskCombobox.DataSource = TaskList;
            this.TaskCombobox.SelectedIndex = 0;
            ResizeCombobox(TaskCombobox);
        }

    }
}

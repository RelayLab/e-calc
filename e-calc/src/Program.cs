using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_calc
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainWindow());


            //создаём модель данных, которая должна быть отдельной от логики WinForms
            Model MainModel = new Model();

            //запускаем графический интерфейс, указывая в конструкторе все исходные данные из модели
            MainWindow mw = new MainWindow(
                MainModel.TaskList);
            
            Application.Run(mw);
        }
    }
}

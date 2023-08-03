using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace e_calc
{
    /// <summary>
    /// Отдельный класс, который управляет всеми данными в приложении, чтобы данные были отдельно от окон WinForms
    /// </summary>
    public partial class Model
    {
        public readonly List<String> ConversionsAsString;
        private readonly List<IConversion> ConversionsReference;

        /// <summary>
        /// Этот конструктор создаёт исходные данные для вывода в окно приложения
        /// </summary>
        public Model()
        {
            IConversion c1 = new Conversion1();
            IConversion c2 = new Conversion2();
            ConversionsReference = new List<IConversion> { c2, c1 };
            this.ConversionsAsString = ConversionsReference.Select(x => x.Name).ToList();

            ///Список задач, которые может решать программа
        }

        public List<string> GetDefaultQuantities(string ActiveConversion)
        {
            IConversion conv = this.GetConversionByString(ActiveConversion);
            return conv.GetDefaultQuantities();
        }
        private IConversion GetConversionByString (string ActiveConversion)
        {
            return this.ConversionsReference.
                Where(x => x.Name == ActiveConversion).
                First();
        }
    }
}

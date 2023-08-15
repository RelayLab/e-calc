using System.Collections.Generic;
using System.Linq;

namespace e_calc
{
    /// <summary>
    /// Отдельный класс, который управляет всеми данными в приложении, чтобы данные были отдельно от окон WinForms
    /// </summary>
    public partial class Model
    {
        public readonly List<string> ConversionsAsString;
        private readonly List<IConversion> ConversionsReference;

        /// <summary>
        /// Этот конструктор создаёт исходные данные для вывода в окно приложения
        /// </summary>
        public Model()
        {
            ConversionsReference = new List<IConversion>
            {
                new Conversion7(),
                new Conversion6(),
                new Conversion5(),
                new Conversion4(),
                new Conversion3(),
                new Conversion2(),
                new Conversion1()
            };
            ConversionsAsString = ConversionsReference.Select(x => x.Name).ToList();

            ///Список задач, которые может решать программа
        }

        public List<string> GetDefaultQuantities(string ActiveConversion)
        {
            IConversion conv = GetConversionByString(ActiveConversion);
            return conv.GetDefaultQuantities();
        }
        private IConversion GetConversionByString(string ActiveConversion)
        {
            return ConversionsReference.
                Where(x => x.Name == ActiveConversion).
                First();
        }
    }
}

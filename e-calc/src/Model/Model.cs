﻿using System;
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
            ConversionsReference = new List<IConversion> { c1, c2 };
            this.ConversionsAsString = ConversionsReference.Select(x => x.Name).ToList();

            ///Список задач, которые может решать программа
        }


        public List<string> GetResultQuantities(string ActiveConversion)
        {
            return this.ConversionsReference.
                Where(x => x.Name == ActiveConversion).
                Select(x => x.QuantitiesAsString).
                First();
            
        }

        public string GetConversionInfo(string ActiveConversion)
        {
            return this.ConversionsReference.
                Where(x => x.Name == ActiveConversion).
                Select(x => x.ConversionInfo).
                First();
        }


        /// <summary>
        /// Эта функция возвращает список доступных единиц измерения для выбранной величины
        /// </summary>
        /// <param name="SelectedItem"></param>
        /// <returns></returns>
        public List<string> UpdateUnits(string SelectedItem)
        {
            return Helper.GetUnitsByString(SelectedItem);
        }


        /// <summary>
        /// Эта функция запускает расчёт
        /// </summary>
        /// <param name="info"></param>
        public string PerformConversion(List<OperandInfo> Infos, OperandInfo ResultInfo, string ActiveConversion)
        {
            IConversion conv = this.ConversionsReference.
                Where(x => x.Name == ActiveConversion).First();

            string Result = conv.PerformConversion(
                    Infos,
                    ResultInfo);

            return Result;
        }
    }

}

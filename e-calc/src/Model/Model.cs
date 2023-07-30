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
        public readonly List<String> TaskList;
        private readonly List<IConversion> Conversions;

        /// <summary>
        /// Этот конструктор создаёт исходные данные для вывода в окно приложения
        /// </summary>
        public Model()
        {
            IConversion c1 = new Conversion1();
            Conversions = new List<IConversion> { c1 };
            this.TaskList = Conversions.Select(x => x.Name).ToList();

            ///Список задач, которые может решать программа
            //this.TaskList = new List<string> {
            //    "любые величины",
            //    "ток(А) - напряжение(В) - сопротивление(Ом) - мощность(кВт)" ,
            //    "мощность(кВт) - энергия(кАч)",
            //    "электрическая(кВт) - тепловая(ккал) мощность",
            //    "активная(кВт) - полная(кВА) мощность",
            //    "активная(кВт) - реактивная(кВА) мощность",
            //    "косинус(cos φ) - тангенс(tg φ) коэффициента мощности" };
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
    }

}

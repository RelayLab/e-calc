﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace e_calc
{
    /// <summary>
    /// Преобразование "любые величины"
    /// </summary>
    class Conversion1 : IConversion
    {
        public string Name { get; }
        
        public List<IPhysicalQuantity> Quantities { get; }
        public List<string> QuantitiesAsString { get; }

        public int OperandsCount { get; }

        public string ConversionInfo { get; }
        public List<Formula> Formulas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Conversion1()
        {
            OperandsCount = 2;
            Name = "любые величины";
            Quantities = new List<IPhysicalQuantity>
            {
                new QuantityVoltage(),
                new QuantityCurrent(),
                new QuantityActivePower()
            };

            QuantitiesAsString = 
                Quantities.Select(x => x.Name).ToList();

            ConversionInfo = 
                "Пример информации о преобразовании. Например, может быть использована формула P = sqrt(3)*Uф*I";
        }
        public string PerformConversion(List<OperandInfo> Infos, OperandInfo ResultInfo)
        {
            return "0";
            //throw new NotImplementedException();
        }
    }

}

//    "любые величины",
//    "ток(А) - напряжение(В) - сопротивление(Ом) - мощность(кВт)" ,
//    "мощность(кВт) - энергия(кАч)",
//    "электрическая(кВт) - тепловая(ккал) мощность",
//    "активная(кВт) - полная(кВА) мощность",
//    "активная(кВт) - реактивная(кВА) мощность",
//    "косинус(cos φ) - тангенс(tg φ) коэффициента мощности"
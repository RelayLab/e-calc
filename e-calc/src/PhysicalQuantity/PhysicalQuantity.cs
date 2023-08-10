using System.Collections.Generic;
using System.Linq;

namespace e_calc
{
    /// <summary>
    /// Физическая единица - базовый класс, должен быть унаследован
    /// </summary>
    internal class PhysicalQuantity : IPhysicalQuantity
    {
        public PhysicalQuantity() 
        {
            AddQuantityToReference(this);
        }

        private static List<IPhysicalQuantity> QuantitiesReference => QuantitiesReferenceSingleton.QuantitiesReference;
        public string Name { get; protected set; }
        public PhysicalQuantityEnum NameAsEnum { get; protected set; }
        protected List<Unit> Units { get; set; }
        public List<string> UnitsAsString => Units.Select(x => x.AsString).ToList();
        public List<UnitsEnum> UnitsAsEnum => Units.Select(x => x.AsEnum).ToList();

        public double Normalize(double v, string u)
        {
            return
                Units.
                Where(x => x.AsString == u).
                Select(x => x.MulKoef * v + x.AddKoef).First();
        }

        public double Reverse(double v, string u)
        {
            return
                Units.
                Where(x => x.AsString == u).
                Select(x => (v - x.AddKoef)/(x.MulKoef)).First();
        }


        /// <summary>
        /// Эта функция возвращает список единиц измерения физической величины по заданной строке
        /// </summary>
        /// <param name="SelectedItem">тип в формате строки</param>
        /// <returns>список единиц измерения физической величины </returns>
        public static List<string> GetUnitsByQuantity(string SelectedItem)
        {
            return QuantitiesReference.
                Where(x => x.Name == SelectedItem).
                Select(x => x.UnitsAsString).
                First();
        }

        public static PhysicalQuantityEnum GetQuantityEnumByString(string SelectedItem)
        {
            return QuantitiesReference.
                Where(x => x.Name == SelectedItem).
                Select(x => x.NameAsEnum).
                First();
        }

        public static string GetQuantityStringByEnum(PhysicalQuantityEnum SelectedItem)
        {
            return QuantitiesReference.
                Where(x => x.NameAsEnum == SelectedItem).
                Select(x => x.Name).
                First();
        }

        public static double NormalizeQuantity(PhysicalQuantityEnum q, double v, string u)
        {
            return QuantitiesReference.
                Where(x => x.NameAsEnum == q).Select(x => x.Normalize(v, u)).First();
        }

        public static double ReverseQuantity(PhysicalQuantityEnum q, double v, string u)
        {
            return QuantitiesReference.
                Where(x => x.NameAsEnum == q).Select(x => x.Reverse(v, u)).First();
        }

        public static void AddQuantityToReference(PhysicalQuantity q)
        {
            bool IsAdded =
                QuantitiesReference.
                Select(x => x.GetType()).
                Contains(q.GetType());

            if (!IsAdded)
            {
                QuantitiesReference.Add(q);
            }
        }



    }
}
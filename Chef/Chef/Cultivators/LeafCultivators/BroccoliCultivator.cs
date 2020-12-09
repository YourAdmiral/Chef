using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Leafs;

namespace Chef.Cultivators.LeafCultivators
{
    internal class BroccoliCultivator : LeafCultivator
    {
        public override Leaf CultivateLeaf()
        {
            return new Broccoli
                (
                GetSort(),
                GetColor(),
                GetWeight(),
                GetProteins(),
                GetFats(),
                GetCarbohydrates(),
                GetCalories(),
                GetWater(),
                GetFe(),
                GetI(),
                GetMn()
                );
        }
        protected double GetFe()
        {
            Console.WriteLine("Введите количество железа (г): ");
            return GetDouble();
        }
        protected double GetI()
        {
            Console.WriteLine("Введите количество йода (г): ");
            return GetDouble();
        }
        protected double GetMn()
        {
            Console.WriteLine("Введите количество марганца (г): ");
            return GetDouble();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Leafs;

namespace Chef.Cultivators.LeafCultivators
{
    internal class KohlrabiCultivator : LeafCultivator
    {
        public override Leaf CultivateLeaf()
        {
            return new Kohlrabi
                (
                GetSort(),
                GetColor(),
                GetWeight(),
                GetProteins(),
                GetFats(),
                GetCarbohydrates(),
                GetCalories(),
                GetWater(),
                GetCa(),
                GetMg(),
                GetP()
                );
        }
        protected double GetCa()
        {
            Console.WriteLine("Введите количество кальция (г): ");
            return GetDouble();
        }
        protected double GetMg()
        {
            Console.WriteLine("Введите количество магния (г): ");
            return GetDouble();
        }
        protected double GetP()
        {
            Console.WriteLine("Введите количество фосфора (г): ");
            return GetDouble();
        }
    }
}

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
            Console.WriteLine("Enter the amount of calcium (g): ");
            return GetDouble();
        }
        protected double GetMg()
        {
            Console.WriteLine("Enter the amount of magnesium (g): ");
            return GetDouble();
        }
        protected double GetP()
        {
            Console.WriteLine("Enter the amount of phosphorus (g): ");
            return GetDouble();
        }
    }
}

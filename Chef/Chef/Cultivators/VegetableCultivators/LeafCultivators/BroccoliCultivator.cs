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
            Console.WriteLine("Enter the amount of iron (g): ");
            return GetDouble();
        }
        protected double GetI()
        {
            Console.WriteLine("Enter the amount of iodine (g): ");
            return GetDouble();
        }
        protected double GetMn()
        {
            Console.WriteLine("Enter the amount of manganese (g): ");
            return GetDouble();
        }
    }
}

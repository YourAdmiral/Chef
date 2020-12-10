using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Leafs;

namespace Chef.Cultivators.LeafCultivators
{
    internal class WhiteCabbageCultivator : LeafCultivator
    {
        public override Leaf CultivateLeaf()
        {
            return new WhiteCabbage
                (
                GetSort(),
                GetColor(),
                GetWeight(),
                GetProteins(),
                GetFats(),
                GetCarbohydrates(),
                GetCalories(),
                GetWater(),
                GetCo(),
                GetMo(),
                GetCr()
                );
        }
        protected double GetCo()
        {
            Console.WriteLine("Enter the amount of carbon monoxide (g): ");
            return GetDouble();
        }
        protected double GetMo()
        {
            Console.WriteLine("Enter the amount of molybdenum (g): ");
            return GetDouble();
        }
        protected double GetCr()
        {
            Console.WriteLine("Enter the amount of chromium (g): ");
            return GetDouble();
        }
    }
}

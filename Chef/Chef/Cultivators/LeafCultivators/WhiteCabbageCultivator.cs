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
            Console.WriteLine("Введите количество оксида углерода (г): ");
            return GetDouble();
        }
        protected double GetMo()
        {
            Console.WriteLine("Введите количество молибдена (г): ");
            return GetDouble();
        }
        protected double GetCr()
        {
            Console.WriteLine("Введите количество хрома (г): ");
            return GetDouble();
        }
    }
}

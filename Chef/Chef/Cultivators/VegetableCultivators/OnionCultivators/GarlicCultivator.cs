using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Onions;

namespace Chef.Cultivators.OnionCultivators
{
    internal class GarlicCultivator : OnionCultivator
    {
        public override Onion CultivateOnion()
        {
            return new Garlic
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
                GetCr(),
                GetMn()
                );
        }
        protected double GetCo()
        {
            Console.WriteLine("Enter the amount of carbon monoxide (g): ");
            return GetDouble();
        }
        protected double GetCr()
        {
            Console.WriteLine("Enter the amount of chromium (g): ");
            return GetDouble();
        }
        protected double GetMn()
        {
            Console.WriteLine("Enter the amount of manganese (g): ");
            return GetDouble();
        }
    }
}

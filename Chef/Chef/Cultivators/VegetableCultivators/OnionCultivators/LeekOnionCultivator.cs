using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Onions;

namespace Chef.Cultivators.OnionCultivators
{
    internal class LeekOnionCultivator : OnionCultivator
    {
        public override Onion CultivateOnion()
        {
            return new LeekOnion
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
                GetSi(),
                GetZn()
                );
        }
        protected double GetCo()
        {
            Console.WriteLine("Enter the amount of carbon monoxide (g): ");
            return GetDouble();
        }
        protected double GetSi()
        {
            Console.WriteLine("Enter the amount of silicon (g): ");
            return GetDouble();
        }
        protected double GetZn()
        {
            Console.WriteLine("Enter the amount of zinc (g): ");
            return GetDouble();
        }
    }
}

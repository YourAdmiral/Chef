using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Onions;

namespace Chef.Cultivators.OnionCultivators
{
    internal class NapiformOnionCultivator : OnionCultivator
    {
        public override Onion CultivateOnion()
        {
            return new NapiformOnion
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
                GetC()
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
        protected double GetC()
        {
            Console.WriteLine("Enter the amount of carbon (g): ");
            return GetDouble();
        }
    }
}

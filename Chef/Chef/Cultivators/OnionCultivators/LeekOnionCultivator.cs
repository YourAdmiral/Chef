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
            Console.WriteLine("Введите количество оксида углерода (г): ");
            return GetDouble();
        }
        protected double GetSi()
        {
            Console.WriteLine("Введите количество кремния (г): ");
            return GetDouble();
        }
        protected double GetZn()
        {
            Console.WriteLine("Введите количество цинка (г): ");
            return GetDouble();
        }
    }
}

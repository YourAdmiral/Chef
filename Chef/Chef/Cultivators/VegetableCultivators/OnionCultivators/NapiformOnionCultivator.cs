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
            Console.WriteLine("Введите количество оксида углерода (г): ");
            return GetDouble();
        }
        protected double GetSi()
        {
            Console.WriteLine("Введите количество кремния (г): ");
            return GetDouble();
        }
        protected double GetC()
        {
            Console.WriteLine("Введите количество углерода (г): ");
            return GetDouble();
        }
    }
}

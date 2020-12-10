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
            Console.WriteLine("Введите количество оксида углерода (г): ");
            return GetDouble();
        }
        protected double GetCr()
        {
            Console.WriteLine("Введите количество хрома (г): ");
            return GetDouble();
        }
        protected double GetMn()
        {
            Console.WriteLine("Введите количество марганца (г): ");
            return GetDouble();
        }
    }
}

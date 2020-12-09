using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Spices;

namespace Chef.Cultivators.SpiceCultivators
{
    internal class SaltCultivator : SpiceCultivator
    {
        public override Spice CultivateSpice()
        {
            return new Salt
                (
                GetSort(),
                GetColor(),
                GetWeight(),
                GetProteins(),
                GetFats(),
                GetCarbohydrates(),
                GetCalories(),
                GetWater(),
                GetNa(),
                GetCl(),
                GetMo()
                );
        }
        protected double GetNa()
        {
            Console.WriteLine("Введите количество натрия (г): ");
            return GetDouble();
        }
        protected double GetCl()
        {
            Console.WriteLine("Введите количество хлора (г): ");
            return GetDouble();
        }
        protected double GetMo()
        {
            Console.WriteLine("Введите количество молибдена (г): ");
            return GetDouble();
        }
    }
}

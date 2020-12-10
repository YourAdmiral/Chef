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
            Console.WriteLine("Enter the amount of sodium (g): ");
            return GetDouble();
        }
        protected double GetCl()
        {
            Console.WriteLine("Enter the amount of chlorine (g): ");
            return GetDouble();
        }
        protected double GetMo()
        {
            Console.WriteLine("Enter the amount of molybdenum (g): ");
            return GetDouble();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Spices;

namespace Chef.Cultivators.SpiceCultivators
{
    internal class VinegarCultivator : SpiceCultivator
    {
        public override Spice CultivateSpice()
        {
            return new Vinegar
                (
                GetSort(),
                GetColor(),
                GetWeight(),
                GetProteins(),
                GetFats(),
                GetCarbohydrates(),
                GetCalories(),
                GetWater(),
                GetCa(),
                GetMg(),
                GetNa()
                );
        }
        protected double GetCa()
        {
            Console.WriteLine("Enter the amount of calcium (g): ");
            return GetDouble();
        }
        protected double GetMg()
        {
            Console.WriteLine("Enter the amount of magnesium (g): ");
            return GetDouble();
        }
        protected double GetNa()
        {
            Console.WriteLine("Enter the amount of sodium (g): ");
            return GetDouble();
        }
    }
}

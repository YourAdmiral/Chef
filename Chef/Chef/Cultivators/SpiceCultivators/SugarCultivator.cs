using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Spices;

namespace Chef.Cultivators.SpiceCultivators
{
    internal class SugarCultivator:SpiceCultivator
    {
        public override Spice CultivateSpice()
        {
            return new Sugar
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
                GetNa(),
                GetFe()
                );
        }
        protected double GetCa()
        {
            Console.WriteLine("Enter the amount of calcium (g): ");
            return GetDouble();
        }
        protected double GetNa()
        {
            Console.WriteLine("Enter the amount of sodium (g): ");
            return GetDouble();
        }
        protected double GetFe()
        {
            Console.WriteLine("Enter the amount of iron (g): ");
            return GetDouble();
        }
    }
}

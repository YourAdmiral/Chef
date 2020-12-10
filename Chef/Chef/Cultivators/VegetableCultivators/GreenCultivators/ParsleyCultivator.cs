using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Greens;

namespace Chef.Cultivators.GreenCultivators
{
    internal class ParsleyCultivator : GreenCultivator
    {
        public override Green CultivateGreen()
        {
            return new Parsley
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
                GetSi(),
                GetMg()
                );
        }
        protected double GetCa()
        {
            Console.WriteLine("Enter the amount of carbon monoxide (g): ");
            return GetDouble();
        }
        protected double GetSi()
        {
            Console.WriteLine("Enter the amount of silicon (g): ");
            return GetDouble();
        }
        protected double GetMg()
        {
            Console.WriteLine("Enter the amount of magnesium (g): ");
            return GetDouble();
        }
    }
}

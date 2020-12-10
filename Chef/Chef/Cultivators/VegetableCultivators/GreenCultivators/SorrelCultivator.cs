using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Greens;

namespace Chef.Cultivators.GreenCultivators
{
    internal class SorrelCultivator : GreenCultivator
    {
        public override Green CultivateGreen()
        {
            return new Sorrel
                (
                GetSort(),
                GetColor(),
                GetWeight(),
                GetProteins(),
                GetFats(),
                GetCarbohydrates(),
                GetCalories(),
                GetWater(),
                GetMg(),
                GetCu(),
                GetP()
                );
        }
        protected double GetMg()
        {
            Console.WriteLine("Enter the amount of magnesium (g): ");
            return GetDouble();
        }
        protected double GetCu()
        {
            Console.WriteLine("Enter the amount of copper (g): ");
            return GetDouble();
        }
        protected double GetP()
        {
            Console.WriteLine("Enter the amount of phosphorus (g):: ");
            return GetDouble();
        }
    }
}

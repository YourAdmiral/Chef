using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Greens;

namespace Chef.Cultivators.GreenCultivators
{
    internal class DillCultivator : GreenCultivator
    {
        public override Green CultivateGreen()
        {
            return new Dill
                (
                GetSort(),
                GetColor(),
                GetWeight(),
                GetProteins(),
                GetFats(),
                GetCarbohydrates(),
                GetCalories(),
                GetWater(),
                GetMn(),
                GetCr(),
                GetCo()
                );
        }
        protected double GetMn()
        {
            Console.WriteLine("Enter the amount of manganese (g): ");
            return GetDouble();
        }
        protected double GetCr()
        {
            Console.WriteLine("Enter the amount of chromium (g): ");
            return GetDouble();
        }
        protected double GetCo()
        {
            Console.WriteLine("Enter the amount of carbon monoxide (g): ");
            return GetDouble();
        }
    }
}

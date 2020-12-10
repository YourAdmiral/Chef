using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Fetuses;

namespace Chef.Cultivators.FetusCultivators
{
    internal class CucumberCultivator : FetusCultivator
    {
        public override Fetus CultivateFetus()
        {
            return new Cucumber
                (
                GetSort(),
                GetColor(),
                GetWeight(),
                GetProteins(),
                GetFats(),
                GetCarbohydrates(),
                GetCalories(),
                GetWater(),
                GetK(),
                GetSi(),
                GetCr()
                );
        }
        protected double GetK()
        {
            Console.WriteLine("Enter the amount of potassium (g): ");
            return GetDouble();
        }
        protected double GetSi()
        {
            Console.WriteLine("Enter the amount of silicon (g): ");
            return GetDouble();
        }
        protected double GetCr()
        {
            Console.WriteLine("Enter the amount of chromium (g): ");
            return GetDouble();
        }
    }
}

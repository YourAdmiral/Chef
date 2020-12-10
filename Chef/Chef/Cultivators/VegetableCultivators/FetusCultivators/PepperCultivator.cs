using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Fetuses;

namespace Chef.Cultivators.FetusCultivators
{
    internal class PepperCultivator : FetusCultivator
    {
        public override Fetus CultivateFetus()
        {
            return new Pepper
                (
                GetSort(),
                GetColor(),
                GetWeight(),
                GetProteins(),
                GetFats(),
                GetCarbohydrates(),
                GetCalories(),
                GetWater(),
                GetC(),
                GetSi(),
                GetCu()
                );
        }
        protected double GetC()
        {
            Console.WriteLine("Enter the amount of carbon (g): ");
            return GetDouble();
        }
        protected double GetSi()
        {
            Console.WriteLine("Enter the amount of silicon (g): ");
            return GetDouble();
        }
        protected double GetCu()
        {
            Console.WriteLine("Enter the amount of copper (g): ");
            return GetDouble();
        }
    }
}

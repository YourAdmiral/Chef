using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Roots;

namespace Chef.Cultivators.RootCultivators
{
    internal class CarrotCultivator : RootCultivator
    {
        public override Root CultivateRoot()
        {
            return new Carrot
                (
                GetSort(),
                GetColor(),
                GetWeight(),
                GetProteins(),
                GetFats(),
                GetCarbohydrates(),
                GetCalories(),
                GetWater(),
                GetSi(),
                GetMo(),
                GetCo()
                );
        }
        protected double GetSi()
        {
            Console.WriteLine("Enter the amount of silicon (g): ");
            return GetDouble();
        }
        protected double GetMo()
        {
            Console.WriteLine("Enter the amount of molybdenum (g): ");
            return GetDouble();
        }
        protected double GetCo()
        {
            Console.WriteLine("Enter the amount of carbon monoxide (g): ");
            return GetDouble();
        }
    }
}

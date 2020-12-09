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
            Console.WriteLine("Введите количество калия (г): ");
            return GetDouble();
        }
        protected double GetSi()
        {
            Console.WriteLine("Введите количество кремния (г): ");
            return GetDouble();
        }
        protected double GetCr()
        {
            Console.WriteLine("Введите количество хрома (г): ");
            return GetDouble();
        }
    }
}

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
            Console.WriteLine("Введите количество марганца (г): ");
            return GetDouble();
        }
        protected double GetCr()
        {
            Console.WriteLine("Введите количество хрома (г): ");
            return GetDouble();
        }
        protected double GetCo()
        {
            Console.WriteLine("Введите количество оксида углерода (г): ");
            return GetDouble();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Roots;

namespace Chef.Cultivators.RootCultivators
{
    internal class PotatoCultivator : RootCultivator
    {
        public override Root CultivateRoot()
        {
            return new Potato
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
                GetCo()
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
        protected double GetCo()
        {
            Console.WriteLine("Введите количество оксида углерода (г): ");
            return GetDouble();
        }
    }
}

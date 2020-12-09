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
            Console.WriteLine("Введите количество кальция (г): ");
            return GetDouble();
        }
        protected double GetSi()
        {
            Console.WriteLine("Введите количество кремния (г): ");
            return GetDouble();
        }
        protected double GetMg()
        {
            Console.WriteLine("Введите количество магния (г): ");
            return GetDouble();
        }
    }
}

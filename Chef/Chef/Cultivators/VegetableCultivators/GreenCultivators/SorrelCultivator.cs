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
            Console.WriteLine("Введите количество магния (г): ");
            return GetDouble();
        }
        protected double GetCu()
        {
            Console.WriteLine("Введите количество меди (г): ");
            return GetDouble();
        }
        protected double GetP()
        {
            Console.WriteLine("Введите количество фосфора (г): ");
            return GetDouble();
        }
    }
}

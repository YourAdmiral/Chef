using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Spices;

namespace Chef.Cultivators.SpiceCultivators
{
    internal class VinegarCultivator : SpiceCultivator
    {
        public override Spice CultivateSpice()
        {
            return new Vinegar
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
                GetMg(),
                GetNa()
                );
        }
        protected double GetCa()
        {
            Console.WriteLine("Введите количество кальция (г): ");
            return GetDouble();
        }
        protected double GetMg()
        {
            Console.WriteLine("Введите количество магния (г): ");
            return GetDouble();
        }
        protected double GetNa()
        {
            Console.WriteLine("Введите количество натрия (г): ");
            return GetDouble();
        }
    }
}

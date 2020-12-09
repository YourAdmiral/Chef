using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Spices;

namespace Chef.Cultivators.SpiceCultivators
{
    internal class SugarCultivator:SpiceCultivator
    {
        public override Spice CultivateSpice()
        {
            return new Sugar
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
                GetNa(),
                GetFe()
                );
        }
        protected double GetCa()
        {
            Console.WriteLine("Введите количество кальция (г): ");
            return GetDouble();
        }
        protected double GetNa()
        {
            Console.WriteLine("Введите количество натрия (г): ");
            return GetDouble();
        }
        protected double GetFe()
        {
            Console.WriteLine("Введите количество железа (г): ");
            return GetDouble();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Fetuses;

namespace Chef.Cultivators.FetusCultivators
{
    internal class TomatoCultivator : FetusCultivator
    {
        public override Fetus CultivateFetus()
        {
            return new Tomato
                (
                GetSort(),
                GetColor(),
                GetWeight(),
                GetProteins(),
                GetFats(),
                GetCarbohydrates(),
                GetCalories(),
                GetWater(),
                GetCo(),
                GetC(),
                GetSi()
                );
        }
        protected double GetCo()
        {
            Console.WriteLine("Введите количество оксида углерода (г): ");
            return GetDouble();
        }
        protected double GetC()
        {
            Console.WriteLine("Введите количество углерода (г): ");
            return GetDouble();
        }
        protected double GetSi()
        {
            Console.WriteLine("Введите количество кремния (г): ");
            return GetDouble();
        }
    }
}

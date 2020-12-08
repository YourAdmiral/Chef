using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.OnionCultivators
{
    internal class GarlicCultivator : OnionCultivator
    {
        public override Vegetables.Onions.Onion CultivateOnion()
        {
            return new Vegetables.Onions.Garlic
                (
                WriteSort(),
                WriteColor(),
                WriteWeight(),
                WriteProteins(),
                WriteFats(),
                WriteCarbohydrates(),
                WriteCalories(),
                WriteWater(),
                WriteCo(),
                WriteCr(),
                WriteMn()
                );
        }
        protected double WriteCo()
        {
            Console.WriteLine("Введите количество оксида углерода (г): ");
            return WriteDouble();
        }
        protected double WriteCr()
        {
            Console.WriteLine("Введите количество хрома (г): ");
            return WriteDouble();
        }
        protected double WriteMn()
        {
            Console.WriteLine("Введите количество марганца (г): ");
            return WriteDouble();
        }
    }
}

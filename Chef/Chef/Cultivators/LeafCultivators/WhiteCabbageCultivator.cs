using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.LeafCultivators
{
    internal class WhiteCabbageCultivator : LeafCultivator
    {
        public override Vegetables.Leafs.Leaf CultivateLeaf()
        {
            return new Vegetables.Leafs.WhiteCabbage
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
                WriteMo(),
                WriteCr()
                );
        }
        protected double WriteCo()
        {
            Console.WriteLine("Введите количество оксида углерода (г): ");
            return WriteDouble();
        }
        protected double WriteMo()
        {
            Console.WriteLine("Введите количество молибдена (г): ");
            return WriteDouble();
        }
        protected double WriteCr()
        {
            Console.WriteLine("Введите количество хрома (г): ");
            return WriteDouble();
        }
    }
}

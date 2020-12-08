using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.LeafCultivators
{
    internal class KohlrabiCultivator : LeafCultivator
    {
        public override Vegetables.Leafs.Leaf CultivateLeaf()
        {
            return new Vegetables.Leafs.Kohlrabi
                (
                WriteSort(),
                WriteColor(),
                WriteWeight(),
                WriteProteins(),
                WriteFats(),
                WriteCarbohydrates(),
                WriteCalories(),
                WriteWater(),
                WriteCa(),
                WriteMg(),
                WriteP()
                );
        }
        protected double WriteCa()
        {
            Console.WriteLine("Введите количество кальция (г): ");
            return WriteDouble();
        }
        protected double WriteMg()
        {
            Console.WriteLine("Введите количество магния (г): ");
            return WriteDouble();
        }
        protected double WriteP()
        {
            Console.WriteLine("Введите количество фосфора (г): ");
            return WriteDouble();
        }
    }
}

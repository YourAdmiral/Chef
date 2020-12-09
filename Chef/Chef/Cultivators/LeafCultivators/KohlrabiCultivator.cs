using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Leafs;

namespace Chef.Cultivators.LeafCultivators
{
    internal class KohlrabiCultivator : LeafCultivator
    {
        public override Leaf CultivateLeaf()
        {
            return new Kohlrabi
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

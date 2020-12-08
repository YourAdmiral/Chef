using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.LeafCultivators
{
    internal class BroccoliCultivator : LeafCultivator
    {
        public override Vegetables.Leafs.Leaf CultivateLeaf()
        {
            return new Vegetables.Leafs.Broccoli
                (
                WriteSort(),
                WriteColor(),
                WriteWeight(),
                WriteProteins(),
                WriteFats(),
                WriteCarbohydrates(),
                WriteCalories(),
                WriteWater(),
                WriteFe(),
                WriteI(),
                WriteMn()
                );
        }
        protected double WriteFe()
        {
            Console.WriteLine("Введите количество железа (г): ");
            return WriteDouble();
        }
        protected double WriteI()
        {
            Console.WriteLine("Введите количество йода (г): ");
            return WriteDouble();
        }
        protected double WriteMn()
        {
            Console.WriteLine("Введите количество марганца (г): ");
            return WriteDouble();
        }
    }
}

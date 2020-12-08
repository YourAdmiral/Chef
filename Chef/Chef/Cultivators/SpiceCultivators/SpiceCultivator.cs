using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.SpiceCultivators
{
    internal abstract class SpiceCultivator : Cultivator
    {
        public abstract Vegetables.Spices.Spice CultivateSpice();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Spices;

namespace Chef.Cultivators.SpiceCultivators
{
    internal abstract class SpiceCultivator : Cultivator
    {
        public abstract Spice CultivateSpice();
    }
}

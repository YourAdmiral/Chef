using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.GreenCultivators
{
    abstract class GreenCultivator : Cultivator
    {
        public abstract Vegetables.Greens.Green CultivateGreen();
    }
}

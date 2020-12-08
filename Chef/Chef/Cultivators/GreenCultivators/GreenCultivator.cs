using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.GreenCultivators
{
    internal abstract class GreenCultivator : Cultivator
    {
        public abstract Vegetables.Greens.Green CultivateGreen();
    }
}

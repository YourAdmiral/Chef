using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Greens;

namespace Chef.Cultivators.GreenCultivators
{
    internal abstract class GreenCultivator : Cultivator
    {
        public abstract Green CultivateGreen();
    }
}

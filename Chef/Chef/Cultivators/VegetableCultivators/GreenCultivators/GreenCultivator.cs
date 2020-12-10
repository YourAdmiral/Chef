using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Greens;
using Chef.Cultivators.VegetableCultivators;

namespace Chef.Cultivators.GreenCultivators
{
    internal abstract class GreenCultivator : VegetableCultivator
    {
        public abstract Green CultivateGreen();
    }
}

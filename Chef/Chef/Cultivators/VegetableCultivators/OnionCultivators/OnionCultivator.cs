using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Onions;
using Chef.Cultivators.VegetableCultivators;

namespace Chef.Cultivators.OnionCultivators
{
    internal abstract class OnionCultivator : VegetableCultivator
    {
        public abstract Onion CultivateOnion();
    }
}

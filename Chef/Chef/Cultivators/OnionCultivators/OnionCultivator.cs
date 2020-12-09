using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Onions;

namespace Chef.Cultivators.OnionCultivators
{
    internal abstract class OnionCultivator : Cultivator
    {
        public abstract Onion CultivateOnion();
    }
}

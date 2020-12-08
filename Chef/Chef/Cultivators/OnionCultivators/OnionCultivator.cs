using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.OnionCultivators
{
    internal abstract class OnionCultivator : Cultivator
    {
        public abstract Vegetables.Onions.Onion CultivateOnion();
    }
}

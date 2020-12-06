using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.OnionCultivators
{
    abstract class OnionCultivator : Cultivator
    {
        public abstract Vegetables.Onions.Onion CultivateOnion();
    }
}

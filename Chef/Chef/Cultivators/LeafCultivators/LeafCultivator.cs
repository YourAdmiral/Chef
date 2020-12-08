using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.LeafCultivators
{
    internal abstract class LeafCultivator : Cultivator
    {
        public abstract Vegetables.Leafs.Leaf CultivateLeaf();
    }
}

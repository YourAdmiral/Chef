using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.LeafCultivators
{
    abstract class LeafCultivator : Cultivator
    {
        public abstract Vegetables.Leafs.Leaf CultivateLeaf();
    }
}

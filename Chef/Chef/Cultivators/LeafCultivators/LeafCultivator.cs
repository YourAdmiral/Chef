using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Leafs;

namespace Chef.Cultivators.LeafCultivators
{
    internal abstract class LeafCultivator : Cultivator
    {
        public abstract Leaf CultivateLeaf();
    }
}

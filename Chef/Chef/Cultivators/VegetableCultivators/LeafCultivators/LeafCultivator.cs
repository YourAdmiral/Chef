using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Leafs;
using Chef.Cultivators.VegetableCultivators;

namespace Chef.Cultivators.LeafCultivators
{
    internal abstract class LeafCultivator : VegetableCultivator
    {
        public abstract Leaf CultivateLeaf();
    }
}

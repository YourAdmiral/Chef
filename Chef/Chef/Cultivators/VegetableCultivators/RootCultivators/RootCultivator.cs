using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Roots;
using Chef.Cultivators.VegetableCultivators;

namespace Chef.Cultivators.RootCultivators
{
    internal abstract class RootCultivator : VegetableCultivator
    {
        public abstract Root CultivateRoot();
    }
}

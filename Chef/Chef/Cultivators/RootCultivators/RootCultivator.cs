using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Roots;

namespace Chef.Cultivators.RootCultivators
{
    internal abstract class RootCultivator : Cultivator
    {
        public abstract Root CultivateRoot();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.RootCultivators
{
    internal abstract class RootCultivator : Cultivator
    {
        public abstract Vegetables.Roots.Root CultivateRoot();
    }
}

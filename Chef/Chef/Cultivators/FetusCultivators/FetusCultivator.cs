using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.FetusCultivators
{
    internal abstract class FetusCultivator : Cultivator
    {
        public abstract Vegetables.Fetuses.Fetus CultivateFetus();
    }
}

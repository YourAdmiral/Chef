using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Fetuses;

namespace Chef.Cultivators.FetusCultivators
{
    internal abstract class FetusCultivator : Cultivator
    {
        public abstract Fetus CultivateFetus();
    }
}

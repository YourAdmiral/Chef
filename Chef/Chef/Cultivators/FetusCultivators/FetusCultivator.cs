using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.FetusCultivators
{
    abstract class FetusCultivator : Cultivator
    {
        public abstract Vegetables.Fetuses.Fetus CultivateFetus();
    }
}

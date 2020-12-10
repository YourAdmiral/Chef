using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Fetuses;
using Chef.Cultivators.VegetableCultivators;

namespace Chef.Cultivators.FetusCultivators
{
    internal abstract class FetusCultivator : VegetableCultivator
    {
        public abstract Fetus CultivateFetus();
    }
}

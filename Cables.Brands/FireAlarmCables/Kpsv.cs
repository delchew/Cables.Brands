using Cables.Brands.Common;
using Cables.Materials;

namespace Cables.Brands.FireAlarmCables
{
    public class Kpsv : Cable, ISingleConstruction
    {
        public ConductingCore ConductingCore { get; set; }

        public Polymer InsulationMaterial { get; set; }

        public int ElementsCount { get; set; }

        public TwistedElementType CoreTwistType { get; set; }

        public Polymer CoverMaterial { get; set; }
    }
}

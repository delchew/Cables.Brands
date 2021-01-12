using Cables.Brands.Common;

namespace Cables.Brands.FireAlarmCables
{
    public class Kps : Cable, ISingleConstruction, IMicable, IFoilShield
    {
        public ConductingCore ConductingCore { get; set; }

        public int ElementsCount { get; set; }

        public TwistedElementType CoreTwistType { get; set; }

        public bool HasMica { get; set; }

        public bool HasFoilShield { get; set; }
    }
}

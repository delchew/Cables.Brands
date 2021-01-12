using Cables.Brands.Common;

namespace Cables.Brands.Kunrs
{
    public class Kunrs : Cable, ISingleConstruction, IFoilShield, IFilled, IArmoured
    {
        public ConductingCore ConductingCore { get; set; }
        public int ElementsCount { get; set; }
        public TwistedElementType CoreTwistType { get; set; }
        public bool HasFoilShield { get; set; }
        public bool HasFilling { get; set; }
        public bool HasArmor { get; set; }
        public bool HasArmorTube { get; set; }
    }
}

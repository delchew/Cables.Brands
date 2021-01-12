using Cables.Brands.Common;

namespace Cables.Brands
{
    public class Kip : Cable, ISingleConstruction, IShield, IArmoured
    {
        public ConductingCore ConductingCore { get; set; }
        public int ElementsCount { get; set; }
        public TwistedElementType CoreTwistType { get; set; }
        public bool HasBraidingShield { get; set; }
        public bool HasContactWire { get; set; }
        public bool HasFoilShield { get; set; }
        public bool HasArmor { get; set; }
        public bool HasArmorTube { get; set; }
    }
}

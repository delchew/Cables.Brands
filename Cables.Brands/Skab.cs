using Cables.Materials;

namespace Cables.Brands
{
    public class Skab : Cable
    {
        public int Id { get; set; }
        public int VoltageType { get; set; }
        public bool HasArmor { get; set; }
        public bool HasArmorTube { get; set; }
        public PolymerType InsulationType { get; set; }
        public Polymer InsulationMaterial { get; set; }
        public int ElementsCount { get; set; }
        public TwistedElementType CoreTwistType { get; set; }
        public double ConductorCoreDiameter { get; set; }
        public bool HasIndividualShields { get; set; }
        public bool HasFoilShield { get; set; }
        public bool WithoutFilling { get; set; }
        public bool HasWaterBlockStripe { get; set; }
        public Polymer CoverMaterial { get; set; }
        public bool SparkSafety { get; set; }
        public double MaxCableDiameter { get; set; }

    }
}

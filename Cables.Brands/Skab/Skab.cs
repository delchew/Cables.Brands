using Cables.Brands.Common;

namespace Cables.Brands.Skab
{
    public class Skab : Cable, ISingleConstruction, IIndividualFoilShields, IShield, IWaterBlockingElements, IFilled, IArmoured
    {
        public SkabVoltageType VoltageType { get; set; }


        public bool HasIndividualFoilShields { get; set; } //public bool HasIndividualFoilShields { get; set; }

        public bool HasFoilShield { get; set; } //public bool HasFoilShield { get; set; }

        public bool HasBraidShield { get; set; } //public bool HasBraidShield { get; set; }

        public bool HasFilling { get; set; } //public bool HasFilling { get; set; }


        public bool HasArmorBraid { get; set; } //public bool HasArmourBraid { get; set; }

        public bool HasArmorTube { get; set; } //public bool HasArmourTube { get; set; }

        public bool HasWaterBlockingElements { get; set; } //public bool HasWaterBlockStripe { get; set; }

        public bool SparkSafety { get; set; } //public bool SparkSafety { get; set; }

    }
}

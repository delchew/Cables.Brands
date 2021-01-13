using Cables.Brands.Common;

namespace Cables.Brands.Skab
{
    public class Skab : Cable, ISingleConstruction, IIndividualFoilShields, IShield, IWaterBlockingElements, IFilled, IArmoured
    {
        public SkabVoltageType VoltageType { get; set; }

        public bool SparkSafety { get; set; }


        public ConductingCore ConductingCore { get; set; }

        public int ElementsCount { get; set; }

        public TwistedElementType CoreTwistType { get; set; }


        public bool HasIndividualFoilShields { get; set; }

        public bool HasFoilShield { get; set; }

        public bool HasBraidingShield { get; set; }

        public bool HasContactWire { get; set; }


        public bool HasWaterBlockingElements { get; set; }

        public bool HasFilling { get; set; }


        public bool HasArmor { get; set; }

        public bool HasArmorTube { get; set; }


    }
}

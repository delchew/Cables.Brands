using Cables.Materials;
using Cables.Brands.Common;

namespace Cables.Brands.Skab
{
    public class Skab : Cable, ISingleConstruction, IWaterBlockingElements, IFilled, IArmoured
    {
        public SkabVoltageType VoltageType { get; set; }

        public bool SparkSafety { get; set; }


        public ConductingCore ConductingCore { get; set; }

        public Polymer InsulationMaterial { get; set; }

        public int ElementsCount { get; set; }

        public TwistedElementType CoreTwistType { get; set; }

        public Polymer CoverMaterial { get; set; }


        public bool HasIndividualShields { get; set; }

        public bool HasFoilShield { get; set; }


        public bool HasWaterBlockingElements { get; set; }

        public Polymer FillingMaterial { get; set; }


        public bool HasArmor { get; set; }

        public bool HasArmorTube { get; set; }

        //public double MaxCableDiameter { get; set; }
    }
}

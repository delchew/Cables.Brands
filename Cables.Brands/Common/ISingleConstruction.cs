using Cables.Materials;

namespace Cables.Brands.Common
{
    public interface ISingleConstruction
    {
        public ConductingCore ConductingCore { get; set; }

        public Polymer InsulationMaterial { get; set; }

        public int ElementsCount { get; set; }

        public TwistedElementType CoreTwistType { get; set; }

        public Polymer CoverMaterial { get; set; }
    }
}

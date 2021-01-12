using Cables.Materials;

namespace Cables.Brands.Common
{
    public interface ISingleConstruction
    {
        ConductingCore ConductingCore { get; set; }

        int ElementsCount { get; set; }

        TwistedElementType CoreTwistType { get; set; }
    }
}

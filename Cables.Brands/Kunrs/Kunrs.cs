using Cables.Brands.Common;

namespace Cables.Brands.Kunrs
{
    public class Kunrs : Cable, ISingleConstruction, IFoilShield, IFilled, IArmoured
    {
        public bool HasFoilShield { get; set; } //public bool HasFoilShield { get; set; }
        public bool HasFilling { get; set; } //public bool HasFilling { get; set; }
        public bool HasArmor { get; set; } //public bool HasArmourBraid { get; set; }
        public bool HasArmorTube { get; set; } //public bool HasArmourTube { get; set; }
        public int PowerColorSchemeId { get; set; } //!!!!!!!!!!!!!!!!!!!!!!
    }
}

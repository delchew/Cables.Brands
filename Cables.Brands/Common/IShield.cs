namespace Cables.Brands.Common
{
    public interface IShield : IFoilShield
    {
        bool HasBraidingShield { get; set; }

        bool HasContactWire { get; set; }
    }
}

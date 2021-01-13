namespace Cables.Brands.Common
{
    public abstract class Cable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string TechnicalSpecifications { get; set; }

        public FireProtectionClass FireProtectionClass { get; set; }

        public double? MaxCableDiameter { get; set; }
    }
}

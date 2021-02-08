namespace Cables.Brands.Common
{
    public abstract class Cable
    {
        public int Id { get; set; } //public long CableId { get; set; }

        public long BilletId { get; set; } //!!!!!!!!!!!!!!!!!!!!!!!!!

        public int ElementsCount { get; set; } //public int ElementsCount { get; set; }

        public int TwistedElementTypeId { get; set; } //!!!!!!!!!!!!!!!!!!!!!!!

        public string TechnicalSpecifications { get; set; } //public int TechCondId { get; set; }

        public double? MaxCableDiameter { get; set; } //public decimal MaxCoverDiameter { get; set; }

        public FireProtectionClass FireProtectionClass { get; set; } //public int FireProtectionId { get; set; }

        public int CoverPolimerGroupId { get; set; } //!!!!!!!!!!!!!!!!!!!!!!!

        public int CoverColorId { get; set; } //!!!!!!!!!!!!!!!!!!!!!!!!!!

        public string Name { get; set; }

        

        

    }
}

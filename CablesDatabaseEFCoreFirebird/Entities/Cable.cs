namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class Cable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int BilletId { get; set; }
        public int ElementsCount { get; set; }
        public int TwistedElementTypeId { get; set; }
        public int TechnicalConditionsId { get; set; }
        public int FireProtectionClassId { get; set; }
        public int CoverPolymerGroupId { get; set; }
        public int CoverColorId { get; set; }
        public decimal MaxCoverDiameter { get; set; }
        public int ClimaticModId { get; set; }
        public int OperatingVoltageId { get; set; }
    }
}

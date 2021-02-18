namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class InsulatedBillet
    {
        public int Id { get; set; }
        public int ConductorId { get; set; }
        public int PolymerGroupId { get; set; }
        public int OperatingVoltageId { get; set; }
        public decimal Diameter { get; set; }
        public decimal MinThickness { get; set; }
        public decimal NominalThickness { get; set; }
        public int CableShortNameId { get; set; }
    }
}

namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class OperatingVoltage
    {
        public int Id { get; set; }
        public int ACVoltage { get; set; }
        public int ACFriquency { get; set; }
        public int DCVoltage { get; set; }
        public string Description { get; set; }
    }
}

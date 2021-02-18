namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class Conductor
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int WiresCount { get; set; }
        //public Metal Metal { get; set; }
        public int Class { get; set; }
        public decimal WiresDiameter { get; set; }
        public decimal ConductorDiameter { get; set; }
        public decimal AreaInSqrMm { get; set; }
    }
}

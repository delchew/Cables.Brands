namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class TwistInfo
    {
        public int Id { get; set; }
        public int ElementsCount { get; set; }
        public decimal TwistCoefficient { get; set; }
        public int Layer1ElementsCount { get; set; }
        public int Layer2ElementsCount { get; set; }
        public int Layer3ElementsCount { get; set; }
        public int Layer4ElementsCount { get; set; }
        public int Layer5ElementsCount { get; set; }
    }
}

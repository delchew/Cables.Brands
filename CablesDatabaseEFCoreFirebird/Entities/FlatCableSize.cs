namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class FlatCableSize
    {
        public int Id { get; set; }

        public decimal Height { get; set; }

        public decimal Width { get; set; }


        public int CableId { get; set; }

        public Cable Cable { get; set; }
    }
}

namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class ListCableProperties
    {
        public int Id { get; set; }

        public int CableId { get; set; }

        public int PropertyId { get; set; }


        public Cable Cable { get; set; }

        public CableProperty Property { get; set; }
    }
}

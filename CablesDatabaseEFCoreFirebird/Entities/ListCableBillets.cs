namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class ListCableBillets
    {
        public int Id { get; set; }

        public int CableId { get; set; }

        public int BilletId { get; set; }


        public Cable Cable { get; set; }

        public InsulatedBillet Billet { get; set; }
    }
}

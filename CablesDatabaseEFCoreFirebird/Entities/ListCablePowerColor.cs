namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class ListCablePowerColor
    {
        public int Id { get; set; }

        public int CableId { get; set; }

        public int PowerColorSchemeId { get; set; }


        public Cable Cable { get; set; }

        public PowerColorScheme PowerColorScheme { get; set; }
    }
}

using System.Collections.Generic;

namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class CableShortName
    {
        public int Id { get; set; }

        public string ShortName { get; set; }

        public List<InsulatedBillet> InsulatedBillets { get; set; }
    }
}

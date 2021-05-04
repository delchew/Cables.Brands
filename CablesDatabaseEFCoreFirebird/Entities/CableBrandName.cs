using System.Collections.Generic;

namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class CableBrandName
    {
        public int Id { get; set; }

        public string BrandName { get; set; }

        public List<InsulatedBillet> InsulatedBillets { get; set; }
    }
}

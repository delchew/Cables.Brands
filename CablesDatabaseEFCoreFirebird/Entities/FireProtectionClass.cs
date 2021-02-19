using System.Collections.Generic;

namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class FireProtectionClass
    {
        public int Id { get; set; }

        public string Class { get; set; }

        public string Designation { get; set; }


        public List<Cable> Cables { get; set; }
    }
}

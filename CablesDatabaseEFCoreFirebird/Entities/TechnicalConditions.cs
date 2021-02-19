using System.Collections.Generic;

namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class TechnicalConditions
    {
        public int Id { get; set; }
        public string Title { get; set; }


        public List<Cable> Cables { get; set; }
    }
}

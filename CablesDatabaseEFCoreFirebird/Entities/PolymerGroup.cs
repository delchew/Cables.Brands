using System.Collections.Generic;

namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class PolymerGroup
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string TitleRus { get; set; }


        public List<InsulatedBillet> InsulatedBillets { get; set; }

        public List<Cable> Cables { get; set; }
    }
}

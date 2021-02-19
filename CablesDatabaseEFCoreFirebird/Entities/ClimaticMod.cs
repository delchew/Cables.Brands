using System.Collections.Generic;

namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class ClimaticMod
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }


        public List<Cable> Cables { get; set; }
    }
}

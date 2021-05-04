using System.Collections.Generic;

namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class Color
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string TitleRus { get; set; }

        public int BitNumber { get; set; }


        public List<Cable> Cables { get; set; }
    }
}

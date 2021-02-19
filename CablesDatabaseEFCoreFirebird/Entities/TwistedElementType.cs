using System.Collections.Generic;

namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class TwistedElementType
    {
        public int Id { get; set; }

        public string ElementType { get; set; }


        public List<Cable> Cables { get; set; }
    }
}

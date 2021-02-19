using System.Collections.Generic;

namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class Metal
    {
        public int Id { get; set; }

        public string MetalName { get; set; }

        public int Density20 { get; set; }


        public List<Conductor> Conductors { get; set; }
    }
}

using System.Collections.Generic;

namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class CableProperty
    {
        public int Id { get; set; }

        public string PropertyInfo { get; set; }


        public List<ListCableProperties> ListCableProperties { get; set; }

    }
}

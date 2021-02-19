using System.Collections.Generic;

namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class PowerColorScheme
    {
        public int Id { get; set; }

        public string ColorScheme { get; set; }

        public string ColorSchemeRus { get; set; }


        public List<ListCablePowerColor> ListCablePowerColors { get; set; }
    }
}

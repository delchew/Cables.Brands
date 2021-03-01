using System.Collections.Generic;

namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class InsulatedBillet
    {
        public int Id { get; set; }

        public int ConductorId { get; set; }

        public int PolymerGroupId { get; set; }

        public int OperatingVoltageId { get; set; }

        public decimal Diameter { get; set; }

        public decimal? MinThickness { get; set; }

        public decimal? NominalThickness { get; set; }

        public int CableShortNameId { get; set; }


        public Conductor Conductor { get; set; }

        public PolymerGroup PolymerGroup { get; set; }

        public OperatingVoltage OperatingVoltage { get; set; }

        public CableShortName CableShortName { get; set; }


        public List<ListCableBillets> ListCableBillets { get; set; }
    }
}

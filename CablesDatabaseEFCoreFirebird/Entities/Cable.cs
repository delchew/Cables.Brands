using System.Collections.Generic;

namespace CablesDatabaseEFCoreFirebird.Entities
{
    public class Cable
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal ElementsCount { get; set; }

        public int TwistedElementTypeId { get; set; }

        public int TechnicalConditionsId { get; set; }

        public int FireProtectionClassId { get; set; }

        public int CoverPolymerGroupId { get; set; }

        public int CoverColorId { get; set; }

        public decimal? MaxCoverDiameter { get; set; }

        public int ClimaticModId { get; set; }

        public int OperatingVoltageId { get; set; }


        public TwistedElementType TwistedElementType { get; set; }

        public TechnicalConditions TechnicalConditions { get; set; }

        public FireProtectionClass FireProtectionClass { get; set; }

        public PolymerGroup CoverPolymerGroup { get; set; }

        public Color CoverColor { get; set; }

        public ClimaticMod ClimaticMod { get; set; }

        public OperatingVoltage OperatingVoltage { get; set; }


        public List<ListCableBillets> ListCableBillets { get; set; }
        
        public List<ListCablePowerColor> ListCablePowerColors { get; set; }

        public List<ListCableProperties> ListCableProperties { get; set; }
    }
}

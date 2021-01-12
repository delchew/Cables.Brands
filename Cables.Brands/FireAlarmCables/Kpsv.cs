﻿using Cables.Brands.Common;

namespace Cables.Brands.FireAlarmCables
{
    public class Kpsv : Cable, ISingleConstruction, IFoilShield, IArmoured
    {
        public ConductingCore ConductingCore { get; set; }

        public int ElementsCount { get; set; }

        public TwistedElementType CoreTwistType { get; set; }

        public bool HasFoilShield { get; set; }

        public bool HasArmor { get; set; }

        public bool HasArmorTube { get; set; }
    }
}

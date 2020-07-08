﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x71845D511FA17C16, NameHash = 0x9A43A9B870251F8C)]
    public class GcMissionConditionShipEngineStatus : NMSTemplate
    {
        public enum EngineStatusEnum { Thrusting, Braking, Landing, Landed, Boosted, Pulsing }
        public EngineStatusEnum EngineStatus;
    }
}
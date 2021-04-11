using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0x48EE891FE5AF8BBD, NameHash = 0xE14D5B0B53D91D7C)]
    public class GcPetEggTraitModifierOverrideData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ProductID;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string SubstanceID;
        /* 0x20 */ public GcCreaturePetTraits Trait;
        /* 0x24 */ public bool IncreasesTrait;
        /* 0x28 */ public int BaseValueOverride;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2C */ public byte[] EndPadding;
    }
}
using ProtoBuf;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace AncientTools.Config
{
    [ProtoBuf.ProtoContract()]
    class AncientToolsConfig
    {
        [ProtoMember(1)]
        public float MortarGrindTime = 4.0f;

        [ProtoMember(2)]
        public int MortarOutputModifier = 1;

        [ProtoMember(3)]
        public bool AllowMortarGrindablePlaceableWithSneak = false;

        [ProtoMember(4)]
        public int BarkPerLog = 4;

        [ProtoMember(5)]
        public double BaseBarkStrippingSpeed = 1.0;

        [ProtoMember(6)]
        public double BasePrimitiveBarrelCarvingSpeed = 1.0;

        [ProtoMember(7)]
        public double SalveMixTime = 1.5;

        [ProtoMember(8)]
        public bool BarkBreadEnabled = true;

        [ProtoMember(9)]
        public bool SalveEnabled = true;

        [ProtoMember(10)]
        public bool DisableVanillaHideCrafting = false;

        [ProtoMember(11)]
        public bool DisableVanillaHideCraftingRecipeOnly = false;

        [ProtoMember(12)]
        public bool DisableVanillaGlue = false;

        [ProtoMember(13)]
        public bool AllowCarvingForResin = true;

        [ProtoMember(14)]
        public float SkinningTime = 4.0f;

        [ProtoMember(15)]
        public double WaterSackConversionHours = 48.0;

        [ProtoMember(16)]
        public bool DisableBrainDrops = false;

        [ProtoMember(17)]
        public int BrainsPerBrainingSolutionCraft = 1;

        [ProtoMember(18)]
        public float BrainedHideSealHours = 96.0f;

        [ProtoMember(19)]
        public float BrainedHideSmokingSeconds = 1200.0f;

        [ProtoMember(20)]
        public bool InWorldBeamCraftingOnly = true;

        [ProtoMember(21)]
        public bool DisableWedgePickupWireframe = false;

        [ProtoMember(22)]
        public bool AdzeStrippingOnly = true;

        [ProtoMember(23)]
        public int CandleChamberstickLightLevel = 14;

        [ProtoMember(24)]
        public int PitchChamberstickLightLevel = 16;

        public AncientToolsConfig()
        {

        }
        public AncientToolsConfig(AncientToolsConfig previousConfig)
        {
            MortarGrindTime = previousConfig.MortarGrindTime;
            MortarOutputModifier = previousConfig.MortarOutputModifier;
            AllowMortarGrindablePlaceableWithSneak = previousConfig.AllowMortarGrindablePlaceableWithSneak;
            BarkPerLog = previousConfig.BarkPerLog;
            BaseBarkStrippingSpeed = previousConfig.BaseBarkStrippingSpeed;
            BasePrimitiveBarrelCarvingSpeed = previousConfig.BasePrimitiveBarrelCarvingSpeed;
            SalveMixTime = previousConfig.SalveMixTime;
            BarkBreadEnabled = previousConfig.BarkBreadEnabled;
            SalveEnabled = previousConfig.SalveEnabled;
            DisableVanillaHideCrafting = previousConfig.DisableVanillaHideCrafting;
            DisableVanillaHideCraftingRecipeOnly = previousConfig.DisableVanillaHideCraftingRecipeOnly;
            DisableVanillaGlue = previousConfig.DisableVanillaGlue;
            AllowCarvingForResin = previousConfig.AllowCarvingForResin;
            SkinningTime = previousConfig.SkinningTime;
            WaterSackConversionHours = previousConfig.WaterSackConversionHours;
            DisableBrainDrops = previousConfig.DisableBrainDrops;
            BrainsPerBrainingSolutionCraft = previousConfig.BrainsPerBrainingSolutionCraft;
            BrainedHideSealHours = previousConfig.BrainedHideSealHours;
            BrainedHideSmokingSeconds = previousConfig.BrainedHideSmokingSeconds;
            InWorldBeamCraftingOnly = previousConfig.InWorldBeamCraftingOnly;
            DisableWedgePickupWireframe = previousConfig.DisableWedgePickupWireframe;
            AdzeStrippingOnly = previousConfig.AdzeStrippingOnly;
            CandleChamberstickLightLevel = previousConfig.CandleChamberstickLightLevel;
            PitchChamberstickLightLevel = previousConfig.PitchChamberstickLightLevel;
        }
    }
}

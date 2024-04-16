using HarmonyLib;

namespace ONI_CuppyUniverse_Mod
{
    public class Patches
    {
        [HarmonyPatch(typeof(Db))]
        [HarmonyPatch("Initialize")]
        public class Db_Initialize_Patch
        {
            public static void Prefix()
            {
                Debug.Log("Hello! Welcome to CuppyUniverse! [before Db.Initialize]");
            }

            public static void Postfix()
            {
                Debug.Log("CuppyUniverse initialized! [after Db.Initialize]");
            }
        }
        [HarmonyPatch(typeof(ElectrolyzerConfig))]
        [HarmonyPatch("CreateBuildingDef")]
        public class ElectrolyzerConfig_Patch
        {
            public static void Postfix(ref BuildingDef __result)
            {
                __result.EnergyConsumptionWhenActive = 114f;
            }
        }
    }
    
}

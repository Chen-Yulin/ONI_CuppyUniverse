using System;
using HarmonyLib;

namespace ONI_CuppyUniverse_Mod
{
    [HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
    public class GeneratedBuildings_LoadGeneratedBuildings
    {
        public static void Prefix()
        {
            Strings.Add(new string[] { 
                "STRINGS.BUILDINGS.PREFABS.GOLDWASHER.NAME",
                "淘金器"
            });
            Strings.Add(new string[] {
                "STRINGS.BUILDINGS.PREFABS.GOLDWASHER.EFFECT",
                "从纯净水中淘取黄金"
            });
            Strings.Add(new string[] {
                "STRINGS.BUILDINGS.PREFABS.GOLDWASHER.DESC",
                "你是信无中生有的"
            });
            ModUtil.AddBuildingToPlanScreen("Food", "GoldWasher");
        }
    }
}

using System.Collections.Generic;
using HarmonyLib;
using RimWorld;

namespace NoRandomApparelOnIdeoEdit.Harmony.Patches
{
    [HarmonyPatch(typeof(Precept_Role))]
    [HarmonyPatch("GenerateNewApparelRequirements")]
    public class PatchPreceptRoleGenerateApparelRequirements
    {
        [HarmonyPrefix]
        public static bool Prefix(ref List<PreceptApparelRequirement> __result)
        {
            //TO-DO : Mod options to set it either for all factions (current behaviour) or only for player faction
            __result = new List<PreceptApparelRequirement>(); 
            return false; //Bypass vanilla method
        }
    }
}
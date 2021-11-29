using HarmonyLib;

namespace NoRandomApparelOnIdeoEdit.Harmony
{
    public class HarmonyBase
    {
        private static HarmonyLib.Harmony harmonyInstance = new HarmonyLib.Harmony("com.norandomapparelonideoedit.patch");

        public static void ApplyPatches()
        {
            harmonyInstance.PatchAll();
        }
    }
}
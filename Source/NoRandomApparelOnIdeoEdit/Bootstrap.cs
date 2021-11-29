using NoRandomApparelOnIdeoEdit.Harmony;
using Verse;

namespace NoRandomApparelOnIdeoEdit
{
    [StaticConstructorOnStartup]
    public static class Bootstrap
    {
        static Bootstrap()
        {
            HarmonyBase.ApplyPatches();
        }
    }
}
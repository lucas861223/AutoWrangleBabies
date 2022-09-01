using HarmonyLib;
using UnityEngine;

namespace AutoWrangleBabies
{
    public class Patches
    {
        [HarmonyPatch(typeof(EntityTemplates), "ExtendEntityToBeingABaby")]
        public class Baby_Patch
        {
            public static void Postfix(GameObject __result)
            {
                __result.AddOrGetDef<FixedCapturableMonitor.Def>();
            }
        }
    }
}

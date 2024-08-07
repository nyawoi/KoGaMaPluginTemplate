using HarmonyLib;

namespace ExamplePlugin.Patches;

[HarmonyPatch(typeof(MVGameControllerBase))]
public static class MVGameControllerBasePatch
{
    [HarmonyPostfix]
    [HarmonyPatch(nameof(MVGameControllerBase.Awake))]
    public static void ExamplePatch(MVGameControllerBase __instance)
    {
        ExamplePlugin.Logger.LogInfo($"Current game version is {__instance.koGaMaSettings.VersionString} ({__instance.koGaMaSettings.ReleaseName})");
    }
}

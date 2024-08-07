using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace ExamplePlugin;

[BepInPlugin(PluginGUID, PluginName, PluginVersion)]
public class ExamplePlugin : BasePlugin
{
    public const string PluginGUID = PluginAuthor + "." + PluginName;
    public const string PluginAuthor = "AuthorName";
    public const string PluginName = "ExamplePlugin";
    public const string PluginVersion = "0.1.0";

    internal static ManualLogSource Logger;

    public override void Load()
    {
        Logger = Log;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGUID);
    }
}

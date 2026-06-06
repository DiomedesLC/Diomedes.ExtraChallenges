using BepInEx;
using BepInEx.Logging;
using System.Collections.Generic;
using MonoMod.RuntimeDetour;
using HarmonyLib;
using Diomedes.Client.API;
using BepInEx.Bootstrap;
using Diomedes.ExtraChallenges.CodeRebirth;

namespace Diomedes.ExtraChallenges;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInDependency(DiomedesClientAPI.PLUGIN_GUID)]
public class DiomedesECPlugin : BaseUnityPlugin {
    internal new static ManualLogSource Logger { get; private set; } = null!;

    void Awake() {
        Logger = base.Logger;
    }

    void OnDestroy() {
        if(Chainloader.PluginInfos.ContainsKey(CodeRebirthChallenges.PLUGIN_GUID)) {
            CodeRebirthChallenges.Init(Logger);
        }

        Logger.LogInfo($"{MyPluginInfo.PLUGIN_GUID} v{MyPluginInfo.PLUGIN_VERSION} has loaded!");
    }
}

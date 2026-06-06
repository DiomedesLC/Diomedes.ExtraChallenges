using System.Runtime.CompilerServices;
using BepInEx.Logging;
using Diomedes.Client.API;

namespace Diomedes.ExtraChallenges.CodeRebirth;

public static class CodeRebirthChallenges {
    public const string PLUGIN_GUID = global::CodeRebirth.MyPluginInfo.PLUGIN_GUID;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static void Init(ManualLogSource logger) {
        logger.LogInfo("Setting up CodeRebirth challenges!");
    }
}
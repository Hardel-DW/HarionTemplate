using BepInEx;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using Harion;
using Harion.Cooldown;
using Harion.CustomOptions;
using HarmonyLib;

namespace TemplateHarion {

    [BepInPlugin(Id)]
    [BepInProcess("Among Us.exe")]
    [BepInDependency(HarionPlugin.Id)]
    public class TemplatePlugin : BasePlugin {
        public const string Id = "gg.hardel.templateharion";
        public static ManualLogSource Logger;

        public Harmony Harmony { get; } = new Harmony(Id);

        public override void Load() {
            Logger = Log;
            Harmony.PatchAll();
            RegisterCooldownButton.Register();
            ResourceLoader.LoadAssets();
            GenericGameOption.GameOptionConfiguration();
        }
    }
}

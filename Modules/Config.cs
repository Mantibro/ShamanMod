using BepInEx.Configuration;
using UnityEngine;

namespace ShamanMod.Modules
{
    public static class Config
    {
        public static ConfigEntry<float> F_DefSpawnTime { get; set; }
        public static ConfigEntry<float> F_MinSpawnTime { get; set; }
        public static ConfigEntry<float> F_MaxSpawnTime { get; set; }

        public static void ReadConfig()
        {
            F_DefSpawnTime = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Properties",
                "Default Acolyte spawn rate",
                45,
                "Seconds until an Acolyte is spawned, before Attack speed calculations."
            );
            F_MinSpawnTime = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Properties",
                "Minimum Acolyte spawn rate",
                15,
                "Minimum seconds until an Acolyte is spawned."
            );
            F_MaxSpawnTime = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Properties",
                "Maximum Acolyte spawn rate",
                60,
                "Maximum seconds until an Acolyte is spawned."
            );
        }
    }
}

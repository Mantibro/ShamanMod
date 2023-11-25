using RoR2;
using System;
using System.Runtime.CompilerServices;

namespace ShamanMod.Modules
{
    public class Compat
    {

        public static bool TinkersSatchelInstalled;
        public static bool AetheriumInstalled;
        public static bool ScepterInstalled;

        public static void Initialize()
        {
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("com.ThinkInvisible.TinkersSatchel"))
            {
                TinkersSatchelInstalled = true;
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("com.KomradeSpectre.Aetherium"))
            {
                AetheriumInstalled = true;
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("com.DestroyedClone.AncientScepter"))
            {
                ScepterInstalled = true;
            }
        }

        internal static int TryGetScepterCount(Inventory inventory)
        {
            if (!ScepterInstalled)
                return 0;

            return GetScepterCount(inventory);
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private static int GetScepterCount(Inventory inventory)
        {
            return inventory.GetItemCount(AncientScepter.AncientScepterItem.instance.ItemDef);
        }
    }
}
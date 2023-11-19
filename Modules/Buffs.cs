using RoR2;
using System.Collections.Generic;
using UnityEngine;

namespace ShamanMod.Modules
{
    public static class Buffs
    {
        // armor buff gained during roll
        internal static BuffDef armorBuff;
        internal static BuffDef summonCooldownDebuff;
        internal static BuffDef acolyteBeastSummonBuff;
        internal static BuffDef acolyteFrenzyBuff;

        internal static void RegisterBuffs()
        {
            armorBuff = AddNewBuff("ArmorBuff",
                LegacyResourcesAPI.Load<BuffDef>("BuffDefs/HiddenInvincibility").iconSprite, 
                Color.white, 
                false, 
                false);

            summonCooldownDebuff = AddNewBuff("ShamanSummonCooldownDebuff",
                Assets.mainAssetBundle.LoadAsset<Sprite>("texCooldownDebuff"),
                new Color(0.0392156862745098f, 0.3137254901960784f, 0f),
                false,
                false);

            acolyteBeastSummonBuff = AddNewBuff("AcolyteBeastPowerBuff",
                Assets.mainAssetBundle.LoadAsset<Sprite>("texCooldownDebuff"),
                new Color(0.0392156862745098f, 0.3137254901960784f, 0f),
                true,
                false);

            acolyteFrenzyBuff = AddNewBuff("AcolyteFrenzyBuff",
                Assets.mainAssetBundle.LoadAsset<Sprite>("texCooldownDebuff"),
                new Color(0.0392156862745098f, 0.3137254901960784f, 0f),
                false,
                false);
        }

        // simple helper method
        internal static BuffDef AddNewBuff(string buffName, Sprite buffIcon, Color buffColor, bool canStack, bool isDebuff)
        {
            BuffDef buffDef = ScriptableObject.CreateInstance<BuffDef>();
            buffDef.name = buffName;
            buffDef.buffColor = buffColor;
            buffDef.canStack = canStack;
            buffDef.isDebuff = isDebuff;
            buffDef.eliteDef = null;
            buffDef.iconSprite = buffIcon;

            Modules.Content.AddBuffDef(buffDef);

            return buffDef;
        }
    }
}
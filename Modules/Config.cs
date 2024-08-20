using BepInEx.Configuration;
using UnityEngine;

namespace ShamanMod.Modules
{
    public static class Config
    {
        public static ConfigEntry<float> F_ShamanBMaxHealth { get; set; }
        public static ConfigEntry<float> F_ShamanBRegen { get; set; }
        public static ConfigEntry<float> F_ShamanBArmor { get; set; }
        public static ConfigEntry<float> F_ShamanBShield { get; set; }
        public static ConfigEntry<int> I_ShamanJumpCount { get; set; }
        public static ConfigEntry<float> F_ShamanBDamage { get; set; }
        public static ConfigEntry<float> F_ShamanBAtkSpd { get; set; }
        public static ConfigEntry<float> F_ShamanBCrit { get; set; }
        public static ConfigEntry<float> F_ShamanBSpeed { get; set; }
        public static ConfigEntry<float> F_ShamanBAccel { get; set; }
        public static ConfigEntry<float> F_ShamanBJump { get; set; }

        public static ConfigEntry<float> F_ShamanLMaxHealth { get; set; }
        public static ConfigEntry<float> F_ShamanLRegen { get; set; }
        public static ConfigEntry<float> F_ShamanLArmor { get; set; }
        public static ConfigEntry<float> F_ShamanLShield { get; set; }
        public static ConfigEntry<float> F_ShamanLDamage { get; set; }
        public static ConfigEntry<float> F_ShamanLAtkSpd { get; set; }
        public static ConfigEntry<float> F_ShamanLCrit { get; set; }
        public static ConfigEntry<float> F_ShamanLSpeed { get; set; }
        public static ConfigEntry<float> F_ShamanLJump { get; set; }

        public static ConfigEntry<float> F_DefSpawnTime { get; set; }
        public static ConfigEntry<float> F_MinSpawnTime { get; set; }
        public static ConfigEntry<float> F_MaxSpawnTime { get; set; }

        //Acolyte
        public static ConfigEntry<float> F_AcolyteBMaxHealth { get; set; }
        public static ConfigEntry<float> F_AcolyteBRegen { get; set; }
        public static ConfigEntry<float> F_AcolyteBArmor { get; set; }
        public static ConfigEntry<float> F_AcolyteBShield { get; set; }
        public static ConfigEntry<float> F_AcolyteBDamage { get; set; }
        public static ConfigEntry<float> F_AcolyteBAtkSpd { get; set; }
        public static ConfigEntry<float> F_AcolyteBCrit { get; set; }
        public static ConfigEntry<float> F_AcolyteBSpeed { get; set; }
        public static ConfigEntry<float> F_AcolyteBAccel { get; set; }
        public static ConfigEntry<float> F_AcolyteBJump { get; set; }

        public static ConfigEntry<float> F_AcolyteLMaxHealth { get; set; }
        public static ConfigEntry<float> F_AcolyteLRegen { get; set; }
        public static ConfigEntry<float> F_AcolyteLArmor { get; set; }
        public static ConfigEntry<float> F_AcolyteLShield { get; set; }
        public static ConfigEntry<float> F_AcolyteLDamage { get; set; }
        public static ConfigEntry<float> F_AcolyteLAtkSpd { get; set; }
        public static ConfigEntry<float> F_AcolyteLCrit { get; set; }
        public static ConfigEntry<float> F_AcolyteLSpeed { get; set; }
        public static ConfigEntry<float> F_AcolyteLJump { get; set; }

        //Shamanic Compound
        public static ConfigEntry<float> F_AcolyteBeastBMaxHealth { get; set; }
        public static ConfigEntry<float> F_AcolyteBeastBRegen { get; set; }
        public static ConfigEntry<float> F_AcolyteBeastBArmor { get; set; }
        public static ConfigEntry<float> F_AcolyteBeastBShield { get; set; }
        public static ConfigEntry<float> F_AcolyteBeastBDamage { get; set; }
        public static ConfigEntry<float> F_AcolyteBeastBAtkSpd { get; set; }
        public static ConfigEntry<float> F_AcolyteBeastBCrit { get; set; }
        public static ConfigEntry<float> F_AcolyteBeastBSpeed { get; set; }
        public static ConfigEntry<float> F_AcolyteBeastBAccel { get; set; }
        public static ConfigEntry<float> F_AcolyteBeastBJump { get; set; }

        public static ConfigEntry<float> F_AcolyteBeastLMaxHealth { get; set; }
        public static ConfigEntry<float> F_AcolyteBeastLRegen { get; set; }
        public static ConfigEntry<float> F_AcolyteBeastLArmor { get; set; }
        public static ConfigEntry<float> F_AcolyteBeastLShield { get; set; }
        public static ConfigEntry<float> F_AcolyteBeastLDamage { get; set; }
        public static ConfigEntry<float> F_AcolyteBeastLAtkSpd { get; set; }
        public static ConfigEntry<float> F_AcolyteBeastLCrit { get; set; }
        public static ConfigEntry<float> F_AcolyteBeastLSpeed { get; set; }
        public static ConfigEntry<float> F_AcolyteBeastLJump { get; set; }

        //Acolytic Preeminence

        public static ConfigEntry<float> F_AcolyteAngelBMaxHealth { get; set; }
        public static ConfigEntry<float> F_AcolyteAngelBRegen { get; set; }
        public static ConfigEntry<float> F_AcolyteAngelBArmor { get; set; }
        public static ConfigEntry<float> F_AcolyteAngelBShield { get; set; }
        public static ConfigEntry<float> F_AcolyteAngelBDamage { get; set; }
        public static ConfigEntry<float> F_AcolyteAngelBAtkSpd { get; set; }
        public static ConfigEntry<float> F_AcolyteAngelBCrit { get; set; }
        //public static ConfigEntry<float> F_AcolyteAngelBSpeed { get; set; }
        //public static ConfigEntry<float> F_AcolyteAngelBAccel { get; set; }
        //public static ConfigEntry<float> F_AcolyteAngelBJump { get; set; }

        public static ConfigEntry<float> F_AcolyteAngelLMaxHealth { get; set; }
        public static ConfigEntry<float> F_AcolyteAngelLRegen { get; set; }
        public static ConfigEntry<float> F_AcolyteAngelLArmor { get; set; }
        public static ConfigEntry<float> F_AcolyteAngelLShield { get; set; }
        public static ConfigEntry<float> F_AcolyteAngelLDamage { get; set; }
        public static ConfigEntry<float> F_AcolyteAngelLAtkSpd { get; set; }
        public static ConfigEntry<float> F_AcolyteAngelLCrit { get; set; }
        //public static ConfigEntry<float> F_AcolyteAngelLSpeed { get; set; }
        //public static ConfigEntry<float> F_AcolyteAngelLJump { get; set; }

        public static void ReadConfig()
        {
            F_ShamanBMaxHealth = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman base max health",
                80f,
                "Shaman base max health"
            );
            F_ShamanBRegen = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman base regen",
                0.9f,
                "Shaman base regen"
            );
            F_ShamanBArmor = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman base armor",
                0f,
                "Shaman base armor"
            );
            F_ShamanBShield = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman base shield",
                0f,
                "Shaman base shield"
            );
            I_ShamanJumpCount = ShamanPlugin.instance.Config.Bind<int>(
                "Shaman Stats",
                "Shaman jump count",
                2,
                "Shaman jump count"
            );
            F_ShamanBDamage = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman base damage",
                12f,
                "Shaman base damage"
            );
            F_ShamanBAtkSpd = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman base attack speed",
                1f,
                "Shaman base attack speed"
            );
            F_ShamanBCrit = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman base crit chance",
                1f,
                "Shaman base crit chance"
            );
            F_ShamanBSpeed = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman base movement speed",
                7f,
                "Shaman base movement speed"
            );
            F_ShamanBAccel = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman base acceleration",
                80f,
                "Shaman base acceleration"
            );
            F_ShamanBJump = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman base jump power",
                15f,
                "Shaman base jump power"
            );

            F_ShamanLMaxHealth = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman max health growth",
                30f,
                "Shaman max health growth"
            );
            F_ShamanLRegen = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman health regen growth",
                0.2f,
                "Shaman health regen growth"
            );
            F_ShamanLArmor = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman armor growth",
                0f,
                "Shaman armor growth"
            );
            F_ShamanLShield = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman shield growth",
                0f,
                "Shaman shield growth"
            );
            F_ShamanLDamage = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman damage growth",
                2.4f,
                "Shaman damage growth"
            );
            F_ShamanLAtkSpd = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman attack speed growth",
                0f,
                "Shaman attack speed growth"
            );
            F_ShamanLCrit = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman crit chance growth",
                0f,
                "Shaman crit chance growth"
            );
            F_ShamanLSpeed = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman move speed growth",
                0f,
                "Shaman move speed growth"
            );
            F_ShamanLJump = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Shaman jump power growth",
                0f,
                "Shaman jump power growth"
            );

            F_DefSpawnTime = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Default Acolyte spawn rate",
                45f,
                "Seconds until an Acolyte is spawned, before Attack speed calculations."
            );
            F_MinSpawnTime = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Minimum Acolyte spawn rate",
                15f,
                "Minimum seconds until an Acolyte is spawned."
            );
            F_MaxSpawnTime = ShamanPlugin.instance.Config.Bind<float>(
                "Shaman Stats",
                "Maximum Acolyte spawn rate",
                60f,
                "Maximum seconds until an Acolyte is spawned."
            );
            //Acolyte
            F_AcolyteBMaxHealth = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte base max health",
                160f,
                "Acolyte base max health"
            );
            F_AcolyteBRegen = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte base regen",
                1.2f,
                "Acolyte base regen"
            );
            F_AcolyteBArmor = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte base armor",
                0f,
                "Acolyte base armor"
            );
            F_AcolyteBShield = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte base shield",
                0f,
                "Acolyte base shield"
            );
            F_AcolyteBDamage = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte base damage",
                14f,
                "Acolyte base damage"
            );
            F_AcolyteBAtkSpd = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte base attack speed",
                1f,
                "Acolyte base attack speed"
            );
            F_AcolyteBCrit = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte base crit chance",
                1f,
                "Acolyte base crit chance"
            );
            F_AcolyteBSpeed = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte base movement speed",
                7f,
                "Acolyte base movement speed"
            );
            F_AcolyteBAccel = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte base acceleration",
                80f,
                "Acolyte base acceleration"
            );
            F_AcolyteBJump = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte base jump power",
                15f,
                "Acolyte base jump power"
            );

            F_AcolyteLMaxHealth = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte max health growth",
                30f,
                "Acolyte max health growth"
            );
            F_AcolyteLRegen = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte health regen growth",
                0.2f,
                "Acolyte health regen growth"
            );
            F_AcolyteLArmor = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte armor growth",
                0f,
                "Acolyte armor growth"
            );
            F_AcolyteLShield = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte shield growth",
                0f,
                "Acolyte shield growth"
            );
            F_AcolyteLDamage = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte damage growth",
                2.4f,
                "Acolyte damage growth"
            );
            F_AcolyteLAtkSpd = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte attack speed growth",
                0f,
                "Acolyte attack speed growth"
            );
            F_AcolyteLCrit = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte crit chance growth",
                0f,
                "Acolyte crit chance growth"
            );
            F_AcolyteLSpeed = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte move speed growth",
                0f,
                "Acolyte move speed growth"
            );
            F_AcolyteLJump = ShamanPlugin.instance.Config.Bind<float>(
                "Acolyte Stats",
                "Acolyte jump power growth",
                0f,
                "Acolyte jump power growth"
            );
            //Shamanic Compound
            F_AcolyteBeastBMaxHealth = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound base max health",
                325f,
                "Shamanic Compound base max health"
            );
            F_AcolyteBeastBRegen = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound base regen",
                0.8f,
                "Shamanic Compound base regen"
            );
            F_AcolyteBeastBArmor = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound base armor",
                0f,
                "Shamanic Compound base armor"
            );
            F_AcolyteBeastBShield = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound base shield",
                0f,
                "Shamanic Compound base shield"
            );
            F_AcolyteBeastBDamage = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound base damage",
                12f,
                "Shamanic Compound base damage"
            );
            F_AcolyteBeastBAtkSpd = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound base attack speed",
                1f,
                "Shamanic Compound base attack speed"
            );
            F_AcolyteBeastBCrit = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound base crit chance",
                1f,
                "Shamanic Compound base crit chance"
            );
            F_AcolyteBeastBSpeed = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound base movement speed",
                7f,
                "Shamanic Compound base movement speed"
            );
            F_AcolyteBeastBAccel = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound base acceleration",
                80f,
                "Shamanic Compound base acceleration"
            );
            F_AcolyteBeastBJump = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound base jump power",
                15f,
                "Shamanic Compound base jump power"
            );

            F_AcolyteBeastLMaxHealth = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound max health growth",
                30f,
                "Shamanic Compound max health growth"
            );
            F_AcolyteBeastLRegen = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound health regen growth",
                0.2f,
                "Shamanic Compound health regen growth"
            );
            F_AcolyteBeastLArmor = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound armor growth",
                0f,
                "Shamanic Compound armor growth"
            );
            F_AcolyteBeastLShield = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound shield growth",
                0f,
                "Shamanic Compound shield growth"
            );
            F_AcolyteBeastLDamage = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound damage growth",
                2.4f,
                "Shamanic Compound damage growth"
            );
            F_AcolyteBeastLAtkSpd = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound attack speed growth",
                0f,
                "Shamanic Compound attack speed growth"
            );
            F_AcolyteBeastLCrit = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound crit chance growth",
                0f,
                "Shamanic Compound crit chance growth"
            );
            F_AcolyteBeastLSpeed = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound move speed growth",
                0f,
                "Shamanic Compound move speed growth"
            );
            F_AcolyteBeastLJump = ShamanPlugin.instance.Config.Bind<float>(
                "Shamanic Compound Stats",
                "Shamanic Compound jump power growth",
                0f,
                "Shamanic Compound jump power growth"
            );
            //Acolytic Preeminence
            F_AcolyteAngelBMaxHealth = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence base max health",
                775f,
                "Acolytic Preeminence base max health"
            );
            F_AcolyteAngelBRegen = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence base regen",
                -10f,
                "Acolytic Preeminence base regen"
            );
            F_AcolyteAngelBArmor = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence base armor",
                25f,
                "Acolytic Preeminence base armor"
            );
            F_AcolyteAngelBShield = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence base shield",
                0f,
                "Acolytic Preeminence base shield"
            );
            F_AcolyteAngelBDamage = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence base damage",
                18f,
                "Acolytic Preeminence base damage"
            );
            F_AcolyteAngelBAtkSpd = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence base attack speed",
                1f,
                "Acolytic Preeminence base attack speed"
            );
            F_AcolyteAngelBCrit = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence base crit chance",
                1f,
                "Acolytic Preeminence base crit chance"
            );
            /*F_AcolyteAngelBSpeed = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence base movement speed",
                8f,
                "Acolytic Preeminence base movement speed"
            );
            F_AcolyteAngelBAccel = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence base acceleration",
                80f,
                "Acolytic Preeminence base acceleration"
            );
            F_AcolyteAngelBJump = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence base jump power",
                15f,
                "Acolytic Preeminence base jump power"
            );*/

            F_AcolyteAngelLMaxHealth = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence max health growth",
                30f,
                "Acolytic Preeminence max health growth"
            );
            F_AcolyteAngelLRegen = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence health regen growth",
                0.2f,
                "Acolytic Preeminence health regen growth"
            );
            F_AcolyteAngelLArmor = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence armor growth",
                0f,
                "Acolytic Preeminence armor growth"
            );
            F_AcolyteAngelLShield = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence shield growth",
                0f,
                "Acolytic Preeminence shield growth"
            );
            F_AcolyteAngelLDamage = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence damage growth",
                2.4f,
                "Acolytic Preeminence damage growth"
            );
            F_AcolyteAngelLAtkSpd = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence attack speed growth",
                0f,
                "Acolytic Preeminence attack speed growth"
            );
            F_AcolyteAngelLCrit = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence crit chance growth",
                0f,
                "Acolytic Preeminence crit chance growth"
            );
            /*F_AcolyteAngelLSpeed = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence move speed growth",
                0f,
                "Acolytic Preeminence move speed growth"
            );
            F_AcolyteAngelLJump = ShamanPlugin.instance.Config.Bind<float>(
                "Acolytic Preeminence Stats",
                "Acolytic Preeminence jump power growth",
                0f,
                "Acolytic Preeminence jump power growth"
            );*/
        }
    }
}

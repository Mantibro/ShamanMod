using BepInEx;
using ShamanMod.Modules.Survivors;
using R2API.Utils;
using RoR2;
using System.Collections.Generic;
using System.Security;
using UnityEngine;
using System.Security.Permissions;
using UnityEngine.Networking;

[module: UnverifiableCode]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]

//rename this namespace
namespace ShamanMod
{
    [BepInDependency("com.bepis.r2api", BepInDependency.DependencyFlags.HardDependency)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.EveryoneNeedSameModVersion)]
    [BepInPlugin(MODUID, MODNAME, MODVERSION)]
    [R2APISubmoduleDependency(new string[]
    {
        "PrefabAPI",
        "LanguageAPI",
        "SoundAPI",
        "UnlockableAPI"
    })]

    public class ShamanPlugin : BaseUnityPlugin
    {
        // if you don't change these you're giving permission to deprecate the mod-
        //  please change the names to your own stuff, thanks
        //   this shouldn't even have to be said
        public const string MODUID = "com.manti.ShamanMod";
        public const string MODNAME = "ShamanMod";
        public const string MODVERSION = "1.0.4";

        // a prefix for name tokens to prevent conflicts- please capitalize all name tokens for convention
        public const string DEVELOPER_PREFIX = "MANTI";

        public static ShamanPlugin instance;

        private void Awake()
        {
            instance = this;

            Log.Init(Logger);
            Modules.Assets.Initialize(); // load assets and read config
            Modules.Config.ReadConfig();
            Modules.States.RegisterStates(); // register states for networking
            Modules.Buffs.RegisterBuffs(); // add and register custom buffs/debuffs
            Modules.Projectiles.RegisterProjectiles(); // add and register custom projectiles
            Modules.Tokens.AddTokens(); // register name tokens
            Modules.ItemDisplays.PopulateDisplays(); // collect item display prefabs for use in our display rules

            // survivor initialization
            new ShamanSurvivor().Initialize();
            new Modules.Characters.AcolyteCharacter().Initialize();
            new Modules.Characters.AcolyteBeastCharacter().Initialize();

            // now make a content pack and add it- this part will change with the next update
            new Modules.ContentPacks().Initialize();

            Hook();
        }

        private void Hook()
        {
            // run hooks here, disabling one is as simple as commenting out the line
            On.RoR2.CharacterBody.RecalculateStats += CharacterBody_RecalculateStats;
            On.RoR2.CharacterBody.FixedUpdate += CharacterBody_FixedUpdate;
            On.RoR2.CharacterBody.Start += CharacterBody_Start;
        }

        private void CharacterBody_RecalculateStats(On.RoR2.CharacterBody.orig_RecalculateStats orig, CharacterBody self)
        {
            orig(self);

            if (self)
            {
                if (self.HasBuff(Modules.Buffs.armorBuff))
                {
                    self.armor += 100f;
                }

                if (self.HasBuff(Modules.Buffs.acolyteBeastSummonBuff))
                {
                    self.armor += 10f;
                    self.baseDamage += 2f;
                    self.baseMaxHealth += 50f;
                }

                if (self.HasBuff(Modules.Buffs.acolyteFrenzyBuff))
                {
                    self.attackSpeed = self.attackSpeed * 2f;
                    self.moveSpeed = self.moveSpeed * 2f;
                    self.damage = self.damage * 1.5f;
                }
            }
        }

        private void CharacterBody_FixedUpdate(On.RoR2.CharacterBody.orig_FixedUpdate orig, CharacterBody self)
        {
            orig(self);
            // summon the acolytes
            if (self)
            {
                if (self.baseNameToken != DEVELOPER_PREFIX + "_SHAMAN_BODY_NAME")
                    return;

                if (!self.HasBuff(Modules.Buffs.summonCooldownDebuff))
                {

                    if (NetworkServer.active)
                    {
                        MasterSummon manner = new MasterSummon();

                        manner.masterPrefab = Modules.Characters.AcolyteCharacter.masterPrefab;

                        if (self.isPlayerControlled)
                        {
                            manner.inventoryToCopy = self.inventory;
                        }

                        manner.teamIndexOverride = self.teamComponent.teamIndex;
                        manner.summonerBodyObject = self.gameObject;
                        manner.rotation = self.gameObject.transform.rotation;

                        Vector3 spawn_pos = self.gameObject.transform.position + new Vector3((Random.value * 6f) - 3f, 0.1f + (Random.value * 0.25f), (Random.value * 6f) - 3f);
                        manner.position = spawn_pos;
                        manner.Perform();

                        float timeneeded = Mathf.Clamp(45f - ((self.attackSpeed - 1f) * 12f), 15f, 60f);
                        self.AddTimedBuff(Modules.Buffs.summonCooldownDebuff, timeneeded);
                    }
                }
            }
        }

        private void CharacterBody_Start(On.RoR2.CharacterBody.orig_Start orig, CharacterBody self)
        {
            orig(self);
            if (self)
            {
                if (NetworkServer.active)
                {
                    if (self.baseNameToken != DEVELOPER_PREFIX + "_SHAMAN_BODY_NAME")
                        return;

                    float timeneeded = Mathf.Clamp(45f - ( ( self.attackSpeed - 1f ) * 12f), 15f, 60f);
                    self.AddTimedBuff(Modules.Buffs.summonCooldownDebuff, timeneeded);
                }
            }
        }
    }
}
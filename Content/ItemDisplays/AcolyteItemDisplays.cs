using RoR2;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ShamanMod.Modules.Characters
{
    internal class AcolyteItemDisplays : ItemDisplaysBase
    {
        protected override void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {

            /*for custom copy format in keb's helper
            {childName},
                                                                       {localPos}, 
                                                                       {localAngles},
                                                                       {localScale})
                                                                                         // for some reason idph can only paste one ) at the end
            */

            /*for items with multiple displays (with CreateDisplayRuleGroupWithRules):
            {childName},
                                               {localPos}, 
                                               {localAngles},
                                               {localScale})
            */

            #region items
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AlienHead, "DisplayAlienHead",
                                                                       "Chest",
                                                                       new Vector3(0.153F, 0.152F, -0.382F),
                                                                       new Vector3(325.9806F, 151.966F, 303.6272F),
                                                                       new Vector3(0.858F, 0.858F, 0.858F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ArmorPlate, "DisplayRepulsionArmorPlate",
                                                                       "UpperArmR",
                                                                       new Vector3(0.026F, 0.13F, 0.056F),
                                                                       new Vector3(78.74371F, 270F, 89.99997F),
                                                                       new Vector3(0.405F, 0.435F, 0.349F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.ArmorReductionOnHit,
                ItemDisplays.CreateDisplayRule("DisplayWarhammer",
                                               "Spine",
                                                                       new Vector3(0.159F, 0.126F, -0.141F),
                                                                       new Vector3(331.8564F, 85.81026F, 91.58662F),
                                                                       new Vector3(0.187F, 0.187F, 0.187F))));//hammer
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AttackSpeedOnCrit, "DisplayWolfPelt",
                                                                       "Head",
                                                                       new Vector3(0.017F, 0.221F, -0.103F),
                                                                       new Vector3(288.4954F, 173.9509F, 176.0275F),
                                                                       new Vector3(0.931F, 0.637F, 0.637F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AutoCastEquipment, "DisplayFossil",
                                                                       "Neck",
                                                                       new Vector3(0.1F, 0.034F, -0.046F),
                                                                       new Vector3(0F, 52.11967F, 337.9004F),
                                                                       new Vector3(0.655F, 0.655F, 0.655F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Bandolier, "DisplayBandolier",
                                                                       "Chest",
                                                                       new Vector3(0F, -0.017F, 0F),
                                                                       new Vector3(270F, 90F, 0F),
                                                                       new Vector3(0.411F, 0.489F, 0.744F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnKill, "DisplayBrooch",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.164F, 0.185F), 
                                                                       new Vector3(80.07201F, 0F, 0F),
                                                                       new Vector3(0.75F, 0.643F, 0.643F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnOverHeal, "DisplayAegis",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.343F, 0.039F),
                                                                       new Vector3(90F, 180F, 0F),
                                                                       new Vector3(0.206F, 0.206F, 0.206F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Bear, "DisplayBear",
                                                                       "Chest",
                                                                       new Vector3(-0.163F, 0.326F, -0.203F),
                                                                       new Vector3(0F, 234.106F, 0F),
                                                                       new Vector3(0.261F, 0.269F, 0.269F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.BearVoid, "DisplayBearVoid",
                                                                       "Chest",
                                                                       new Vector3(-0.169F, 0.289F, -0.182F),
                                                                       new Vector3(0F, 223.9681F, 0F),
                                                                       new Vector3(0.28F, 0.28F, 0.28F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BeetleGland, "DisplayBeetleGland",
                                                                       "Chest",
                                                                       new Vector3(-0.005F, 0.169F, -0.227F),
                                                                       new Vector3(0F, 0F, 280.2594F),
                                                                       new Vector3(0.118F, 0.118F, 0.118F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Behemoth,
                ItemDisplays.CreateDisplayRule("DisplayBehemoth",
                                               "UpperArmL",
                                                                       new Vector3(0F, 0.163F, 0.186F),
                                                                       new Vector3(354.609F, 0F, 0F),
                                                                       new Vector3(0.068F, 0.068F, 0.068F))));

            //again, don't have to do this 
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.BleedOnHit,
                ItemDisplays.CreateDisplayRule("DisplayTriTip",
                                               "Chest",
                                                                       new Vector3(0F, 0.219F, -0.216F),
                                                                       new Vector3(314.135F, 180F, 180F),
                                                                       new Vector3(0.537F, 0.537F, 0.636F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(DLC1Content.Items.BleedOnHitVoid,
                ItemDisplays.CreateDisplayRule("DisplayTriTipVoid",
                                               "Neck",
                                                                       new Vector3(0F, -0.106F, -0.068F),
                                                                       new Vector3(61.19586F, 180F, 180F),
                                                                       new Vector3(0.44F, 0.44F, 0.521F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BleedOnHitAndExplode, "DisplayBleedOnHitAndExplode",
                                                                       "Spine",
                                                                       new Vector3(0F, 0F, 0.102F),
                                                                       new Vector3(27.99068F, 0F, 0F),
                                                                       new Vector3(0.049F, 0.049F, 0.049F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BonusGoldPackOnKill, "DisplayTome",
                                                                       "ThighL",
                                                                       new Vector3(-0.074F, 0.285F, 0.058F),
                                                                       new Vector3(0F, 96.85566F, 0F),
                                                                       new Vector3(0.078F, 0.078F, 0.078F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BossDamageBonus, "DisplayAPRound",
                                                                       "Spine",
                                                                       new Vector3(-0.113F, -0.006F, -0.077F),
                                                                       new Vector3(80.79361F, 20.23979F, 162.3526F),
                                                                       new Vector3(0.7F, 0.7F, 0.7F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BounceNearby, "DisplayHook",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.354F, -0.111F),
                                                                       new Vector3(41.59288F, 180F, 180F),
                                                                       new Vector3(-0.397F, -0.397F, -0.397F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ChainLightning, "DisplayUkulele",
                                                                       "Chest",
                                                                       new Vector3(-0.044F, 0.222F, -0.17F),
                                                                       new Vector3(359.3017F, 180F, 154.6813F),
                                                                       new Vector3(0.725F, 0.688F, 0.699F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ChainLightningVoid, "DisplayUkuleleVoid",
                                                                       "Chest",
                                                                       new Vector3(0.069F, 0.18F, -0.194F),
                                                                       new Vector3(351.1519F, 180F, 148.944F),
                                                                       new Vector3(0.783F, 0.744F, 0.755F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Clover, "DisplayClover",
                                                                       "Head",
                                                                       new Vector3(0.144F, 0.191F, -0.122F),
                                                                       new Vector3(286.0782F, 295.6274F, 12.20513F),
                                                                       new Vector3(0.595F, 0.595F, 0.593F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CloverVoid, "DisplayCloverVoid",
                                                                       "Head",
                                                                       new Vector3(0.116F, 0.179F, -0.146F),
                                                                       new Vector3(276.9178F, 237.7042F, 94.53139F),
                                                                       new Vector3(0.659F, 0.659F, 0.659F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(JunkContent.Items.CooldownOnCrit,
                ItemDisplays.CreateDisplayRule("DisplaySkull",
                                               "Head",
                                                                       new Vector3(0F, 0.189F, -0.135F),
                                                                       new Vector3(43.48513F, 180F, 180F),
                                                                       new Vector3(0.285F, 0.285F, 0.285F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.Head)
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.CritGlasses, "DisplayGlasses",
                                                                       "Head",
                                                                       new Vector3(0F, 0.308F, 0.017F),
                                                                       new Vector3(270F, 0.00001F, 0F),
                                                                       new Vector3(0.403F, 0.305F, 0.793F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CritGlassesVoid, "DisplayGlassesVoid",
                                                                       "Head",
                                                                       new Vector3(0F, 0.331F, 0.004F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.353F, 0.363F, 0.507F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Crowbar, "DisplayCrowbar",
                                                                       "Chest",
                                                                       new Vector3(-0.056F, 0.131F, -0.167F),
                                                                       new Vector3(48.24174F, 90F, 0F),
                                                                       new Vector3(0.498F, 0.498F, 0.498F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Dagger, "DisplayDagger",
                                                                       "Chest",
                                                                       new Vector3(0.018F, 0.26F, -0.089F),
                                                                       new Vector3(287.5269F, 0.00002F, 29.03086F),
                                                                       new Vector3(01.003F, 1.003F, 1.003F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.DeathMark, "DisplayDeathMark",
                                                                       "HandL",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(80.29325F, 355.1307F, 175.7849F),
                                                                       new Vector3(0.045F, 0.045F, 0.045F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.EnergizedOnEquipmentUse, "DisplayWarHorn",
                                                                       "Chest",
                                                                       new Vector3(-0.039F, 0.072F, -0.202F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.565F, 0.565F, 0.565F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.EquipmentMagazine, "DisplayBattery",
                                                                       "Hips",
                                                                       new Vector3(0.062F, 0.049F, -0.133F),
                                                                       new Vector3(0F, 270F, 0F),
                                                                       new Vector3(0.204F, 0.204F, 0.204F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.EquipmentMagazineVoid, "DisplayFuelCellVoid",
                                                                       "Hips",
                                                                       new Vector3(0F, 0.059F, -0.106F),
                                                                       new Vector3(90F, 89.99999F, 0F),
                                                                       new Vector3(0.285F, 0.285F, 0.285F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExecuteLowHealthElite, "DisplayGuillotine",
                                                                       "LowerArmL",
                                                                       new Vector3(0.004F, 0.363F, 0.1F),
                                                                       new Vector3(42.92808F, 180.5273F, 270.7742F),
                                                                       new Vector3(0.227F, 0.227F, 0.224F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExplodeOnDeath, "DisplayWilloWisp",
                                                                       "Neck",
                                                                       new Vector3(-0.167F, 0.047F, -0.014F),
                                                                       new Vector3(291.8631F, 180F, 142.0484F),
                                                                       new Vector3(0.088F, 0.088F, 0.088F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ExplodeOnDeathVoid, "DisplayWillowWispVoid",
                                                                       "Hips",
                                                                       new Vector3(0.106F, 0.068F, -0.09F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.067F, 0.067F, 0.067F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExtraLife, "DisplayHippo",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.197F, 0.225F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.289F, 0.297F, 0.297F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ExtraLifeVoid, "DisplayHippoVoid",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.085F, 0.151F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.292F, 0.301F, 0.301F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.FallBoots,
                ItemDisplays.CreateDisplayRule("DisplayGravBoots",
                                               "CalfL",
                                                                       new Vector3(0F, 0.43F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.251F, 0.251F, 0.251F)),
                ItemDisplays.CreateDisplayRule("DisplayGravBoots",
                                               "CalfR",
                                                                       new Vector3(0F, 0.43F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.251F, 0.251F, 0.251F)
                )));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Feather,
                ItemDisplays.CreateDisplayRule("DisplayFeather",
                                               "Chest",
                                                                       new Vector3(0.085F, 0.187F, -0.129F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(-0.062F, 0.037F, 0.037F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FireballsOnHit, "DisplayFireballsOnHit",
                                                                       "Chest",
                                                                       new Vector3(0.069F, 0.373F, -0.24F),
                                                                       new Vector3(336.4221F, 161.2971F, 354.7277F),
                                                                       new Vector3(0.102F, 0.117F, 0.097F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FireRing, "DisplayFireRing",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.544F, 0F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.55F, 0.55F, 0.55F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.IceRing, "DisplayIceRing",
                                                                       "LowerArmR",
                                                                       new Vector3(-0.009F, 0.55F, -0.002F),
                                                                       new Vector3(78.20138F, 54.06794F, 55.8657F),
                                                                       new Vector3(0.622F, 0.622F, 0.622F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ElementalRingVoid, "DisplayVoidRing",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.429F, 0F),
                                                                       new Vector3(270F, 136.8969F, 0F),
                                                                       new Vector3(0.715F, 0.715F, 0.612F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Firework, "DisplayFirework",
                                                                       "Chest",
                                                                       new Vector3(-0.179F, 0.383F, -0.135F),
                                                                       new Vector3(316.392F, 241.8502F, 127.8034F),
                                                                       new Vector3(0.361F, 0.361F, 0.361F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FlatHealth, "DisplaySteakCurved",
                                                                       "Head",
                                                                       new Vector3(0F, 0.035F, -0.198F),
                                                                       new Vector3(35.11937F, 180F, 180F),
                                                                       new Vector3(0.175F, 0.175F, 0.175F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FocusConvergence, "DisplayFocusedConvergence",
                                                                       "Root",
                                                                       new Vector3(-0.587F, 1.951F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.5F, 0.5F, 0.5F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.GhostOnKill, "DisplayMask",
                                                                       "UpperArmL",
                                                                       new Vector3(0F, 0.05F, 0.04F),
                                                                       new Vector3(0F, 0F, 180F),
                                                                       new Vector3(0.798F, 0.798F, 0.615F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.GoldOnHit, "DisplayBoneCrown",
                                                                       "Head",
                                                                       new Vector3(0F, -0.051F, -0.001F),
                                                                       new Vector3(0F, 180F, 0F),
                                                                       new Vector3(1.759F, 1.526F, 1.526F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HeadHunter, "DisplaySkullCrown",
                                                                       "Head",
                                                                       new Vector3(-0.002F, 0.199F, 0F),
                                                                       new Vector3(359.9472F, 173.7351F, 179.5188F),
                                                                       new Vector3(0.629F, 0.227F, 0.227F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HealOnCrit, "DisplayScythe",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.48F, 0.017F),
                                                                       new Vector3(270F, 270F, 0F),
                                                                       new Vector3(0.246F, 0.246F, 0.246F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HealWhileSafe, "DisplaySnail",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.044F, -0.029F),
                                                                       new Vector3(290.3202F, 180F, 180F),
                                                                       new Vector3(0.111F, 0.111F, 0.111F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Hoof,
                ItemDisplays.CreateDisplayRule("DisplayHoof",
                                               "CalfR",
                                                                       new Vector3(-0.023F, 0.353F, -0.017F),
                                                                       new Vector3(79.93874F, 359.8341F, 341.8235F),
                                                                       new Vector3(0.097F, 0.092F, 0.086F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.RightCalf)
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Icicle, "DisplayFrostRelic",
                                                                       "Root",
                                                                       new Vector3(0.814F, 1.618F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(1.38875F, 1.38875F, 1.38875F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.IgniteOnKill, "DisplayGasoline",
                                                                       "Spine",
                                                                       new Vector3(-0.051F, -0.061F, -0.112F),
                                                                       new Vector3(276.1328F, 180.0001F, 116.3038F),
                                                                       new Vector3(0.654F, 0.654F, 0.654F)));
            //hello
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.IncreaseHealing,
                ItemDisplays.CreateDisplayRule("DisplayAntler",
                                               "Head",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(353.9438F, 81.39288F, 300.5692F),
                                                                       new Vector3(0.42F, 0.42F, 0.42F)),
                ItemDisplays.CreateDisplayRule("DisplayAntler",
                                               "Head",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(356.1463F, 266.133F, 47.10716F),
                                                                       new Vector3(-0.42F, 0.42F, 0.42F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(JunkContent.Items.Incubator, "DisplayAncestralIncubator",
                                                                       "Chest",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(317.0807F, 0F, 0F),
                                                                       new Vector3(0.071F, 0.071F, 0.071F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Infusion, "DisplayInfusion",
                                                                       "Spine",
                                                                       new Vector3(0.098F, 0.003F, -0.113F),
                                                                       new Vector3(0.17003F, 142.4715F, 353.6781F),
                                                                       new Vector3(0.57F, 0.57F, 0.575F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.JumpBoost, "DisplayWaxBird",
                                                                       "Head",
                                                                       new Vector3(0F, -0.008F, 0.24F),
                                                                       new Vector3(270.4673F, 0F, 0F),
                                                                       new Vector3(0.701F, 0.701F, 0.701F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.KillEliteFrenzy, "DisplayBrainstalk",
                                                                       "Head",
                                                                       new Vector3(0F, 0.156F, 0.022F),
                                                                       new Vector3(296.542F, 0F, 0F),
                                                                       new Vector3(0.291F, 0.412F, 0.289F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Knurl, "DisplayKnurl",
                                                                       "Spine",
                                                                       new Vector3(0F, -0.003F, 0.061F),
                                                                       new Vector3(274.4412F, 180F, 180F),
                                                                       new Vector3(0.102F, 0.102F, 0.102F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LaserTurbine, "DisplayLaserTurbine",
                                                                       "UpperArmR",
                                                                       new Vector3(-0.046F, 0.366F, 0.039F),
                                                                       new Vector3(349.8132F, 331.6221F, 93.57278F),
                                                                       new Vector3(0.462F, 0.462F, 0.462F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LightningStrikeOnHit, "DisplayChargedPerforator",
                                                                       "Chest",
                                                                       new Vector3(-0.101F, 0.23F, -0.201F),
                                                                       new Vector3(280.2537F, 303.8771F, 270F),
                                                                       new Vector3(1.362F, 1.362F, 1.362F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarDagger, "DisplayLunarDagger",
                                                                       "LowerArmL",
                                                                       new Vector3(0.013F, 0.609F, -0.009F),
                                                                       new Vector3(343.0934F, 176.5319F, 281.7719F),
                                                                       new Vector3(0.381F, 0.393F, 0.381F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarPrimaryReplacement, "DisplayBirdEye",
                                                                       "Head",
                                                                       new Vector3(0F, 0.126F, 0F),
                                                                       new Vector3(0F, 180F, 180F),
                                                                       new Vector3(1.032F, 1.032F, 1.032F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarSecondaryReplacement, "DisplayBirdClaw",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.557F, 0F),
                                                                       new Vector3(0F, 277.3215F, 29.31899F),
                                                                       new Vector3(0.427F, 0.427F, 0.427F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarSpecialReplacement, "DisplayBirdHeart",
                                                                       "Root",
                                                                       new Vector3(0.505F, 1.944F, -0.351F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.15153F, 0.15153F, 0.15153F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarTrinket, "DisplayBeads",
                                                                       "Chest",
                                                                       new Vector3(0.006F, 0.164F, -0.229F),
                                                                       new Vector3(0F, 0F, 96.99689F),
                                                                       new Vector3(1.6F, 1.6F, 1.6F)));
            //hello
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarUtilityReplacement, "DisplayBirdFoot",
                                                                       "CalfR",
                                                                       new Vector3(-0.014F, 0.117F, -0.097F),
                                                                       new Vector3(357.8506F, 98.42979F, 271.0889F),
                                                                       new Vector3(0.899F, 0.899F, 0.899F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Medkit, "DisplayMedkit",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.062F, -0.161F),
                                                                       new Vector3(270F, 180F, 0F),
                                                                       new Vector3(0.824F, 0.824F, 0.824F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Missile, "DisplayMissileLauncher",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.131F, -0.426F),
                                                                       new Vector3(283.581F, 180F, 180F),
                                                                       new Vector3(0.097F, 0.097F, 0.097F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MissileVoid, "DisplayMissileLauncherVoid",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.131F, -0.442F),
                                                                       new Vector3(286.235F, 180F, 180F),
                                                                       new Vector3(0.103F, 0.103F, 0.103F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.MonstersOnShrineUse, "DisplayMonstersOnShrineUse",
                                                                       "Spine",
                                                                       new Vector3(0.038F, 0.096F, -0.18F),
                                                                       new Vector3(54.70983F, 90F, 0F),
                                                                       new Vector3(0.105F, 0.105F, 0.105F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Mushroom, "DisplayMushroom",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.342F, -0.088F),
                                                                       new Vector3(316.2383F, 0F, 0F),
                                                                       new Vector3(0.156F, 0.156F, 0.156F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MushroomVoid, "DisplayMushroomVoid",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.345F, -0.096F),
                                                                       new Vector3(313.4806F, 0F, 0F),
                                                                       new Vector3(0.107F, 0.107F, 0.107F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.NearbyDamageBonus, "DisplayDiamond",
                                                                       "LowerArmL",
                                                                       new Vector3(0.078F, 0.43F, -0.069F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.125F, 0.125F, 0.125F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.NovaOnHeal,
                ItemDisplays.CreateDisplayRule("DisplayDevilHorns",
                                               "Head",
                                                                       new Vector3(0F, 0.181F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.891F, 0.891F, -0.921F)),
                ItemDisplays.CreateDisplayRule("DisplayDevilHorns",
                                               "Head",
                                                                       new Vector3(0F, 0.181F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(-0.891F, 0.891F, -0.921F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.NovaOnLowHealth, "DisplayJellyGuts",
                                                                       "Head",
                                                                       new Vector3(-0.006F, 0.05F, -0.183F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.137F, 0.137F, 0.137F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ParentEgg, "DisplayParentEgg",
                                                                       "Chest",
                                                                       new Vector3(0.063F, 0.01F, -0.252F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.085F, 0.085F, 0.085F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Pearl, "DisplayPearl",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.304F, 0F),
                                                                       new Vector3(270F, 0.00001F, 0F),
                                                                       new Vector3(0.123F, 0.123F, 0.123F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.PersonalShield, "DisplayShieldGenerator",
                                                                       "LowerArmR",
                                                                       new Vector3(0F, 0.367F, 0.047F),
                                                                       new Vector3(90F, 180F, 0F),
                                                                       new Vector3(0.2F, 0.2F, 0.2F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Phasing, "DisplayStealthkit",
                                                                       "Spine",
                                                                       new Vector3(0F, 0F, 0.121F),
                                                                       new Vector3(270F, 0.00001F, 0F),
                                                                       new Vector3(0.454F, 0.483F, 0.483F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Plant, "DisplayInterstellarDeskPlant",
                                                                       "UpperArmL",
                                                                       new Vector3(-0.006F, 0.463F, 0.079F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.095F, 0.094F, 0.094F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.RandomDamageZone, "DisplayRandomDamageZone",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.23F, -0.219F),
                                                                       new Vector3(355.1876F, 0F, 0F),
                                                                       new Vector3(0.12F, 0.156F, 0.156F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.RepeatHeal, "DisplayCorpseFlower",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.2F, -0.128F),
                                                                       new Vector3(279.8827F, 0F, 0F),
                                                                       new Vector3(0.653F, 0.653F, 0.653F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SecondarySkillMagazine, "DisplayDoubleMag",
                                                                       "ThighL",
                                                                       new Vector3(-0.11F, 0.201F, 0.028F),
                                                                       new Vector3(32.78108F, 0F, 0F),
                                                                       new Vector3(0.092F, 0.075F, 0.095F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Seed, "DisplaySeed",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.094F, -0.112F),
                                                                       new Vector3(321.2692F, 275.33F, 36.64926F),
                                                                       new Vector3(0.05F, 0.05F, 0.05F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.ShieldOnly,
                ItemDisplays.CreateDisplayRule("DisplayShieldBug",
                                               "Head",
                                                                       new Vector3(-0.049F, 0.156F, -0.146F),
                                                                       new Vector3(345.8107F, 93.77663F, 47.13652F),
                                                                       new Vector3(0.428F, -0.428F, 0.428F)),
                ItemDisplays.CreateDisplayRule("DisplayShieldBug",
                                               "Head",
                                                                       new Vector3(0.032F, 0.148F, -0.165F),
                                                                       new Vector3(4.33289F, 82.82901F, 41.46194F),
                                                                       new Vector3(0.428F, -0.428F, -0.428F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ShinyPearl, "DisplayShinyPearl",
                                                                       "LowerArmL",
                                                                       new Vector3(-0.055F, 0.408F, 0.021F), 
                                                                       new Vector3(278.2202F, 291.1136F, 78.58687F),
                                                                       new Vector3(0.102F, 0.102F, 0.102F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.ShockNearby,
                ItemDisplays.CreateDisplayRule("DisplayTeslaCoil",
                                               "Chest",
                                                                       new Vector3(0F, 0.171F, -0.134F),
                                                                       new Vector3(297.7337F, 0F, 0F),
                                                                       new Vector3(0.773F, 0.701F, 0.773F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.None)
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SiphonOnLowHealth, "DisplaySiphonOnLowHealth",
                                                                       "ThighL",
                                                                       new Vector3(-0.077F, 0.15F, 0.065F),
                                                                       new Vector3(350.1686F, 126.6686F, 187.4797F),
                                                                       new Vector3(0.102F, 0.102F, 0.103F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SlowOnHit, "DisplayBauble",
                                                                       "UpperArmR",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(9.91723F, 280.3184F, 131.0858F),
                                                                       new Vector3(-0.372F, -0.372F, -0.372F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.SlowOnHitVoid, "DisplayBaubleVoid",
                                                                       "Chest",
                                                                       new Vector3(-0.231F, -0.054F, 0.008F),
                                                                       new Vector3(34.56911F, 80.53241F, 297.2141F),
                                                                       new Vector3(0.459F, 0.459F, 0.459F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintArmor, "DisplayBuckler",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.176F, 0.012F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.201F, 0.201F, 0.212F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintBonus, "DisplaySoda",
                                                                       "ThighL",
                                                                       new Vector3(-0.055F, 0.033F, 0.05F),
                                                                       new Vector3(72.51923F, 89.33367F, 89.30141F),
                                                                       new Vector3(0.241F, 0.241F, 0.241F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintOutOfCombat, "DisplayWhip",
                                                                       "ThighR",
                                                                       new Vector3(0.109F, 0.17F, 0F),
                                                                       new Vector3(0F, 0F, 166.9113F),
                                                                       new Vector3(0.471F, 0.471F, 0.471F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintWisp, "DisplayBrokenMask",
                                                                       "Head",
                                                                       new Vector3(-0.157F, 0.188F, 0F),
                                                                       new Vector3(345.7309F, 270F, 21.39397F),
                                                                       new Vector3(0.329F, 0.28F, 0.28F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Squid, "DisplaySquidTurret",
                                                                "Chest",
                                                                       new Vector3(-0.141F, 0.167F, -0.07F),
                                                                       new Vector3(293.5349F, 44.28252F, 359.5478F),
                                                                       new Vector3(0.065F, 0.065F, 0.065F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.StickyBomb, "DisplayStickyBomb",
                                                                       "ThighR",
                                                                       new Vector3(0.1F, 0.194F, 0.082F),
                                                                       new Vector3(72.96555F, 0F, 0F),
                                                                       new Vector3(0.3F, 0.3F, 0.3F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.StunChanceOnHit, "DisplayStunGrenade",
                                                                       "Spine",
                                                                       new Vector3(0.146F, 0.067F, -0.005F),
                                                                       new Vector3(277.1569F, 122.3802F, 145.4737F),
                                                                       new Vector3(0.568F, 0.568F, 0.568F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Syringe, "DisplaySyringeCluster",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.04F, -0.074F),
                                                                       new Vector3(298.1592F, 180F, 180F),
                                                                       new Vector3(0.196F, 0.196F, 0.196F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Talisman, "DisplayTalisman",
                                                                       "Root",
                                                                       new Vector3(0.288F, 1.833F, -0.813F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.71215F, 0.71215F, 0.71215F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TPHealingNova, "DisplayGlowFlower",
                                                                       "Head",
                                                                       new Vector3(0.111F, 0.25F, -0.08F),
                                                                       new Vector3(344.2946F, 125.722F, 200.6264F),
                                                                       new Vector3(0.53F, 0.53F, 0.53F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Thorns, "DisplayRazorwireLeft",
                                                                "UpperArmL",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.77F, 0.77F, 0.77F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TitanGoldDuringTP, "DisplayGoldHeart",
                                                                       "UpperArmL",
                                                                       new Vector3(0.058F, 0.443F, 0.055F),
                                                                       new Vector3(0F, 0F, 125.2354F),
                                                                       new Vector3(0.291F, 0.291F, 0.291F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Tooth,
                ItemDisplays.CreateDisplayRule("DisplayToothMeshLarge",
                                               "Chest",
                                                                       new Vector3(0F, 0.176F, 0.194F),
                                                                       new Vector3(0F, 180F, 0F),
                                                                       new Vector3(4.595F, 4.595F, 4.595F)),
                ItemDisplays.CreateDisplayRule("DisplayToothMeshSmall1",
                                               "Chest",
                                                                       new Vector3(0.09F, 0.181F, 0.187F),
                                                                       new Vector3(355.8568F, 31.64545F, 20.10809F),
                                                                       new Vector3(2.583F, 2.583F, 2.583F)),
                ItemDisplays.CreateDisplayRule("DisplayToothMeshSmall2",
                                               "Chest",
                                                                       new Vector3(0.148F, 0.229F, 0.157F),
                                                                       new Vector3(333.1917F, 14.827F, 39.42159F),
                                                                       new Vector3(2.395F, 2.395F, 2.395F)),
                ItemDisplays.CreateDisplayRule("DisplayToothMeshSmall1",
                                               "Chest",
                                                                       new Vector3(-0.092F, 0.19F, 0.194F),
                                                                       new Vector3(354.2122F, 340.7911F, 346.9413F),
                                                                       new Vector3(2.682F, 2.682F, 2.682F)),
                ItemDisplays.CreateDisplayRule("DisplayToothMeshSmall2",
                                               "Chest",
                                                                       new Vector3(-0.139F, 0.227F, 0.139F),
                                                                       new Vector3(324.9079F, 348.7476F, 320.2073F),
                                                                       new Vector3(2.395F, 2.395F, 2.395F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TreasureCache, "DisplayKey",
                                                                       "ThighR",
                                                                       new Vector3(0.083F, 0.073F, 0F),
                                                                       new Vector3(13.68084F, 0.15543F, 265.412F),
                                                                       new Vector3(1.802F, 1.802F, 1.802F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.TreasureCacheVoid, "DisplayKeyVoid",
                                                                       "ThighR",
                                                                       new Vector3(0.096F, 0F, 0F),
                                                                       new Vector3(0F, 0F, 270F),
                                                                       new Vector3(1.333F, 1.333F, 1.333F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.UtilitySkillMagazine,
                ItemDisplays.CreateDisplayRule("DisplayAfterburnerShoulderRing",
                                               "UpperArmR",
                                                                       new Vector3(0F, 0.517F, 0F),
                                                                       new Vector3(0F, 0F, 270F),
                                                                       new Vector3(0.474F, 0.474F, 0.474F)),
                ItemDisplays.CreateDisplayRule("DisplayAfterburnerShoulderRing",
                                               "UpperArmL",
                                                                       new Vector3(0F, 0.503F, 0F),
                                                                       new Vector3(0F, 0F, 90F),
                                                                       new Vector3(0.474F, 0.474F, 0.474F))
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.WarCryOnMultiKill, "DisplayPauldron",
                                                                       "UpperArmL",
                                                                       new Vector3(-0.028F, -0.012F, 0.065F),
                                                                       new Vector3(79.76083F, 180.8482F, 203.4562F),
                                                                       new Vector3(0.787F, 0.787F, 0.787F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.WardOnLevel, "DisplayWarbanner",
                                                                       "Chest",
                                                                       new Vector3(-0.002F, 0.158F, -0.193F),
                                                                       new Vector3(349.2031F, 196.4238F, 356.8394F),
                                                                       new Vector3(0.64F, 0.64F, 0.64F)));
            #endregion items

            #region quips
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.BFG, "DisplayBFG",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.087F, -0.093F),
                                                                       new Vector3(276.9176F, 180F, 180F),
                                                                       new Vector3(0.425F, 0.425F, 0.425F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Blackhole, "DisplayGravCube",
                                                                       "Root",
                                                                       new Vector3(0F, 2.669F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.97127F, 0.97127F, 0.97127F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Cleanse, "DisplayWaterPack",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.079F, 0.154F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.095F, 0.095F, 0.095F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CommandMissile, "DisplayMissileRack",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.06F, -0.091F),
                                                                       new Vector3(71.88335F, 0.00001F, 180F),
                                                                       new Vector3(0.502F, 0.502F, 0.502F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.BurnNearby, "DisplayPotion",
                                                                       "Chest",
                                                                       new Vector3(0.032F, 0.072F, -0.18F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.039F, 0.039F, 0.039F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CrippleWard, "DisplayEffigy",
                                                                       "Chest",
                                                                       new Vector3(-0.061F, -0.021F, -0.26F),
                                                                       new Vector3(0F, 0F, 341.444F),
                                                                       new Vector3(1.043F, 1.043F, 1.043F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CritOnUse, "DisplayNeuralImplant",
                                                                       "Head",
                                                                       new Vector3(0F, 0.37F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.361F, 0.311F, 0.279F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.DeathProjectile, "DisplayDeathProjectile",
                                                                       "Chest",
                                                                       new Vector3(0.08F, 0.416F, -0.292F),
                                                                       new Vector3(320.0211F, 159.6173F, 300.0403F),
                                                                       new Vector3(0.131F, 0.131F, 0.131F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.DroneBackup, "DisplayRadio",
                                                                       "Chest",
                                                                       new Vector3(0.02F, 0.241F, -0.204F),
                                                                       new Vector3(4.74331F, 237.0253F, 348.9089F),
                                                                       new Vector3(0.507F, 0.507F, 0.507F)));
            //E for Affix
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Equipment.AffixRed,
                ItemDisplays.CreateDisplayRule("DisplayEliteHorn",
                                               "Head",
                                                                       new Vector3(0.189F, 0.208F, -0.04F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.109F, 0.109F, 0.109F)),
                ItemDisplays.CreateDisplayRule("DisplayEliteHorn",
                                               "Head",
                                                                       new Vector3(-0.176F, 0.163F, -0.058F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(-0.109F, 0.109F, 0.109F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixHaunted, "DisplayEliteStealthCrown",
                                                                       "Head",
                                                                       new Vector3(0F, 0.164F, -0.137F),
                                                                       new Vector3(359.5518F, 0F, 0F),
                                                                       new Vector3(-0.061F, -0.055F, -0.055F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixWhite, "DisplayEliteIceCrown",
                                                                       "Head",
                                                                       new Vector3(0F, 0.131F, -0.191F),
                                                                       new Vector3(1.07661F, 180F, 180F),
                                                                       new Vector3(0.033F, 0.033F, 0.033F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Equipment.AffixBlue,
                ItemDisplays.CreateDisplayRule("DisplayEliteRhinoHorn",
                                               "Head",
                                                                       new Vector3(0F, 0.093F, -0.196F),
                                                                       new Vector3(26.90219F, 180F, 180F),
                                                                       new Vector3(0.305F, 0.31F, 0.262F)),
                ItemDisplays.CreateDisplayRule("DisplayEliteRhinoHorn",
                                               "Head",
                                                                       new Vector3(0F, 0.206F, -0.19F),
                                                                       new Vector3(342.8231F, 180F, 180F),
                                                                       new Vector3(-0.199F, 0.202F, 0.159F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixLunar, "DisplayEliteLunar,Eye",
                                                                       "Head",
                                                                       new Vector3(0F, 0.347F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.265F, 0.246F, 0.265F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixPoison, "DisplayEliteUrchinCrown",
                                                                       "Head",
                                                                       new Vector3(0F, 0.183F, -0.16F),
                                                                       new Vector3(349.3365F, 180F, 270F),
                                                                       new Vector3(0.054F, 0.054F, 0.054F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.FireBallDash, "DisplayEgg",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.197F, -0.264F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.472F, 0.472F, 0.472F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Fruit, "DisplayFruit",
                                                                       "Chest",
                                                                       new Vector3(-0.19F, 0.068F, 0.252F),
                                                                       new Vector3(49.89084F, 193.1927F, 55.48783F),
                                                                       new Vector3(0.335F, 0.335F, 0.346F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.GainArmor, "DisplayElephantFigure",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.321F, -0.19F),
                                                                       new Vector3(287.2275F, 0F, 0F),
                                                                       new Vector3(1.032F, 1.032F, 1.032F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Gateway, "DisplayVase",
                                                                       "Chest",
                                                                       new Vector3(-0.047F, 0.363F, -0.209F),
                                                                       new Vector3(348.9436F, 352.6793F, 33.81813F),
                                                                       new Vector3(0.275F, 0.275F, 0.275F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.GoldGat, "DisplayGoldGat",
                                                                       "Neck",
                                                                       new Vector3(0F, -0.178F, -0.197F),
                                                                       new Vector3(0F, 90F, 212.5969F),
                                                                       new Vector3(0.133F, 0.133F, 0.133F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Jetpack, "DisplayBugWings",
                                                                       "Chest",
                                                                       new Vector3(0F, -0.078F, -0.085F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.206F, 0.206F, 0.206F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.LifestealOnHit, "DisplayLifestealOnHit",
                                                                       "Neck",
                                                                       new Vector3(-0.02F, 0.056F, -0.233F),
                                                                       new Vector3(323.6458F, 1.34282F, 359.2039F),
                                                                       new Vector3(0.101F, 0.101F, 0.101F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Equipment.Lightning,
                ItemDisplays.CreateDisplayRule("DisplayLightningArmCustom",
                                               "UpperArmR",
                                                                       new Vector3(0.043F, 0.273F, 0.092F),
                                                                       new Vector3(292.1966F, 76.24585F, 180F),
                                                                       new Vector3(0.831F, 0.831F, 0.831F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.RightArm)
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Meteor, "DisplayMeteor",
                                                                       "Root",
                                                                       new Vector3(0F, 2.11F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.76542F, 0.76645F, 0.76645F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.QuestVolatileBattery, "DisplayBatteryArray",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.257F, -0.295F),
                                                                       new Vector3(341.7507F, 180F, 180F),
                                                                       new Vector3(0.397F, 0.397F, 0.397F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Recycle, "DisplayRecycler",
                                                                       "Chest",
                                                                       new Vector3(0.057F, 0.237F, -0.17F),
                                                                       new Vector3(0F, 90F, 6.79936F),
                                                                       new Vector3(0.085F, 0.085F, 0.085F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Saw, "DisplaySawmerangFollower",
                                                                       "Root",
                                                                       new Vector3(-0.003F, 2.201F, -0.039F),
                                                                       new Vector3(271.0232F, 185.0242F, 175.0119F),
                                                                       new Vector3(0.141F, 0.141F, 0.141F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Scanner, "DisplayScanner",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.07F, -0.045F),
                                                                       new Vector3(11.62957F, 180F, 180F),
                                                                       new Vector3(0.178F, 0.178F, 0.178F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.TeamWarCry, "DisplayTeamWarCry",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.066F, -0.12F),
                                                                       new Vector3(8.42614F, 180F, 180F),
                                                                       new Vector3(0.104F, 0.104F, 0.104F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Tonic, "DisplayTonic",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.113F, 0.183F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.269F, 0.269F, 0.269F)));

            #endregion quips

            #region dlc1

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PrimarySkillShuriken, "DisplayShuriken",
                                                                       "LowerArmR",
                                                                       new Vector3(0F, 0.438F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.719F, 0.719F, 0.719F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.OutOfCombatArmor, "DisplayOddlyShapedOpal",
                                                                       "LowerArmR",
                                                                       new Vector3(0F, 0.342F, 0.058F),
                                                                       new Vector3(3.71043F, 0F, 0F),
                                                                       new Vector3(0.449F, 0.449F, 0.453F)));
            //head
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(DLC1Content.Items.LunarSun,
                ItemDisplays.CreateDisplayRule("DisplaySunHead",
                                               "Head",
                                                                       new Vector3(0F, 0.151F, 0.003F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(1.302F, 1.305F, 1.305F)),
                ItemDisplays.CreateDisplayRule("DisplaySunHeadNeck",
                                               "Head",
                                                                       new Vector3(-0.003F, 0.004F, 0.067F),
                                                                       new Vector3(8.72353F, 128.8626F, 349.3409F),
                                                                       new Vector3(1.681F, 0.903F, 1.885F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.Head)));
            //size
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MinorConstructOnKill, "DisplayDefenseNucleus",
                                                                       "Root",
                                                                       new Vector3(-0.374F, 2.148F, -0.536F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.29386F, 0.29386F, 0.29386F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HalfAttackSpeedHalfCooldowns, "DisplayLunarShoulderNature",
                                                                       "Head",
                                                                       new Vector3(0F, 0.25F, 0.157F),
                                                                       new Vector3(0F, 90F, 36.93161F),
                                                                       new Vector3(0.725F, 0.725F, 0.517F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HalfSpeedDoubleHealth, "DisplayLunarShoulderStone",
                                                                       "Head",
                                                                       new Vector3(0F, 0.184F, -0.127F),
                                                                       new Vector3(0F, 270F, 22.2875F),
                                                                       new Vector3(0.811F, 0.811F, 1.201F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.AttackSpeedAndMoveSpeed, "DisplayCoffee",
                                                                       "Hips",
                                                                       new Vector3(0.086F, 0.036F, -0.133F),
                                                                       new Vector3(335.4913F, 40.24231F, 355.9257F),
                                                                       new Vector3(0.235F, 0.235F, 0.235F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.GoldOnHurt, "DisplayRollOfPennies",
                                                                       "ThighL",
                                                                       new Vector3(0F, 0.365F, -0.053F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.983F, 0.983F, 0.983F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.FragileDamageBonus, "DisplayDelicateWatch",
                                                                       "LowerArmR",
                                                                       new Vector3(0F, 0.395F, 0.021F),
                                                                       new Vector3(85.66948F, 180F, 180F),
                                                                       new Vector3(0.456F, 0.774F, 0.466F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ImmuneToDebuff, "DisplayRainCoatBelt",
                                                                       "Hips",
                                                                       new Vector3(0F, 0.088F, 0F),
                                                                       new Vector3(342.9062F, 0F, 0F),
                                                                       new Vector3(0.802F, 0.694F, 0.694F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RandomEquipmentTrigger, "DisplayBottledChaos",
                                                                       "Spine",
                                                                       new Vector3(0F, 0F, -0.153F),
                                                                       new Vector3(355.1696F, 0F, 0F),
                                                                       new Vector3(0.215F, 0.215F, 0.215F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.StrengthenBurn, "DisplayGasTank",
                                                                       "ThighL",
                                                                       new Vector3(-0.056F, 0.338F, 0.094F),
                                                                       new Vector3(0F, 0F, 180.2308F),
                                                                       new Vector3(0.139F, 0.139F, 0.139F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.VoidMegaCrabItem, "DisplayMegaCrabItem",
                                                                       "Head",
                                                                       new Vector3(0F, 0.2F, -0.203F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.145F, 0.145F, 0.145F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RegeneratingScrap, "DisplayRegeneratingScrap",
                                                                       "Neck",
                                                                       new Vector3(-0.054F, 0.055F, -0.088F),
                                                                       new Vector3(343.7381F, 42.33283F, 252.4204F),
                                                                       new Vector3(0.225F, 0.225F, 0.225F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PermanentDebuffOnHit, "DisplayScorpion",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.254F, -0.115F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.963F, 0.963F, 0.963F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CritDamage, "DisplayLaserSight",
                                                                       "Head",
                                                                       new Vector3(0.153F, 0.155F, 0F),
                                                                       new Vector3(0F, 0F, 270F),
                                                                       new Vector3(0.089F, 0.089F, 0.089F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.FreeChest, "DisplayShippingRequestForm",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.271F, -0.194F),
                                                                       new Vector3(270.0949F, 0F, 0F),
                                                                       new Vector3(1.087F, 1.09F, 1.087F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoveSpeedOnKill, "DisplayGrappleHook",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.625F, 0F),
                                                                       new Vector3(0F, 180F, 180F),
                                                                       new Vector3(0.219F, 0.219F, 0.219F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RandomlyLunar, "DisplayDomino",
                                                                       "Root",
                                                                       new Vector3(-0.944F, 1.324F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(1.43943F, 1.43943F, 1.43943F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HealingPotion, "DisplayHealingPotion",
                                                                       "ThighR",
                                                                       new Vector3(0.118F, 0.101F, -0.004F),
                                                                       new Vector3(327.7106F, 17.98712F, 148.7098F),
                                                                       new Vector3(0.063F, 0.063F, 0.063F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoreMissile, "DisplayICBM",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.071F, -0.186F),
                                                                       new Vector3(0.97053F, 0F, 0F),
                                                                       new Vector3(0.18F, 0.18F, 0.18F)));

            //quips
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(DLC1Content.Equipment.BossHunter,
                ItemDisplays.CreateDisplayRule("DisplayTricornGhost",
                                               "Head",
                                                                       new Vector3(0F, 0.132F, -0.228F),
                                                                       new Vector3(292.5309F, 0F, 0F),
                                                                       new Vector3(0.623F, 0.623F, 0.623F)),
                ItemDisplays.CreateDisplayRule("DisplayBlunderbuss",
                                               "Root",
                                                                       new Vector3(0F, 2.169F, 0.137F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.53345F, 0.53345F, 0.53345F))));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.BossHunterConsumed, "DisplayTricornUsed",
                                                                       "Head",
                                                                       new Vector3(0F, 0.143F, -0.224F),
                                                                       new Vector3(294.8055F, 0F, 0F),
                                                                       new Vector3(0.757F, 0.757F, 0.757F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.EliteVoidEquipment, "DisplayAffixVoid",
                                                                       "Head",
                                                                       new Vector3(0F, 0.176F, 0.034F),
                                                                       new Vector3(353.7043F, 0F, 0F),
                                                                       new Vector3(0.337F, 0.337F, 0.337F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.GummyClone, "DisplayGummyClone",
                                                                       "Chest",
                                                                       new Vector3(0.028F, 0.266F, -0.163F),
                                                                       new Vector3(19.72359F, 0F, 0F),
                                                                       new Vector3(0.294F, 0.294F, 0.294F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule("IrradiatingLaser", "DisplayIrradiatingLaser",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.109F, -0.054F),
                                                                       new Vector3(321.2852F, 180F, 180F),
                                                                       new Vector3(0.169F, 0.169F, 0.169F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.LunarPortalOnUse, "DisplayLunarPortalOnUse",
                                                                       "Root",
                                                                       new Vector3(0F, 2.291F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.85193F, 0.85193F, 0.85193F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.Molotov, "DisplayMolotov",
                                                                       "Neck",
                                                                       new Vector3(0F, -0.025F, -0.108F),
                                                                       new Vector3(336.3658F, 0F, 0F),
                                                                       new Vector3(0.302F, 0.302F, 0.302F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.MultiShopCard, "DisplayExecutiveCard",
                                                                       "Chest",
                                                                       new Vector3(0.097F, 0.156F, -0.265F),
                                                                       new Vector3(274.4852F, 180F, 180F),
                                                                       new Vector3(1.217F, 1.243F, 1.282F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.VendingMachine, "DisplayVendingMachine",
                                                                       "Neck",
                                                                       new Vector3(0F, -0.098F, -0.283F),
                                                                       new Vector3(286.4358F, 180F, 180F),
                                                                       new Vector3(0.346F, 0.346F, 0.346F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Elites.Earth.eliteEquipmentDef, "DisplayEliteMendingAntlers",
                                                                       "Head",
                                                                       new Vector3(0F, 0.195F, -0.082F),
                                                                       new Vector3(284.1421F, 0F, 0F),
                                                                       new Vector3(0.988F, 0.988F, 0.988F)));

            #endregion

            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("com.KomradeSpectre.Aetherium"))
            {
                SetAetheriumDisplayRules(itemDisplayRules);
            }

        }

        #region aeth
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private void SetAetheriumDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.AccursedPotion.instance.ItemDef,
                                                                       Aetherium.Items.AccursedPotion.ItemBodyModelPrefab,
                                                                       "Hips",
                                                                       new Vector3(-0.12946F, 0.05655F, -0.09089F),
                                                                       new Vector3(352.1309F, 2.07741F, 0.27456F),
                                                                       new Vector3(0.06197F, 0.06197F, 0.06197F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.AlienMagnet.instance.ItemDef,
                                                                       Aetherium.Items.AlienMagnet.ItemBodyModelPrefab,
                                                                       "Root",
                                                                       new Vector3(-0.85034F, 1.83867F, -0.0771F),
                                                                       new Vector3(351.4943F, 0F, 0F),
                                                                       new Vector3(0.10931F, 0.10931F, 0.10931F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.BlasterSword.instance.ItemDef,
                                                                       Aetherium.Items.BlasterSword.ItemBodyModelPrefab,
                                                                       "LowerArmL",
                                                                       new Vector3(-0.03489F, 0.80027F, 0.04625F),
                                                                       new Vector3(0F, 316.0607F, 180F),
                                                                       new Vector3(0.05965F, 0.05965F, 0.05965F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.BloodthirstyShield.instance.ItemDef,
                                                                       Aetherium.Items.BloodthirstyShield.ItemBodyModelPrefab,
                                                                       "LowerArmR",
                                                                       new Vector3(0.00222F, 0.41343F, 0.08069F),
                                                                       new Vector3(1.48965F, 353.3753F, 10.35441F),
                                                                       new Vector3(0.18505F, 0.18505F, 0.18505F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.EngineersToolbelt.instance.ItemDef,
                                                                       Aetherium.Items.EngineersToolbelt.ItemBodyModelPrefab,
                                                                       "Hips",
                                                                       new Vector3(0F, 0.0545F, 0.0031F),
                                                                       new Vector3(357.8437F, 0F, 0F),
                                                                       new Vector3(0.17904F, 0.12389F, 0.1273F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.FeatheredPlume.instance.ItemDef,
                                                                       Aetherium.Items.FeatheredPlume.ItemBodyModelPrefab,
                                                                       "Chest",
                                                                       new Vector3(-0.12944F, 0.30726F, -0.16674F),
                                                                       new Vector3(305.0129F, 82.94401F, 337.0811F),
                                                                       new Vector3(0.25964F, 0.18505F, 0.23623F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.Voidheart.instance.ItemDef,
                                                                       Aetherium.Items.Voidheart.ItemBodyModelPrefab,
                                                                       "Chest",
                                                                       new Vector3(-0.02262F, 0.1078F, 0.18193F),
                                                                       new Vector3(15.57688F, 341.2918F, 353.7321F),
                                                                       new Vector3(0.09114F, 0.09114F, 0.09114F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.InspiringDrone.instance.ItemDef,
                                                                       Aetherium.Items.InspiringDrone.ItemBodyModelPrefab,
                                                                       "Root",
                                                                       new Vector3(0.52308F, 2.46091F, -0.01632F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.16571F, 0.16571F, 0.16571F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.NailBomb.instance.ItemDef,
                                                                       Aetherium.Items.NailBomb.ItemBodyModelPrefab,
                                                                       "Neck",
                                                                       new Vector3(0F, 0.0846F, -0.1199F),
                                                                       new Vector3(287.8274F, 180F, 180F),
                                                                       new Vector3(0.09878F, 0.09878F, 0.09878F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.SharkTeeth.instance.ItemDef,
                                                                       Aetherium.Items.SharkTeeth.ItemBodyModelPrefab,
                                                                       "Head",
                                                                       new Vector3(0F, 0.28772F, -0.01749F),
                                                                       new Vector3(291.1072F, -0.00005F, 180F),
                                                                       new Vector3(0.19223F, 0.19466F, 0.14597F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.ShieldingCore.instance.ItemDef,
                                                                       Aetherium.Items.ShieldingCore.ItemBodyModelPrefab,
                                                                       "Chest",
                                                                       new Vector3(0.10856F, 0.21605F, -0.10656F),
                                                                       new Vector3(36.81234F, 222.0987F, 60.4989F),
                                                                       new Vector3(0.27672F, 0.27672F, 0.27672F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.UnstableDesign.instance.ItemDef,
                                                                       Aetherium.Items.UnstableDesign.ItemBodyModelPrefab,
                                                                       "Chest",
                                                                       new Vector3(0.00771F, -0.03459F, -0.19881F),
                                                                       new Vector3(359.6312F, 44.63949F, 0.45308F),
                                                                       new Vector3(0.88639F, 0.88639F, 0.88639F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.WeightedAnklet.instance.ItemDef,
                                                                       Aetherium.Items.WeightedAnklet.ItemBodyModelPrefab,
                                                                       "CalfL",
                                                                       new Vector3(0.0045F, 0.21071F, 0.01637F),
                                                                       new Vector3(3.47227F, 0F, 7.27702F),
                                                                       new Vector3(0.20588F, 0.15922F, 0.18731F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(Aetherium.Items.WitchesRing.instance.ItemDef,
                ItemDisplays.CreateDisplayRule(Aetherium.Items.WitchesRing.ItemBodyModelPrefab,
                                               "LowerArmL",
                                                                       new Vector3(0.00313F, 0.39397F, 0.00084F),
                                                                       new Vector3(4.55092F, 359.2983F, 354.1099F),
                                                                       new Vector3(0.236F, 0.2564F, 0.236F)),
                ItemDisplays.CreateDisplayRule(Aetherium.Items.WitchesRing.CircleBodyModelPrefab,
                                               "LowerArmL",
                                                                       new Vector3(0.00625F, 0.38271F, 0.0752F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.18255F, 0.18255F, 0.01054F))
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.ZenithAccelerator.instance.ItemDef,
                                                                       Aetherium.Items.ZenithAccelerator.ItemBodyModelPrefab,
                                                                       "Chest",
                                                                       new Vector3(0.00222F, 0.256F, -0.25856F),
                                                                       new Vector3(295.6192F, 3.67244F, 350.2317F),
                                                                       new Vector3(0.1688F, 0.1688F, 0.1688F)));
        }
        #endregion aeth
    }
}
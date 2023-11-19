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
                                                                       new Vector3(0.00153F, 0.00152F, -0.00382F),
                                                                       new Vector3(325.9806F, 151.966F, 303.6272F),
                                                                       new Vector3(0.00858F, 0.00858F, 0.00858F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ArmorPlate, "DisplayRepulsionArmorPlate",
                                                                       "UpperArmR",
                                                                       new Vector3(0.00026F, 0.0013F, 0.00056F),
                                                                       new Vector3(78.74371F, 270F, 89.99997F),
                                                                       new Vector3(0.00405F, 0.00435F, 0.00349F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.ArmorReductionOnHit,
                ItemDisplays.CreateDisplayRule("DisplayWarhammer",
                                               "Spine",
                                                                       new Vector3(0.00159F, 0.00126F, -0.00141F),
                                                                       new Vector3(331.8564F, 85.81026F, 91.58662F),
                                                                       new Vector3(0.00187F, 0.00187F, 0.00187F))));//hammer
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AttackSpeedOnCrit, "DisplayWolfPelt",
                                                                       "Head",
                                                                       new Vector3(0.00017F, 0.00221F, -0.00103F),
                                                                       new Vector3(288.4954F, 173.9509F, 176.0275F),
                                                                       new Vector3(0.00931F, 0.00637F, 0.00637F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AutoCastEquipment, "DisplayFossil",
                                                                       "Neck",
                                                                       new Vector3(0.001F, 0.00034F, -0.00046F),
                                                                       new Vector3(0F, 52.11967F, 337.9004F),
                                                                       new Vector3(0.00655F, 0.00655F, 0.00655F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Bandolier, "DisplayBandolier",
                                                                       "Chest",
                                                                       new Vector3(0F, -0.00017F, 0F),
                                                                       new Vector3(270F, 90F, 0F),
                                                                       new Vector3(0.00411F, 0.00489F, 0.00744F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnKill, "DisplayBrooch",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00164F, 0.00185F), 
                                                                       new Vector3(80.07201F, 0F, 0F),
                                                                       new Vector3(0.0075F, 0.00643F, 0.00643F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnOverHeal, "DisplayAegis",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.00343F, 0.00039F),
                                                                       new Vector3(90F, 180F, 0F),
                                                                       new Vector3(0.00206F, 0.00206F, 0.00206F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Bear, "DisplayBear",
                                                                       "Chest",
                                                                       new Vector3(-0.00163F, 0.00326F, -0.00203F),
                                                                       new Vector3(0F, 234.106F, 0F),
                                                                       new Vector3(0.00261F, 0.00269F, 0.00269F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.BearVoid, "DisplayBearVoid",
                                                                       "Chest",
                                                                       new Vector3(-0.00169F, 0.00289F, -0.00182F),
                                                                       new Vector3(0F, 223.9681F, 0F),
                                                                       new Vector3(0.0028F, 0.0028F, 0.0028F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BeetleGland, "DisplayBeetleGland",
                                                                       "Chest",
                                                                       new Vector3(-0.00005F, 0.00169F, -0.00227F),
                                                                       new Vector3(0F, 0F, 280.2594F),
                                                                       new Vector3(0.00118F, 0.00118F, 0.00118F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Behemoth,
                ItemDisplays.CreateDisplayRule("DisplayBehemoth",
                                               "UpperArmL",
                                                                       new Vector3(0F, 0.00163F, 0.00186F),
                                                                       new Vector3(354.609F, 0F, 0F),
                                                                       new Vector3(0.00068F, 0.00068F, 0.00068F))));

            //again, don't have to do this 
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.BleedOnHit,
                ItemDisplays.CreateDisplayRule("DisplayTriTip",
                                               "Chest",
                                                                       new Vector3(0F, 0.00219F, -0.00216F),
                                                                       new Vector3(314.135F, 180F, 180F),
                                                                       new Vector3(0.00537F, 0.00537F, 0.00636F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(DLC1Content.Items.BleedOnHitVoid,
                ItemDisplays.CreateDisplayRule("DisplayTriTipVoid",
                                               "Neck",
                                                                       new Vector3(0F, -0.00106F, -0.00068F),
                                                                       new Vector3(61.19586F, 180F, 180F),
                                                                       new Vector3(0.0044F, 0.0044F, 0.00521F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BleedOnHitAndExplode, "DisplayBleedOnHitAndExplode",
                                                                       "Spine",
                                                                       new Vector3(0F, 0F, 0.00102F),
                                                                       new Vector3(27.99068F, 0F, 0F),
                                                                       new Vector3(0.00049F, 0.00049F, 0.00049F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BonusGoldPackOnKill, "DisplayTome",
                                                                       "ThighL",
                                                                       new Vector3(-0.00074F, 0.00285F, 0.00058F),
                                                                       new Vector3(0F, 96.85566F, 0F),
                                                                       new Vector3(0.00078F, 0.00078F, 0.00078F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BossDamageBonus, "DisplayAPRound",
                                                                       "Spine",
                                                                       new Vector3(-0.00113F, -0.00006F, -0.00077F),
                                                                       new Vector3(80.79361F, 20.23979F, 162.3526F),
                                                                       new Vector3(0.007F, 0.007F, 0.007F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BounceNearby, "DisplayHook",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00354F, -0.00111F),
                                                                       new Vector3(41.59288F, 180F, 180F),
                                                                       new Vector3(-0.00397F, -0.00397F, -0.00397F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ChainLightning, "DisplayUkulele",
                                                                       "Chest",
                                                                       new Vector3(-0.00044F, 0.00222F, -0.0017F),
                                                                       new Vector3(359.3017F, 180F, 154.6813F),
                                                                       new Vector3(0.00725F, 0.00688F, 0.00699F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ChainLightningVoid, "DisplayUkuleleVoid",
                                                                       "Chest",
                                                                       new Vector3(0.00069F, 0.0018F, -0.00194F),
                                                                       new Vector3(351.1519F, 180F, 148.944F),
                                                                       new Vector3(0.00783F, 0.00744F, 0.00755F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Clover, "DisplayClover",
                                                                       "Head",
                                                                       new Vector3(0.00144F, 0.00191F, -0.00122F),
                                                                       new Vector3(286.0782F, 295.6274F, 12.20513F),
                                                                       new Vector3(0.00595F, 0.00595F, 0.00593F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CloverVoid, "DisplayCloverVoid",
                                                                       "Head",
                                                                       new Vector3(0.00116F, 0.00179F, -0.00146F),
                                                                       new Vector3(276.9178F, 237.7042F, 94.53139F),
                                                                       new Vector3(0.00659F, 0.00659F, 0.00659F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(JunkContent.Items.CooldownOnCrit,
                ItemDisplays.CreateDisplayRule("DisplaySkull",
                                               "Head",
                                                                       new Vector3(0F, 0.00189F, -0.00135F),
                                                                       new Vector3(43.48513F, 180F, 180F),
                                                                       new Vector3(0.00285F, 0.00285F, 0.00285F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.Head)
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.CritGlasses, "DisplayGlasses",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00308F, 0.00017F),
                                                                       new Vector3(270F, 0.00001F, 0F),
                                                                       new Vector3(0.00403F, 0.00305F, 0.00793F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CritGlassesVoid, "DisplayGlassesVoid",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00331F, 0.00004F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.00353F, 0.00363F, 0.00507F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Crowbar, "DisplayCrowbar",
                                                                       "Chest",
                                                                       new Vector3(-0.00056F, 0.00131F, -0.00167F),
                                                                       new Vector3(48.24174F, 90F, 0F),
                                                                       new Vector3(0.00498F, 0.00498F, 0.00498F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Dagger, "DisplayDagger",
                                                                       "Chest",
                                                                       new Vector3(0.00018F, 0.0026F, -0.00089F),
                                                                       new Vector3(287.5269F, 0.00002F, 29.03086F),
                                                                       new Vector3(0.01003F, 0.01003F, 0.01003F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.DeathMark, "DisplayDeathMark",
                                                                       "HandL",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(80.29325F, 355.1307F, 175.7849F),
                                                                       new Vector3(0.00045F, 0.00045F, 0.00045F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.EnergizedOnEquipmentUse, "DisplayWarHorn",
                                                                       "Chest",
                                                                       new Vector3(-0.00039F, 0.00072F, -0.00202F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00565F, 0.00565F, 0.00565F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.EquipmentMagazine, "DisplayBattery",
                                                                       "Hips",
                                                                       new Vector3(0.00062F, 0.00049F, -0.00133F),
                                                                       new Vector3(0F, 270F, 0F),
                                                                       new Vector3(0.00204F, 0.00204F, 0.00204F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.EquipmentMagazineVoid, "DisplayFuelCellVoid",
                                                                       "Hips",
                                                                       new Vector3(0F, 0.00059F, -0.00106F),
                                                                       new Vector3(90F, 89.99999F, 0F),
                                                                       new Vector3(0.00285F, 0.00285F, 0.00285F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExecuteLowHealthElite, "DisplayGuillotine",
                                                                       "LowerArmL",
                                                                       new Vector3(0.00004F, 0.00363F, 0.001F),
                                                                       new Vector3(42.92808F, 180.5273F, 270.7742F),
                                                                       new Vector3(0.00227F, 0.00227F, 0.00224F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExplodeOnDeath, "DisplayWilloWisp",
                                                                       "Neck",
                                                                       new Vector3(-0.00167F, 0.00047F, -0.00014F),
                                                                       new Vector3(291.8631F, 180F, 142.0484F),
                                                                       new Vector3(0.00088F, 0.00088F, 0.00088F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ExplodeOnDeathVoid, "DisplayWillowWispVoid",
                                                                       "Hips",
                                                                       new Vector3(0.00106F, 0.00068F, -0.0009F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00067F, 0.00067F, 0.00067F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExtraLife, "DisplayHippo",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00197F, 0.00225F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00289F, 0.00297F, 0.00297F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ExtraLifeVoid, "DisplayHippoVoid",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00085F, 0.00151F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00292F, 0.00301F, 0.00301F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.FallBoots,
                ItemDisplays.CreateDisplayRule("DisplayGravBoots",
                                               "CalfL",
                                                                       new Vector3(0F, 0.00426F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00251F, 0.00251F, 0.00251F)),
                ItemDisplays.CreateDisplayRule("DisplayGravBoots",
                                               "CalfR",
                                                                       new Vector3(0F, 0.0043F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00251F, 0.00251F, 0.00251F)
                )));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Feather,
                ItemDisplays.CreateDisplayRule("DisplayFeather",
                                               "Chest",
                                                                       new Vector3(0.00085F, 0.00187F, -0.00129F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(-0.00062F, 0.00037F, 0.00037F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FireballsOnHit, "DisplayFireballsOnHit",
                                                                       "Chest",
                                                                       new Vector3(0.00069F, 0.00373F, -0.0024F),
                                                                       new Vector3(336.4221F, 161.2971F, 354.7277F),
                                                                       new Vector3(0.00102F, 0.00117F, 0.00097F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FireRing, "DisplayFireRing",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.00544F, 0F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.0055F, 0.0055F, 0.0055F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.IceRing, "DisplayIceRing",
                                                                       "LowerArmR",
                                                                       new Vector3(-0.00009F, 0.0055F, -0.00002F),
                                                                       new Vector3(78.20138F, 54.06794F, 55.8657F),
                                                                       new Vector3(0.00622F, 0.00622F, 0.00622F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ElementalRingVoid, "DisplayVoidRing",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.00429F, 0F),
                                                                       new Vector3(270F, 136.8969F, 0F),
                                                                       new Vector3(0.00715F, 0.00715F, 0.00612F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Firework, "DisplayFirework",
                                                                       "Chest",
                                                                       new Vector3(-0.00179F, 0.00383F, -0.00135F),
                                                                       new Vector3(316.392F, 241.8502F, 127.8034F),
                                                                       new Vector3(0.00361F, 0.00361F, 0.00361F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FlatHealth, "DisplaySteakCurved",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00035F, -0.00198F),
                                                                       new Vector3(35.11937F, 180F, 180F),
                                                                       new Vector3(0.00175F, 0.00175F, 0.00175F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FocusConvergence, "DisplayFocusedConvergence",
                                                                       "Root",
                                                                       new Vector3(-0.00587F, 0.01951F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.05F, 0.05F, 0.05F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.GhostOnKill, "DisplayMask",
                                                                       "UpperArmL",
                                                                       new Vector3(0F, 0.0005F, 0.0004F),
                                                                       new Vector3(0F, 0F, 180F),
                                                                       new Vector3(0.00798F, 0.00798F, 0.00615F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.GoldOnHit, "DisplayBoneCrown",
                                                                       "Head",
                                                                       new Vector3(0F, -0.00051F, -0.00001F),
                                                                       new Vector3(0F, 180F, 0F),
                                                                       new Vector3(0.01759F, 0.01526F, 0.01526F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HeadHunter, "DisplaySkullCrown",
                                                                       "Head",
                                                                       new Vector3(-0.00002F, 0.00199F, 0F),
                                                                       new Vector3(359.9472F, 173.7351F, 179.5188F),
                                                                       new Vector3(0.00629F, 0.00227F, 0.00227F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HealOnCrit, "DisplayScythe",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.0048F, 0.00017F),
                                                                       new Vector3(270F, 270F, 0F),
                                                                       new Vector3(0.00246F, 0.00246F, 0.00246F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HealWhileSafe, "DisplaySnail",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.00044F, -0.00029F),
                                                                       new Vector3(290.3202F, 180F, 180F),
                                                                       new Vector3(0.00111F, 0.00111F, 0.00111F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Hoof,
                ItemDisplays.CreateDisplayRule("DisplayHoof",
                                               "CalfR",
                                                                       new Vector3(-0.00023F, 0.00353F, -0.00017F),
                                                                       new Vector3(79.93874F, 359.8341F, 341.8235F),
                                                                       new Vector3(0.00097F, 0.00092F, 0.00086F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.RightCalf)
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Icicle, "DisplayFrostRelic",
                                                                       "Root",
                                                                       new Vector3(0.00814F, 0.01618F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(1.38875F, 1.38875F, 1.38875F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.IgniteOnKill, "DisplayGasoline",
                                                                       "Spine",
                                                                       new Vector3(-0.00051F, -0.00061F, -0.00112F),
                                                                       new Vector3(276.1328F, 180.0001F, 116.3038F),
                                                                       new Vector3(0.00654F, 0.00654F, 0.00654F)));
            //hello
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.IncreaseHealing,
                ItemDisplays.CreateDisplayRule("DisplayAntler",
                                               "Head",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(353.9438F, 81.39288F, 300.5692F),
                                                                       new Vector3(0.0042F, 0.0042F, 0.0042F)),
                ItemDisplays.CreateDisplayRule("DisplayAntler",
                                               "Head",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(356.1463F, 266.133F, 47.10716F),
                                                                       new Vector3(-0.00452F, 0.0039F, 0.00394F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(JunkContent.Items.Incubator, "DisplayAncestralIncubator",
                                                                       "Chest",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(317.0807F, 0F, 0F),
                                                                       new Vector3(0.00071F, 0.00071F, 0.00071F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Infusion, "DisplayInfusion",
                                                                       "Spine",
                                                                       new Vector3(0.00098F, 0.00003F, -0.00113F),
                                                                       new Vector3(0.17003F, 142.4715F, 353.6781F),
                                                                       new Vector3(0.0057F, 0.0057F, 0.00575F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.JumpBoost, "DisplayWaxBird",
                                                                       "Head",
                                                                       new Vector3(0F, -0.00008F, 0.0024F),
                                                                       new Vector3(270.4673F, 0F, 0F),
                                                                       new Vector3(0.00701F, 0.00701F, 0.00701F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.KillEliteFrenzy, "DisplayBrainstalk",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00156F, 0.00022F),
                                                                       new Vector3(296.542F, 0F, 0F),
                                                                       new Vector3(0.00291F, 0.00412F, 0.00289F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Knurl, "DisplayKnurl",
                                                                       "Spine",
                                                                       new Vector3(0F, -0.00003F, 0.00061F),
                                                                       new Vector3(274.4412F, 180F, 180F),
                                                                       new Vector3(0.00102F, 0.00102F, 0.00102F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LaserTurbine, "DisplayLaserTurbine",
                                                                       "UpperArmR",
                                                                       new Vector3(-0.00046F, 0.00366F, 0.00039F),
                                                                       new Vector3(349.8132F, 331.6221F, 93.57278F),
                                                                       new Vector3(0.00462F, 0.00462F, 0.00462F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LightningStrikeOnHit, "DisplayChargedPerforator",
                                                                       "Chest",
                                                                       new Vector3(-0.00101F, 0.0023F, -0.00201F),
                                                                       new Vector3(280.2537F, 303.8771F, 270F),
                                                                       new Vector3(0.01362F, 0.01362F, 0.01362F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarDagger, "DisplayLunarDagger",
                                                                       "LowerArmL",
                                                                       new Vector3(0.00013F, 0.00609F, -0.00009F),
                                                                       new Vector3(343.0934F, 176.5319F, 281.7719F),
                                                                       new Vector3(0.00381F, 0.00393F, 0.00381F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarPrimaryReplacement, "DisplayBirdEye",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00126F, 0F),
                                                                       new Vector3(0F, 180F, 180F),
                                                                       new Vector3(0.01032F, 0.01032F, 0.01032F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarSecondaryReplacement, "DisplayBirdClaw",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.00557F, 0F),
                                                                       new Vector3(0F, 277.3215F, 29.31899F),
                                                                       new Vector3(0.00427F, 0.00427F, 0.00427F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarSpecialReplacement, "DisplayBirdHeart",
                                                                       "Root",
                                                                       new Vector3(0.00505F, 0.01944F, -0.00351F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.15153F, 0.15153F, 0.15153F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarTrinket, "DisplayBeads",
                                                                       "Chest",
                                                                       new Vector3(0.00006F, 0.00164F, -0.00229F),
                                                                       new Vector3(0F, 0F, 96.99689F),
                                                                       new Vector3(0.016F, 0.016F, 0.016F)));
            //hello
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarUtilityReplacement, "DisplayBirdFoot",
                                                                       "CalfR",
                                                                       new Vector3(-0.00014F, 0.00117F, -0.00097F),
                                                                       new Vector3(357.8506F, 98.42979F, 271.0889F),
                                                                       new Vector3(0.00899F, 0.00899F, 0.00899F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Medkit, "DisplayMedkit",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.00062F, -0.00161F),
                                                                       new Vector3(270F, 180F, 0F),
                                                                       new Vector3(0.00824F, 0.00824F, 0.00824F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Missile, "DisplayMissileLauncher",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.00131F, -0.00426F),
                                                                       new Vector3(283.581F, 180F, 180F),
                                                                       new Vector3(0.00097F, 0.00097F, 0.00097F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MissileVoid, "DisplayMissileLauncherVoid",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.00131F, -0.00442F),
                                                                       new Vector3(286.235F, 180F, 180F),
                                                                       new Vector3(0.00103F, 0.00103F, 0.00103F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.MonstersOnShrineUse, "DisplayMonstersOnShrineUse",
                                                                       "Spine",
                                                                       new Vector3(0.00038F, 0.00096F, -0.0018F),
                                                                       new Vector3(54.70983F, 90F, 0F),
                                                                       new Vector3(0.00105F, 0.00105F, 0.00105F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Mushroom, "DisplayMushroom",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00342F, -0.00088F),
                                                                       new Vector3(316.2383F, 0F, 0F),
                                                                       new Vector3(0.00156F, 0.00156F, 0.00156F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MushroomVoid, "DisplayMushroomVoid",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00345F, -0.00096F),
                                                                       new Vector3(313.4806F, 0F, 0F),
                                                                       new Vector3(0.00107F, 0.00107F, 0.00107F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.NearbyDamageBonus, "DisplayDiamond",
                                                                       "LowerArmL",
                                                                       new Vector3(0.00078F, 0.0043F, -0.00069F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00125F, 0.00125F, 0.00125F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.NovaOnHeal,
                ItemDisplays.CreateDisplayRule("DisplayDevilHorns",
                                               "Head",
                                                                       new Vector3(0F, 0.00181F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00891F, 0.00891F, -0.00921F)),
                ItemDisplays.CreateDisplayRule("DisplayDevilHorns",
                                               "Head",
                                                                       new Vector3(0F, 0.00178F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(-0.00891F, 0.00891F, -0.00921F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.NovaOnLowHealth, "DisplayJellyGuts",
                                                                       "Head",
                                                                       new Vector3(-0.00006F, 0.0005F, -0.00183F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00137F, 0.00137F, 0.00137F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ParentEgg, "DisplayParentEgg",
                                                                       "Chest",
                                                                       new Vector3(0.00063F, 0.0001F, -0.00252F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00085F, 0.00085F, 0.00085F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Pearl, "DisplayPearl",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.00304F, 0F),
                                                                       new Vector3(270F, 0.00001F, 0F),
                                                                       new Vector3(0.00123F, 0.00123F, 0.00123F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.PersonalShield, "DisplayShieldGenerator",
                                                                       "LowerArmR",
                                                                       new Vector3(0F, 0.00367F, 0.00047F),
                                                                       new Vector3(90F, 180F, 0F),
                                                                       new Vector3(0.002F, 0.002F, 0.002F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Phasing, "DisplayStealthkit",
                                                                       "Spine",
                                                                       new Vector3(0F, 0F, 0.00121F),
                                                                       new Vector3(270F, 0.00001F, 0F),
                                                                       new Vector3(0.00454F, 0.00483F, 0.00483F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Plant, "DisplayInterstellarDeskPlant",
                                                                       "UpperArmL",
                                                                       new Vector3(-0.00006F, 0.00463F, 0.00079F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00095F, 0.00094F, 0.00094F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.RandomDamageZone, "DisplayRandomDamageZone",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.0023F, -0.00219F),
                                                                       new Vector3(355.1876F, 0F, 0F),
                                                                       new Vector3(0.0012F, 0.00156F, 0.00156F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.RepeatHeal, "DisplayCorpseFlower",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.002F, -0.00128F),
                                                                       new Vector3(279.8827F, 0F, 0F),
                                                                       new Vector3(0.00653F, 0.00653F, 0.00653F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SecondarySkillMagazine, "DisplayDoubleMag",
                                                                       "ThighL",
                                                                       new Vector3(-0.0011F, 0.00201F, 0.00028F),
                                                                       new Vector3(32.78108F, 0F, 0F),
                                                                       new Vector3(0.00092F, 0.00075F, 0.00095F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Seed, "DisplaySeed", //don
                                                                       "Neck",
                                                                       new Vector3(0F, 0.00094F, -0.00112F),
                                                                       new Vector3(321.2692F, 275.33F, 36.64926F),
                                                                       new Vector3(0.0005F, 0.0005F, 0.0005F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.ShieldOnly,
                ItemDisplays.CreateDisplayRule("DisplayShieldBug",
                                               "Head",
                                                                       new Vector3(-0.00049F, 0.00156F, -0.00146F),
                                                                       new Vector3(345.8107F, 93.77663F, 47.13652F),
                                                                       new Vector3(0.00428F, -0.00428F, 0.00428F)),
                ItemDisplays.CreateDisplayRule("DisplayShieldBug",
                                               "Head",
                                                                       new Vector3(0.00032F, 0.00148F, -0.00165F),
                                                                       new Vector3(4.33289F, 82.82901F, 41.46194F),
                                                                       new Vector3(0.00428F, -0.00428F, -0.00428F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ShinyPearl, "DisplayShinyPearl",
                                                                       "LowerArmL",
                                                                       new Vector3(-0.00055F, 0.00408F, 0.00021F), 
                                                                       new Vector3(278.2202F, 291.1136F, 78.58687F),
                                                                       new Vector3(0.00102F, 0.00102F, 0.00102F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.ShockNearby,
                ItemDisplays.CreateDisplayRule("DisplayTeslaCoil",
                                               "Chest",
                                                                       new Vector3(0F, 0.00171F, -0.00134F),
                                                                       new Vector3(297.7337F, 0F, 0F),
                                                                       new Vector3(0.00773F, 0.00701F, 0.00773F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.None)//gauntlet coil
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SiphonOnLowHealth, "DisplaySiphonOnLowHealth",
                                                                       "ThighL",
                                                                       new Vector3(-0.00077F, 0.0015F, 0.00065F),
                                                                       new Vector3(350.1686F, 126.6686F, 187.4797F),
                                                                       new Vector3(0.00102F, 0.00102F, 0.00103F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SlowOnHit, "DisplayBauble",
                                                                       "UpperArmR",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(9.91723F, 280.3184F, 131.0858F),
                                                                       new Vector3(-0.00372F, -0.00372F, -0.00372F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.SlowOnHitVoid, "DisplayBaubleVoid",
                                                                       "Chest",
                                                                       new Vector3(-0.00231F, -0.00054F, 0.00008F),
                                                                       new Vector3(34.56911F, 80.53241F, 297.2141F),
                                                                       new Vector3(0.00459F, 0.00459F, 0.00459F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintArmor, "DisplayBuckler",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.00176F, 0.00012F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00201F, 0.00201F, 0.00212F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintBonus, "DisplaySoda",
                                                                       "ThighL",
                                                                       new Vector3(-0.00055F, 0.00033F, 0.0005F),
                                                                       new Vector3(72.51923F, 89.33367F, 89.30141F),
                                                                       new Vector3(0.00241F, 0.00241F, 0.00241F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintOutOfCombat, "DisplayWhip",
                                                                       "ThighR",
                                                                       new Vector3(0.00109F, 0.0017F, 0F),
                                                                       new Vector3(0F, 0F, 166.9113F),
                                                                       new Vector3(0.00471F, 0.00471F, 0.00471F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintWisp, "DisplayBrokenMask",
                                                                       "Head",
                                                                       new Vector3(-0.00157F, 0.00188F, 0F),
                                                                       new Vector3(345.7309F, 270F, 21.39397F),
                                                                       new Vector3(0.00329F, 0.0028F, 0.0028F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Squid, "DisplaySquidTurret",
                                                                "Chest",
                                                                       new Vector3(-0.00141F, 0.00167F, -0.0007F),
                                                                       new Vector3(293.5349F, 44.28252F, 359.5478F),
                                                                       new Vector3(0.00065F, 0.00065F, 0.00065F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.StickyBomb, "DisplayStickyBomb",
                                                                       "ThighR",
                                                                       new Vector3(0.001F, 0.00194F, 0.00082F),
                                                                       new Vector3(72.96555F, 0F, 0F),
                                                                       new Vector3(0.003F, 0.003F, 0.003F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.StunChanceOnHit, "DisplayStunGrenade",
                                                                       "Spine",
                                                                       new Vector3(0.00146F, 0.00067F, -0.00005F),
                                                                       new Vector3(277.1569F, 122.3802F, 145.4737F),
                                                                       new Vector3(0.00568F, 0.00568F, 0.00568F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Syringe, "DisplaySyringeCluster",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.0004F, -0.00074F),
                                                                       new Vector3(298.1592F, 180F, 180F),
                                                                       new Vector3(0.00196F, 0.00196F, 0.00196F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Talisman, "DisplayTalisman",
                                                                       "Root",
                                                                       new Vector3(0.00288F, 0.01833F, -0.00813F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.71215F, 0.71215F, 0.71215F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TPHealingNova, "DisplayGlowFlower",
                                                                       "Head",
                                                                       new Vector3(0.00111F, 0.0025F, -0.0008F),
                                                                       new Vector3(344.2946F, 125.722F, 200.6264F),
                                                                       new Vector3(0.0053F, 0.0053F, 0.0053F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Thorns, "DisplayRazorwireLeft",
                                                                "UpperArmL",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.0077F, 0.0077F, 0.0077F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TitanGoldDuringTP, "DisplayGoldHeart",
                                                                       "UpperArmL",
                                                                       new Vector3(0.00058F, 0.00443F, 0.00055F),
                                                                       new Vector3(0F, 0F, 125.2354F),
                                                                       new Vector3(0.00291F, 0.00291F, 0.00291F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Tooth,
                ItemDisplays.CreateDisplayRule("DisplayToothMeshLarge",
                                               "Chest",
                                                                       new Vector3(0F, 0.00176F, 0.00194F),
                                                                       new Vector3(0F, 180F, 0F),
                                                                       new Vector3(0.04595F, 0.04595F, 0.04595F)),
                ItemDisplays.CreateDisplayRule("DisplayToothMeshSmall1",
                                               "Chest",
                                                                       new Vector3(0.0009F, 0.00181F, 0.00187F),
                                                                       new Vector3(355.8568F, 31.64545F, 20.10809F),
                                                                       new Vector3(0.02583F, 0.02583F, 0.02583F)),
                ItemDisplays.CreateDisplayRule("DisplayToothMeshSmall2",
                                               "Chest",
                                                                       new Vector3(0.00148F, 0.00229F, 0.00157F),
                                                                       new Vector3(333.1917F, 14.827F, 39.42159F),
                                                                       new Vector3(0.02395F, 0.02395F, 0.02395F)),
                ItemDisplays.CreateDisplayRule("DisplayToothMeshSmall1",
                                               "Chest",
                                                                       new Vector3(-0.00092F, 0.0019F, 0.00194F),
                                                                       new Vector3(354.2122F, 340.7911F, 346.9413F),
                                                                       new Vector3(0.02682F, 0.02682F, 0.02682F)),
                ItemDisplays.CreateDisplayRule("DisplayToothMeshSmall2",
                                               "Chest",
                                                                       new Vector3(-0.00139F, 0.00227F, 0.00139F),
                                                                       new Vector3(324.9079F, 348.7476F, 320.2073F),
                                                                       new Vector3(0.02395F, 0.02395F, 0.02395F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TreasureCache, "DisplayKey",
                                                                       "ThighR",
                                                                       new Vector3(0.00083F, 0.00073F, 0F),
                                                                       new Vector3(13.68084F, 0.15543F, 265.412F),
                                                                       new Vector3(0.01802F, 0.01802F, 0.01802F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.TreasureCacheVoid, "DisplayKeyVoid",
                                                                       "ThighR",
                                                                       new Vector3(0.00096F, 0F, 0F),
                                                                       new Vector3(0F, 0F, 270F),
                                                                       new Vector3(0.01333F, 0.01333F, 0.01333F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.UtilitySkillMagazine,
                ItemDisplays.CreateDisplayRule("DisplayAfterburnerShoulderRing",
                                               "UpperArmR",
                                                                       new Vector3(0F, 0.00517F, 0F),
                                                                       new Vector3(0F, 0F, 270F),
                                                                       new Vector3(0.00474F, 0.00474F, 0.00474F)),
                ItemDisplays.CreateDisplayRule("DisplayAfterburnerShoulderRing",
                                               "UpperArmL",
                                                                       new Vector3(0F, 0.00503F, 0F),
                                                                       new Vector3(0F, 0F, 90F),
                                                                       new Vector3(0.00474F, 0.00474F, 0.00474F))
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.WarCryOnMultiKill, "DisplayPauldron",
                                                                       "UpperArmL",
                                                                       new Vector3(-0.00028F, -0.00012F, 0.00065F),
                                                                       new Vector3(79.76083F, 180.8482F, 203.4562F),
                                                                       new Vector3(0.00787F, 0.00787F, 0.00787F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.WardOnLevel, "DisplayWarbanner",
                                                                       "Chest",
                                                                       new Vector3(-0.00002F, 0.00158F, -0.00193F),
                                                                       new Vector3(349.2031F, 196.4238F, 356.8394F),
                                                                       new Vector3(0.0064F, 0.0064F, 0.0064F)));
            #endregion items

            #region quips
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.BFG, "DisplayBFG",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.00087F, -0.00093F),
                                                                       new Vector3(276.9176F, 180F, 180F),
                                                                       new Vector3(0.00425F, 0.00425F, 0.00425F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Blackhole, "DisplayGravCube",
                                                                       "Root",
                                                                       new Vector3(0F, 0.02669F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.97127F, 0.97127F, 0.97127F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Cleanse, "DisplayWaterPack",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00079F, 0.00154F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00095F, 0.00095F, 0.00095F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CommandMissile, "DisplayMissileRack",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.0006F, -0.00091F),
                                                                       new Vector3(71.88335F, 0.00001F, 180F),
                                                                       new Vector3(0.00502F, 0.00502F, 0.00502F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.BurnNearby, "DisplayPotion",
                                                                       "Chest",
                                                                       new Vector3(0.00032F, 0.00072F, -0.0018F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00039F, 0.00039F, 0.00039F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CrippleWard, "DisplayEffigy",
                                                                       "Chest",
                                                                       new Vector3(-0.00061F, -0.00021F, -0.0026F),
                                                                       new Vector3(0F, 0F, 341.444F),
                                                                       new Vector3(0.01043F, 0.01043F, 0.01043F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CritOnUse, "DisplayNeuralImplant",
                                                                       "Head",
                                                                       new Vector3(0F, 0.0037F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.00361F, 0.00311F, 0.00279F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.DeathProjectile, "DisplayDeathProjectile",
                                                                       "Chest",
                                                                       new Vector3(0.0008F, 0.00416F, -0.00292F),
                                                                       new Vector3(320.0211F, 159.6173F, 300.0403F),
                                                                       new Vector3(0.00131F, 0.00131F, 0.00131F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.DroneBackup, "DisplayRadio",
                                                                       "Chest",
                                                                       new Vector3(0.0002F, 0.00241F, -0.00204F),
                                                                       new Vector3(4.74331F, 237.0253F, 348.9089F),
                                                                       new Vector3(0.00507F, 0.00507F, 0.00507F)));
            //E for Affix
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Equipment.AffixRed,
                ItemDisplays.CreateDisplayRule("DisplayEliteHorn",
                                               "Head",
                                                                       new Vector3(0.00189F, 0.00208F, -0.0004F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00109F, 0.00109F, 0.00109F)),
                ItemDisplays.CreateDisplayRule("DisplayEliteHorn",
                                               "Head",
                                                                       new Vector3(-0.00176F, 0.00163F, -0.00058F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(-0.00109F, 0.00109F, 0.00109F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixHaunted, "DisplayEliteStealthCrown",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00164F, -0.00137F),
                                                                       new Vector3(359.5518F, 0F, 0F),
                                                                       new Vector3(-0.00061F, -0.00055F, -0.00055F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixWhite, "DisplayEliteIceCrown",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00131F, -0.00191F),
                                                                       new Vector3(1.07661F, 180F, 180F),
                                                                       new Vector3(0.00033F, 0.00033F, 0.00033F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Equipment.AffixBlue,
                ItemDisplays.CreateDisplayRule("DisplayEliteRhinoHorn",
                                               "Head",
                                                                       new Vector3(0F, 0.00093F, -0.00196F),
                                                                       new Vector3(26.90219F, 180F, 180F),
                                                                       new Vector3(0.00305F, 0.0031F, 0.00262F)),
                ItemDisplays.CreateDisplayRule("DisplayEliteRhinoHorn",
                                               "Head",
                                                                       new Vector3(0F, 0.00206F, -0.0019F),
                                                                       new Vector3(342.8231F, 180F, 180F),
                                                                       new Vector3(-0.00199F, 0.00202F, 0.00159F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixLunar, "DisplayEliteLunar,Eye",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00347F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.00265F, 0.00246F, 0.00265F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixPoison, "DisplayEliteUrchinCrown",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00183F, -0.0016F),
                                                                       new Vector3(349.3365F, 180F, 270F),
                                                                       new Vector3(0.00054F, 0.00054F, 0.00054F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.FireBallDash, "DisplayEgg",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00197F, -0.00264F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.00472F, 0.00472F, 0.00472F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Fruit, "DisplayFruit",
                                                                       "Chest",
                                                                       new Vector3(-0.0019F, 0.00068F, 0.00252F),
                                                                       new Vector3(49.89084F, 193.1927F, 55.48783F),
                                                                       new Vector3(0.00335F, 0.00335F, 0.00346F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.GainArmor, "DisplayElephantFigure",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00321F, -0.0019F),
                                                                       new Vector3(287.2275F, 0F, 0F),
                                                                       new Vector3(0.01032F, 0.01032F, 0.01032F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Gateway, "DisplayVase",
                                                                       "Chest",
                                                                       new Vector3(-0.00047F, 0.00363F, -0.00209F),
                                                                       new Vector3(348.9436F, 352.6793F, 33.81813F),
                                                                       new Vector3(0.00275F, 0.00275F, 0.00275F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.GoldGat, "DisplayGoldGat",
                                                                       "Neck",
                                                                       new Vector3(0F, -0.00178F, -0.00197F),
                                                                       new Vector3(0F, 90F, 212.5969F),
                                                                       new Vector3(0.00133F, 0.00133F, 0.00133F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Jetpack, "DisplayBugWings",
                                                                       "Chest",
                                                                       new Vector3(0F, -0.00078F, -0.00085F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00206F, 0.00206F, 0.00206F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.LifestealOnHit, "DisplayLifestealOnHit",
                                                                       "Neck",
                                                                       new Vector3(-0.0002F, 0.00056F, -0.00233F),
                                                                       new Vector3(323.6458F, 1.34282F, 359.2039F),
                                                                       new Vector3(0.00101F, 0.00101F, 0.00101F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Equipment.Lightning,
                ItemDisplays.CreateDisplayRule("DisplayLightningArmCustom",
                                               "UpperArmR",
                                                                       new Vector3(0.00043F, 0.00273F, 0.00092F),
                                                                       new Vector3(292.1966F, 76.24585F, 180F),
                                                                       new Vector3(0.00831F, 0.00831F, 0.00831F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.RightArm)//shoulder coil
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Meteor, "DisplayMeteor",
                                                                       "Root",
                                                                       new Vector3(0F, 0.0211F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.76542F, 0.76645F, 0.76645F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.QuestVolatileBattery, "DisplayBatteryArray",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00257F, -0.00295F),
                                                                       new Vector3(341.7507F, 180F, 180F),
                                                                       new Vector3(0.00397F, 0.00397F, 0.00397F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Recycle, "DisplayRecycler",
                                                                       "Chest",
                                                                       new Vector3(0.00057F, 0.00237F, -0.0017F),
                                                                       new Vector3(0F, 90F, 6.79936F),
                                                                       new Vector3(0.00085F, 0.00085F, 0.00085F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Saw, "DisplaySawmerangFollower",
                                                                       "Root",
                                                                       new Vector3(-0.00003F, 0.02201F, -0.00039F),
                                                                       new Vector3(271.0232F, 185.0242F, 175.0119F),
                                                                       new Vector3(0.00141F, 0.00141F, 0.00141F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Scanner, "DisplayScanner",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.0007F, -0.00045F),
                                                                       new Vector3(11.62957F, 180F, 180F),
                                                                       new Vector3(0.00178F, 0.00178F, 0.00178F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.TeamWarCry, "DisplayTeamWarCry",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.00066F, -0.0012F),
                                                                       new Vector3(8.42614F, 180F, 180F),
                                                                       new Vector3(0.00104F, 0.00104F, 0.00104F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Tonic, "DisplayTonic",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00113F, 0.00183F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00269F, 0.00269F, 0.00269F)));

            #endregion quips

            #region dlc1

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PrimarySkillShuriken, "DisplayShuriken",
                                                                       "LowerArmR",
                                                                       new Vector3(0F, 0.00438F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.00719F, 0.00719F, 0.00719F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.OutOfCombatArmor, "DisplayOddlyShapedOpal",
                                                                       "LowerArmR",
                                                                       new Vector3(0F, 0.00342F, 0.00058F),
                                                                       new Vector3(3.71043F, 0F, 0F),
                                                                       new Vector3(0.00449F, 0.00449F, 0.00453F)));
            //head
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(DLC1Content.Items.LunarSun,
                ItemDisplays.CreateDisplayRule("DisplaySunHead",
                                               "Head",
                                                                       new Vector3(0F, 0.00151F, 0.00003F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.01302F, 0.01305F, 0.01305F)),
                ItemDisplays.CreateDisplayRule("DisplaySunHeadNeck",
                                               "Head",
                                                                       new Vector3(-0.00003F, 0.00004F, 0.00067F),
                                                                       new Vector3(8.72353F, 128.8626F, 349.3409F),
                                                                       new Vector3(0.01681F, 0.00903F, -0.01885F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.Head)));
            //size
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MinorConstructOnKill, "DisplayDefenseNucleus",
                                                                       "Root",
                                                                       new Vector3(-0.00374F, 0.02148F, -0.00536F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.29386F, 0.29386F, 0.29386F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HalfAttackSpeedHalfCooldowns, "DisplayLunarShoulderNature",
                                                                       "Head",
                                                                       new Vector3(0F, 0.0025F, 0.00157F),
                                                                       new Vector3(0F, 90F, 36.93161F),
                                                                       new Vector3(0.00725F, 0.00725F, 0.00517F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HalfSpeedDoubleHealth, "DisplayLunarShoulderStone",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00184F, -0.00127F),
                                                                       new Vector3(0F, 270F, 22.2875F),
                                                                       new Vector3(0.00811F, 0.00811F, 0.01201F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.AttackSpeedAndMoveSpeed, "DisplayCoffee",
                                                                       "Hips",
                                                                       new Vector3(0.00086F, 0.00036F, -0.00133F),
                                                                       new Vector3(335.4913F, 40.24231F, 355.9257F),
                                                                       new Vector3(0.00235F, 0.00235F, 0.00235F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.GoldOnHurt, "DisplayRollOfPennies",
                                                                       "ThighL",
                                                                       new Vector3(0F, 0.00365F, -0.00053F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00983F, 0.00983F, 0.00983F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.FragileDamageBonus, "DisplayDelicateWatch",
                                                                       "LowerArmR",
                                                                       new Vector3(0F, 0.00395F, 0.00021F),
                                                                       new Vector3(85.66948F, 180F, 180F),
                                                                       new Vector3(0.00456F, 0.00774F, 0.00466F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ImmuneToDebuff, "DisplayRainCoatBelt",
                                                                       "Hips",
                                                                       new Vector3(0F, 0.00088F, 0F),
                                                                       new Vector3(342.9062F, 0F, 0F),
                                                                       new Vector3(0.00802F, 0.00694F, 0.00694F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RandomEquipmentTrigger, "DisplayBottledChaos",
                                                                       "Spine",
                                                                       new Vector3(0F, 0F, -0.00153F),
                                                                       new Vector3(355.1696F, 0F, 0F),
                                                                       new Vector3(0.00215F, 0.00215F, 0.00215F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.StrengthenBurn, "DisplayGasTank",
                                                                       "ThighL",
                                                                       new Vector3(-0.00056F, 0.00338F, 0.00094F),
                                                                       new Vector3(0F, 0F, 180.2308F),
                                                                       new Vector3(0.00139F, 0.00139F, 0.00139F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.VoidMegaCrabItem, "DisplayMegaCrabItem",
                                                                       "Head",
                                                                       new Vector3(0F, 0.002F, -0.00203F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00145F, 0.00145F, 0.00145F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RegeneratingScrap, "DisplayRegeneratingScrap",
                                                                       "Neck",
                                                                       new Vector3(-0.00054F, 0.00055F, -0.00088F),
                                                                       new Vector3(343.7381F, 42.33283F, 252.4204F),
                                                                       new Vector3(0.00225F, 0.00225F, 0.00225F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PermanentDebuffOnHit, "DisplayScorpion",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00254F, -0.00115F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00963F, 0.00963F, 0.00963F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CritDamage, "DisplayLaserSight",
                                                                       "Head",
                                                                       new Vector3(0.00153F, 0.00155F, 0F),
                                                                       new Vector3(0F, 0F, 270F),
                                                                       new Vector3(0.00089F, 0.00089F, 0.00089F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.FreeChest, "DisplayShippingRequestForm",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00271F, -0.00194F),
                                                                       new Vector3(270.0949F, 0F, 0F),
                                                                       new Vector3(0.01087F, 0.0109F, 0.01087F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoveSpeedOnKill, "DisplayGrappleHook",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.00625F, 0F),
                                                                       new Vector3(0F, 180F, 180F),
                                                                       new Vector3(0.00219F, 0.00219F, 0.00219F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RandomlyLunar, "DisplayDomino",
                                                                       "Root",
                                                                       new Vector3(-0.00944F, 0.01324F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(1.43943F, 1.43943F, 1.43943F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HealingPotion, "DisplayHealingPotion",
                                                                       "ThighR",
                                                                       new Vector3(0.00118F, 0.00101F, -0.00004F),
                                                                       new Vector3(327.7106F, 17.98712F, 148.7098F),
                                                                       new Vector3(0.00063F, 0.00063F, 0.00063F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoreMissile, "DisplayICBM",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.00071F, -0.00186F),
                                                                       new Vector3(0.97053F, 0F, 0F),
                                                                       new Vector3(0.0018F, 0.0018F, 0.0018F)));

            //quips
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(DLC1Content.Equipment.BossHunter,
                ItemDisplays.CreateDisplayRule("DisplayTricornGhost",
                                               "Head",
                                                                       new Vector3(0F, 0.00132F, -0.00228F),
                                                                       new Vector3(292.5309F, 0F, 0F),
                                                                       new Vector3(0.00623F, 0.00623F, 0.00623F)),
                ItemDisplays.CreateDisplayRule("DisplayBlunderbuss",
                                               "Root",
                                                                       new Vector3(0F, 0.02169F, 0.00137F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.53345F, 0.53345F, 0.53345F))));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.BossHunterConsumed, "DisplayTricornUsed",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00143F, -0.00224F),
                                                                       new Vector3(294.8055F, 0F, 0F),
                                                                       new Vector3(0.00757F, 0.00757F, 0.00757F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.EliteVoidEquipment, "DisplayAffixVoid",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00176F, 0.00034F),
                                                                       new Vector3(353.7043F, 0F, 0F),
                                                                       new Vector3(0.00337F, 0.00337F, 0.00337F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.GummyClone, "DisplayGummyClone",
                                                                       "Chest",
                                                                       new Vector3(0.00028F, 0.00266F, -0.00163F),
                                                                       new Vector3(19.72359F, 0F, 0F),
                                                                       new Vector3(0.00294F, 0.00294F, 0.00294F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule("IrradiatingLaser", "DisplayIrradiatingLaser",
                                                                       "Neck",
                                                                       new Vector3(0F, 0.00109F, -0.00054F),
                                                                       new Vector3(321.2852F, 180F, 180F),
                                                                       new Vector3(0.00169F, 0.00169F, 0.00169F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.LunarPortalOnUse, "DisplayLunarPortalOnUse",
                                                                       "Root",
                                                                       new Vector3(0F, 0.02291F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.85193F, 0.85193F, 0.85193F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.Molotov, "DisplayMolotov",
                                                                       "Neck",
                                                                       new Vector3(0F, -0.00025F, -0.00108F),
                                                                       new Vector3(336.3658F, 0F, 0F),
                                                                       new Vector3(0.00302F, 0.00302F, 0.00302F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.MultiShopCard, "DisplayExecutiveCard",
                                                                       "Chest",
                                                                       new Vector3(0.00097F, 0.00156F, -0.00265F),
                                                                       new Vector3(274.4852F, 180F, 180F),
                                                                       new Vector3(0.01217F, 0.01243F, 0.01282F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.VendingMachine, "DisplayVendingMachine",
                                                                       "Neck",
                                                                       new Vector3(0F, -0.00098F, -0.00283F),
                                                                       new Vector3(286.4358F, 180F, 180F),
                                                                       new Vector3(0.00346F, 0.00346F, 0.00346F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Elites.Earth.eliteEquipmentDef, "DisplayEliteMendingAntlers",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00195F, -0.00082F),
                                                                       new Vector3(284.1421F, 0F, 0F),
                                                                       new Vector3(0.00988F, 0.00988F, 0.00988F)));

            #endregion

        }
    }
}
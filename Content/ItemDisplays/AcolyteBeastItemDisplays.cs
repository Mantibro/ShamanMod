using RoR2;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ShamanMod.Modules.Characters
{
    internal class AcolyteBeastItemDisplays : ItemDisplaysBase
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
                                                                       new Vector3(-2.407F, 2.185F, 0.849F),
                                                                       new Vector3(285.0947F, 328.6408F, 350.1125F),
                                                                       new Vector3(0.858F, 0.858F, 0.858F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ArmorPlate, "DisplayRepulsionArmorPlate",
                                                                       "UpperArmL",
                                                                       new Vector3(0.387F, 0.13F, -0.168F),
                                                                       new Vector3(90F, 280.2563F, 0F),
                                                                       new Vector3(0.853F, 0.467F, 0.735F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.ArmorReductionOnHit,
                ItemDisplays.CreateDisplayRule("DisplayWarhammer",
                                               "Spine",
                                                                       new Vector3(0.548F, 0.601F, -0.315F),
                                                                       new Vector3(1.69786F, 86.60026F, 91.39961F),
                                                                       new Vector3(0.473F, 0.473F, 0.473F))));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AttackSpeedOnCrit, "DisplayWolfPelt",
                                                                       "Eye1",
                                                                       new Vector3(0.077F, 0.611F, -0.224F),
                                                                       new Vector3(288.4954F, 173.9509F, 176.0275F),
                                                                       new Vector3(1.788F, 1.223F, 1.223F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AutoCastEquipment, "DisplayFossil",
                                                                       "Chest",
                                                                       new Vector3(1.052F, 1.525F, 1.273F),
                                                                       new Vector3(22.30449F, 105.8541F, 17.78504F),
                                                                       new Vector3(1.939F, 1.939F, 1.939F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Bandolier, "DisplayBandolier",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.01F, -0.177F),
                                                                       new Vector3(278.6648F, 0F, 90F),
                                                                       new Vector3(1.332F, 1.584F, 2.41F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnKill, "DisplayBrooch",
                                                                       "Chest",
                                                                       new Vector3(0.794F, 0.497F, 1.649F),
                                                                       new Vector3(80.07203F, 0F, 0F),
                                                                       new Vector3(1.072F, 0.919F, 0.919F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnOverHeal, "DisplayAegis",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 1.123F, 0.266F),
                                                                       new Vector3(90F, 180F, 0F),
                                                                       new Vector3(0.725F, 0.725F, 0.725F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Bear, "DisplayBear",
                                                                       "Chest",
                                                                       new Vector3(0.094F, 0.256F, 1.161F),
                                                                       new Vector3(31.4944F, 10.23464F, 11.85665F),
                                                                       new Vector3(0.346F, 0.357F, 0.357F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.BearVoid, "DisplayBearVoid",
                                                                       "Chest",
                                                                       new Vector3(0.085F, 0.217F, 1.18F),
                                                                       new Vector3(20.06796F, 13.30229F, 18.20955F),
                                                                       new Vector3(0.347F, 0.347F, 0.347F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BeetleGland, "DisplayBeetleGland",
                                                                       "Chest",
                                                                       new Vector3(-1.891F, 3.335F, 0.154F),
                                                                       new Vector3(0F, 0F, 280.2594F),
                                                                       new Vector3(0.323F, 0.323F, 0.323F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Behemoth,
                ItemDisplays.CreateDisplayRule("DisplayBehemoth",
                                               "UpperArmL",
                                                                       new Vector3(0.629F, 0.163F, 0.183F),
                                                                       new Vector3(359.5844F, 85.59161F, 354.625F),
                                                                       new Vector3(0.1F, 0.1F, 0.1F))));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.BleedOnHit,
                ItemDisplays.CreateDisplayRule("DisplayTriTip",
                                               "Chest",
                                                                       new Vector3(-0.124F, 3.141F, 0.468F),
                                                                       new Vector3(280.8553F, 180F, 180F),
                                                                       new Vector3(1.664F, 1.664F, 1.97F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(DLC1Content.Items.BleedOnHitVoid,
                ItemDisplays.CreateDisplayRule("DisplayTriTipVoid",
                                               "Chest",
                                                                       new Vector3(0.353F, 3.099F, 0.517F),
                                                                       new Vector3(304.272F, 134.9929F, 219.5764F),
                                                                       new Vector3(0.678F, 0.678F, 0.803F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BleedOnHitAndExplode, "DisplayBleedOnHitAndExplode",
                                                                       "Chest",
                                                                       new Vector3(-0.958F, 2.599F, 1.571F),
                                                                       new Vector3(20.89036F, 338.1264F, 296.4275F),
                                                                       new Vector3(0.115F, 0.127F, 0.115F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BonusGoldPackOnKill, "DisplayTome",
                                                                       "ThighL",
                                                                       new Vector3(-0.503F, 0.282F, 0.115F),
                                                                       new Vector3(9.22191F, 77.22878F, 356.7291F),
                                                                       new Vector3(0.127F, 0.127F, 0.127F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BossDamageBonus, "DisplayAPRound",
                                                                       "Spine",
                                                                       new Vector3(0.281F, 0.085F, 0.378F),
                                                                       new Vector3(80.79362F, 20.23978F, 167.7541F),
                                                                       new Vector3(0.7F, 0.7F, 0.7F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BounceNearby, "DisplayHook",
                                                                       "Chest",
                                                                       new Vector3(0.422F, 2.877F, 0.888F),
                                                                       new Vector3(359.116F, 180F, 209.1495F),
                                                                       new Vector3(-1.196F, -1.196F, -1.196F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ChainLightning, "DisplayUkulele",
                                                                       "Chest",
                                                                       new Vector3(0.243F, 2.068F, -1.137F),
                                                                       new Vector3(359.6609F, 149.0193F, 170.173F),
                                                                       new Vector3(0.725F, 0.688F, 0.699F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ChainLightningVoid, "DisplayUkuleleVoid",
                                                                       "Chest",
                                                                       new Vector3(0.186F, 1.449F, -1.147F),
                                                                       new Vector3(8.33601F, 162.0218F, 189.5914F),
                                                                       new Vector3(0.783F, 0.744F, 0.755F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Clover, "DisplayClover",
                                                                       "Chest",
                                                                       new Vector3(1.057F, 2.343F, 1.234F),
                                                                       new Vector3(17.08605F, 293.8966F, 273.6263F),
                                                                       new Vector3(0.595F, 0.595F, 0.593F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CloverVoid, "DisplayCloverVoid",
                                                                       "Chest",
                                                                       new Vector3(1.057F, 2.343F, 1.234F),
                                                                       new Vector3(17.08605F, 293.8966F, 273.6263F),
                                                                       new Vector3(0.595F, 0.595F, 0.593F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(JunkContent.Items.CooldownOnCrit,
                ItemDisplays.CreateDisplayRule("DisplaySkull",
                                               "Eye1",
                                                                       new Vector3(0F, 0.778F, -0.335F),
                                                                       new Vector3(27.78193F, 180F, 180F),
                                                                       new Vector3(0.327F, 0.327F, 0.327F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.Head)
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.CritGlasses, "DisplayGlasses",
                                                                       "Eye3",
                                                                       new Vector3(0F, 0.649F, 0.017F),
                                                                       new Vector3(270F, 0.00001F, 0F),
                                                                       new Vector3(0.403F, 0.305F, 0.793F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CritGlassesVoid, "DisplayGlassesVoid",
                                                                       "Eye3",
                                                                       new Vector3(0F, 0.649F, -0.025F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.551F, 0.567F, 0.791F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Crowbar, "DisplayCrowbar",
                                                                       "Chest",
                                                                       new Vector3(-0.732F, 2.69F, -1.139F),
                                                                       new Vector3(12.76912F, 141.1832F, 299.6208F),
                                                                       new Vector3(0.834F, 0.834F, 0.834F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Dagger, "DisplayDagger",
                                                                       "Chest",
                                                                       new Vector3(0.783F, 2.542F, 0.911F),
                                                                       new Vector3(356.0795F, 8.14295F, 53.11333F),
                                                                       new Vector3(1.839F, 1.839F, 1.839F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.DeathMark, "DisplayDeathMark",
                                                                       "HandL",
                                                                       new Vector3(0.00036F, 0.27562F, 0.07561F),
                                                                       new Vector3(45.38486F, 358.5659F, 178.989F),
                                                                       new Vector3(0.08179F, 0.08179F, 0.08179F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.EnergizedOnEquipmentUse, "DisplayWarHorn",
                                                                       "Chest",
                                                                       new Vector3(-0.039F, 0.402F, -0.525F),
                                                                       new Vector3(11.66601F, 0F, 8.8871F),
                                                                       new Vector3(1.594F, 1.594F, 1.594F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.EquipmentMagazine, "DisplayBattery",
                                                                       "Hips",
                                                                       new Vector3(0.062F, 0.827F, -0.56F),
                                                                       new Vector3(0F, 270F, 0F),
                                                                       new Vector3(0.204F, 0.204F, 0.204F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.EquipmentMagazineVoid, "DisplayFuelCellVoid",
                                                                       "Hips",
                                                                       new Vector3(0F, 0.73F, -0.573F),
                                                                       new Vector3(90F, 89.99999F, 0F),
                                                                       new Vector3(0.285F, 0.285F, 0.285F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExecuteLowHealthElite, "DisplayGuillotine",
                                                                       "LowerArmL",
                                                                       new Vector3(0.015F, 1.482F, 0.167F),
                                                                       new Vector3(42.92809F, 180.5273F, 270.7742F),
                                                                       new Vector3(0.288F, 0.288F, 0.284F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExplodeOnDeath, "DisplayWilloWisp",
                                                                       "Chest",
                                                                       new Vector3(-0.836F, 0.18F, -0.445F),
                                                                       new Vector3(7.67746F, 325.9193F, 47.46843F),
                                                                       new Vector3(0.088F, 0.088F, 0.088F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ExplodeOnDeathVoid, "DisplayWillowWispVoid",
                                                                       "Chest",
                                                                       new Vector3(-0.602F, 0.068F, -0.438F),
                                                                       new Vector3(341.1968F, 347.5622F, 24.27017F),
                                                                       new Vector3(0.067F, 0.067F, 0.067F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExtraLife, "DisplayHippo",
                                                                       "Chest",
                                                                       new Vector3(0.821F, 0.761F, 1.227F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.482F, 0.495F, 0.495F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ExtraLifeVoid, "DisplayHippoVoid",
                                                                       "Chest",
                                                                       new Vector3(0.836F, 0.573F, 1.297F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.409F, 0.422F, 0.422F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.FallBoots,
                ItemDisplays.CreateDisplayRule("DisplayGravBoots",
                                               "CalfL",
                                                                       new Vector3(0F, 1.059F, 0.043F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.612F, 0.612F, 0.612F)),
                ItemDisplays.CreateDisplayRule("DisplayGravBoots",
                                               "CalfR",
                                                                       new Vector3(0F, 1.218F, 0.032F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.413F, 0.413F, 0.413F)
                )));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Feather,
                ItemDisplays.CreateDisplayRule("DisplayFeather",
                                               "Chest",
                                                                       new Vector3(0.076F, 2.058F, -0.984F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(-0.171F, 0.102F, 0.102F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FireballsOnHit, "DisplayFireballsOnHit",
                                                                       "Chest",
                                                                       new Vector3(-0.026F, 3.406F, -0.711F),
                                                                       new Vector3(284.2644F, 178.6002F, 340.0135F),
                                                                       new Vector3(0.242F, 0.277F, 0.23F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FireRing, "DisplayFireRing",
                                                                       "LowerArmL",
                                                                       new Vector3(0.027F, 2.171F, -0.095F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(1.735F, 1.735F, 1.735F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.IceRing, "DisplayIceRing",
                                                                       "LowerArmL",
                                                                       new Vector3(0.012F, 2.005F, 0.034F),
                                                                       new Vector3(78.20138F, 54.06792F, 55.86569F),
                                                                       new Vector3(1.119F, 1.119F, 1.119F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ElementalRingVoid, "DisplayVoidRing",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 1.177F, 0F),
                                                                       new Vector3(270F, 136.8969F, 0F),
                                                                       new Vector3(1.547F, 1.547F, 1.325F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Firework, "DisplayFirework",
                                                                       "Chest",
                                                                       new Vector3(-1.481F, 2.925F, -0.268F),
                                                                       new Vector3(316.392F, 241.8502F, 127.8034F),
                                                                       new Vector3(0.745F, 0.745F, 0.745F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FlatHealth, "DisplaySteakCurved",
                                                                       "Eye1",
                                                                       new Vector3(0F, 0.546F, -0.457F),
                                                                       new Vector3(17.20867F, 180F, 180F),
                                                                       new Vector3(0.197F, 0.197F, 0.197F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FocusConvergence, "DisplayFocusedConvergence",
                                                                       "Root",
                                                                       new Vector3(-2.391F, 8.383F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.05F, 0.05F, 0.05F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.GhostOnKill, "DisplayMask",
                                                                       "UpperArmL",
                                                                       new Vector3(0.344F, 0.05F, -0.157F),
                                                                       new Vector3(352.714F, 127.0883F, 180F),
                                                                       new Vector3(0.798F, 0.798F, 0.615F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.GoldOnHit, "DisplayBoneCrown",
                                                                       "Eye2",
                                                                       new Vector3(0F, 0.795F, -0.001F),
                                                                       new Vector3(0F, 180F, 0F),
                                                                       new Vector3(2.551F, 2.213F, 2.213F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HeadHunter, "DisplaySkullCrown",
                                                                       "Eye3",
                                                                       new Vector3(-0.006F, 0.689F, 0F),
                                                                       new Vector3(359.9472F, 173.7351F, 179.5188F),
                                                                       new Vector3(0.629F, 0.227F, 0.227F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HealOnCrit, "DisplayScythe",
                                                                       "LowerArmL",
                                                                       new Vector3(0.342F, 1.235F, 0.049F),
                                                                       new Vector3(273.6758F, 270F, 0F),
                                                                       new Vector3(0.474F, 0.474F, 0.474F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HealWhileSafe, "DisplaySnail",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.504F, -0.714F),
                                                                       new Vector3(301.7467F, 180F, 180F),
                                                                       new Vector3(0.156F, 0.156F, 0.156F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Hoof,
                ItemDisplays.CreateDisplayRule("DisplayHoof",
                                               "CalfR",
                                                                       new Vector3(0.039F, 0.91F, -0.034F),
                                                                       new Vector3(79.93876F, 359.8341F, 6.88061F),
                                                                       new Vector3(0.234F, 0.222F, 0.208F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.RightCalf)
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Icicle, "DisplayFrostRelic",
                                                                       "Root",
                                                                       new Vector3(3.693F, 6.569F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(2.54082F, 2.54082F, 2.54082F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.IgniteOnKill, "DisplayGasoline",
                                                                       "Spine",
                                                                       new Vector3(-0.196F, 0.255F, -0.376F),
                                                                       new Vector3(300.99F, 30.69935F, 209.3635F),
                                                                       new Vector3(0.654F, 0.654F, 0.654F)));
            //hello
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.IncreaseHealing,
                ItemDisplays.CreateDisplayRule("DisplayAntler",
                                               "Eye1",
                                                                       new Vector3(0.301F, 0.55F, 0.015F),
                                                                       new Vector3(353.9438F, 81.39288F, 300.5692F),
                                                                       new Vector3(0.957F, 0.957F, 0.957F)),
                ItemDisplays.CreateDisplayRule("DisplayAntler",
                                               "Eye1",
                                                                       new Vector3(-0.307F, 0.526F, -0.079F),
                                                                       new Vector3(356.1463F, 266.133F, 47.10715F),
                                                                       new Vector3(-0.897F, 0.774F, 0.782F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(JunkContent.Items.Incubator, "DisplayAncestralIncubator",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.445F, -0.644F),
                                                                       new Vector3(291.1831F, 0F, 0F),
                                                                       new Vector3(0.071F, 0.071F, 0.071F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Infusion, "DisplayInfusion",
                                                                       "Spine",
                                                                       new Vector3(-0.242F, 0.137F, 0.306F),
                                                                       new Vector3(7.2393F, 148.6312F, 15.16809F),
                                                                       new Vector3(1.286F, 1.286F, 1.297F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.JumpBoost, "DisplayWaxBird",
                                                                       "Eye3",
                                                                       new Vector3(0F, 0.386F, 0.15F),
                                                                       new Vector3(271.6526F, 0F, 0F),
                                                                       new Vector3(0.701F, 0.701F, 0.701F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.KillEliteFrenzy, "DisplayBrainstalk",
                                                                       "Chest",
                                                                       new Vector3(0F, 2.274F, 0.44F),
                                                                       new Vector3(13.85592F, 0F, 0F),
                                                                       new Vector3(1.34F, 1.897F, 1.331F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Knurl, "DisplayKnurl",
                                                                       "UpperArmR",
                                                                       new Vector3(-0.43F, 0.38F, -0.362F),
                                                                       new Vector3(35.00983F, 249.0631F, 196.2022F),
                                                                       new Vector3(0.331F, 0.331F, 0.331F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LaserTurbine, "DisplayLaserTurbine",
                                                                       "UpperArmR",
                                                                       new Vector3(-0.346F, 0.48F, 0.595F),
                                                                       new Vector3(358.0021F, 312.3606F, 96.76483F),
                                                                       new Vector3(0.462F, 0.462F, 0.462F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LightningStrikeOnHit, "DisplayChargedPerforator",
                                                                       "Chest",
                                                                       new Vector3(0.97F, 3.21F, -0.421F),
                                                                       new Vector3(322.0188F, 301.867F, 179.463F),
                                                                       new Vector3(5.521F, 5.521F, 5.521F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarDagger, "DisplayLunarDagger",
                                                                       "Spine",
                                                                       new Vector3(-0.06F, 0.244F, 0.745F),
                                                                       new Vector3(36.18383F, 188.3709F, 283.9954F),
                                                                       new Vector3(1.94F, 2.001F, 1.94F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarPrimaryReplacement, "DisplayBirdEye",
                                                                       "Eye2",
                                                                       new Vector3(0F, 0.414F, 0F),
                                                                       new Vector3(0F, 180F, 180F),
                                                                       new Vector3(2.875F, 2.875F, 2.875F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarSecondaryReplacement, "DisplayBirdClaw",
                                                                       "LowerArmL",
                                                                       new Vector3(-0.014F, 1.948F, -0.106F),
                                                                       new Vector3(0F, 277.3215F, 29.31899F),
                                                                       new Vector3(1.71F, 1.71F, 1.71F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarSpecialReplacement, "DisplayBirdHeart",
                                                                       "Root",
                                                                       new Vector3(2.557F, 9.304F, -0.351F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.90171F, 0.90171F, 0.90171F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarTrinket, "DisplayBeads",
                                                                       "Chest",
                                                                       new Vector3(0.007F, 0.257F, 0.976F),
                                                                       new Vector3(337.1407F, 33.15829F, 120.7352F),
                                                                       new Vector3(1.6F, 1.6F, 1.6F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarUtilityReplacement, "DisplayBirdFoot",
                                                                       "CalfR",
                                                                       new Vector3(-0.029F, 0.417F, -0.12F),
                                                                       new Vector3(357.8506F, 98.42979F, 271.0889F),
                                                                       new Vector3(1.242F, 1.242F, 1.242F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Medkit, "DisplayMedkit",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.623F, -0.196F),
                                                                       new Vector3(270F, 180F, 0F),
                                                                       new Vector3(0.824F, 0.824F, 0.824F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Missile, "DisplayMissileLauncher",
                                                                       "Chest",
                                                                       new Vector3(-1.508F, 1.915F, -1.034F),
                                                                       new Vector3(332.239F, 313.7123F, 92.96133F),
                                                                       new Vector3(0.184F, 0.184F, 0.184F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MissileVoid, "DisplayMissileLauncherVoid",
                                                                       "Chest",
                                                                       new Vector3(-1.786F, 2.014F, -0.551F),
                                                                       new Vector3(339.358F, 333.265F, 84.6225F),
                                                                       new Vector3(0.147F, 0.147F, 0.147F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.MonstersOnShrineUse, "DisplayMonstersOnShrineUse",
                                                                       "Spine",
                                                                       new Vector3(-0.279F, 0.532F, -0.357F),
                                                                       new Vector3(53.0141F, 127.0394F, 22.71369F),
                                                                       new Vector3(0.105F, 0.105F, 0.105F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Mushroom, "DisplayMushroom",
                                                                       "Chest",
                                                                       new Vector3(0.095F, 2.992F, 0.066F),
                                                                       new Vector3(8.17051F, 0F, 0F),
                                                                       new Vector3(0.423F, 0.423F, 0.423F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MushroomVoid, "DisplayMushroomVoid",
                                                                       "Chest",
                                                                       new Vector3(0F, 2.924F, 0.13F),
                                                                       new Vector3(3.40732F, 0F, 0F),
                                                                       new Vector3(0.245F, 0.245F, 0.245F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.NearbyDamageBonus, "DisplayDiamond",
                                                                       "LowerArmL",
                                                                       new Vector3(0.078F, 2.245F, -0.069F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.331F, 0.331F, 0.331F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.NovaOnHeal,
                ItemDisplays.CreateDisplayRule("DisplayDevilHorns",
                                               "Eye3",
                                                                       new Vector3(0.146F, 0.442F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.891F, 0.891F, -0.921F)),
                ItemDisplays.CreateDisplayRule("DisplayDevilHorns",
                                               "Eye3",
                                                                       new Vector3(-0.148F, 0.432F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(-0.891F, 0.891F, -0.921F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.NovaOnLowHealth, "DisplayJellyGuts",
                                                                       "Chest",
                                                                       new Vector3(-0.473F, 2.659F, 1.083F),
                                                                       new Vector3(349.0874F, 0F, 0F),
                                                                       new Vector3(0.313F, 0.313F, 0.313F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ParentEgg, "DisplayParentEgg",
                                                                       "Chest",
                                                                       new Vector3(0.377F, 3.288F, 0.237F),
                                                                       new Vector3(282.6532F, 0.00002F, 280.2806F),
                                                                       new Vector3(0.254F, 0.254F, 0.254F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Pearl, "DisplayPearl",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.852F, 0F),
                                                                       new Vector3(270F, 0.00001F, 0F),
                                                                       new Vector3(0.198F, 0.198F, 0.198F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.PersonalShield, "DisplayShieldGenerator",
                                                                       "LowerArmR",
                                                                       new Vector3(-0.055F, 2.052F, 0.628F),
                                                                       new Vector3(90F, 188.5162F, 0F),
                                                                       new Vector3(0.452F, 0.452F, 0.452F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Phasing, "DisplayStealthkit",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.727F, 0.524F),
                                                                       new Vector3(282.3932F, 0.00001F, 0F),
                                                                       new Vector3(0.658F, 0.7F, 0.7F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Plant, "DisplayInterstellarDeskPlant",
                                                                       "UpperArmL",
                                                                       new Vector3(-0.006F, 0.975F, -0.415F),
                                                                       new Vector3(345.1604F, 180F, 180F),
                                                                       new Vector3(0.129F, 0.128F, 0.128F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.RandomDamageZone, "DisplayRandomDamageZone",
                                                                       "Chest",
                                                                       new Vector3(0F, 3.317F, -0.479F),
                                                                       new Vector3(50.08339F, 0F, 0F),
                                                                       new Vector3(0.298F, 0.388F, 0.388F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.RepeatHeal, "DisplayCorpseFlower",
                                                                       "Chest",
                                                                       new Vector3(1.455F, 2.504F, 0.973F),
                                                                       new Vector3(69.55318F, 0.00001F, 338.7922F),
                                                                       new Vector3(0.87F, 0.87F, 0.87F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SecondarySkillMagazine, "DisplayDoubleMag",
                                                                       "ThighL",
                                                                       new Vector3(-0.476F, 0.201F, 0.028F),
                                                                       new Vector3(30.11958F, 321.4325F, 357.7466F),
                                                                       new Vector3(0.206F, 0.168F, 0.212F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Seed, "DisplaySeed", //don
                                                                       "Chest",
                                                                       new Vector3(-0.135F, 2.276F, -1.207F),
                                                                       new Vector3(318.4842F, 304.6638F, 5.49144F),
                                                                       new Vector3(0.133F, 0.133F, 0.133F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.ShieldOnly,
                ItemDisplays.CreateDisplayRule("DisplayShieldBug",
                                               "Eye1",
                                                                       new Vector3(-0.17F, 0.571F, -0.392F),
                                                                       new Vector3(345.8107F, 93.77663F, 47.13652F),
                                                                       new Vector3(0.428F, -0.428F, 0.428F)),
                ItemDisplays.CreateDisplayRule("DisplayShieldBug",
                                               "Eye1",
                                                                       new Vector3(0.258F, 0.664F, -0.34F),
                                                                       new Vector3(4.33289F, 82.829F, 41.46194F),
                                                                       new Vector3(0.428F, -0.428F, -0.428F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ShinyPearl, "DisplayShinyPearl",
                                                                       "LowerArmL",
                                                                       new Vector3(-0.15F, 1.11F, 0.057F),
                                                                       new Vector3(278.2202F, 291.1136F, 78.58687F),
                                                                       new Vector3(0.241F, 0.241F, 0.241F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.ShockNearby,
                ItemDisplays.CreateDisplayRule("DisplayTeslaCoil",
                                               "Chest",
                                                                       new Vector3(0F, 2.563F, -0.999F),
                                                                       new Vector3(320.309F, 0F, 0F),
                                                                       new Vector3(2.042F, 1.851F, 2.042F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.None)
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SiphonOnLowHealth, "DisplaySiphonOnLowHealth",
                                                                       "ThighL",
                                                                       new Vector3(-0.13F, 0.168F, -0.041F),
                                                                       new Vector3(5.29017F, 21.54024F, 179.3033F),
                                                                       new Vector3(0.102F, 0.102F, 0.103F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SlowOnHit, "DisplayBauble",
                                                                       "UpperArmR",
                                                                       new Vector3(-0.916F, -0.163F, 0.167F),
                                                                       new Vector3(9.50827F, 139.2855F, 151.6732F),
                                                                       new Vector3(-0.88F, -0.88F, -0.88F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.SlowOnHitVoid, "DisplayBaubleVoid",
                                                                       "UpperArmR",
                                                                       new Vector3(0.216F, 0.531F, -0.267F),
                                                                       new Vector3(344.1371F, 238.8591F, 248.579F),
                                                                       new Vector3(1.074F, 1.074F, 1.074F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintArmor, "DisplayBuckler",
                                                                       "LowerArmL",
                                                                       new Vector3(0.316F, 0.972F, 0.009F),
                                                                       new Vector3(0F, 96.12917F, 0F),
                                                                       new Vector3(0.339F, 0.339F, 0.358F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintBonus, "DisplaySoda",
                                                                       "ThighL",
                                                                       new Vector3(-0.535F, -0.118F, 0.051F),
                                                                       new Vector3(83.74255F, 88.08578F, 88.07431F),
                                                                       new Vector3(0.639F, 0.639F, 0.639F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintOutOfCombat, "DisplayWhip",
                                                                       "ThighR",
                                                                       new Vector3(0.367F, 0.345F, 0F),
                                                                       new Vector3(0F, 0F, 166.9113F),
                                                                       new Vector3(0.998F, 0.998F, 0.998F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintWisp, "DisplayBrokenMask",
                                                                       "Eye1",
                                                                       new Vector3(-0.381F, 0.668F, -0.044F),
                                                                       new Vector3(348.4537F, 263.1501F, 22.92627F),
                                                                       new Vector3(0.329F, 0.28F, 0.28F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Squid, "DisplaySquidTurret",
                                                                "Chest",
                                                                       new Vector3(1.21F, 2.893F, 0.344F),
                                                                       new Vector3(15.16477F, 43.819F, 359.8129F),
                                                                       new Vector3(0.11F, 0.11F, 0.11F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.StickyBomb, "DisplayStickyBomb",
                                                                       "ThighR",
                                                                       new Vector3(0.082F, 1.179F, -0.138F),
                                                                       new Vector3(53.5294F, 291.7325F, 209.4936F),
                                                                       new Vector3(0.3F, 0.3F, 0.3F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.StunChanceOnHit, "DisplayStunGrenade",
                                                                       "Spine",
                                                                       new Vector3(0.578F, 0.302F, -0.006F),
                                                                       new Vector3(282.0037F, 338.19F, 287.8869F),
                                                                       new Vector3(0.989F, 0.989F, 0.989F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Syringe, "DisplaySyringeCluster",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.698F, -0.836F),
                                                                       new Vector3(298.1592F, 180F, 180F),
                                                                       new Vector3(0.684F, 0.684F, 0.684F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Talisman, "DisplayTalisman",
                                                                       "Root",
                                                                       new Vector3(-0.625F, 8.454F, -0.813F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.71215F, 0.71215F, 0.71215F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TPHealingNova, "DisplayGlowFlower",
                                                                       "Eye2",
                                                                       new Vector3(0.442F, 0.631F, -0.228F),
                                                                       new Vector3(344.2946F, 125.722F, 200.6264F),
                                                                       new Vector3(0.53F, 0.53F, 0.53F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Thorns, "DisplayRazorwireLeft",
                                                                "UpperArmL",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(3.134F, 3.134F, 3.134F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TitanGoldDuringTP, "DisplayGoldHeart",
                                                                       "UpperArmL",
                                                                       new Vector3(0.058F, 0.443F, -0.531F),
                                                                       new Vector3(0F, 0F, 125.2354F),
                                                                       new Vector3(0.291F, 0.291F, 0.291F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Tooth,
                ItemDisplays.CreateDisplayRule("DisplayToothMeshLarge",
                                               "Chest",
                                                                       new Vector3(0F, 0.176F, 0.601F),
                                                                       new Vector3(0F, 180F, 0F),
                                                                       new Vector3(4.595F, 4.595F, 4.595F)),
                ItemDisplays.CreateDisplayRule("DisplayToothMeshSmall1",
                                               "Chest",
                                                                       new Vector3(0.109F, 0.175F, 0.558F),
                                                                       new Vector3(355.8568F, 31.64545F, 20.10809F),
                                                                       new Vector3(2.583F, 2.583F, 2.583F)),
                ItemDisplays.CreateDisplayRule("DisplayToothMeshSmall2",
                                               "Chest",
                                                                       new Vector3(0.189F, 0.218F, 0.544F),
                                                                       new Vector3(359.6251F, 346.4328F, 30.68613F),
                                                                       new Vector3(2.395F, 2.395F, 2.395F)),
                ItemDisplays.CreateDisplayRule("DisplayToothMeshSmall1",
                                               "Chest",
                                                                       new Vector3(-0.091F, 0.197F, 0.592F),
                                                                       new Vector3(354.2122F, 340.7911F, 346.9413F),
                                                                       new Vector3(2.682F, 2.682F, 2.682F)),
                ItemDisplays.CreateDisplayRule("DisplayToothMeshSmall2",
                                               "Chest",
                                                                       new Vector3(-0.14F, 0.252F, 0.61F),
                                                                       new Vector3(324.9079F, 348.7476F, 320.2073F),
                                                                       new Vector3(2.395F, 2.395F, 2.395F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TreasureCache, "DisplayKey",
                                                                       "ThighR",
                                                                       new Vector3(0.31F, 0.055F, -0.005F),
                                                                       new Vector3(13.68084F, 0.15543F, 265.412F),
                                                                       new Vector3(1.802F, 1.802F, 1.802F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.TreasureCacheVoid, "DisplayKeyVoid",
                                                                       "ThighR",
                                                                       new Vector3(0.332F, 0F, 0F),
                                                                       new Vector3(0F, 0F, 270F),
                                                                       new Vector3(1.333F, 1.333F, 1.333F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.UtilitySkillMagazine,
                ItemDisplays.CreateDisplayRule("DisplayAfterburnerShoulderRing",
                                               "UpperArmR",
                                                                       new Vector3(-0.65F, 0.517F, 0.087F),
                                                                       new Vector3(0F, 0F, 270F),
                                                                       new Vector3(1.513F, 1.513F, 1.513F)),
                ItemDisplays.CreateDisplayRule("DisplayAfterburnerShoulderRing",
                                               "UpperArmL",
                                                                       new Vector3(0.029F, 0.926F, -0.039F),
                                                                       new Vector3(0F, 53.38605F, 90F),
                                                                       new Vector3(1.374F, 1.374F, 1.374F))
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.WarCryOnMultiKill, "DisplayPauldron",
                                                                       "UpperArmL",
                                                                       new Vector3(0.219F, 0.747F, -0.401F),
                                                                       new Vector3(67.26572F, 156.098F, 17.82712F),
                                                                       new Vector3(1.503F, 1.503F, 1.503F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.WardOnLevel, "DisplayWarbanner",
                                                                       "Spine",
                                                                       new Vector3(0.128F, 0.57F, -0.252F),
                                                                       new Vector3(37.50025F, 169.5783F, 259.2919F),
                                                                       new Vector3(1.017F, 1.017F, 1.017F)));
            #endregion items

            #region quips
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.BFG, "DisplayBFG",
                                                                       "Chest",
                                                                       new Vector3(0F, 2.988F, -0.58F),
                                                                       new Vector3(334.191F, 0.00001F, 0F),
                                                                       new Vector3(0.766F, 0.766F, 0.766F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Blackhole, "DisplayGravCube",
                                                                       "Root",
                                                                       new Vector3(-1.88F, 8.019F, -2.692F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.97127F, 0.97127F, 0.97127F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Cleanse, "DisplayWaterPack",
                                                                       "Spine",
                                                                       new Vector3(0.15F, 0.079F, 0.351F),
                                                                       new Vector3(0F, 1.47547F, 16.41561F),
                                                                       new Vector3(0.095F, 0.095F, 0.095F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CommandMissile, "DisplayMissileRack",
                                                                       "Chest",
                                                                       new Vector3(0F, 2.055F, -1.256F),
                                                                       new Vector3(77.61501F, 93.34979F, 269.2482F),
                                                                       new Vector3(1.373F, 1.373F, 1.373F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.BurnNearby, "DisplayPotion",
                                                                       "ThighL",
                                                                       new Vector3(0.046F, 0.066F, -0.138F),
                                                                       new Vector3(8.07462F, 18.28391F, 131.7562F),
                                                                       new Vector3(0.074F, 0.074F, 0.074F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CrippleWard, "DisplayEffigy",
                                                                       "Chest",
                                                                       new Vector3(1.019F, 2.936F, 0.315F),
                                                                       new Vector3(358.3123F, 185.0357F, 9.71317F),
                                                                       new Vector3(1.555F, 1.555F, 1.555F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CritOnUse, "DisplayNeuralImplant",
                                                                       "Eye2",
                                                                       new Vector3(0F, 1.058F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(1.226F, 1.056F, 0.948F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.DeathProjectile, "DisplayDeathProjectile",
                                                                       "Chest",
                                                                       new Vector3(0.041F, 0.249F, 1.047F),
                                                                       new Vector3(5.17213F, 357.8452F, 222.6271F),
                                                                       new Vector3(0.184F, 0.184F, 0.184F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.DroneBackup, "DisplayRadio",
                                                                       "Chest",
                                                                       new Vector3(0.17F, 1.511F, -1.13F),
                                                                       new Vector3(19.93324F, 150.1699F, 353.8893F),
                                                                       new Vector3(1.18F, 1.18F, 1.18F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Equipment.AffixRed,
                ItemDisplays.CreateDisplayRule("DisplayEliteHorn",
                                               "Chest",
                                                                       new Vector3(1.029F, 2.865F, -0.027F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.593F, 0.593F, 0.593F)),
                ItemDisplays.CreateDisplayRule("DisplayEliteHorn",
                                               "Chest",
                                                                       new Vector3(-0.499F, 2.689F, 0.396F),
                                                                       new Vector3(31.83355F, 359.1885F, 358.4617F),
                                                                       new Vector3(-0.518F, 0.518F, 0.518F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixHaunted, "DisplayEliteStealthCrown",
                                                                       "Chest",
                                                                       new Vector3(0F, 3.377F, -0.051F),
                                                                       new Vector3(68.27699F, 0F, 0F),
                                                                       new Vector3(-0.366F, -0.33F, -0.33F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixWhite, "DisplayEliteIceCrown",
                                                                       "Chest",
                                                                       new Vector3(0F, 3.159F, -0.058F),
                                                                       new Vector3(285.7278F, 180F, 180F),
                                                                       new Vector3(0.182F, 0.182F, 0.182F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Equipment.AffixBlue,
                ItemDisplays.CreateDisplayRule("DisplayEliteRhinoHorn",
                                               "Chest",
                                                                       new Vector3(0F, 3.05F, 0.834F),
                                                                       new Vector3(275.2688F, 180F, 180F),
                                                                       new Vector3(1.474F, 1.498F, 1.266F)),
                ItemDisplays.CreateDisplayRule("DisplayEliteRhinoHorn",
                                               "Chest",
                                                                       new Vector3(0F, 2.966F, 0.095F),
                                                                       new Vector3(300.5047F, 180F, 180F),
                                                                       new Vector3(-0.88F, 0.894F, 0.703F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixLunar, "DisplayEliteLunar,Eye",
                                                                       "Chest",
                                                                       new Vector3(0F, 3.353F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(1.374F, 1.276F, 1.374F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixPoison, "DisplayEliteUrchinCrown",
                                                                       "Chest",
                                                                       new Vector3(0F, 2.856F, 0.34F),
                                                                       new Vector3(281.0453F, 0.00003F, 89.99998F),
                                                                       new Vector3(0.309F, 0.309F, 0.309F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.FireBallDash, "DisplayEgg",
                                                                       "Chest",
                                                                       new Vector3(0F, 2.16F, -1.151F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.472F, 0.472F, 0.472F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Fruit, "DisplayFruit",
                                                                       "Chest",
                                                                       new Vector3(-0.341F, 2.037F, -0.469F),
                                                                       new Vector3(357.2344F, 143.4151F, 32.10563F),
                                                                       new Vector3(0.849F, 0.849F, 0.877F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.GainArmor, "DisplayElephantFigure",
                                                                       "Chest",
                                                                       new Vector3(-0.526F, 3.104F, 0.124F),
                                                                       new Vector3(0.49149F, 0F, 15.29472F),
                                                                       new Vector3(1.511F, 1.511F, 1.511F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Gateway, "DisplayVase",
                                                                       "Chest",
                                                                       new Vector3(-0.469F, 2.999F, 0.801F),
                                                                       new Vector3(4.23708F, 284.4304F, 359.9639F),
                                                                       new Vector3(0.275F, 0.275F, 0.275F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.GoldGat, "DisplayGoldGat",
                                                                       "Chest",
                                                                       new Vector3(-0.293F, 3.268F, 1.144F),
                                                                       new Vector3(343.2914F, 69.27016F, 52.77748F),
                                                                       new Vector3(0.213F, 0.213F, 0.213F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Jetpack, "DisplayBugWings",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.954F, -0.832F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.493F, 0.493F, 0.493F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.LifestealOnHit, "DisplayLifestealOnHit",
                                                                       "Chest",
                                                                       new Vector3(-0.007F, 2.693F, -1.341F),
                                                                       new Vector3(14.53486F, 0.70464F, 359.3376F),
                                                                       new Vector3(0.32F, 0.32F, 0.32F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Equipment.Lightning,
                ItemDisplays.CreateDisplayRule("DisplayLightningArmCustom",
                                               "UpperArmR",
                                                                       new Vector3(-0.811F, 0.758F, 0.145F),
                                                                       new Vector3(282.4129F, 2.43764F, 149.6336F),
                                                                       new Vector3(0.831F, 0.831F, 0.831F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.RightArm)
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Meteor, "DisplayMeteor",
                                                                      "Root",
                                                                       new Vector3(0F, 9.26F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(2.3689F, 2.37209F, 2.37209F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.QuestVolatileBattery, "DisplayBatteryArray",
                                                                       "Chest",
                                                                       new Vector3(0.403F, 3.021F, 0.551F),
                                                                       new Vector3(276.5612F, 0.00005F, -0.00004F),
                                                                       new Vector3(0.549F, 0.549F, 0.549F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Recycle, "DisplayRecycler",
                                                                       "Chest",
                                                                       new Vector3(0.057F, 3.101F, 0.171F),
                                                                       new Vector3(0F, 90F, 6.79936F),
                                                                       new Vector3(0.085F, 0.085F, 0.085F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Saw, "DisplaySawmerangFollower",
                                                                       "Root",
                                                                       new Vector3(-3.072F, 2.622F, -0.045F),
                                                                       new Vector3(271.0232F, 185.0242F, 175.0119F),
                                                                       new Vector3(0.141F, 0.141F, 0.141F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Scanner, "DisplayScanner",
                                                                       "Chest",
                                                                       new Vector3(0.83F, 2.736F, 0.481F),
                                                                       new Vector3(295.9275F, 0.00001F, -0.00001F),
                                                                       new Vector3(0.503F, 0.503F, 0.503F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.TeamWarCry, "DisplayTeamWarCry",
                                                                       "Chest",
                                                                       new Vector3(0F, 3.156F, -0.636F),
                                                                       new Vector3(281.8971F, 180F, 180F),
                                                                       new Vector3(0.155F, 0.155F, 0.155F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Tonic, "DisplayTonic",
                                                                       "Chest",
                                                                       new Vector3(0.14F, 0.805F, -0.935F),
                                                                       new Vector3(325.9704F, 327.1277F, 359.8788F),
                                                                       new Vector3(0.269F, 0.269F, 0.269F)));

            #endregion quips

            #region dlc1

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PrimarySkillShuriken, "DisplayShuriken",
                                                                       "LowerArmR",
                                                                       new Vector3(0F, 2.909F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(4.629F, 4.629F, 4.629F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.OutOfCombatArmor, "DisplayOddlyShapedOpal",
                                                                       "Chest",
                                                                       new Vector3(0F, 2.439F, 1.292F),
                                                                       new Vector3(49.57659F, 0F, 0F),
                                                                       new Vector3(0.914F, 0.906F, 0.923F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(DLC1Content.Items.LunarSun,
                ItemDisplays.CreateDisplayRule("DisplaySunHead",
                                               "Eye1",
                                                                       new Vector3(0F, 0.531F, 0.003F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(2.888F, 2.895F, 2.895F)),
                ItemDisplays.CreateDisplayRule("DisplaySunHeadNeck",
                                               "Eye1",
                                                                       new Vector3(0.011F, 0.168F, 0.125F),
                                                                       new Vector3(8.72353F, 128.8626F, 349.3409F),
                                                                       new Vector3(3.7F, 1.988F, -4.149F)),

                ItemDisplays.CreateDisplayRule("DisplaySunHead",
                                               "Eye2",
                                                                       new Vector3(0F, 0.491F, 0.003F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(3.312F, 3.319F, 3.319F)),
                ItemDisplays.CreateDisplayRule("DisplaySunHeadNeck",
                                               "Eye2",
                                                                       new Vector3(0.055F, 0.181F, 0.176F),
                                                                       new Vector3(8.72353F, 128.8626F, 349.3409F),
                                                                       new Vector3(4.434F, 2.382F, -4.972F)),

                ItemDisplays.CreateDisplayRule("DisplaySunHead",
                                               "Eye3",
                                                                       new Vector3(-0.016F, 0.361F, -0.028F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(1.955F, 1.955F, 1.955F)),
                ItemDisplays.CreateDisplayRule("DisplaySunHeadNeck",
                                               "Eye3",
                                                                       new Vector3(-0.081F, 0.151F, 0.053F),
                                                                       new Vector3(1.02483F, 94.19476F, 346.2958F),
                                                                       new Vector3(2.984F, 1.603F, -3.346F)),


                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.Head)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MinorConstructOnKill, "DisplayDefenseNucleus",
                                                                       "Root",
                                                                       new Vector3(-1.294F, 3.352F, -0.607F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.29386F, 0.29386F, 0.29386F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HalfAttackSpeedHalfCooldowns, "DisplayLunarShoulderNature",
                                                                       "Eye2",
                                                                       new Vector3(0F, 0.658F, 0.464F),
                                                                       new Vector3(0F, 90F, 36.93161F),
                                                                       new Vector3(1.275F, 1.275F, 0.909F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HalfSpeedDoubleHealth, "DisplayLunarShoulderStone",
                                                                       "Eye1",
                                                                       new Vector3(0F, 0.649F, -0.317F),
                                                                       new Vector3(0F, 270F, 22.2875F),
                                                                       new Vector3(1.522F, 1.522F, 2.424F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.AttackSpeedAndMoveSpeed, "DisplayCoffee",
                                                                       "Hips",
                                                                       new Vector3(-0.231F, 0.857F, -0.557F),
                                                                       new Vector3(8.38961F, 38.00237F, 356.2532F),
                                                                       new Vector3(0.235F, 0.235F, 0.235F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.GoldOnHurt, "DisplayRollOfPennies",
                                                                       "ThighL",
                                                                       new Vector3(0.413F, 0.365F, -0.053F),
                                                                       new Vector3(0F, 0F, 18.86138F),
                                                                       new Vector3(0.983F, 0.983F, 0.983F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.FragileDamageBonus, "DisplayDelicateWatch",
                                                                       "LowerArmR",
                                                                       new Vector3(0F, 1.808F, 0.255F),
                                                                       new Vector3(85.53652F, 194.046F, 194.0051F),
                                                                       new Vector3(6.135F, 9.068F, 5.459F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ImmuneToDebuff, "DisplayRainCoatBelt",
                                                                       "Hips",
                                                                       new Vector3(0F, 0.772F, 0.025F),
                                                                       new Vector3(355.1231F, 0F, 0F),
                                                                       new Vector3(5.632F, 2.938F, 2.938F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RandomEquipmentTrigger, "DisplayBottledChaos",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.046F, 0.397F),
                                                                       new Vector3(0.70701F, 0F, 0F),
                                                                       new Vector3(0.343F, 0.343F, 0.343F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.StrengthenBurn, "DisplayGasTank",
                                                                       "ThighL",
                                                                       new Vector3(-0.058F, 0.885F, -0.14F),
                                                                       new Vector3(0F, 0F, 180.2308F),
                                                                       new Vector3(0.139F, 0.139F, 0.139F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.VoidMegaCrabItem, "DisplayMegaCrabItem",
                                                                       "Eye3",
                                                                       new Vector3(0F, 0.62F, -0.187F),
                                                                       new Vector3(47.02247F, 0F, 0F),
                                                                       new Vector3(0.145F, 0.145F, 0.145F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RegeneratingScrap, "DisplayRegeneratingScrap",
                                                                       "Chest",
                                                                       new Vector3(-0.486F, 2.958F, -0.728F),
                                                                       new Vector3(40.16991F, 22.44481F, 11.30554F),
                                                                       new Vector3(0.545F, 0.545F, 0.545F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PermanentDebuffOnHit, "DisplayScorpion",
                                                                       "Chest",
                                                                       new Vector3(0F, 2.887F, -0.668F),
                                                                       new Vector3(82.22948F, 0F, 0F),
                                                                       new Vector3(2.344F, 2.344F, 2.344F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CritDamage, "DisplayLaserSight",
                                                                       "Eye1",
                                                                       new Vector3(0.325F, 0.74F, 0F),
                                                                       new Vector3(0F, 0F, 270F),
                                                                       new Vector3(0.089F, 0.089F, 0.089F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.FreeChest, "DisplayShippingRequestForm",
                                                                       "Chest",
                                                                       new Vector3(-0.061F, 0.338F, 0.88F),
                                                                       new Vector3(317.7483F, 306.2836F, 213.6472F),
                                                                       new Vector3(1.087F, 1.09F, 1.087F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoveSpeedOnKill, "DisplayGrappleHook",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 2.084F, -0.114F),
                                                                       new Vector3(0F, 180F, 180F),
                                                                       new Vector3(0.508F, 0.508F, 0.508F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RandomlyLunar, "DisplayDomino",
                                                                       "Root",
                                                                       new Vector3(-0.902F, 3.419F, -1.683F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(1.43943F, 1.43943F, 1.43943F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HealingPotion, "DisplayHealingPotion",
                                                                       "ThighR",
                                                                       new Vector3(0.336F, -0.006F, -0.006F),
                                                                       new Vector3(61.50288F, 295.8233F, 106.3418F),
                                                                       new Vector3(0.063F, 0.063F, 0.063F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoreMissile, "DisplayICBM",
                                                                       "Spine",
                                                                       new Vector3(0.025F, 0.412F, -0.212F),
                                                                       new Vector3(0.97053F, 0F, 346.847F),
                                                                       new Vector3(0.18F, 0.18F, 0.18F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(DLC1Content.Equipment.BossHunter,
                ItemDisplays.CreateDisplayRule("DisplayTricornGhost",
                                               "Eye2",
                                                                       new Vector3(0F, 0.614F, -0.583F),
                                                                       new Vector3(306.7557F, 0F, 0F),
                                                                       new Vector3(1.231F, 1.231F, 1.231F)),
                ItemDisplays.CreateDisplayRule("DisplayBlunderbuss",
                                               "Root",
                                                                       new Vector3(-3.591F, 6.423F, 0.137F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(2.48804F, 2.48804F, 2.48804F))));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.BossHunterConsumed, "DisplayTricornUsed",
                                                                       "Eye2",
                                                                       new Vector3(0F, 0.614F, -0.583F),
                                                                       new Vector3(306.7557F, 0F, 0F),
                                                                       new Vector3(1.231F, 1.231F, 1.231F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.EliteVoidEquipment, "DisplayAffixVoid",
                                                                       "Chest",
                                                                       new Vector3(0.635F, 2.189F, 1.297F),
                                                                       new Vector3(69.83808F, 0F, 0F),
                                                                       new Vector3(0.381F, 0.381F, 0.381F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.GummyClone, "DisplayGummyClone",
                                                                       "Chest",
                                                                       new Vector3(0.028F, 3.037F, 0.823F),
                                                                       new Vector3(63.27668F, 180F, 180F),
                                                                       new Vector3(0.294F, 0.294F, 0.294F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule("IrradiatingLaser", "DisplayIrradiatingLaser",
                                                                       "Chest",
                                                                       new Vector3(0F, 2.972F, 0.373F),
                                                                       new Vector3(0.27596F, 0.00001F, 0F),
                                                                       new Vector3(0.366F, 0.366F, 0.366F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.LunarPortalOnUse, "DisplayLunarPortalOnUse",
                                                                       "Root",
                                                                       new Vector3(0F, 8.716F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(1.44249F, 1.44249F, 1.44249F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.Molotov, "DisplayMolotov",
                                                                       "Chest",
                                                                       new Vector3(-0.1F, 0.978F, -1.047F),
                                                                       new Vector3(358.5333F, 0F, 338.0709F),
                                                                       new Vector3(0.302F, 0.302F, 0.302F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.MultiShopCard, "DisplayExecutiveCard",
                                                                       "Chest",
                                                                       new Vector3(0.097F, 3.207F, -0.486F),
                                                                       new Vector3(339.4911F, 268.3186F, 94.78941F),
                                                                       new Vector3(1.217F, 1.243F, 1.282F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.VendingMachine, "DisplayVendingMachine",
                                                                       "Chest",
                                                                       new Vector3(-0.048F, 2.918F, -0.806F),
                                                                       new Vector3(318.0802F, 185.9435F, 358.7872F),
                                                                       new Vector3(0.658F, 0.658F, 0.658F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Elites.Earth.eliteEquipmentDef, "DisplayEliteMendingAntlers",
                                                                       "Chest",
                                                                       new Vector3(0F, 2.866F, 0.764F),
                                                                       new Vector3(353.4887F, 0F, 0F),
                                                                       new Vector3(3.63F, 3.63F, 3.63F)));

            #endregion

            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("com.KomradeSpectre.Aetherium"))
            {
                //SetAetheriumDisplayRules(itemDisplayRules);
            }

        }


        #region aeth
        /*[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private void SetAetheriumDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.AccursedPotion.instance.ItemDef,
                                                                       Aetherium.Items.AccursedPotion.ItemBodyModelPrefab,
                                                                       "Hips",
                                                                       new Vector3(-0.23261F, 0.51421F, -0.53206F),
                                                                       new Vector3(358.4659F, 3.45783F, 351.5305F),
                                                                       new Vector3(0.06197F, 0.06197F, 0.06197F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.AlienMagnet.instance.ItemDef,
                                                                       Aetherium.Items.AlienMagnet.ItemBodyModelPrefab,
                                                                       "Root",
                                                                       new Vector3(-1.24593F, 3.33102F, -0.67314F),
                                                                       new Vector3(351.4943F, 0F, 0F),
                                                                       new Vector3(0.10931F, 0.10931F, 0.10931F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.BlasterSword.instance.ItemDef,
                                                                       Aetherium.Items.BlasterSword.ItemBodyModelPrefab,
                                                                       "Chest",
                                                                       new Vector3(0F, 3.26094F, 0.157F),
                                                                       new Vector3(352.6502F, 123.7769F, 10.8277F),
                                                                       new Vector3(0.23491F, 0.23491F, 0.23491F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.BloodthirstyShield.instance.ItemDef,
                                                                       Aetherium.Items.BloodthirstyShield.ItemBodyModelPrefab,
                                                                       "LowerArmL",
                                                                       new Vector3(0.35107F, 1.59512F, 0.02125F),
                                                                       new Vector3(355.6207F, 89.20272F, 351.4718F),
                                                                       new Vector3(0.18505F, 0.18505F, 0.18505F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.EngineersToolbelt.instance.ItemDef,
                                                                       Aetherium.Items.EngineersToolbelt.ItemBodyModelPrefab,
                                                                       "Spine",
                                                                       new Vector3(-0.00021F, 0.21362F, -0.09102F),
                                                                       new Vector3(6.90201F, 0F, 0F),
                                                                       new Vector3(0.63999F, 0.54277F, 0.48588F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.FeatheredPlume.instance.ItemDef,
                                                                       Aetherium.Items.FeatheredPlume.ItemBodyModelPrefab,
                                                                       "UpperArmL",
                                                                       new Vector3(0.32071F, 0.1289F, -0.45445F),
                                                                       new Vector3(44.31231F, 289.3011F, 194.5541F),
                                                                       new Vector3(0.25964F, 0.18505F, 0.23623F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.Voidheart.instance.ItemDef,
                                                                       Aetherium.Items.Voidheart.ItemBodyModelPrefab,
                                                                       "Chest",
                                                                       new Vector3(-1.61634F, 3.19549F, 0.11845F),
                                                                       new Vector3(336.6419F, 256.0048F, 330.6313F),
                                                                       new Vector3(0.34265F, 0.34265F, 0.34265F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.InspiringDrone.instance.ItemDef,
                                                                       Aetherium.Items.InspiringDrone.ItemBodyModelPrefab,
                                                                       "Root",
                                                                       new Vector3(0.52308F, 8.63635F, 1.7789F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.16571F, 0.16571F, 0.16571F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.NailBomb.instance.ItemDef,
                                                                       Aetherium.Items.NailBomb.ItemBodyModelPrefab,
                                                                       "Hips",
                                                                       new Vector3(0.50161F, 0.83585F, 0.34956F),
                                                                       new Vector3(53.64922F, 6.29286F, 356.1477F),
                                                                       new Vector3(0.09878F, 0.09878F, 0.09878F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.SharkTeeth.instance.ItemDef,
                                                                       Aetherium.Items.SharkTeeth.ItemBodyModelPrefab,
                                                                       "CalfR",
                                                                       new Vector3(0.00621F, 0.17859F, 0.0036F),
                                                                       new Vector3(309.5345F, 32.43342F, 147.9259F),
                                                                       new Vector3(0.23023F, 0.23313F, 0.17482F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.ShieldingCore.instance.ItemDef,
                                                                       Aetherium.Items.ShieldingCore.ItemBodyModelPrefab,
                                                                       "Chest",
                                                                       new Vector3(0.2458F, 0.44185F, -0.63871F),
                                                                       new Vector3(306.4525F, 212.377F, 128.4635F),
                                                                       new Vector3(0.68418F, 0.68418F, 0.68418F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.UnstableDesign.instance.ItemDef,
                                                                       Aetherium.Items.UnstableDesign.ItemBodyModelPrefab,
                                                                       "Chest",
                                                                       new Vector3(-0.16735F, 0.09988F, -0.36508F),
                                                                       new Vector3(359.5522F, 55.52745F, 0.37526F),
                                                                       new Vector3(0.88639F, 0.88639F, 0.88639F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.WeightedAnklet.instance.ItemDef,
                                                                       Aetherium.Items.WeightedAnklet.ItemBodyModelPrefab,
                                                                       "CalfL",
                                                                       new Vector3(0.02532F, 0.77459F, 0.05282F),
                                                                       new Vector3(353.1609F, 358.681F, 7.31593F),
                                                                       new Vector3(0.74539F, 0.57649F, 0.67819F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(Aetherium.Items.WitchesRing.instance.ItemDef,
                ItemDisplays.CreateDisplayRule(Aetherium.Items.WitchesRing.ItemBodyModelPrefab,
                                               "UpperArmR",
                                                                       new Vector3(0.00004F, 1.77161F, -0.00001F),
                                                                       new Vector3(0F, 275.3768F, 0F),
                                                                       new Vector3(2.96412F, 3.22034F, 2.96412F)),
                ItemDisplays.CreateDisplayRule(Aetherium.Items.WitchesRing.CircleBodyModelPrefab,
                                               "UpperArmR",
                                                                       new Vector3(-0.92427F, 1.75431F, 0.11382F),
                                                                       new Vector3(356.4313F, 270.2026F, 86.74802F),
                                                                       new Vector3(2.54049F, 2.54049F, 0.14675F))
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.ZenithAccelerator.instance.ItemDef,
                                                                       Aetherium.Items.ZenithAccelerator.ItemBodyModelPrefab,
                                                                       "Chest",
                                                                       new Vector3(-0.02144F, 3.36076F, -0.34862F),
                                                                       new Vector3(0F, 0F, 4.77517F),
                                                                       new Vector3(0.52945F, 0.52945F, 0.52945F)));
        }*/
        #endregion aeth
    }
}
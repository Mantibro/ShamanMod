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
                                                                       new Vector3(-0.02407F, 0.02185F, 0.00849F),
                                                                       new Vector3(285.0947F, 328.6408F, 350.1125F),
                                                                       new Vector3(0.00858F, 0.00858F, 0.00858F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ArmorPlate, "DisplayRepulsionArmorPlate",
                                                                       "UpperArmL",
                                                                       new Vector3(0.00387F, 0.0013F, -0.00168F),
                                                                       new Vector3(90F, 280.2563F, 0F),
                                                                       new Vector3(0.00853F, 0.00467F, 0.00735F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.ArmorReductionOnHit,
                ItemDisplays.CreateDisplayRule("DisplayWarhammer",
                                               "Spine",
                                                                       new Vector3(0.00548F, 0.00601F, -0.00315F),
                                                                       new Vector3(1.69786F, 86.60026F, 91.39961F),
                                                                       new Vector3(0.00473F, 0.00473F, 0.00473F))));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AttackSpeedOnCrit, "DisplayWolfPelt",
                                                                       "Eye1",
                                                                       new Vector3(0.00077F, 0.00611F, -0.00224F),
                                                                       new Vector3(288.4954F, 173.9509F, 176.0275F),
                                                                       new Vector3(0.01788F, 0.01223F, 0.01223F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AutoCastEquipment, "DisplayFossil",
                                                                       "Chest",
                                                                       new Vector3(0.01052F, 0.01525F, 0.01273F),
                                                                       new Vector3(22.30449F, 105.8541F, 17.78504F),
                                                                       new Vector3(0.01939F, 0.01939F, 0.01939F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Bandolier, "DisplayBandolier",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.0001F, -0.00177F),
                                                                       new Vector3(278.6648F, 0F, 90F),
                                                                       new Vector3(0.01332F, 0.01584F, 0.0241F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnKill, "DisplayBrooch",
                                                                       "Chest",
                                                                       new Vector3(0.00794F, 0.00497F, 0.01649F),
                                                                       new Vector3(80.07203F, 0F, 0F),
                                                                       new Vector3(0.01072F, 0.00919F, 0.00919F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnOverHeal, "DisplayAegis",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.01123F, 0.00266F),
                                                                       new Vector3(90F, 180F, 0F),
                                                                       new Vector3(0.00725F, 0.00725F, 0.00725F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Bear, "DisplayBear",
                                                                       "Chest",
                                                                       new Vector3(0.00094F, 0.00256F, 0.01161F),
                                                                       new Vector3(31.4944F, 10.23464F, 11.85665F),
                                                                       new Vector3(0.00346F, 0.00357F, 0.00357F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.BearVoid, "DisplayBearVoid",
                                                                       "Chest",
                                                                       new Vector3(0.00085F, 0.00217F, 0.0118F),
                                                                       new Vector3(20.06796F, 13.30229F, 18.20955F),
                                                                       new Vector3(0.00347F, 0.00347F, 0.00347F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BeetleGland, "DisplayBeetleGland",
                                                                       "Chest",
                                                                       new Vector3(-0.01891F, 0.03335F, 0.00154F),
                                                                       new Vector3(0F, 0F, 280.2594F),
                                                                       new Vector3(0.00323F, 0.00323F, 0.00323F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Behemoth,
                ItemDisplays.CreateDisplayRule("DisplayBehemoth",
                                               "UpperArmL",
                                                                       new Vector3(0.00629F, 0.00163F, 0.00183F),
                                                                       new Vector3(359.5844F, 85.59161F, 354.625F),
                                                                       new Vector3(0.001F, 0.001F, 0.001F))));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.BleedOnHit,
                ItemDisplays.CreateDisplayRule("DisplayTriTip",
                                               "Chest",
                                                                       new Vector3(-0.00124F, 0.03141F, 0.00468F),
                                                                       new Vector3(280.8553F, 180F, 180F),
                                                                       new Vector3(0.01664F, 0.01664F, 0.0197F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(DLC1Content.Items.BleedOnHitVoid,
                ItemDisplays.CreateDisplayRule("DisplayTriTipVoid",
                                               "Chest",
                                                                       new Vector3(0.00353F, 0.03099F, 0.00517F),
                                                                       new Vector3(304.272F, 134.9929F, 219.5764F),
                                                                       new Vector3(0.00678F, 0.00678F, 0.00803F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BleedOnHitAndExplode, "DisplayBleedOnHitAndExplode",
                                                                       "Chest",
                                                                       new Vector3(-0.00958F, 0.02599F, 0.01571F),
                                                                       new Vector3(20.89036F, 338.1264F, 296.4275F),
                                                                       new Vector3(0.00115F, 0.00127F, 0.00115F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BonusGoldPackOnKill, "DisplayTome",
                                                                       "ThighL",
                                                                       new Vector3(-0.00503F, 0.00282F, 0.00115F),
                                                                       new Vector3(9.22191F, 77.22878F, 356.7291F),
                                                                       new Vector3(0.00127F, 0.00127F, 0.00127F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BossDamageBonus, "DisplayAPRound",
                                                                       "Spine",
                                                                       new Vector3(0.00281F, 0.00085F, 0.00378F),
                                                                       new Vector3(80.79362F, 20.23978F, 167.7541F),
                                                                       new Vector3(0.007F, 0.007F, 0.007F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BounceNearby, "DisplayHook",
                                                                       "Chest",
                                                                       new Vector3(0.00422F, 0.02877F, 0.00888F),
                                                                       new Vector3(359.116F, 180F, 209.1495F),
                                                                       new Vector3(-0.01196F, -0.01196F, -0.01196F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ChainLightning, "DisplayUkulele",
                                                                       "Chest",
                                                                       new Vector3(0.00243F, 0.02068F, -0.01137F),
                                                                       new Vector3(359.6609F, 149.0193F, 170.173F),
                                                                       new Vector3(0.00725F, 0.00688F, 0.00699F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ChainLightningVoid, "DisplayUkuleleVoid",
                                                                       "Chest",
                                                                       new Vector3(0.00186F, 0.01449F, -0.01147F),
                                                                       new Vector3(8.33601F, 162.0218F, 189.5914F),
                                                                       new Vector3(0.00783F, 0.00744F, 0.00755F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Clover, "DisplayClover",
                                                                       "Chest",
                                                                       new Vector3(0.01057F, 0.02343F, 0.01234F),
                                                                       new Vector3(17.08605F, 293.8966F, 273.6263F),
                                                                       new Vector3(0.00595F, 0.00595F, 0.00593F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CloverVoid, "DisplayCloverVoid",
                                                                       "Chest",
                                                                       new Vector3(0.01057F, 0.02343F, 0.01234F),
                                                                       new Vector3(17.08605F, 293.8966F, 273.6263F),
                                                                       new Vector3(0.00595F, 0.00595F, 0.00593F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(JunkContent.Items.CooldownOnCrit,
                ItemDisplays.CreateDisplayRule("DisplaySkull",
                                               "Eye1",
                                                                       new Vector3(0F, 0.00778F, -0.00335F),
                                                                       new Vector3(27.78193F, 180F, 180F),
                                                                       new Vector3(0.00327F, 0.00327F, 0.00327F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.Head)
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.CritGlasses, "DisplayGlasses",
                                                                       "Eye3",
                                                                       new Vector3(0F, 0.00649F, 0.00017F),
                                                                       new Vector3(270F, 0.00001F, 0F),
                                                                       new Vector3(0.00403F, 0.00305F, 0.00793F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CritGlassesVoid, "DisplayGlassesVoid",
                                                                       "Eye3",
                                                                       new Vector3(0F, 0.00649F, -0.00025F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.00551F, 0.00567F, 0.00791F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Crowbar, "DisplayCrowbar",
                                                                       "Chest",
                                                                       new Vector3(-0.00732F, 0.0269F, -0.01139F),
                                                                       new Vector3(12.76912F, 141.1832F, 299.6208F),
                                                                       new Vector3(0.00834F, 0.00834F, 0.00834F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Dagger, "DisplayDagger",
                                                                       "Chest",
                                                                       new Vector3(0.00783F, 0.02542F, 0.00911F),
                                                                       new Vector3(356.0795F, 8.14295F, 53.11333F),
                                                                       new Vector3(0.01839F, 0.01839F, 0.01839F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.DeathMark, "DisplayDeathMark",
                                                                       "HandL",
                                                                       new Vector3(0F, 0.00172F, 0.00154F),
                                                                       new Vector3(45.38486F, 358.5659F, 178.989F),
                                                                       new Vector3(0.00045F, 0.00045F, 0.00045F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.EnergizedOnEquipmentUse, "DisplayWarHorn",
                                                                       "Chest",
                                                                       new Vector3(-0.00039F, 0.00402F, -0.00525F),
                                                                       new Vector3(11.66601F, 0F, 8.8871F),
                                                                       new Vector3(0.01594F, 0.01594F, 0.01594F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.EquipmentMagazine, "DisplayBattery",
                                                                       "Hips",
                                                                       new Vector3(0.00062F, 0.00827F, -0.0056F),
                                                                       new Vector3(0F, 270F, 0F),
                                                                       new Vector3(0.00204F, 0.00204F, 0.00204F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.EquipmentMagazineVoid, "DisplayFuelCellVoid",
                                                                       "Hips",
                                                                       new Vector3(0F, 0.0073F, -0.00573F),
                                                                       new Vector3(90F, 89.99999F, 0F),
                                                                       new Vector3(0.00285F, 0.00285F, 0.00285F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExecuteLowHealthElite, "DisplayGuillotine",
                                                                       "LowerArmL",
                                                                       new Vector3(0.00015F, 0.01482F, 0.00167F),
                                                                       new Vector3(42.92809F, 180.5273F, 270.7742F),
                                                                       new Vector3(0.00288F, 0.00288F, 0.00284F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExplodeOnDeath, "DisplayWilloWisp",
                                                                       "Chest",
                                                                       new Vector3(-0.00836F, 0.0018F, -0.00445F),
                                                                       new Vector3(7.67746F, 325.9193F, 47.46843F),
                                                                       new Vector3(0.00088F, 0.00088F, 0.00088F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ExplodeOnDeathVoid, "DisplayWillowWispVoid",
                                                                       "Chest",
                                                                       new Vector3(-0.00602F, 0.00068F, -0.00438F),
                                                                       new Vector3(341.1968F, 347.5622F, 24.27017F),
                                                                       new Vector3(0.00067F, 0.00067F, 0.00067F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExtraLife, "DisplayHippo",
                                                                       "Chest",
                                                                       new Vector3(0.00821F, 0.00761F, 0.01227F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00482F, 0.00495F, 0.00495F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ExtraLifeVoid, "DisplayHippoVoid",
                                                                       "Chest",
                                                                       new Vector3(0.00836F, 0.00573F, 0.01297F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00409F, 0.00422F, 0.00422F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.FallBoots,
                ItemDisplays.CreateDisplayRule("DisplayGravBoots",
                                               "CalfL",
                                                                       new Vector3(0F, 0.01059F, 0.00043F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00612F, 0.00612F, 0.00612F)),
                ItemDisplays.CreateDisplayRule("DisplayGravBoots",
                                               "CalfR",
                                                                       new Vector3(0F, 0.01218F, 0.00032F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00413F, 0.00413F, 0.00413F)
                )));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Feather,
                ItemDisplays.CreateDisplayRule("DisplayFeather",
                                               "Chest",
                                                                       new Vector3(0.00076F, 0.02058F, -0.00984F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(-0.00171F, 0.00102F, 0.00102F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FireballsOnHit, "DisplayFireballsOnHit",
                                                                       "Chest",
                                                                       new Vector3(-0.00026F, 0.03406F, -0.00711F),
                                                                       new Vector3(284.2644F, 178.6002F, 340.0135F),
                                                                       new Vector3(0.00242F, 0.00277F, 0.0023F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FireRing, "DisplayFireRing",
                                                                       "LowerArmL",
                                                                       new Vector3(0.00027F, 0.02171F, -0.00095F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.01735F, 0.01735F, 0.01735F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.IceRing, "DisplayIceRing",
                                                                       "LowerArmL",
                                                                       new Vector3(0.00012F, 0.02005F, 0.00034F),
                                                                       new Vector3(78.20138F, 54.06792F, 55.86569F),
                                                                       new Vector3(0.01119F, 0.01119F, 0.01119F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ElementalRingVoid, "DisplayVoidRing",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.01177F, 0F),
                                                                       new Vector3(270F, 136.8969F, 0F),
                                                                       new Vector3(0.01547F, 0.01547F, 0.01325F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Firework, "DisplayFirework",
                                                                       "Chest",
                                                                       new Vector3(-0.01481F, 0.02925F, -0.00268F),
                                                                       new Vector3(316.392F, 241.8502F, 127.8034F),
                                                                       new Vector3(0.00745F, 0.00745F, 0.00745F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FlatHealth, "DisplaySteakCurved",
                                                                       "Eye1",
                                                                       new Vector3(0F, 0.00546F, -0.00457F),
                                                                       new Vector3(17.20867F, 180F, 180F),
                                                                       new Vector3(0.00197F, 0.00197F, 0.00197F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FocusConvergence, "DisplayFocusedConvergence",
                                                                       "Root",
                                                                       new Vector3(-0.02391F, 0.08383F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.05F, 0.05F, 0.05F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.GhostOnKill, "DisplayMask",
                                                                       "UpperArmL",
                                                                       new Vector3(0.00344F, 0.0005F, -0.00157F),
                                                                       new Vector3(352.714F, 127.0883F, 180F),
                                                                       new Vector3(0.00798F, 0.00798F, 0.00615F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.GoldOnHit, "DisplayBoneCrown",
                                                                       "Eye2",
                                                                       new Vector3(0F, 0.00795F, -0.00001F),
                                                                       new Vector3(0F, 180F, 0F),
                                                                       new Vector3(0.02551F, 0.02213F, 0.02213F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HeadHunter, "DisplaySkullCrown",
                                                                       "Eye3",
                                                                       new Vector3(-0.00006F, 0.00689F, 0F),
                                                                       new Vector3(359.9472F, 173.7351F, 179.5188F),
                                                                       new Vector3(0.00629F, 0.00227F, 0.00227F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HealOnCrit, "DisplayScythe",
                                                                       "LowerArmL",
                                                                       new Vector3(0.00342F, 0.01235F, 0.00049F),
                                                                       new Vector3(273.6758F, 270F, 0F),
                                                                       new Vector3(0.00474F, 0.00474F, 0.00474F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HealWhileSafe, "DisplaySnail",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00504F, -0.00714F),
                                                                       new Vector3(301.7467F, 180F, 180F),
                                                                       new Vector3(0.00156F, 0.00156F, 0.00156F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Hoof,
                ItemDisplays.CreateDisplayRule("DisplayHoof",
                                               "CalfR",
                                                                       new Vector3(0.00039F, 0.0091F, -0.00034F),
                                                                       new Vector3(79.93876F, 359.8341F, 6.88061F),
                                                                       new Vector3(0.00234F, 0.00222F, 0.00208F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.RightCalf)
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Icicle, "DisplayFrostRelic",
                                                                       "Root",
                                                                       new Vector3(0.03693F, 0.06569F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(2.54082F, 2.54082F, 2.54082F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.IgniteOnKill, "DisplayGasoline",
                                                                       "Spine",
                                                                       new Vector3(-0.00196F, 0.00255F, -0.00376F),
                                                                       new Vector3(300.99F, 30.69935F, 209.3635F),
                                                                       new Vector3(0.00654F, 0.00654F, 0.00654F)));
            //hello
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.IncreaseHealing,
                ItemDisplays.CreateDisplayRule("DisplayAntler",
                                               "Eye1",
                                                                       new Vector3(0.00301F, 0.0055F, 0.00015F),
                                                                       new Vector3(353.9438F, 81.39288F, 300.5692F),
                                                                       new Vector3(0.00957F, 0.00957F, 0.00957F)),
                ItemDisplays.CreateDisplayRule("DisplayAntler",
                                               "Eye1",
                                                                       new Vector3(-0.00307F, 0.00526F, -0.00079F),
                                                                       new Vector3(356.1463F, 266.133F, 47.10715F),
                                                                       new Vector3(-0.00897F, 0.00774F, 0.00782F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(JunkContent.Items.Incubator, "DisplayAncestralIncubator",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00445F, -0.00644F),
                                                                       new Vector3(291.1831F, 0F, 0F),
                                                                       new Vector3(0.00071F, 0.00071F, 0.00071F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Infusion, "DisplayInfusion",
                                                                       "Spine",
                                                                       new Vector3(-0.00242F, 0.00137F, 0.00306F),
                                                                       new Vector3(7.2393F, 148.6312F, 15.16809F),
                                                                       new Vector3(0.01286F, 0.01286F, 0.01297F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.JumpBoost, "DisplayWaxBird",
                                                                       "Eye3",
                                                                       new Vector3(0F, 0.00386F, 0.0015F),
                                                                       new Vector3(271.6526F, 0F, 0F),
                                                                       new Vector3(0.00701F, 0.00701F, 0.00701F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.KillEliteFrenzy, "DisplayBrainstalk",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.02274F, 0.0044F),
                                                                       new Vector3(13.85592F, 0F, 0F),
                                                                       new Vector3(0.0134F, 0.01897F, 0.01331F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Knurl, "DisplayKnurl",
                                                                       "UpperArmR",
                                                                       new Vector3(-0.0043F, 0.0038F, -0.00362F),
                                                                       new Vector3(35.00983F, 249.0631F, 196.2022F),
                                                                       new Vector3(0.00331F, 0.00331F, 0.00331F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LaserTurbine, "DisplayLaserTurbine",
                                                                       "UpperArmR",
                                                                       new Vector3(-0.00346F, 0.0048F, 0.00595F),
                                                                       new Vector3(358.0021F, 312.3606F, 96.76483F),
                                                                       new Vector3(0.00462F, 0.00462F, 0.00462F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LightningStrikeOnHit, "DisplayChargedPerforator",
                                                                       "Chest",
                                                                       new Vector3(0.0097F, 0.0321F, -0.00421F),
                                                                       new Vector3(322.0188F, 301.867F, 179.463F),
                                                                       new Vector3(0.05521F, 0.05521F, 0.05521F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarDagger, "DisplayLunarDagger",
                                                                       "Spine",
                                                                       new Vector3(-0.0006F, 0.00244F, 0.00745F),
                                                                       new Vector3(36.18383F, 188.3709F, 283.9954F),
                                                                       new Vector3(0.0194F, 0.02001F, 0.0194F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarPrimaryReplacement, "DisplayBirdEye",
                                                                       "Eye2",
                                                                       new Vector3(0F, 0.00414F, 0F),
                                                                       new Vector3(0F, 180F, 180F),
                                                                       new Vector3(0.02875F, 0.02875F, 0.02875F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarSecondaryReplacement, "DisplayBirdClaw",
                                                                       "LowerArmL",
                                                                       new Vector3(-0.00014F, 0.01948F, -0.00106F),
                                                                       new Vector3(0F, 277.3215F, 29.31899F),
                                                                       new Vector3(0.0171F, 0.0171F, 0.0171F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarSpecialReplacement, "DisplayBirdHeart",
                                                                       "Root",
                                                                       new Vector3(0.02557F, 0.09304F, -0.00351F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.90171F, 0.90171F, 0.90171F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarTrinket, "DisplayBeads",
                                                                       "Chest",
                                                                       new Vector3(0.00007F, 0.00257F, 0.00976F),
                                                                       new Vector3(337.1407F, 33.15829F, 120.7352F),
                                                                       new Vector3(0.016F, 0.016F, 0.016F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarUtilityReplacement, "DisplayBirdFoot",
                                                                       "CalfR",
                                                                       new Vector3(-0.00029F, 0.00417F, -0.0012F),
                                                                       new Vector3(357.8506F, 98.42979F, 271.0889F),
                                                                       new Vector3(0.01242F, 0.01242F, 0.01242F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Medkit, "DisplayMedkit",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.00623F, -0.00196F),
                                                                       new Vector3(270F, 180F, 0F),
                                                                       new Vector3(0.00824F, 0.00824F, 0.00824F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Missile, "DisplayMissileLauncher",
                                                                       "Chest",
                                                                       new Vector3(-0.01508F, 0.01915F, -0.01034F),
                                                                       new Vector3(332.239F, 313.7123F, 92.96133F),
                                                                       new Vector3(0.00184F, 0.00184F, 0.00184F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MissileVoid, "DisplayMissileLauncherVoid",
                                                                       "Chest",
                                                                       new Vector3(-0.01786F, 0.02014F, -0.00551F),
                                                                       new Vector3(339.358F, 333.265F, 84.6225F),
                                                                       new Vector3(0.00147F, 0.00147F, 0.00147F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.MonstersOnShrineUse, "DisplayMonstersOnShrineUse",
                                                                       "Spine",
                                                                       new Vector3(-0.00279F, 0.00532F, -0.00357F),
                                                                       new Vector3(53.0141F, 127.0394F, 22.71369F),
                                                                       new Vector3(0.00105F, 0.00105F, 0.00105F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Mushroom, "DisplayMushroom",
                                                                       "Chest",
                                                                       new Vector3(0.00095F, 0.02992F, 0.00066F),
                                                                       new Vector3(8.17051F, 0F, 0F),
                                                                       new Vector3(0.00423F, 0.00423F, 0.00423F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MushroomVoid, "DisplayMushroomVoid",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.02924F, 0.0013F),
                                                                       new Vector3(3.40732F, 0F, 0F),
                                                                       new Vector3(0.00245F, 0.00245F, 0.00245F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.NearbyDamageBonus, "DisplayDiamond",
                                                                       "LowerArmL",
                                                                       new Vector3(0.00078F, 0.02245F, -0.00069F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00331F, 0.00331F, 0.00331F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.NovaOnHeal,
                ItemDisplays.CreateDisplayRule("DisplayDevilHorns",
                                               "Eye3",
                                                                       new Vector3(0.00146F, 0.00442F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00891F, 0.00891F, -0.00921F)),
                ItemDisplays.CreateDisplayRule("DisplayDevilHorns",
                                               "Eye3",
                                                                       new Vector3(-0.00148F, 0.00432F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(-0.00891F, 0.00891F, -0.00921F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.NovaOnLowHealth, "DisplayJellyGuts",
                                                                       "Chest",
                                                                       new Vector3(-0.00473F, 0.02659F, 0.01083F),
                                                                       new Vector3(349.0874F, 0F, 0F),
                                                                       new Vector3(0.00313F, 0.00313F, 0.00313F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ParentEgg, "DisplayParentEgg",
                                                                       "Chest",
                                                                       new Vector3(0.00377F, 0.03288F, 0.00237F),
                                                                       new Vector3(282.6532F, 0.00002F, 280.2806F),
                                                                       new Vector3(0.00254F, 0.00254F, 0.00254F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Pearl, "DisplayPearl",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.00852F, 0F),
                                                                       new Vector3(270F, 0.00001F, 0F),
                                                                       new Vector3(0.00198F, 0.00198F, 0.00198F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.PersonalShield, "DisplayShieldGenerator",
                                                                       "LowerArmR",
                                                                       new Vector3(-0.00055F, 0.02052F, 0.00628F),
                                                                       new Vector3(90F, 188.5162F, 0F),
                                                                       new Vector3(0.00452F, 0.00452F, 0.00452F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Phasing, "DisplayStealthkit",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.00727F, 0.00524F),
                                                                       new Vector3(282.3932F, 0.00001F, 0F),
                                                                       new Vector3(0.00658F, 0.007F, 0.007F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Plant, "DisplayInterstellarDeskPlant",
                                                                       "UpperArmL",
                                                                       new Vector3(-0.00006F, 0.00975F, -0.00415F),
                                                                       new Vector3(345.1604F, 180F, 180F),
                                                                       new Vector3(0.00129F, 0.00128F, 0.00128F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.RandomDamageZone, "DisplayRandomDamageZone",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.03317F, -0.00479F),
                                                                       new Vector3(50.08339F, 0F, 0F),
                                                                       new Vector3(0.00298F, 0.00388F, 0.00388F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.RepeatHeal, "DisplayCorpseFlower",
                                                                       "Chest",
                                                                       new Vector3(0.01455F, 0.02504F, 0.00973F),
                                                                       new Vector3(69.55318F, 0.00001F, 338.7922F),
                                                                       new Vector3(0.0087F, 0.0087F, 0.0087F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SecondarySkillMagazine, "DisplayDoubleMag",
                                                                       "ThighL",
                                                                       new Vector3(-0.00476F, 0.00201F, 0.00028F),
                                                                       new Vector3(30.11958F, 321.4325F, 357.7466F),
                                                                       new Vector3(0.00206F, 0.00168F, 0.00212F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Seed, "DisplaySeed", //don
                                                                       "Chest",
                                                                       new Vector3(-0.00135F, 0.02276F, -0.01207F),
                                                                       new Vector3(318.4842F, 304.6638F, 5.49144F),
                                                                       new Vector3(0.00133F, 0.00133F, 0.00133F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.ShieldOnly,
                ItemDisplays.CreateDisplayRule("DisplayShieldBug",
                                               "Eye1",
                                                                       new Vector3(-0.0017F, 0.00571F, -0.00392F),
                                                                       new Vector3(345.8107F, 93.77663F, 47.13652F),
                                                                       new Vector3(0.00428F, -0.00428F, 0.00428F)),
                ItemDisplays.CreateDisplayRule("DisplayShieldBug",
                                               "Eye1",
                                                                       new Vector3(0.00258F, 0.00664F, -0.0034F),
                                                                       new Vector3(4.33289F, 82.829F, 41.46194F),
                                                                       new Vector3(0.00428F, -0.00428F, -0.00428F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ShinyPearl, "DisplayShinyPearl",
                                                                       "LowerArmL",
                                                                       new Vector3(-0.0015F, 0.0111F, 0.00057F),
                                                                       new Vector3(278.2202F, 291.1136F, 78.58687F),
                                                                       new Vector3(0.00241F, 0.00241F, 0.00241F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.ShockNearby,
                ItemDisplays.CreateDisplayRule("DisplayTeslaCoil",
                                               "Chest",
                                                                       new Vector3(0F, 0.02563F, -0.00999F),
                                                                       new Vector3(320.309F, 0F, 0F),
                                                                       new Vector3(0.02042F, 0.01851F, 0.02042F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.None)
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SiphonOnLowHealth, "DisplaySiphonOnLowHealth",
                                                                       "ThighL",
                                                                       new Vector3(-0.0013F, 0.00168F, -0.00041F),
                                                                       new Vector3(5.29017F, 21.54024F, 179.3033F),
                                                                       new Vector3(0.00102F, 0.00102F, 0.00103F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SlowOnHit, "DisplayBauble",
                                                                       "UpperArmR",
                                                                       new Vector3(-0.00916F, -0.00163F, 0.00167F),
                                                                       new Vector3(9.50827F, 139.2855F, 151.6732F),
                                                                       new Vector3(-0.0088F, -0.0088F, -0.0088F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.SlowOnHitVoid, "DisplayBaubleVoid",
                                                                       "UpperArmR",
                                                                       new Vector3(0.00216F, 0.00531F, -0.00267F),
                                                                       new Vector3(344.1371F, 238.8591F, 248.579F),
                                                                       new Vector3(0.01074F, 0.01074F, 0.01074F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintArmor, "DisplayBuckler",
                                                                       "LowerArmL",
                                                                       new Vector3(0.00316F, 0.00972F, 0.00009F),
                                                                       new Vector3(0F, 96.12917F, 0F),
                                                                       new Vector3(0.00339F, 0.00339F, 0.00358F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintBonus, "DisplaySoda",
                                                                       "ThighL",
                                                                       new Vector3(-0.00535F, -0.00118F, 0.00051F),
                                                                       new Vector3(83.74255F, 88.08578F, 88.07431F),
                                                                       new Vector3(0.00639F, 0.00639F, 0.00639F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintOutOfCombat, "DisplayWhip",
                                                                       "ThighR",
                                                                       new Vector3(0.00367F, 0.00345F, 0F),
                                                                       new Vector3(0F, 0F, 166.9113F),
                                                                       new Vector3(0.00998F, 0.00998F, 0.00998F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintWisp, "DisplayBrokenMask",
                                                                       "Eye1",
                                                                       new Vector3(-0.00381F, 0.00668F, -0.00044F),
                                                                       new Vector3(348.4537F, 263.1501F, 22.92627F),
                                                                       new Vector3(0.00329F, 0.0028F, 0.0028F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Squid, "DisplaySquidTurret",
                                                                "Chest",
                                                                       new Vector3(0.0121F, 0.02893F, 0.00344F),
                                                                       new Vector3(15.16477F, 43.819F, 359.8129F),
                                                                       new Vector3(0.0011F, 0.0011F, 0.0011F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.StickyBomb, "DisplayStickyBomb",
                                                                       "ThighR",
                                                                       new Vector3(0.00082F, 0.01179F, -0.00138F),
                                                                       new Vector3(53.5294F, 291.7325F, 209.4936F),
                                                                       new Vector3(0.003F, 0.003F, 0.003F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.StunChanceOnHit, "DisplayStunGrenade",
                                                                       "Spine",
                                                                       new Vector3(0.00578F, 0.00302F, -0.00006F),
                                                                       new Vector3(282.0037F, 338.19F, 287.8869F),
                                                                       new Vector3(0.00989F, 0.00989F, 0.00989F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Syringe, "DisplaySyringeCluster",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00698F, -0.00836F),
                                                                       new Vector3(298.1592F, 180F, 180F),
                                                                       new Vector3(0.00684F, 0.00684F, 0.00684F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Talisman, "DisplayTalisman",
                                                                       "Root",
                                                                       new Vector3(-0.00625F, 0.08454F, -0.00813F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.71215F, 0.71215F, 0.71215F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TPHealingNova, "DisplayGlowFlower",
                                                                       "Eye2",
                                                                       new Vector3(0.00442F, 0.00631F, -0.00228F),
                                                                       new Vector3(344.2946F, 125.722F, 200.6264F),
                                                                       new Vector3(0.0053F, 0.0053F, 0.0053F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Thorns, "DisplayRazorwireLeft",
                                                                "UpperArmL",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.03134F, 0.03134F, 0.03134F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TitanGoldDuringTP, "DisplayGoldHeart",
                                                                       "UpperArmL",
                                                                       new Vector3(0.00058F, 0.00443F, -0.00531F),
                                                                       new Vector3(0F, 0F, 125.2354F),
                                                                       new Vector3(0.00291F, 0.00291F, 0.00291F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Tooth,
                ItemDisplays.CreateDisplayRule("DisplayToothMeshLarge",
                                               "Chest",
                                                                       new Vector3(0F, 0.00176F, 0.00601F),
                                                                       new Vector3(0F, 180F, 0F),
                                                                       new Vector3(0.04595F, 0.04595F, 0.04595F)),
                ItemDisplays.CreateDisplayRule("DisplayToothMeshSmall1",
                                               "Chest",
                                                                       new Vector3(0.00109F, 0.00175F, 0.00558F),
                                                                       new Vector3(355.8568F, 31.64545F, 20.10809F),
                                                                       new Vector3(0.02583F, 0.02583F, 0.02583F)),
                ItemDisplays.CreateDisplayRule("DisplayToothMeshSmall2",
                                               "Chest",
                                                                       new Vector3(0.00189F, 0.00218F, 0.00544F),
                                                                       new Vector3(359.6251F, 346.4328F, 30.68613F),
                                                                       new Vector3(0.02395F, 0.02395F, 0.02395F)),
                ItemDisplays.CreateDisplayRule("DisplayToothMeshSmall1",
                                               "Chest",
                                                                       new Vector3(-0.00091F, 0.00197F, 0.00592F),
                                                                       new Vector3(354.2122F, 340.7911F, 346.9413F),
                                                                       new Vector3(0.02682F, 0.02682F, 0.02682F)),
                ItemDisplays.CreateDisplayRule("DisplayToothMeshSmall2",
                                               "Chest",
                                                                       new Vector3(-0.0014F, 0.00252F, 0.0061F),
                                                                       new Vector3(324.9079F, 348.7476F, 320.2073F),
                                                                       new Vector3(0.02395F, 0.02395F, 0.02395F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TreasureCache, "DisplayKey",
                                                                       "ThighR",
                                                                       new Vector3(0.0031F, 0.00055F, -0.00005F),
                                                                       new Vector3(13.68084F, 0.15543F, 265.412F),
                                                                       new Vector3(0.01802F, 0.01802F, 0.01802F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.TreasureCacheVoid, "DisplayKeyVoid",
                                                                       "ThighR",
                                                                       new Vector3(0.00332F, 0F, 0F),
                                                                       new Vector3(0F, 0F, 270F),
                                                                       new Vector3(0.01333F, 0.01333F, 0.01333F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.UtilitySkillMagazine,
                ItemDisplays.CreateDisplayRule("DisplayAfterburnerShoulderRing",
                                               "UpperArmR",
                                                                       new Vector3(-0.0065F, 0.00517F, 0.00087F),
                                                                       new Vector3(0F, 0F, 270F),
                                                                       new Vector3(0.01513F, 0.01513F, 0.01513F)),
                ItemDisplays.CreateDisplayRule("DisplayAfterburnerShoulderRing",
                                               "UpperArmL",
                                                                       new Vector3(0.00029F, 0.00926F, -0.00039F),
                                                                       new Vector3(0F, 53.38605F, 90F),
                                                                       new Vector3(0.01374F, 0.01374F, 0.01374F))
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.WarCryOnMultiKill, "DisplayPauldron",
                                                                       "UpperArmL",
                                                                       new Vector3(0.00219F, 0.00747F, -0.00401F),
                                                                       new Vector3(67.26572F, 156.098F, 17.82712F),
                                                                       new Vector3(0.01503F, 0.01503F, 0.01503F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.WardOnLevel, "DisplayWarbanner",
                                                                       "Spine",
                                                                       new Vector3(0.00128F, 0.0057F, -0.00252F),
                                                                       new Vector3(37.50025F, 169.5783F, 259.2919F),
                                                                       new Vector3(0.01017F, 0.01017F, 0.01017F)));
            #endregion items

            #region quips
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.BFG, "DisplayBFG",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.02988F, -0.0058F),
                                                                       new Vector3(334.191F, 0.00001F, 0F),
                                                                       new Vector3(0.00766F, 0.00766F, 0.00766F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Blackhole, "DisplayGravCube",
                                                                       "Root",
                                                                       new Vector3(-0.0188F, 0.08019F, -0.02692F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.97127F, 0.97127F, 0.97127F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Cleanse, "DisplayWaterPack",
                                                                       "Spine",
                                                                       new Vector3(0.0015F, 0.00079F, 0.00351F),
                                                                       new Vector3(0F, 1.47547F, 16.41561F),
                                                                       new Vector3(0.00095F, 0.00095F, 0.00095F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CommandMissile, "DisplayMissileRack",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.02055F, -0.01256F),
                                                                       new Vector3(77.61501F, 93.34979F, 269.2482F),
                                                                       new Vector3(0.01373F, 0.01373F, 0.01373F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.BurnNearby, "DisplayPotion",
                                                                       "ThighL",
                                                                       new Vector3(0.00046F, 0.00066F, -0.00138F),
                                                                       new Vector3(8.07462F, 18.28391F, 131.7562F),
                                                                       new Vector3(0.00074F, 0.00074F, 0.00074F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CrippleWard, "DisplayEffigy",
                                                                       "Chest",
                                                                       new Vector3(0.01019F, 0.02936F, 0.00315F),
                                                                       new Vector3(358.3123F, 185.0357F, 9.71317F),
                                                                       new Vector3(0.01555F, 0.01555F, 0.01555F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CritOnUse, "DisplayNeuralImplant",
                                                                       "Eye2",
                                                                       new Vector3(0F, 0.01058F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.01226F, 0.01056F, 0.00948F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.DeathProjectile, "DisplayDeathProjectile",
                                                                       "Chest",
                                                                       new Vector3(0.00041F, 0.00249F, 0.01047F),
                                                                       new Vector3(5.17213F, 357.8452F, 222.6271F),
                                                                       new Vector3(0.00184F, 0.00184F, 0.00184F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.DroneBackup, "DisplayRadio",
                                                                       "Chest",
                                                                       new Vector3(0.0017F, 0.01511F, -0.0113F),
                                                                       new Vector3(19.93324F, 150.1699F, 353.8893F),
                                                                       new Vector3(0.0118F, 0.0118F, 0.0118F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Equipment.AffixRed,
                ItemDisplays.CreateDisplayRule("DisplayEliteHorn",
                                               "Chest",
                                                                       new Vector3(0.01029F, 0.02865F, -0.00027F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00593F, 0.00593F, 0.00593F)),
                ItemDisplays.CreateDisplayRule("DisplayEliteHorn",
                                               "Chest",
                                                                       new Vector3(-0.00499F, 0.02689F, 0.00396F),
                                                                       new Vector3(31.83355F, 359.1885F, 358.4617F),
                                                                       new Vector3(-0.00518F, 0.00518F, 0.00518F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixHaunted, "DisplayEliteStealthCrown",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.03377F, -0.00051F),
                                                                       new Vector3(68.27699F, 0F, 0F),
                                                                       new Vector3(-0.00366F, -0.0033F, -0.0033F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixWhite, "DisplayEliteIceCrown",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.03159F, -0.00058F),
                                                                       new Vector3(285.7278F, 180F, 180F),
                                                                       new Vector3(0.00182F, 0.00182F, 0.00182F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Equipment.AffixBlue,
                ItemDisplays.CreateDisplayRule("DisplayEliteRhinoHorn",
                                               "Chest",
                                                                       new Vector3(0F, 0.0305F, 0.00834F),
                                                                       new Vector3(275.2688F, 180F, 180F),
                                                                       new Vector3(0.01474F, 0.01498F, 0.01266F)),
                ItemDisplays.CreateDisplayRule("DisplayEliteRhinoHorn",
                                               "Chest",
                                                                       new Vector3(0F, 0.02966F, 0.00095F),
                                                                       new Vector3(300.5047F, 180F, 180F),
                                                                       new Vector3(-0.0088F, 0.00894F, 0.00703F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixLunar, "DisplayEliteLunar,Eye",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.03353F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.01374F, 0.01276F, 0.01374F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixPoison, "DisplayEliteUrchinCrown",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.02856F, 0.0034F),
                                                                       new Vector3(281.0453F, 0.00003F, 89.99998F),
                                                                       new Vector3(0.00309F, 0.00309F, 0.00309F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.FireBallDash, "DisplayEgg",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.0216F, -0.01151F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.00472F, 0.00472F, 0.00472F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Fruit, "DisplayFruit",
                                                                       "Chest",
                                                                       new Vector3(-0.00341F, 0.02037F, -0.00469F),
                                                                       new Vector3(357.2344F, 143.4151F, 32.10563F),
                                                                       new Vector3(0.00849F, 0.00849F, 0.00877F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.GainArmor, "DisplayElephantFigure",
                                                                       "Chest",
                                                                       new Vector3(-0.00526F, 0.03104F, 0.00124F),
                                                                       new Vector3(0.49149F, 0F, 15.29472F),
                                                                       new Vector3(0.01511F, 0.01511F, 0.01511F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Gateway, "DisplayVase",
                                                                       "Chest",
                                                                       new Vector3(-0.00469F, 0.02999F, 0.00801F),
                                                                       new Vector3(4.23708F, 284.4304F, 359.9639F),
                                                                       new Vector3(0.00275F, 0.00275F, 0.00275F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.GoldGat, "DisplayGoldGat",
                                                                       "Chest",
                                                                       new Vector3(-0.00293F, 0.03268F, 0.01144F),
                                                                       new Vector3(343.2914F, 69.27016F, 52.77748F),
                                                                       new Vector3(0.00213F, 0.00213F, 0.00213F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Jetpack, "DisplayBugWings",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00954F, -0.00832F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00493F, 0.00493F, 0.00493F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.LifestealOnHit, "DisplayLifestealOnHit",
                                                                       "Chest",
                                                                       new Vector3(-0.00007F, 0.02693F, -0.01341F),
                                                                       new Vector3(14.53486F, 0.70464F, 359.3376F),
                                                                       new Vector3(0.0032F, 0.0032F, 0.0032F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Equipment.Lightning,
                ItemDisplays.CreateDisplayRule("DisplayLightningArmCustom",
                                               "UpperArmR",
                                                                       new Vector3(-0.00811F, 0.00758F, 0.00145F),
                                                                       new Vector3(282.4129F, 2.43764F, 149.6336F),
                                                                       new Vector3(0.00831F, 0.00831F, 0.00831F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.RightArm)
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Meteor, "DisplayMeteor",
                                                                      "Root",
                                                                       new Vector3(0F, 0.0926F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(2.3689F, 2.37209F, 2.37209F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.QuestVolatileBattery, "DisplayBatteryArray",
                                                                       "Chest",
                                                                       new Vector3(0.00403F, 0.03021F, 0.00551F),
                                                                       new Vector3(276.5612F, 0.00005F, -0.00004F),
                                                                       new Vector3(0.00549F, 0.00549F, 0.00549F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Recycle, "DisplayRecycler",
                                                                       "Chest",
                                                                       new Vector3(0.00057F, 0.03101F, 0.00171F),
                                                                       new Vector3(0F, 90F, 6.79936F),
                                                                       new Vector3(0.00085F, 0.00085F, 0.00085F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Saw, "DisplaySawmerangFollower",
                                                                       "Root",
                                                                       new Vector3(-0.03072F, 0.02622F, -0.00045F),
                                                                       new Vector3(271.0232F, 185.0242F, 175.0119F),
                                                                       new Vector3(0.00141F, 0.00141F, 0.00141F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Scanner, "DisplayScanner",
                                                                       "Chest",
                                                                       new Vector3(0.0083F, 0.02736F, 0.00481F),
                                                                       new Vector3(295.9275F, 0.00001F, -0.00001F),
                                                                       new Vector3(0.00503F, 0.00503F, 0.00503F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.TeamWarCry, "DisplayTeamWarCry",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.03156F, -0.00636F),
                                                                       new Vector3(281.8971F, 180F, 180F),
                                                                       new Vector3(0.00155F, 0.00155F, 0.00155F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Tonic, "DisplayTonic",
                                                                       "Chest",
                                                                       new Vector3(0.0014F, 0.00805F, -0.00935F),
                                                                       new Vector3(325.9704F, 327.1277F, 359.8788F),
                                                                       new Vector3(0.00269F, 0.00269F, 0.00269F)));

            #endregion quips

            #region dlc1

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PrimarySkillShuriken, "DisplayShuriken",
                                                                       "LowerArmR",
                                                                       new Vector3(0F, 0.02909F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.04629F, 0.04629F, 0.04629F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.OutOfCombatArmor, "DisplayOddlyShapedOpal",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.02439F, 0.01292F),
                                                                       new Vector3(49.57659F, 0F, 0F),
                                                                       new Vector3(0.00914F, 0.00906F, 0.00923F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(DLC1Content.Items.LunarSun,
                ItemDisplays.CreateDisplayRule("DisplaySunHead",
                                               "Eye1",
                                                                       new Vector3(0F, 0.00531F, 0.00003F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.02888F, 0.02895F, 0.02895F)),
                ItemDisplays.CreateDisplayRule("DisplaySunHeadNeck",
                                               "Eye1",
                                                                       new Vector3(0.00011F, 0.00168F, 0.00125F),
                                                                       new Vector3(8.72353F, 128.8626F, 349.3409F),
                                                                       new Vector3(0.037F, 0.01988F, -0.04149F)),

                ItemDisplays.CreateDisplayRule("DisplaySunHead",
                                               "Eye2",
                                                                       new Vector3(0F, 0.00491F, 0.00003F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.03312F, 0.03319F, 0.03319F)),
                ItemDisplays.CreateDisplayRule("DisplaySunHeadNeck",
                                               "Eye2",
                                                                       new Vector3(0.00055F, 0.00181F, 0.00176F),
                                                                       new Vector3(8.72353F, 128.8626F, 349.3409F),
                                                                       new Vector3(0.04434F, 0.02382F, -0.04972F)),

                ItemDisplays.CreateDisplayRule("DisplaySunHead",
                                               "Eye3",
                                                                       new Vector3(-0.00016F, 0.00361F, -0.00028F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.01955F, 0.01955F, 0.01955F)),
                ItemDisplays.CreateDisplayRule("DisplaySunHeadNeck",
                                               "Eye3",
                                                                       new Vector3(-0.00081F, 0.00151F, 0.00053F),
                                                                       new Vector3(1.02483F, 94.19476F, 346.2958F),
                                                                       new Vector3(0.02984F, 0.01603F, -0.03346F)),


                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.Head)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MinorConstructOnKill, "DisplayDefenseNucleus",
                                                                       "Root",
                                                                       new Vector3(-0.01294F, 0.03352F, -0.00607F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.29386F, 0.29386F, 0.29386F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HalfAttackSpeedHalfCooldowns, "DisplayLunarShoulderNature",
                                                                       "Eye2",
                                                                       new Vector3(0F, 0.00658F, 0.00464F),
                                                                       new Vector3(0F, 90F, 36.93161F),
                                                                       new Vector3(0.01275F, 0.01275F, 0.00909F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HalfSpeedDoubleHealth, "DisplayLunarShoulderStone",
                                                                       "Eye1",
                                                                       new Vector3(0F, 0.00649F, -0.00317F),
                                                                       new Vector3(0F, 270F, 22.2875F),
                                                                       new Vector3(0.01522F, 0.01522F, 0.02424F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.AttackSpeedAndMoveSpeed, "DisplayCoffee",
                                                                       "Hips",
                                                                       new Vector3(-0.00231F, 0.00857F, -0.00557F),
                                                                       new Vector3(8.38961F, 38.00237F, 356.2532F),
                                                                       new Vector3(0.00235F, 0.00235F, 0.00235F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.GoldOnHurt, "DisplayRollOfPennies",
                                                                       "ThighL",
                                                                       new Vector3(0.00413F, 0.00365F, -0.00053F),
                                                                       new Vector3(0F, 0F, 18.86138F),
                                                                       new Vector3(0.00983F, 0.00983F, 0.00983F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.FragileDamageBonus, "DisplayDelicateWatch",
                                                                       "LowerArmR",
                                                                       new Vector3(0F, 0.01808F, 0.00255F),
                                                                       new Vector3(85.53652F, 194.046F, 194.0051F),
                                                                       new Vector3(0.06135F, 0.09068F, 0.05459F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ImmuneToDebuff, "DisplayRainCoatBelt",
                                                                       "Hips",
                                                                       new Vector3(0F, 0.00772F, 0.00025F),
                                                                       new Vector3(355.1231F, 0F, 0F),
                                                                       new Vector3(0.05632F, 0.02938F, 0.02938F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RandomEquipmentTrigger, "DisplayBottledChaos",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.00046F, 0.00397F),
                                                                       new Vector3(0.70701F, 0F, 0F),
                                                                       new Vector3(0.00343F, 0.00343F, 0.00343F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.StrengthenBurn, "DisplayGasTank",
                                                                       "ThighL",
                                                                       new Vector3(-0.00058F, 0.00885F, -0.0014F),
                                                                       new Vector3(0F, 0F, 180.2308F),
                                                                       new Vector3(0.00139F, 0.00139F, 0.00139F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.VoidMegaCrabItem, "DisplayMegaCrabItem",
                                                                       "Eye3",
                                                                       new Vector3(0F, 0.0062F, -0.00187F),
                                                                       new Vector3(47.02247F, 0F, 0F),
                                                                       new Vector3(0.00145F, 0.00145F, 0.00145F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RegeneratingScrap, "DisplayRegeneratingScrap",
                                                                       "Chest",
                                                                       new Vector3(-0.00486F, 0.02958F, -0.00728F),
                                                                       new Vector3(40.16991F, 22.44481F, 11.30554F),
                                                                       new Vector3(0.00545F, 0.00545F, 0.00545F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PermanentDebuffOnHit, "DisplayScorpion",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.02887F, -0.00668F),
                                                                       new Vector3(82.22948F, 0F, 0F),
                                                                       new Vector3(0.02344F, 0.02344F, 0.02344F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CritDamage, "DisplayLaserSight",
                                                                       "Eye1",
                                                                       new Vector3(0.00325F, 0.0074F, 0F),
                                                                       new Vector3(0F, 0F, 270F),
                                                                       new Vector3(0.00089F, 0.00089F, 0.00089F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.FreeChest, "DisplayShippingRequestForm",
                                                                       "Chest",
                                                                       new Vector3(-0.00061F, 0.00338F, 0.0088F),
                                                                       new Vector3(317.7483F, 306.2836F, 213.6472F),
                                                                       new Vector3(0.01087F, 0.0109F, 0.01087F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoveSpeedOnKill, "DisplayGrappleHook",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.02084F, -0.00114F),
                                                                       new Vector3(0F, 180F, 180F),
                                                                       new Vector3(0.00508F, 0.00508F, 0.00508F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RandomlyLunar, "DisplayDomino",
                                                                       "Root",
                                                                       new Vector3(-0.00902F, 0.03419F, -0.01683F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(1.43943F, 1.43943F, 1.43943F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HealingPotion, "DisplayHealingPotion",
                                                                       "ThighR",
                                                                       new Vector3(0.00336F, -0.00006F, -0.00006F),
                                                                       new Vector3(61.50288F, 295.8233F, 106.3418F),
                                                                       new Vector3(0.00063F, 0.00063F, 0.00063F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoreMissile, "DisplayICBM",
                                                                       "Spine",
                                                                       new Vector3(0.00025F, 0.00412F, -0.00212F),
                                                                       new Vector3(0.97053F, 0F, 346.847F),
                                                                       new Vector3(0.0018F, 0.0018F, 0.0018F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(DLC1Content.Equipment.BossHunter,
                ItemDisplays.CreateDisplayRule("DisplayTricornGhost",
                                               "Eye2",
                                                                       new Vector3(0F, 0.00614F, -0.00583F),
                                                                       new Vector3(306.7557F, 0F, 0F),
                                                                       new Vector3(0.01231F, 0.01231F, 0.01231F)),
                ItemDisplays.CreateDisplayRule("DisplayBlunderbuss",
                                               "Root",
                                                                       new Vector3(-0.03591F, 0.06423F, 0.00137F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(2.48804F, 2.48804F, 2.48804F))));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.BossHunterConsumed, "DisplayTricornUsed",
                                                                       "Eye2",
                                                                       new Vector3(0F, 0.00614F, -0.00583F),
                                                                       new Vector3(306.7557F, 0F, 0F),
                                                                       new Vector3(0.01231F, 0.01231F, 0.01231F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.EliteVoidEquipment, "DisplayAffixVoid",
                                                                       "Chest",
                                                                       new Vector3(0.00635F, 0.02189F, 0.01297F),
                                                                       new Vector3(69.83808F, 0F, 0F),
                                                                       new Vector3(0.00381F, 0.00381F, 0.00381F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.GummyClone, "DisplayGummyClone",
                                                                       "Chest",
                                                                       new Vector3(0.00028F, 0.03037F, 0.00823F),
                                                                       new Vector3(63.27668F, 180F, 180F),
                                                                       new Vector3(0.00294F, 0.00294F, 0.00294F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule("IrradiatingLaser", "DisplayIrradiatingLaser",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.02972F, 0.00373F),
                                                                       new Vector3(0.27596F, 0.00001F, 0F),
                                                                       new Vector3(0.00366F, 0.00366F, 0.00366F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.LunarPortalOnUse, "DisplayLunarPortalOnUse",
                                                                       "Root",
                                                                       new Vector3(0F, 0.08716F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(1.44249F, 1.44249F, 1.44249F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.Molotov, "DisplayMolotov",
                                                                       "Chest",
                                                                       new Vector3(-0.001F, 0.00978F, -0.01047F),
                                                                       new Vector3(358.5333F, 0F, 338.0709F),
                                                                       new Vector3(0.00302F, 0.00302F, 0.00302F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.MultiShopCard, "DisplayExecutiveCard",
                                                                       "Chest",
                                                                       new Vector3(0.00097F, 0.03207F, -0.00486F),
                                                                       new Vector3(339.4911F, 268.3186F, 94.78941F),
                                                                       new Vector3(0.01217F, 0.01243F, 0.01282F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.VendingMachine, "DisplayVendingMachine",
                                                                       "Chest",
                                                                       new Vector3(-0.00048F, 0.02918F, -0.00806F),
                                                                       new Vector3(318.0802F, 185.9435F, 358.7872F),
                                                                       new Vector3(0.00658F, 0.00658F, 0.00658F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Elites.Earth.eliteEquipmentDef, "DisplayEliteMendingAntlers",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.02866F, 0.00764F),
                                                                       new Vector3(353.4887F, 0F, 0F),
                                                                       new Vector3(0.0363F, 0.0363F, 0.0363F)));

            #endregion

        }
    }
}
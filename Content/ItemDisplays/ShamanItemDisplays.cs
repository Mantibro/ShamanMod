using RoR2;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ShamanMod.Modules.Characters
{
    internal class ShamanItemDisplays : ItemDisplaysBase
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
                                                                       "Staff",
                                                                       new Vector3(0.00002F, 0.01131F, -0.00256F),
                                                                       new Vector3(295.4775F, 271.1627F, 356.0796F),
                                                                       new Vector3(0.00858F, 0.00858F, 0.00858F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ArmorPlate, "DisplayRepulsionArmorPlate",
                                                                       "UpperArmR",
                                                                       new Vector3(0.00026F, 0.0013F, 0.00056F),
                                                                       new Vector3(78.74375F, 270F, 89.99999F),
                                                                       new Vector3(0.00405F, 0.00435F, 0.00349F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.ArmorReductionOnHit,
                ItemDisplays.CreateDisplayRule("DisplayWarhammer",
                                               "Spine",
                                                                       new Vector3(0.00159F, 0.00126F, -0.00141F),
                                                                       new Vector3(331.8564F, 85.81026F, 91.58662F),
                                                                       new Vector3(0.00187F, 0.00187F, 0.00187F))));//hammer
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AttackSpeedOnCrit, "DisplayWolfPelt",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00261F, 0.00054F),
                                                                       new Vector3(336.6781F, 359.9765F, 0.11483F),
                                                                       new Vector3(0.00731F, 0.00637F, 0.00637F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AutoCastEquipment, "DisplayFossil",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00007F, -0.00193F),
                                                                       new Vector3(0F, 270F, 17.75658F),
                                                                       new Vector3(0.00784F, 0.00784F, 0.00784F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Bandolier, "DisplayBandolier",
                                                                       "Hips",
                                                                       new Vector3(0F, 0.00066F, -0.00028F),
                                                                       new Vector3(270F, 90F, 0F),
                                                                       new Vector3(0.0034F, 0.00424F, 0.00615F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnKill, "DisplayBrooch",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00164F, 0.00185F),
                                                                       new Vector3(80.07203F, 0F, 0F),
                                                                       new Vector3(0.00628F, 0.00539F, 0.00539F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnOverHeal, "DisplayAegis",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.00239F, 0.00081F),
                                                                       new Vector3(82.10845F, 180F, 0F),
                                                                       new Vector3(0.00206F, 0.00206F, 0.00206F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Bear, "DisplayBear",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.00085F, 0.00063F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00199F, 0.00199F, 0.00199F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.BearVoid, "DisplayBearVoid",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.00096F, 0.00059F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00197F, 0.00197F, 0.00197F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BeetleGland, "DisplayBeetleGland",
                                                                       "Staff",
                                                                       new Vector3(0F, 0.00527F, 0F),
                                                                       new Vector3(299.3822F, 0F, 0F),
                                                                       new Vector3(0.00118F, 0.00118F, 0.00118F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Behemoth,
                ItemDisplays.CreateDisplayRule("DisplayBehemoth",
                                               "Spine",
                                                                       new Vector3(-0.00061F, 0.00021F, -0.00177F),
                                                                       new Vector3(276.8044F, 179.9999F, 270.9254F),
                                                                       new Vector3(0.00049F, 0.00049F, 0.00049F))));
 
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.BleedOnHit,
                ItemDisplays.CreateDisplayRule("DisplayTriTip",
                                               "Chest",
                                                                       new Vector3(-0.00042F, 0.00196F, -0.00229F),
                                                                       new Vector3(312.364F, 251.8789F, 98.84457F),
                                                                       new Vector3(0.00537F, 0.00537F, 0.00636F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(DLC1Content.Items.BleedOnHitVoid,
                ItemDisplays.CreateDisplayRule("DisplayTriTipVoid",
                                               "Head",
                                                                       new Vector3(0F, 0.00334F, -0.00014F),
                                                                       new Vector3(309.7547F, 180F, 180F),
                                                                       new Vector3(0.0044F, 0.0044F, 0.00521F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BleedOnHitAndExplode, "DisplayBleedOnHitAndExplode",
                                                                       "Spine",
                                                                       new Vector3(-0.00122F, 0.00079F, 0.00017F),
                                                                       new Vector3(339.2223F, 212.0563F, 249.7049F),
                                                                       new Vector3(0.00049F, 0.00049F, 0.00049F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BonusGoldPackOnKill, "DisplayTome",
                                                                       "Hips",
                                                                       new Vector3(0.0022F, 0.00054F, -0.00001F),
                                                                       new Vector3(0F, 264.1379F, 0F),
                                                                       new Vector3(0.00078F, 0.00078F, 0.00078F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BossDamageBonus, "DisplayAPRound",
                                                                       "Chest",
                                                                       new Vector3(-0.0014F, 0.00005F, 0.00164F),
                                                                       new Vector3(63.5081F, 268.9081F, 286.1247F),
                                                                       new Vector3(0.007F, 0.007F, 0.007F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BounceNearby, "DisplayHook",
                                                                       "Chest",
                                                                       new Vector3(0.00324F, 0.00246F, -0.00178F),
                                                                       new Vector3(37.56657F, 150.0612F, 160.6522F),
                                                                       new Vector3(-0.00397F, -0.00397F, -0.00397F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ChainLightning, "DisplayUkulele",
                                                                       "Chest",
                                                                       new Vector3(0.00042F, 0.0004F, -0.00217F),
                                                                       new Vector3(359.3017F, 180F, 145.2479F),
                                                                       new Vector3(0.00725F, 0.00688F, 0.00699F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ChainLightningVoid, "DisplayUkuleleVoid",
                                                                       "Chest",
                                                                       new Vector3(0.00024F, 0.00062F, -0.00205F),
                                                                       new Vector3(2.57437F, 180.3139F, 156.2212F),
                                                                       new Vector3(0.00783F, 0.00744F, 0.00755F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Clover, "DisplayClover",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00249F, 0.00418F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00595F, 0.00595F, 0.00593F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CloverVoid, "DisplayCloverVoid",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00242F, 0.00427F),
                                                                       new Vector3(15.61712F, 0F, 0F),
                                                                       new Vector3(0.00659F, 0.00659F, 0.00659F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(JunkContent.Items.CooldownOnCrit,
                ItemDisplays.CreateDisplayRule("DisplaySkull",
                                               "Head",
                                                                       new Vector3(0F, 0.00343F, 0.00046F),
                                                                       new Vector3(305.9099F, 180F, 180F),
                                                                       new Vector3(0.00285F, 0.00285F, 0.00285F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.Head)
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.CritGlasses, "DisplayGlasses",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00253F, 0.00187F),
                                                                       new Vector3(346.041F, 0.00001F, 0F),
                                                                       new Vector3(0.00383F, 0.00127F, 0.00375F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CritGlassesVoid, "DisplayGlassesVoid",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00115F, 0.00193F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00289F, 0.00297F, 0.00415F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Crowbar, "DisplayCrowbar",
                                                                       "Chest",
                                                                       new Vector3(-0.00036F, 0.00108F, -0.00206F),
                                                                       new Vector3(48.24174F, 90F, 0F),
                                                                       new Vector3(0.00498F, 0.00498F, 0.00498F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Dagger, "DisplayDagger",
                                                                       "Chest",
                                                                       new Vector3(0.00014F, 0.0011F, -0.00126F),
                                                                       new Vector3(287.0031F, 138.7832F, 291.8255F),
                                                                       new Vector3(0.01003F, 0.01003F, 0.01003F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.DeathMark, "DisplayDeathMark",
                                                                       "HandL",
                                                                       new Vector3(0.00001F, 0.00102F, -0.00017F),
                                                                       new Vector3(80.2933F, 355.1307F, 175.7849F),
                                                                       new Vector3(0.00034F, 0.00034F, 0.00034F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.EnergizedOnEquipmentUse, "DisplayWarHorn",
                                                                       "Spine",
                                                                       new Vector3(0.00046F, 0.00116F, -0.00151F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00565F, 0.00565F, 0.00565F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.EquipmentMagazine, "DisplayBattery",
                                                                       "Hips",
                                                                       new Vector3(0.00062F, 0.00068F, -0.00158F),
                                                                       new Vector3(0F, 270F, 0F),
                                                                       new Vector3(0.00204F, 0.00204F, 0.00204F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.EquipmentMagazineVoid, "DisplayFuelCellVoid",
                                                                       "Hips",
                                                                       new Vector3(0F, 0.00071F, -0.00144F),
                                                                       new Vector3(90F, 89.99999F, 0F),
                                                                       new Vector3(0.00285F, 0.00285F, 0.00285F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExecuteLowHealthElite, "DisplayGuillotine",
                                                                       "Head",
                                                                       new Vector3(0.00003F, 0.00269F, 0.00356F),
                                                                       new Vector3(88.4026F, 339.2228F, 69.21539F),
                                                                       new Vector3(0.00118F, 0.00118F, 0.00116F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExplodeOnDeath, "DisplayWilloWisp",
                                                                       "Chest",
                                                                       new Vector3(-0.00565F, 0.00385F, -0.00068F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00052F, 0.00052F, 0.00052F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ExplodeOnDeathVoid, "DisplayWillowWispVoid",
                                                                       "Chest",
                                                                       new Vector3(-0.00657F, 0.00383F, -0.00065F),
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
                                               "Hips",
                                                                       new Vector3(-0.00259F, -0.00029F, 0F),
                                                                       new Vector3(0F, 0F, 247.3832F),
                                                                       new Vector3(0.00251F, 0.00251F, 0.00251F)),
                ItemDisplays.CreateDisplayRule("DisplayGravBoots",
                                               "Hips",
                                                                       new Vector3(0.0027F, -0.00033F, 0F),
                                                                       new Vector3(0F, 180F, 245.1566F),
                                                                       new Vector3(0.00251F, 0.00251F, 0.00251F)
                )));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Feather,
                ItemDisplays.CreateDisplayRule("DisplayFeather",
                                               "Chest",
                                                                       new Vector3(0.00102F, 0.00018F, -0.00169F),
                                                                       new Vector3(282.1741F, 180F, 180F),
                                                                       new Vector3(-0.00065F, 0.00039F, 0.00038F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FireballsOnHit, "DisplayFireballsOnHit",
                                                                       "Chest",
                                                                       new Vector3(0.00395F, 0.003F, -0.0006F),
                                                                       new Vector3(327.7166F, 91.96867F, 0.41358F),
                                                                       new Vector3(0.00069F, 0.00079F, 0.00065F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FireRing, "DisplayFireRing",
                                                                       "HandL",
                                                                       new Vector3(0.00008F, 0.00029F, -0.00008F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.00307F, 0.00307F, 0.00307F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.IceRing, "DisplayIceRing",
                                                                       "HandR",
                                                                       new Vector3(-0.00003F, 0.00089F, -0.00005F),
                                                                       new Vector3(78.20138F, 54.06792F, 55.86569F),
                                                                       new Vector3(0.00351F, 0.00351F, 0.00351F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ElementalRingVoid, "DisplayVoidRing",
                                                                       "HandL",
                                                                       new Vector3(0.00005F, 0.00121F, 0.00002F),
                                                                       new Vector3(270F, 136.8969F, 0F),
                                                                       new Vector3(0.00308F, 0.00308F, 0.00264F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Firework, "DisplayFirework",
                                                                       "Chest",
                                                                       new Vector3(-0.00216F, 0.00309F, -0.00215F),
                                                                       new Vector3(316.392F, 241.8502F, 127.8034F),
                                                                       new Vector3(0.00361F, 0.00361F, 0.00361F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FlatHealth, "DisplaySteakCurved",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00128F, 0.00548F),
                                                                       new Vector3(311.6444F, -0.00001F, 180F),
                                                                       new Vector3(0.00117F, 0.00117F, 0.00117F)));
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
                                                                       new Vector3(0F, 0.0015F, 0.00003F),
                                                                       new Vector3(351.9346F, 316.124F, 7.68299F),
                                                                       new Vector3(0.01532F, 0.01329F, 0.01329F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HeadHunter, "DisplaySkullCrown",
                                                                       "Head",
                                                                       new Vector3(-0.00001F, 0.00234F, -0.00011F),
                                                                       new Vector3(341.7557F, 353.576F, 0.50668F),
                                                                       new Vector3(0.00629F, 0.00227F, 0.00227F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HealOnCrit, "DisplayScythe",
                                                                       "Chest",
                                                                       new Vector3(-0.00044F, 0.00024F, -0.00226F),
                                                                       new Vector3(331.8608F, 264.4655F, 270F),
                                                                       new Vector3(0.00246F, 0.00246F, 0.00246F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HealWhileSafe, "DisplaySnail",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.00088F, -0.00002F),
                                                                       new Vector3(84.33878F, 180F, 180F),
                                                                       new Vector3(0.00111F, 0.00111F, 0.00111F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Hoof,
                ItemDisplays.CreateDisplayRule("DisplayHoof",
                                               "Staff",
                                                                       new Vector3(0F, -0.00886F, 0.00019F),
                                                                       new Vector3(278.8528F, 180F, 180F),
                                                                       new Vector3(0.00074F, 0.00071F, 0.00066F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.RightCalf)
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Icicle, "DisplayFrostRelic",
                                                                       "Root",
                                                                       new Vector3(0.00814F, 0.01618F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(1.38875F, 1.38875F, 1.38875F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.IgniteOnKill, "DisplayGasoline",
                                                                       "Spine",
                                                                       new Vector3(-0.00071F, -0.00037F, -0.00155F),
                                                                       new Vector3(276.5062F, 180.6793F, 100.9834F),
                                                                       new Vector3(0.00428F, 0.00428F, 0.00428F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.IncreaseHealing,
                ItemDisplays.CreateDisplayRule("DisplayAntler",
                                               "Head",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(353.9438F, 81.39288F, 37.44671F),
                                                                       new Vector3(0.0042F, 0.0042F, 0.0042F)),
                ItemDisplays.CreateDisplayRule("DisplayAntler",
                                               "Head",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(356.1463F, 266.133F, 329.6633F),
                                                                       new Vector3(-0.00452F, 0.0039F, 0.00394F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(JunkContent.Items.Incubator, "DisplayAncestralIncubator",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00121F, -0.00099F),
                                                                       new Vector3(317.0807F, 0F, 0F),
                                                                       new Vector3(0.00045F, 0.00045F, 0.00045F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Infusion, "DisplayInfusion",
                                                                       "Spine",
                                                                       new Vector3(0.00181F, 0.00009F, -0.00097F),
                                                                       new Vector3(8.25727F, 135.0008F, 352.6233F),
                                                                       new Vector3(0.0057F, 0.0057F, 0.00575F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.JumpBoost, "DisplayWaxBird",
                                                                       "Head",
                                                                       new Vector3(0F, -0.00111F, 0.00195F),
                                                                       new Vector3(23.53981F, 0F, 0F),
                                                                       new Vector3(0.00701F, 0.00701F, 0.00701F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.KillEliteFrenzy, "DisplayBrainstalk",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00156F, 0.00022F),
                                                                       new Vector3(10.49918F, 0F, 0F),
                                                                       new Vector3(0.00291F, 0.00412F, 0.00289F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Knurl, "DisplayKnurl",
                                                                       "Staff",
                                                                       new Vector3(0F, 0.00683F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.001F, 0.001F, 0.001F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LaserTurbine, "DisplayLaserTurbine",
                                                                       "UpperArmR",
                                                                       new Vector3(-0.00046F, 0.00366F, 0.00039F),
                                                                       new Vector3(349.8132F, 331.6221F, 93.57278F),
                                                                       new Vector3(0.00462F, 0.00462F, 0.00462F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LightningStrikeOnHit, "DisplayChargedPerforator",
                                                                       "Chest",
                                                                       new Vector3(-0.00276F, 0.00239F, -0.00072F),
                                                                       new Vector3(315.747F, 100.982F, 166.6977F),
                                                                       new Vector3(0.01362F, 0.01362F, 0.01362F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarDagger, "DisplayLunarDagger",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00026F, 0.00359F),
                                                                       new Vector3(27.04753F, 179.6618F, 269.2563F),
                                                                       new Vector3(0.00381F, 0.00393F, 0.00381F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarPrimaryReplacement, "DisplayBirdEye",
                                                                       "Staff",
                                                                       new Vector3(0F, 0.01226F, 0F),
                                                                       new Vector3(286.612F, 180F, 180F),
                                                                       new Vector3(0.00798F, 0.00798F, 0.00798F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarSecondaryReplacement, "DisplayBirdClaw",
                                                                       "LowerArmL",
                                                                       new Vector3(0.00013F, 0.00391F, 0.001F),
                                                                       new Vector3(0F, 277.3215F, 280.5488F),
                                                                       new Vector3(0.00427F, 0.00427F, 0.00427F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarSpecialReplacement, "DisplayBirdHeart",
                                                                       "Root",
                                                                       new Vector3(0.00505F, 0.01944F, -0.00351F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.15153F, 0.15153F, 0.15153F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarTrinket, "DisplayBeads",
                                                                       "Staff",
                                                                       new Vector3(0F, 0.00279F, 0F),
                                                                       new Vector3(0F, 0F, 90F),
                                                                       new Vector3(0.016F, 0.016F, 0.016F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarUtilityReplacement, "DisplayBirdFoot",
                                                                       "Staff",
                                                                       new Vector3(-0.00001F, -0.00159F, 0.00081F),
                                                                       new Vector3(0F, 90F, 90F),
                                                                       new Vector3(0.00899F, 0.00899F, 0.00899F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Medkit, "DisplayMedkit",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.00062F, -0.00161F),
                                                                       new Vector3(270F, 180F, 0F),
                                                                       new Vector3(0.00824F, 0.00824F, 0.00824F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Missile, "DisplayMissileLauncher",
                                                                       "Chest",
                                                                       new Vector3(-0.00428F, 0.00596F, -0.00204F),
                                                                       new Vector3(353.6533F, 0.00001F, 0F),
                                                                       new Vector3(0.00097F, 0.00097F, 0.00097F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MissileVoid, "DisplayMissileLauncherVoid",
                                                                       "Spine",
                                                                       new Vector3(-0.00478F, 0.00869F, -0.0002F),
                                                                       new Vector3(3.61074F, 0.00001F, 0F),
                                                                       new Vector3(0.00103F, 0.00103F, 0.00103F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.MonstersOnShrineUse, "DisplayMonstersOnShrineUse",
                                                                       "Spine",
                                                                       new Vector3(0.00038F, 0.00096F, -0.0018F),
                                                                       new Vector3(54.70983F, 90F, 0F),
                                                                       new Vector3(0.00105F, 0.00105F, 0.00105F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Mushroom, "DisplayMushroom",
                                                                       "Chest",
                                                                       new Vector3(0.00642F, 0.00324F, -0.0005F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00064F, 0.00064F, 0.00064F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MushroomVoid, "DisplayMushroomVoid",
                                                                       "Chest",
                                                                       new Vector3(0.00674F, 0.00335F, -0.00068F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00046F, 0.00046F, 0.00046F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.NearbyDamageBonus, "DisplayDiamond",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.00121F, 0.00081F),
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
                                                                       new Vector3(-0.00044F, 0.0029F, 0.00074F),
                                                                       new Vector3(70.6662F, 180F, 180F),
                                                                       new Vector3(0.00137F, 0.00137F, 0.00137F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ParentEgg, "DisplayParentEgg",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.00065F, 0.00168F),
                                                                       new Vector3(12.56524F, 0F, 0F),
                                                                       new Vector3(0.00085F, 0.00085F, 0.00085F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Pearl, "DisplayPearl",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.00304F, 0F),
                                                                       new Vector3(270F, 0.00001F, 0F),
                                                                       new Vector3(0.00123F, 0.00123F, 0.00123F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.PersonalShield, "DisplayShieldGenerator",
                                                                       "LowerArmR",
                                                                       new Vector3(0F, 0.00117F, 0.00072F),
                                                                       new Vector3(80.30421F, 180F, 0F),
                                                                       new Vector3(0.002F, 0.002F, 0.002F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Phasing, "DisplayStealthkit",
                                                                       "Hips",
                                                                       new Vector3(0F, 0.00045F, 0.00149F),
                                                                       new Vector3(270F, 0.00001F, 0F),
                                                                       new Vector3(0.00343F, 0.00365F, 0.00365F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Plant, "DisplayInterstellarDeskPlant",
                                                                       "UpperArmL",
                                                                       new Vector3(-0.00006F, 0.00463F, 0.00079F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00095F, 0.00094F, 0.00094F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.RandomDamageZone, "DisplayRandomDamageZone",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00388F, -0.00018F),
                                                                       new Vector3(57.56997F, 0F, 0F),
                                                                       new Vector3(0.00066F, 0.00086F, 0.00086F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.RepeatHeal, "DisplayCorpseFlower",
                                                                       "Staff",
                                                                       new Vector3(0F, 0.01435F, 0.00269F),
                                                                       new Vector3(52.92662F, 0F, 0F),
                                                                       new Vector3(0.00433F, 0.00433F, 0.00433F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SecondarySkillMagazine, "DisplayDoubleMag",
                                                                       "Staff",
                                                                       new Vector3(-0.00006F, 0.01102F, 0.00262F),
                                                                       new Vector3(293.7661F, 180F, 180F),
                                                                       new Vector3(0.00092F, 0.00075F, 0.00095F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Seed, "DisplaySeed", //don
                                                                       "Chest",
                                                                       new Vector3(-0.00464F, 0.00337F, -0.00034F),
                                                                       new Vector3(330.0132F, 62.84436F, 123.1749F),
                                                                       new Vector3(0.00045F, 0.00045F, 0.00045F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.ShieldOnly,
                ItemDisplays.CreateDisplayRule("DisplayShieldBug",
                                               "Head",
                                                                       new Vector3(-0.00049F, 0.00156F, -0.00146F),
                                                                       new Vector3(345.8107F, 93.77667F, 143.4084F),
                                                                       new Vector3(0.00428F, -0.00428F, 0.00428F)),
                ItemDisplays.CreateDisplayRule("DisplayShieldBug",
                                               "Head",
                                                                       new Vector3(0.00112F, 0.00162F, -0.0011F),
                                                                       new Vector3(13.58704F, 78.49554F, 154.8037F),
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
                                                                       new Vector3(0F, 0.0014F, -0.00204F),
                                                                       new Vector3(274.4081F, 0F, 0F),
                                                                       new Vector3(0.00405F, 0.00367F, 0.00405F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.None)
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SiphonOnLowHealth, "DisplaySiphonOnLowHealth",
                                                                       "Hips",
                                                                       new Vector3(0.00245F, 0.00042F, 0F),
                                                                       new Vector3(0F, 91.50988F, 0F),
                                                                       new Vector3(0.00054F, 0.00054F, 0.00054F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SlowOnHit, "DisplayBauble",
                                                                       "Staff",
                                                                       new Vector3(-0.00011F, 0.01504F, 0.00057F),
                                                                       new Vector3(0F, 258.8748F, 0F),
                                                                       new Vector3(-0.00372F, -0.00372F, -0.00372F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.SlowOnHitVoid, "DisplayBaubleVoid",
                                                                       "Chest",
                                                                       new Vector3(-0.0005F, -0.00072F, -0.00082F),
                                                                       new Vector3(34.56912F, 80.53242F, 297.2141F),
                                                                       new Vector3(0.00459F, 0.00459F, 0.00459F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintArmor, "DisplayBuckler",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.00267F, 0.00077F),
                                                                       new Vector3(10.70441F, 0F, 0F),
                                                                       new Vector3(0.00201F, 0.00201F, 0.00212F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintBonus, "DisplaySoda",
                                                                       "Hips",
                                                                       new Vector3(-0.00201F, 0.00065F, -0.00005F),
                                                                       new Vector3(274.0116F, 180F, 180F),
                                                                       new Vector3(0.00241F, 0.00241F, 0.00241F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintOutOfCombat, "DisplayWhip",
                                                                       "Hips",
                                                                       new Vector3(-0.00223F, -0.00118F, -0.00095F),
                                                                       new Vector3(0F, 332.451F, 344.7224F),
                                                                       new Vector3(0.00471F, 0.00471F, 0.00471F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintWisp, "DisplayBrokenMask",
                                                                       "Head",
                                                                       new Vector3(-0.00158F, 0.00187F, -0.00104F),
                                                                       new Vector3(352.4009F, 246.1753F, 25.28349F),
                                                                       new Vector3(0.00329F, 0.0028F, 0.0028F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Squid, "DisplaySquidTurret",
                                                                "Chest",
                                                                       new Vector3(-0.0038F, 0.00281F, -0.00072F),
                                                                       new Vector3(7.61121F, 43.84381F, 350.6197F),
                                                                       new Vector3(0.00065F, 0.00065F, 0.00065F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.StickyBomb, "DisplayStickyBomb",
                                                                       "Head",
                                                                       new Vector3(-0.0024F, 0.00475F, -0.0023F),
                                                                       new Vector3(0F, 0F, 308.9087F),
                                                                       new Vector3(0.003F, 0.003F, 0.003F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.StunChanceOnHit, "DisplayStunGrenade",
                                                                       "Chest",
                                                                       new Vector3(0.00122F, 0.00099F, 0.00157F),
                                                                       new Vector3(290.7513F, 272.3995F, 116.1337F),
                                                                       new Vector3(0.00568F, 0.00568F, 0.00568F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Syringe, "DisplaySyringeCluster",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00193F, -0.00202F),
                                                                       new Vector3(282.4055F, 0.00002F, -0.00001F),
                                                                       new Vector3(0.00196F, 0.00196F, 0.00196F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Talisman, "DisplayTalisman",
                                                                       "Root",
                                                                       new Vector3(0.00288F, 0.01833F, -0.00813F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.71215F, 0.71215F, 0.71215F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TPHealingNova, "DisplayGlowFlower",
                                                                       "Head",
                                                                       new Vector3(0.00093F, 0.00212F, -0.00124F),
                                                                       new Vector3(344.2946F, 125.722F, 229.4036F),
                                                                       new Vector3(0.0053F, 0.0053F, 0.0053F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Thorns, "DisplayRazorwireLeft",
                                                                "UpperArmL",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.0077F, 0.0077F, 0.0077F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TitanGoldDuringTP, "DisplayGoldHeart",
                                                                       "Staff",
                                                                       new Vector3(-0.00017F, 0.01479F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00194F, 0.00194F, 0.00194F)));
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
                                                                       "Staff",
                                                                       new Vector3(-0.00001F, 0.00758F, -0.00034F),
                                                                       new Vector3(0F, 90.95602F, 102.5071F),
                                                                       new Vector3(0.01802F, 0.01802F, 0.01802F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.TreasureCacheVoid, "DisplayKeyVoid",
                                                                       "Staff",
                                                                       new Vector3(0F, 0.00754F, 0.0001F),
                                                                       new Vector3(30.23697F, 0F, 270F),
                                                                       new Vector3(0.01333F, 0.01333F, 0.01333F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.UtilitySkillMagazine,
                ItemDisplays.CreateDisplayRule("DisplayAfterburnerShoulderRing",
                                               "Head",
                                                                       new Vector3(0.00255F, 0.00486F, -0.00223F),
                                                                       new Vector3(47.37375F, 90F, 180F),
                                                                       new Vector3(0.003F, 0.003F, 0.003F)),
                ItemDisplays.CreateDisplayRule("DisplayAfterburnerShoulderRing",
                                               "Head",
                                                                       new Vector3(-0.00248F, 0.00488F, -0.00197F),
                                                                       new Vector3(313.5355F, 90F, 180F),
                                                                       new Vector3(0.003F, 0.003F, 0.003F))
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.WarCryOnMultiKill, "DisplayPauldron",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00219F, -0.00172F),
                                                                       new Vector3(270F, 0.00001F, 0F),
                                                                       new Vector3(0.00787F, 0.00787F, 0.00787F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.WardOnLevel, "DisplayWarbanner",
                                                                       "Chest",
                                                                       new Vector3(0.00057F, 0.0007F, -0.00192F),
                                                                       new Vector3(338.8275F, 209.4081F, 42.74953F),
                                                                       new Vector3(0.0064F, 0.0064F, 0.0064F)));
            #endregion items

            #region quips
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.BFG, "DisplayBFG",
                                                                       "Chest",
                                                                       new Vector3(-0.00628F, 0.00289F, -0.00114F),
                                                                       new Vector3(356.6259F, 0.00001F, 0F),
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
                                                                       "Chest",
                                                                       new Vector3(0F, 0.0024F, -0.0027F),
                                                                       new Vector3(69.06752F, 180F, 0F),
                                                                       new Vector3(0.00502F, 0.00502F, 0.00502F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.BurnNearby, "DisplayPotion",
                                                                       "Hips",
                                                                       new Vector3(-0.0012F, 0.00072F, -0.00145F),
                                                                       new Vector3(0F, 0F, 322.8796F),
                                                                       new Vector3(0.00039F, 0.00039F, 0.00039F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CrippleWard, "DisplayEffigy",
                                                                       "Chest",
                                                                       new Vector3(-0.00061F, -0.00021F, -0.0026F),
                                                                       new Vector3(0F, 0F, 341.444F),
                                                                       new Vector3(0.01043F, 0.01043F, 0.01043F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CritOnUse, "DisplayNeuralImplant",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00121F, 0.00511F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00361F, 0.00311F, 0.00279F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.DeathProjectile, "DisplayDeathProjectile",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00138F, -0.00276F),
                                                                       new Vector3(0F, 180F, 0F),
                                                                       new Vector3(0.00131F, 0.00131F, 0.00131F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.DroneBackup, "DisplayRadio",
                                                                       "Hips",
                                                                       new Vector3(0F, 0.00172F, 0.00128F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00507F, 0.00507F, 0.00507F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Equipment.AffixRed,
                ItemDisplays.CreateDisplayRule("DisplayEliteHorn",
                                               "Head",
                                                                       new Vector3(0.00094F, 0.00211F, 0.0008F),
                                                                       new Vector3(68.41402F, 0F, 0F),
                                                                       new Vector3(0.00109F, 0.00109F, 0.00109F)),
                ItemDisplays.CreateDisplayRule("DisplayEliteHorn",
                                               "Head",
                                                                       new Vector3(-0.00105F, 0.00219F, 0.00098F),
                                                                       new Vector3(73.02985F, 0F, 0F),
                                                                       new Vector3(-0.00109F, 0.00109F, 0.00109F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixHaunted, "DisplayEliteStealthCrown",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00319F, 0.00005F),
                                                                       new Vector3(75.39037F, 0F, 0F),
                                                                       new Vector3(-0.00061F, -0.00055F, -0.00055F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixWhite, "DisplayEliteIceCrown",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00245F, -0.00022F),
                                                                       new Vector3(304.1333F, 180F, 180F),
                                                                       new Vector3(0.00033F, 0.00033F, 0.00033F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Equipment.AffixBlue,
                ItemDisplays.CreateDisplayRule("DisplayEliteRhinoHorn",
                                               "Head",
                                                                       new Vector3(0F, 0.00316F, -0.00003F),
                                                                       new Vector3(291.7304F, 180F, 180F),
                                                                       new Vector3(0.00305F, 0.0031F, 0.00262F)),
                ItemDisplays.CreateDisplayRule("DisplayEliteRhinoHorn",
                                               "Head",
                                                                       new Vector3(0F, 0.00305F, 0.0011F),
                                                                       new Vector3(288.8945F, 0.00002F, -0.00001F),
                                                                       new Vector3(-0.00199F, 0.00202F, 0.00159F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixLunar, "DisplayEliteLunar,Eye",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00561F, -0.00071F),
                                                                       new Vector3(71.63628F, 0F, 0F),
                                                                       new Vector3(0.0051F, 0.00473F, 0.0051F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixPoison, "DisplayEliteUrchinCrown",
                                                                       "Head",
                                                                       new Vector3(0F, 0.0024F, 0.00011F),
                                                                       new Vector3(270.6974F, 180.0022F, 269.9978F),
                                                                       new Vector3(0.00054F, 0.00054F, 0.00054F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.FireBallDash, "DisplayEgg",
                                                                       "Chest",
                                                                       new Vector3(0F, -0.00006F, -0.00247F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.00472F, 0.00472F, 0.00472F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Fruit, "DisplayFruit",
                                                                       "Chest",
                                                                       new Vector3(-0.00124F, 0.00278F, 0.00278F),
                                                                       new Vector3(63.86541F, 266.3865F, 122.9459F),
                                                                       new Vector3(0.00335F, 0.00335F, 0.00346F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.GainArmor, "DisplayElephantFigure",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00046F, -0.00299F),
                                                                       new Vector3(282.3987F, 180F, 180F),
                                                                       new Vector3(0.01032F, 0.01032F, 0.01032F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Gateway, "DisplayVase",
                                                                       "Chest",
                                                                       new Vector3(-0.00054F, 0.00182F, -0.0024F),
                                                                       new Vector3(343.8488F, 349.1142F, 34.65776F),
                                                                       new Vector3(0.00275F, 0.00275F, 0.00275F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.GoldGat, "DisplayGoldGat",
                                                                       "Chest",
                                                                       new Vector3(-0.00627F, 0.00615F, -0.00125F),
                                                                       new Vector3(0F, 93.71225F, 0F),
                                                                       new Vector3(0.00133F, 0.00133F, 0.00133F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Jetpack, "DisplayBugWings",
                                                                       "Chest",
                                                                       new Vector3(0F, -0.00078F, -0.00085F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00206F, 0.00206F, 0.00206F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.LifestealOnHit, "DisplayLifestealOnHit",
                                                                       "Neck",
                                                                       new Vector3(-0.0002F, 0.00147F, -0.00269F),
                                                                       new Vector3(14.9227F, 0.7F, 359.3365F),
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
                                                                       new Vector3(0F, 0.02632F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.76542F, 0.76645F, 0.76645F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.QuestVolatileBattery, "DisplayBatteryArray",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00034F, -0.00315F),
                                                                       new Vector3(3.67658F, 180F, 180F),
                                                                       new Vector3(0.00397F, 0.00397F, 0.00397F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Recycle, "DisplayRecycler",
                                                                       "Chest",
                                                                       new Vector3(0.00057F, 0.00064F, -0.00261F),
                                                                       new Vector3(0F, 90F, 354.3717F),
                                                                       new Vector3(0.00085F, 0.00085F, 0.00085F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Saw, "DisplaySawmerangFollower",
                                                                       "Root",
                                                                       new Vector3(-0.00004F, 0.02568F, -0.00046F),
                                                                       new Vector3(271.0232F, 185.0242F, 175.0119F),
                                                                       new Vector3(0.00141F, 0.00141F, 0.00141F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Scanner, "DisplayScanner",
                                                                       "Chest",
                                                                       new Vector3(-0.00648F, 0.00293F, -0.00068F),
                                                                       new Vector3(281.7952F, 180F, 180F),
                                                                       new Vector3(0.00178F, 0.00178F, 0.00178F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.TeamWarCry, "DisplayTeamWarCry",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00127F, -0.00261F),
                                                                       new Vector3(353.8062F, 180F, 180F),
                                                                       new Vector3(0.00104F, 0.00104F, 0.00104F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Tonic, "DisplayTonic",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00113F, -0.00224F),
                                                                       new Vector3(354.6881F, 0F, 0F),
                                                                       new Vector3(0.00269F, 0.00269F, 0.00269F)));

            #endregion quips

            #region dlc1

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PrimarySkillShuriken, "DisplayShuriken",
                                                                       "Staff",
                                                                       new Vector3(0F, 0.00255F, -0.00014F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.0044F, 0.0044F, 0.0044F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.OutOfCombatArmor, "DisplayOddlyShapedOpal",
                                                                       "Staff",
                                                                       new Vector3(0F, 0.01005F, 0.00065F),
                                                                       new Vector3(22.94225F, 180F, 180F),
                                                                       new Vector3(0.00449F, 0.00449F, 0.00453F)));
            //head
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(DLC1Content.Items.LunarSun,
                ItemDisplays.CreateDisplayRule("DisplaySunHead",
                                               "Head",
                                                                       new Vector3(0F, 0.00119F, 0.00054F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.00994F, 0.00997F, 0.00997F)),
                ItemDisplays.CreateDisplayRule("DisplaySunHeadNeck",
                                               "Neck",
                                                                       new Vector3(0.00007F, 0.00027F, -0.0002F),
                                                                       new Vector3(0F, 270F, 0F),
                                                                       new Vector3(0.01681F, 0.01498F, -0.01885F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.Head)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MinorConstructOnKill, "DisplayDefenseNucleus",
                                                                       "Root",
                                                                       new Vector3(-0.00374F, 0.02148F, -0.00536F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.29386F, 0.29386F, 0.29386F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HalfAttackSpeedHalfCooldowns, "DisplayLunarShoulderNature",
                                                                       "Head",
                                                                       new Vector3(0F, -0.00055F, 0.00189F),
                                                                       new Vector3(0F, 90F, 55.68917F),
                                                                       new Vector3(0.00725F, 0.00725F, 0.00517F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HalfSpeedDoubleHealth, "DisplayLunarShoulderStone",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00307F, 0.00087F),
                                                                       new Vector3(0F, 270F, 267.0847F),
                                                                       new Vector3(0.00811F, 0.00811F, 0.00982F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.AttackSpeedAndMoveSpeed, "DisplayCoffee",
                                                                       "Hips",
                                                                       new Vector3(0.00144F, 0.00062F, -0.00144F),
                                                                       new Vector3(358.4995F, 340.8977F, 355.4437F),
                                                                       new Vector3(0.00168F, 0.00168F, 0.00168F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.GoldOnHurt, "DisplayRollOfPennies",
                                                                       "Staff",
                                                                       new Vector3(0F, -0.00198F, -0.00043F),
                                                                       new Vector3(86.22836F, 0F, 0F),
                                                                       new Vector3(0.00983F, 0.00983F, 0.00983F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.FragileDamageBonus, "DisplayDelicateWatch",
                                                                       "LowerArmR",
                                                                       new Vector3(0F, 0.0018F, 0.00027F),
                                                                       new Vector3(85.66948F, 180F, 180F),
                                                                       new Vector3(0.00867F, 0.01471F, 0.00886F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ImmuneToDebuff, "DisplayRainCoatBelt",
                                                                       "Hips",
                                                                       new Vector3(-0.00017F, 0.00077F, -0.0001F),
                                                                       new Vector3(5.67388F, 0F, 0F),
                                                                       new Vector3(0.00977F, 0.00845F, 0.00845F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RandomEquipmentTrigger, "DisplayBottledChaos",
                                                                       "Spine",
                                                                       new Vector3(0F, -0.00044F, -0.00152F),
                                                                       new Vector3(355.1696F, 0F, 0F),
                                                                       new Vector3(0.00215F, 0.00215F, 0.00215F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.StrengthenBurn, "DisplayGasTank",
                                                                       "Coat1",
                                                                       new Vector3(-0.0011F, 0.00131F, 0.00212F),
                                                                       new Vector3(11.24596F, 0F, 0F),
                                                                       new Vector3(0.00139F, 0.00139F, 0.00139F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.VoidMegaCrabItem, "DisplayMegaCrabItem",
                                                                       "Staff",
                                                                       new Vector3(0F, 0.01582F, -0.00002F),
                                                                       new Vector3(85.22649F, 0F, 0F),
                                                                       new Vector3(0.00188F, 0.00188F, 0.00188F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RegeneratingScrap, "DisplayRegeneratingScrap",
                                                                       "Head",
                                                                       new Vector3(-0.00266F, 0.00499F, -0.002F),
                                                                       new Vector3(54.22608F, 94.53197F, 1.48302F),
                                                                       new Vector3(0.00225F, 0.00225F, 0.00225F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PermanentDebuffOnHit, "DisplayScorpion",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.00188F, -0.00115F),
                                                                       new Vector3(344.2816F, 0F, 0F),
                                                                       new Vector3(0.00963F, 0.00963F, 0.00963F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CritDamage, "DisplayLaserSight",
                                                                       "Head",
                                                                       new Vector3(0.00153F, 0.00155F, 0.00109F),
                                                                       new Vector3(90F, 90F, 0F),
                                                                       new Vector3(0.00089F, 0.00089F, 0.00089F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.FreeChest, "DisplayShippingRequestForm",
                                                                       "Staff",
                                                                       new Vector3(0F, 0.00566F, 0F),
                                                                       new Vector3(32.92329F, 0F, 26.54572F),
                                                                       new Vector3(0.00662F, 0.00664F, 0.00662F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoveSpeedOnKill, "DisplayGrappleHook",
                                                                       "HandL",
                                                                       new Vector3(0F, 0.00057F, 0.00046F),
                                                                       new Vector3(342.545F, 165.3742F, 184.4758F),
                                                                       new Vector3(0.00219F, 0.00219F, 0.00219F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RandomlyLunar, "DisplayDomino",
                                                                       "Root",
                                                                       new Vector3(-0.00944F, 0.01324F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(1.43943F, 1.43943F, 1.43943F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HealingPotion, "DisplayHealingPotion",
                                                                       "Hips",
                                                                       new Vector3(0.00183F, 0.00063F, 0.00092F),
                                                                       new Vector3(349.5982F, 357.4122F, 14.05364F),
                                                                       new Vector3(0.00063F, 0.00063F, 0.00063F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoreMissile, "DisplayICBM",
                                                                       "Spine",
                                                                       new Vector3(-0.00145F, 0.00025F, -0.0016F),
                                                                       new Vector3(354.6163F, 0F, 0F),
                                                                       new Vector3(0.00096F, 0.00096F, 0.00096F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(DLC1Content.Equipment.BossHunter,
                ItemDisplays.CreateDisplayRule("DisplayTricornGhost",
                                               "Head",
                                                                       new Vector3(0F, 0.00361F, 0.00005F),
                                                                       new Vector3(28.45431F, 0F, 0F),
                                                                       new Vector3(0.00623F, 0.00623F, 0.00623F)),
                ItemDisplays.CreateDisplayRule("DisplayBlunderbuss",
                                               "Root",
                                                                       new Vector3(0F, 0.02678F, 0.00336F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.53345F, 0.53345F, 0.53345F))));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.BossHunterConsumed, "DisplayTricornUsed",
                                                                       "Head",
                                                                       new Vector3(0F, 0.0037F, -0.00051F),
                                                                       new Vector3(17.74602F, 0F, 0F),
                                                                       new Vector3(0.00757F, 0.00757F, 0.00757F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.EliteVoidEquipment, "DisplayAffixVoid",
                                                                       "Head",
                                                                       new Vector3(0F, 0.0008F, 0.00149F),
                                                                       new Vector3(89.19473F, 180F, 180F),
                                                                       new Vector3(0.00199F, 0.00199F, 0.00199F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.GummyClone, "DisplayGummyClone",
                                                                       "Chest",
                                                                       new Vector3(0.0002F, 0.0018F, -0.00221F),
                                                                       new Vector3(355.3549F, 328.7025F, 2.81858F),
                                                                       new Vector3(0.00294F, 0.00294F, 0.00294F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule("IrradiatingLaser", "DisplayIrradiatingLaser",
                                                                       "Chest",
                                                                       new Vector3(-0.00559F, 0.00308F, -0.00096F),
                                                                       new Vector3(0F, 0F, 344.9919F),
                                                                       new Vector3(0.00169F, 0.00169F, 0.00169F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.LunarPortalOnUse, "DisplayLunarPortalOnUse",
                                                                       "Root",
                                                                       new Vector3(0F, 0.02291F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.85193F, 0.85193F, 0.85193F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.Molotov, "DisplayMolotov",
                                                                       "Chest",
                                                                       new Vector3(0F, -0.00046F, -0.0018F),
                                                                       new Vector3(350.9389F, 0F, 0F),
                                                                       new Vector3(0.00302F, 0.00302F, 0.00302F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.MultiShopCard, "DisplayExecutiveCard",
                                                                       "Staff",
                                                                       new Vector3(-0.00003F, 0.00641F, -0.00021F),
                                                                       new Vector3(0F, 54.12595F, 0F),
                                                                       new Vector3(0.01217F, 0.01243F, 0.01282F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.VendingMachine, "DisplayVendingMachine",
                                                                       "Chest",
                                                                       new Vector3(0.00001F, 0.00187F, -0.00184F),
                                                                       new Vector3(9.90617F, 156.248F, 355.6707F),
                                                                       new Vector3(0.00346F, 0.00346F, 0.00346F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Elites.Earth.eliteEquipmentDef, "DisplayEliteMendingAntlers",
                                                                       "Head",
                                                                       new Vector3(0F, 0.00223F, 0.00101F),
                                                                       new Vector3(73.20102F, 0F, 0F),
                                                                       new Vector3(0.00988F, 0.00988F, 0.00988F)));

            #endregion

        }
    }
}
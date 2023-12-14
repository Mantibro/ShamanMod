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
                                                                       new Vector3(0.00843F, 1.12065F, -0.26039F),
                                                                       new Vector3(295.4775F, 271.1627F, 356.0796F),
                                                                       new Vector3(0.858F, 0.858F, 0.858F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ArmorPlate, "DisplayRepulsionArmorPlate",
                                                                       "UpperArmR",
                                                                       new Vector3(0.02983F, 0.1498F, 0.04536F),
                                                                       new Vector3(78.74376F, 270F, 90F),
                                                                       new Vector3(0.405F, 0.435F, 0.349F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.ArmorReductionOnHit,
                ItemDisplays.CreateDisplayRule("DisplayWarhammer",
                                               "Spine",
                                                                       new Vector3(0.159F, 0.126F, -0.141F),
                                                                       new Vector3(331.8564F, 85.81026F, 91.58662F),
                                                                       new Vector3(0.187F, 0.187F, 0.187F))));//hammer
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AttackSpeedOnCrit, "DisplayWolfPelt",
                                                                       "Head",
                                                                       new Vector3(0F, 0.261F, 0.054F),
                                                                       new Vector3(336.6781F, 359.9765F, 0.11483F),
                                                                       new Vector3(0.731F, 0.637F, 0.637F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AutoCastEquipment, "DisplayFossil",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.007F, -0.193F),
                                                                       new Vector3(0F, 270F, 17.75658F),
                                                                       new Vector3(0.784F, 0.784F, 0.784F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Bandolier, "DisplayBandolier",
                                                                       "Hips",
                                                                       new Vector3(0F, 0.066F, -0.028F),
                                                                       new Vector3(270F, 90F, 0F),
                                                                       new Vector3(0.34F, 0.424F, 0.615F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnKill, "DisplayBrooch",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.164F, 0.185F),
                                                                       new Vector3(80.07203F, 0F, 0F),
                                                                       new Vector3(0.628F, 0.539F, 0.539F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnOverHeal, "DisplayAegis",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.239F, 0.081F),
                                                                       new Vector3(82.10845F, 180F, 0F),
                                                                       new Vector3(0.206F, 0.206F, 0.206F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Bear, "DisplayBear",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.085F, 0.063F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.199F, 0.199F, 0.199F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.BearVoid, "DisplayBearVoid",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.096F, 0.059F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.197F, 0.197F, 0.197F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BeetleGland, "DisplayBeetleGland",
                                                                       "Staff",
                                                                       new Vector3(0F, 0.527F, 0F),
                                                                       new Vector3(299.3822F, 0F, 0F),
                                                                       new Vector3(0.118F, 0.118F, 0.118F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Behemoth,
                ItemDisplays.CreateDisplayRule("DisplayBehemoth",
                                               "Spine",
                                                                       new Vector3(-0.061F, 0.021F, -0.177F),
                                                                       new Vector3(276.8044F, 179.9999F, 270.9254F),
                                                                       new Vector3(0.049F, 0.049F, 0.049F))));
 
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.BleedOnHit,
                ItemDisplays.CreateDisplayRule("DisplayTriTip",
                                               "Chest",
                                                                       new Vector3(-0.042F, 0.196F, -0.229F),
                                                                       new Vector3(312.364F, 251.8789F, 98.84457F),
                                                                       new Vector3(0.537F, 0.537F, 0.636F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(DLC1Content.Items.BleedOnHitVoid,
                ItemDisplays.CreateDisplayRule("DisplayTriTipVoid",
                                               "Head",
                                                                       new Vector3(0F, 0.334F, -0.014F),
                                                                       new Vector3(309.7547F, 180F, 180F),
                                                                       new Vector3(0.44F, 0.44F, 0.521F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BleedOnHitAndExplode, "DisplayBleedOnHitAndExplode",
                                                                       "Spine",
                                                                       new Vector3(-0.122F, 0.079F, 0.017F),
                                                                       new Vector3(339.2223F, 212.0563F, 249.7049F),
                                                                       new Vector3(0.049F, 0.049F, 0.049F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BonusGoldPackOnKill, "DisplayTome",
                                                                       "Hips",
                                                                       new Vector3(0.22F, 0.054F, -0.001F),
                                                                       new Vector3(0F, 264.1379F, 0F),
                                                                       new Vector3(0.078F, 0.078F, 0.078F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BossDamageBonus, "DisplayAPRound",
                                                                       "Chest",
                                                                       new Vector3(-0.14F, 0.005F, 0.164F),
                                                                       new Vector3(63.5081F, 268.9081F, 286.1247F),
                                                                       new Vector3(0.7F, 0.7F, 0.7F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BounceNearby, "DisplayHook",
                                                                       "Chest",
                                                                       new Vector3(0.324F, 0.246F, -0.178F),
                                                                       new Vector3(37.56657F, 150.0612F, 160.6522F),
                                                                       new Vector3(-0.397F, -0.397F, -0.397F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ChainLightning, "DisplayUkulele",
                                                                       "Chest",
                                                                       new Vector3(0.042F, 0.04F, -0.217F),
                                                                       new Vector3(359.3017F, 180F, 145.2479F),
                                                                       new Vector3(0.725F, 0.688F, 0.699F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ChainLightningVoid, "DisplayUkuleleVoid",
                                                                       "Chest",
                                                                       new Vector3(0.024F, 0.062F, -0.205F),
                                                                       new Vector3(2.57437F, 180.3139F, 156.2212F),
                                                                       new Vector3(0.783F, 0.744F, 0.755F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Clover, "DisplayClover",
                                                                       "Head",
                                                                       new Vector3(-0.00049F, 0.32583F, 0.01482F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.595F, 0.595F, 0.593F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CloverVoid, "DisplayCloverVoid",
                                                                       "Head",
                                                                       new Vector3(-0.00046F, 0.305F, 0.05089F),
                                                                       new Vector3(15.61712F, 0F, 0F),
                                                                       new Vector3(0.659F, 0.659F, 0.659F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(JunkContent.Items.CooldownOnCrit,
                ItemDisplays.CreateDisplayRule("DisplaySkull",
                                               "Head",
                                                                       new Vector3(0F, 0.343F, 0.046F),
                                                                       new Vector3(305.9099F, 180F, 180F),
                                                                       new Vector3(0.285F, 0.285F, 0.285F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.Head)
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.CritGlasses, "DisplayGlasses",
                                                                       "Head",
                                                                       new Vector3(0F, 0.253F, 0.187F),
                                                                       new Vector3(346.041F, 0.00001F, 0F),
                                                                       new Vector3(0.383F, 0.127F, 0.375F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CritGlassesVoid, "DisplayGlassesVoid",
                                                                       "Head",
                                                                       new Vector3(0F, 0.115F, 0.193F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.289F, 0.297F, 0.415F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Crowbar, "DisplayCrowbar",
                                                                       "Chest",
                                                                       new Vector3(-0.036F, 0.108F, -0.206F),
                                                                       new Vector3(48.24174F, 90F, 0F),
                                                                       new Vector3(0.498F, 0.498F, 0.498F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Dagger, "DisplayDagger",
                                                                       "Chest",
                                                                       new Vector3(0.014F, 0.11F, -0.126F),
                                                                       new Vector3(287.0031F, 138.7832F, 291.8255F),
                                                                       new Vector3(1.003F, 1.003F, 1.003F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.DeathMark, "DisplayDeathMark",
                                                                       "HandL",
                                                                       new Vector3(0.001F, 0.102F, -0.017F),
                                                                       new Vector3(80.2933F, 355.1307F, 175.7849F),
                                                                       new Vector3(0.034F, 0.034F, 0.034F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.EnergizedOnEquipmentUse, "DisplayWarHorn",
                                                                       "Spine",
                                                                       new Vector3(0.046F, 0.116F, -0.151F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.565F, 0.565F, 0.565F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.EquipmentMagazine, "DisplayBattery",
                                                                       "Hips",
                                                                       new Vector3(0.062F, 0.068F, -0.158F),
                                                                       new Vector3(0F, 270F, 0F),
                                                                       new Vector3(0.204F, 0.204F, 0.204F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.EquipmentMagazineVoid, "DisplayFuelCellVoid",
                                                                       "Hips",
                                                                       new Vector3(0F, 0.071F, -0.144F),
                                                                       new Vector3(90F, 89.99999F, 0F),
                                                                       new Vector3(0.285F, 0.285F, 0.285F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExecuteLowHealthElite, "DisplayGuillotine",
                                                                       "Head",
                                                                       new Vector3(0.00273F, 0.26919F, 0.13643F),
                                                                       new Vector3(29.45429F, 180.7224F, 270.3758F),
                                                                       new Vector3(0.118F, 0.118F, 0.116F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExplodeOnDeath, "DisplayWilloWisp",
                                                                       "Chest",
                                                                       new Vector3(-0.565F, 0.385F, -0.068F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.052F, 0.052F, 0.052F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ExplodeOnDeathVoid, "DisplayWillowWispVoid",
                                                                       "Chest",
                                                                       new Vector3(-0.657F, 0.383F, -0.065F),
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
                                               "Hips",
                                                                       new Vector3(-0.259F, -0.029F, 0F),
                                                                       new Vector3(0F, 0F, 247.3832F),
                                                                       new Vector3(0.251F, 0.251F, 0.251F)),
                ItemDisplays.CreateDisplayRule("DisplayGravBoots",
                                               "Hips",
                                                                       new Vector3(0.27F, -0.033F, 0F),
                                                                       new Vector3(0F, 180F, 245.1566F),
                                                                       new Vector3(0.251F, 0.251F, 0.251F)
                )));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Feather,
                ItemDisplays.CreateDisplayRule("DisplayFeather",
                                               "Chest",
                                                                       new Vector3(0.102F, 0.018F, -0.169F),
                                                                       new Vector3(282.1741F, 180F, 180F),
                                                                       new Vector3(-0.065F, 0.039F, 0.038F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FireballsOnHit, "DisplayFireballsOnHit",
                                                                       "Chest",
                                                                       new Vector3(0.395F, 0.3F, -0.06F),
                                                                       new Vector3(327.7166F, 91.96867F, 0.41358F),
                                                                       new Vector3(0.069F, 0.079F, 0.065F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FireRing, "DisplayFireRing",
                                                                       "HandL",
                                                                       new Vector3(0.008F, 0.029F, -0.008F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.307F, 0.307F, 0.307F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.IceRing, "DisplayIceRing",
                                                                       "HandR",
                                                                       new Vector3(-0.003F, 0.089F, -0.005F),
                                                                       new Vector3(78.20138F, 54.06792F, 55.86569F),
                                                                       new Vector3(0.351F, 0.351F, 0.351F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ElementalRingVoid, "DisplayVoidRing",
                                                                       "HandL",
                                                                       new Vector3(0.005F, 0.121F, 0.002F),
                                                                       new Vector3(270F, 136.8969F, 0F),
                                                                       new Vector3(0.308F, 0.308F, 0.264F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Firework, "DisplayFirework",
                                                                       "Chest",
                                                                       new Vector3(-0.216F, 0.309F, -0.215F),
                                                                       new Vector3(316.392F, 241.8502F, 127.8034F),
                                                                       new Vector3(0.361F, 0.361F, 0.361F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FlatHealth, "DisplaySteakCurved",
                                                                       "Staff",
                                                                       new Vector3(-0.0155F, 0.3716F, 0.10933F),
                                                                       new Vector3(311.6444F, -0.00001F, 180F),
                                                                       new Vector3(0.117F, 0.117F, 0.117F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FocusConvergence, "DisplayFocusedConvergence",
                                                                       "Root",
                                                                       new Vector3(-0.587F, 1.951F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.06713F, 0.06713F, 0.06713F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.GhostOnKill, "DisplayMask",
                                                                       "UpperArmL",
                                                                       new Vector3(0F, 0.05F, 0.04F),
                                                                       new Vector3(0F, 0F, 180F),
                                                                       new Vector3(0.798F, 0.798F, 0.615F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.GoldOnHit, "DisplayBoneCrown",
                                                                       "Head",
                                                                       new Vector3(0F, 0.15F, 0.003F),
                                                                       new Vector3(351.9346F, 316.124F, 7.68299F),
                                                                       new Vector3(1.532F, 1.329F, 1.329F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HeadHunter, "DisplaySkullCrown",
                                                                       "Head",
                                                                       new Vector3(-0.001F, 0.234F, -0.011F),
                                                                       new Vector3(341.7557F, 353.576F, 0.50668F),
                                                                       new Vector3(0.629F, 0.227F, 0.227F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HealOnCrit, "DisplayScythe",
                                                                       "Chest",
                                                                       new Vector3(-0.044F, 0.024F, -0.226F),
                                                                       new Vector3(331.8608F, 264.4655F, 270F),
                                                                       new Vector3(0.246F, 0.246F, 0.246F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HealWhileSafe, "DisplaySnail",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.088F, -0.002F),
                                                                       new Vector3(84.33878F, 180F, 180F),
                                                                       new Vector3(0.111F, 0.111F, 0.111F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Hoof,
                ItemDisplays.CreateDisplayRule("DisplayHoof",
                                               "Staff",
                                                                       new Vector3(0F, -0.886F, 0.019F),
                                                                       new Vector3(278.8528F, 180F, 180F),
                                                                       new Vector3(0.074F, 0.071F, 0.066F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.RightCalf)
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Icicle, "DisplayFrostRelic",
                                                                       "Root",
                                                                       new Vector3(0.814F, 1.618F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.91727F, 0.91727F, 0.91727F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.IgniteOnKill, "DisplayGasoline",
                                                                       "Spine",
                                                                       new Vector3(-0.071F, -0.037F, -0.155F),
                                                                       new Vector3(276.5062F, 180.6793F, 100.9834F),
                                                                       new Vector3(0.428F, 0.428F, 0.428F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.IncreaseHealing,
                ItemDisplays.CreateDisplayRule("DisplayAntler",
                                               "Head",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(353.9438F, 81.39288F, 37.44671F),
                                                                       new Vector3(0.42F, 0.42F, 0.42F)),
                ItemDisplays.CreateDisplayRule("DisplayAntler",
                                               "Head",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(356.1463F, 266.133F, 329.6633F),
                                                                       new Vector3(-0.452F, 0.39F, 0.394F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(JunkContent.Items.Incubator, "DisplayAncestralIncubator",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.121F, -0.099F),
                                                                       new Vector3(317.0807F, 0F, 0F),
                                                                       new Vector3(0.045F, 0.045F, 0.045F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Infusion, "DisplayInfusion",
                                                                       "Spine",
                                                                       new Vector3(0.181F, 0.009F, -0.097F),
                                                                       new Vector3(8.25727F, 135.0008F, 352.6233F),
                                                                       new Vector3(0.57F, 0.57F, 0.575F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.JumpBoost, "DisplayWaxBird",
                                                                       "Head",
                                                                       new Vector3(-0.0005F, -0.02757F, -0.21434F),
                                                                       new Vector3(23.53981F, 0F, 0F),
                                                                       new Vector3(0.701F, 0.701F, 0.701F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.KillEliteFrenzy, "DisplayBrainstalk",
                                                                       "Head",
                                                                       new Vector3(0F, 0.156F, 0.022F),
                                                                       new Vector3(10.49918F, 0F, 0F),
                                                                       new Vector3(0.291F, 0.412F, 0.289F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Knurl, "DisplayKnurl",
                                                                       "Staff",
                                                                       new Vector3(0F, 0.683F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.1F, 0.1F, 0.1F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LaserTurbine, "DisplayLaserTurbine",
                                                                       "UpperArmR",
                                                                       new Vector3(-0.046F, 0.366F, 0.039F),
                                                                       new Vector3(349.8132F, 331.6221F, 93.57278F),
                                                                       new Vector3(0.462F, 0.462F, 0.462F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LightningStrikeOnHit, "DisplayChargedPerforator",
                                                                       "Chest",
                                                                       new Vector3(-0.276F, 0.239F, -0.072F),
                                                                       new Vector3(315.747F, 100.982F, 166.6977F),
                                                                       new Vector3(1.362F, 1.362F, 1.362F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarDagger, "DisplayLunarDagger",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.026F, 0.359F),
                                                                       new Vector3(27.04753F, 179.6618F, 269.2563F),
                                                                       new Vector3(0.381F, 0.393F, 0.381F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarPrimaryReplacement, "DisplayBirdEye",
                                                                       "Staff",
                                                                       new Vector3(0F, 1.226F, 0F),
                                                                       new Vector3(286.612F, 180F, 180F),
                                                                       new Vector3(0.798F, 0.798F, 0.798F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarSecondaryReplacement, "DisplayBirdClaw",
                                                                       "LowerArmL",
                                                                       new Vector3(0.013F, 0.391F, 0.1F),
                                                                       new Vector3(0F, 277.3215F, 280.5488F),
                                                                       new Vector3(0.427F, 0.427F, 0.427F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarSpecialReplacement, "DisplayBirdHeart",
                                                                       "Root",
                                                                       new Vector3(0.505F, 1.944F, -0.351F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.16244F, 0.16244F, 0.16244F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarTrinket, "DisplayBeads",
                                                                       "Staff",
                                                                       new Vector3(0F, 0.279F, 0F),
                                                                       new Vector3(0F, 0F, 90F),
                                                                       new Vector3(1.6F, 1.6F, 1.6F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LunarUtilityReplacement, "DisplayBirdFoot",
                                                                       "Staff",
                                                                       new Vector3(-0.001F, -0.159F, 0.081F),
                                                                       new Vector3(0F, 90F, 90F),
                                                                       new Vector3(0.899F, 0.899F, 0.899F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Medkit, "DisplayMedkit",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.062F, -0.161F),
                                                                       new Vector3(270F, 180F, 0F),
                                                                       new Vector3(0.824F, 0.824F, 0.824F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Missile, "DisplayMissileLauncher",
                                                                       "Chest",
                                                                       new Vector3(-0.428F, 0.596F, -0.204F),
                                                                       new Vector3(353.6533F, 0.00001F, 0F),
                                                                       new Vector3(0.097F, 0.097F, 0.097F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MissileVoid, "DisplayMissileLauncherVoid",
                                                                       "Spine",
                                                                       new Vector3(-0.478F, 0.869F, -0.02F),
                                                                       new Vector3(3.61074F, 0.00001F, 0F),
                                                                       new Vector3(0.103F, 0.103F, 0.103F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.MonstersOnShrineUse, "DisplayMonstersOnShrineUse",
                                                                       "Spine",
                                                                       new Vector3(0.038F, 0.096F, -0.18F),
                                                                       new Vector3(54.70983F, 90F, 0F),
                                                                       new Vector3(0.105F, 0.105F, 0.105F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Mushroom, "DisplayMushroom",
                                                                       "Chest",
                                                                       new Vector3(0.642F, 0.324F, -0.05F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.064F, 0.064F, 0.064F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MushroomVoid, "DisplayMushroomVoid",
                                                                       "Chest",
                                                                       new Vector3(0.674F, 0.335F, -0.068F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.046F, 0.046F, 0.046F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.NearbyDamageBonus, "DisplayDiamond",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.121F, 0.081F),
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
                                                                       new Vector3(0F, 0.178F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(-0.891F, 0.891F, -0.921F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.NovaOnLowHealth, "DisplayJellyGuts",
                                                                       "Head",
                                                                       new Vector3(-0.044F, 0.29F, 0.074F),
                                                                       new Vector3(70.6662F, 180F, 180F),
                                                                       new Vector3(0.137F, 0.137F, 0.137F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ParentEgg, "DisplayParentEgg",
                                                                       "Spine",
                                                                       new Vector3(0F, 0.065F, 0.168F),
                                                                       new Vector3(12.56524F, 0F, 0F),
                                                                       new Vector3(0.085F, 0.085F, 0.085F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Pearl, "DisplayPearl",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.304F, 0F),
                                                                       new Vector3(270F, 0.00001F, 0F),
                                                                       new Vector3(0.123F, 0.123F, 0.123F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.PersonalShield, "DisplayShieldGenerator",
                                                                       "LowerArmR",
                                                                       new Vector3(0F, 0.117F, 0.072F),
                                                                       new Vector3(80.30421F, 180F, 0F),
                                                                       new Vector3(0.2F, 0.2F, 0.2F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Phasing, "DisplayStealthkit",
                                                                       "Hips",
                                                                       new Vector3(0F, 0.045F, 0.149F),
                                                                       new Vector3(270F, 0.00001F, 0F),
                                                                       new Vector3(0.343F, 0.365F, 0.365F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Plant, "DisplayInterstellarDeskPlant",
                                                                       "UpperArmL",
                                                                       new Vector3(-0.006F, 0.463F, 0.079F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.095F, 0.094F, 0.094F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.RandomDamageZone, "DisplayRandomDamageZone",
                                                                       "Head",
                                                                       new Vector3(0F, 0.388F, -0.018F),
                                                                       new Vector3(57.56997F, 0F, 0F),
                                                                       new Vector3(0.066F, 0.086F, 0.086F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.RepeatHeal, "DisplayCorpseFlower",
                                                                       "Staff",
                                                                       new Vector3(0F, 1.435F, 0.269F),
                                                                       new Vector3(52.92662F, 0F, 0F),
                                                                       new Vector3(0.433F, 0.433F, 0.433F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SecondarySkillMagazine, "DisplayDoubleMag",
                                                                       "Staff",
                                                                       new Vector3(-0.006F, 1.102F, 0.262F),
                                                                       new Vector3(293.7661F, 180F, 180F),
                                                                       new Vector3(0.092F, 0.075F, 0.095F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Seed, "DisplaySeed", //don
                                                                       "Chest",
                                                                       new Vector3(-0.464F, 0.337F, -0.034F),
                                                                       new Vector3(330.0132F, 62.84436F, 123.1749F),
                                                                       new Vector3(0.045F, 0.045F, 0.045F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.ShieldOnly,
                ItemDisplays.CreateDisplayRule("DisplayShieldBug",
                                               "Head",
                                                                       new Vector3(-0.049F, 0.156F, -0.146F),
                                                                       new Vector3(345.8107F, 93.77667F, 143.4084F),
                                                                       new Vector3(0.428F, -0.428F, 0.428F)),
                ItemDisplays.CreateDisplayRule("DisplayShieldBug",
                                               "Head",
                                                                       new Vector3(0.112F, 0.162F, -0.11F),
                                                                       new Vector3(13.58704F, 78.49554F, 154.8037F),
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
                                                                       new Vector3(0F, 0.14F, -0.204F),
                                                                       new Vector3(274.4081F, 0F, 0F),
                                                                       new Vector3(0.405F, 0.367F, 0.405F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.None)
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SiphonOnLowHealth, "DisplaySiphonOnLowHealth",
                                                                       "Hips",
                                                                       new Vector3(0.245F, 0.042F, 0F),
                                                                       new Vector3(0F, 91.50988F, 0F),
                                                                       new Vector3(0.054F, 0.054F, 0.054F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SlowOnHit, "DisplayBauble",
                                                                       "Staff",
                                                                       new Vector3(-0.011F, 1.504F, 0.057F),
                                                                       new Vector3(0F, 258.8748F, 0F),
                                                                       new Vector3(-0.372F, -0.372F, -0.372F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.SlowOnHitVoid, "DisplayBaubleVoid",
                                                                       "Chest",
                                                                       new Vector3(-0.05F, -0.072F, -0.082F),
                                                                       new Vector3(34.56912F, 80.53242F, 297.2141F),
                                                                       new Vector3(0.459F, 0.459F, 0.459F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintArmor, "DisplayBuckler",
                                                                       "LowerArmL",
                                                                       new Vector3(0F, 0.267F, 0.077F),
                                                                       new Vector3(10.70441F, 0F, 0F),
                                                                       new Vector3(0.201F, 0.201F, 0.212F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintBonus, "DisplaySoda",
                                                                       "Hips",
                                                                       new Vector3(-0.201F, 0.065F, -0.005F),
                                                                       new Vector3(274.0116F, 180F, 180F),
                                                                       new Vector3(0.241F, 0.241F, 0.241F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintOutOfCombat, "DisplayWhip",
                                                                       "Hips",
                                                                       new Vector3(-0.223F, -0.118F, -0.095F),
                                                                       new Vector3(0F, 332.451F, 344.7224F),
                                                                       new Vector3(0.471F, 0.471F, 0.471F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintWisp, "DisplayBrokenMask",
                                                                       "Head",
                                                                       new Vector3(-0.158F, 0.187F, -0.104F),
                                                                       new Vector3(352.4009F, 246.1753F, 25.28349F),
                                                                       new Vector3(0.329F, 0.28F, 0.28F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Squid, "DisplaySquidTurret",
                                                                "Chest",
                                                                       new Vector3(-0.38F, 0.281F, -0.072F),
                                                                       new Vector3(7.61121F, 43.84381F, 350.6197F),
                                                                       new Vector3(0.065F, 0.065F, 0.065F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.StickyBomb, "DisplayStickyBomb",
                                                                       "Staff",
                                                                       new Vector3(0.00101F, -0.23676F, -0.02713F),
                                                                       new Vector3(0F, 0F, 308.9087F),
                                                                       new Vector3(0.3F, 0.3F, 0.3F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.StunChanceOnHit, "DisplayStunGrenade",
                                                                       "Chest",
                                                                       new Vector3(0.122F, 0.099F, 0.157F),
                                                                       new Vector3(290.7513F, 272.3995F, 116.1337F),
                                                                       new Vector3(0.568F, 0.568F, 0.568F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Syringe, "DisplaySyringeCluster",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.193F, -0.202F),
                                                                       new Vector3(282.4055F, 0.00002F, -0.00001F),
                                                                       new Vector3(0.196F, 0.196F, 0.196F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Talisman, "DisplayTalisman",
                                                                       "Root",
                                                                       new Vector3(0.288F, 1.833F, -0.813F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.55617F, 0.55617F, 0.55617F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TPHealingNova, "DisplayGlowFlower",
                                                                       "Head",
                                                                       new Vector3(0.093F, 0.212F, -0.124F),
                                                                       new Vector3(344.2946F, 125.722F, 229.4036F),
                                                                       new Vector3(0.53F, 0.53F, 0.53F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Thorns, "DisplayRazorwireLeft",
                                                                "UpperArmL",
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.77F, 0.77F, 0.77F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TitanGoldDuringTP, "DisplayGoldHeart",
                                                                       "Staff",
                                                                       new Vector3(-0.017F, 1.479F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.194F, 0.194F, 0.194F)));
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
                                                                       "Staff",
                                                                       new Vector3(-0.001F, 0.758F, -0.034F),
                                                                       new Vector3(0F, 90.95602F, 102.5071F),
                                                                       new Vector3(1.802F, 1.802F, 1.802F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.TreasureCacheVoid, "DisplayKeyVoid",
                                                                       "Staff",
                                                                       new Vector3(0F, 0.754F, 0.01F),
                                                                       new Vector3(30.23697F, 0F, 270F),
                                                                       new Vector3(1.333F, 1.333F, 1.333F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.UtilitySkillMagazine,
                ItemDisplays.CreateDisplayRule("DisplayAfterburnerShoulderRing",
                                               "Head",
                                                                       new Vector3(0.255F, 0.486F, -0.223F),
                                                                       new Vector3(47.37375F, 90F, 180F),
                                                                       new Vector3(0.3F, 0.3F, 0.3F)),
                ItemDisplays.CreateDisplayRule("DisplayAfterburnerShoulderRing",
                                               "Head",
                                                                       new Vector3(-0.248F, 0.488F, -0.197F),
                                                                       new Vector3(313.5355F, 90F, 180F),
                                                                       new Vector3(0.3F, 0.3F, 0.3F))
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.WarCryOnMultiKill, "DisplayPauldron",
                                                                       "Head",
                                                                       new Vector3(0F, 0.219F, -0.172F),
                                                                       new Vector3(270F, 0.00001F, 0F),
                                                                       new Vector3(0.787F, 0.787F, 0.787F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.WardOnLevel, "DisplayWarbanner",
                                                                       "Chest",
                                                                       new Vector3(0.057F, 0.07F, -0.192F),
                                                                       new Vector3(338.8275F, 209.4081F, 42.74953F),
                                                                       new Vector3(0.64F, 0.64F, 0.64F)));
            #endregion items

            #region quips
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.BFG, "DisplayBFG",
                                                                       "Chest",
                                                                       new Vector3(-0.628F, 0.289F, -0.114F),
                                                                       new Vector3(356.6259F, 0.00001F, 0F),
                                                                       new Vector3(0.425F, 0.425F, 0.425F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Blackhole, "DisplayGravCube",
                                                                       "Root",
                                                                       new Vector3(0F, 2.669F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.45897F, 0.45897F, 0.45897F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Cleanse, "DisplayWaterPack",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.079F, 0.154F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.095F, 0.095F, 0.095F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CommandMissile, "DisplayMissileRack",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.24F, -0.27F),
                                                                       new Vector3(69.06752F, 180F, 0F),
                                                                       new Vector3(0.502F, 0.502F, 0.502F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.BurnNearby, "DisplayPotion",
                                                                       "Hips",
                                                                       new Vector3(-0.12F, 0.072F, -0.145F),
                                                                       new Vector3(0F, 0F, 322.8796F),
                                                                       new Vector3(0.039F, 0.039F, 0.039F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CrippleWard, "DisplayEffigy",
                                                                       "Chest",
                                                                       new Vector3(-0.061F, -0.021F, -0.26F),
                                                                       new Vector3(0F, 0F, 341.444F),
                                                                       new Vector3(1.043F, 1.043F, 1.043F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CritOnUse, "DisplayNeuralImplant",
                                                                       "Head",
                                                                       new Vector3(0F, 0.121F, 0.511F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.361F, 0.311F, 0.279F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.DeathProjectile, "DisplayDeathProjectile",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.138F, -0.276F),
                                                                       new Vector3(0F, 180F, 0F),
                                                                       new Vector3(0.131F, 0.131F, 0.131F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.DroneBackup, "DisplayRadio",
                                                                       "Hips",
                                                                       new Vector3(0F, 0.172F, 0.128F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.507F, 0.507F, 0.507F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Equipment.AffixRed,
                ItemDisplays.CreateDisplayRule("DisplayEliteHorn",
                                               "Head",
                                                                       new Vector3(0.094F, 0.211F, 0.08F),
                                                                       new Vector3(68.41402F, 0F, 0F),
                                                                       new Vector3(0.109F, 0.109F, 0.109F)),
                ItemDisplays.CreateDisplayRule("DisplayEliteHorn",
                                               "Head",
                                                                       new Vector3(-0.105F, 0.219F, 0.098F),
                                                                       new Vector3(73.02985F, 0F, 0F),
                                                                       new Vector3(-0.109F, 0.109F, 0.109F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixHaunted, "DisplayEliteStealthCrown",
                                                                       "Head",
                                                                       new Vector3(0F, 0.319F, 0.005F),
                                                                       new Vector3(75.39037F, 0F, 0F),
                                                                       new Vector3(-0.061F, -0.055F, -0.055F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixWhite, "DisplayEliteIceCrown",
                                                                       "Head",
                                                                       new Vector3(0F, 0.245F, -0.022F),
                                                                       new Vector3(304.1333F, 180F, 180F),
                                                                       new Vector3(0.033F, 0.033F, 0.033F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Equipment.AffixBlue,
                ItemDisplays.CreateDisplayRule("DisplayEliteRhinoHorn",
                                               "Head",
                                                                       new Vector3(0F, 0.316F, -0.003F),
                                                                       new Vector3(291.7304F, 180F, 180F),
                                                                       new Vector3(0.305F, 0.31F, 0.262F)),
                ItemDisplays.CreateDisplayRule("DisplayEliteRhinoHorn",
                                               "Head",
                                                                       new Vector3(0F, 0.305F, 0.11F),
                                                                       new Vector3(288.8945F, 0.00002F, -0.00001F),
                                                                       new Vector3(-0.199F, 0.202F, 0.159F))
                ));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixLunar, "DisplayEliteLunar,Eye",
                                                                       "Head",
                                                                       new Vector3(0F, 0.561F, -0.071F),
                                                                       new Vector3(71.63628F, 0F, 0F),
                                                                       new Vector3(0.51F, 0.473F, 0.51F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.AffixPoison, "DisplayEliteUrchinCrown",
                                                                       "Head",
                                                                       new Vector3(0F, 0.24F, 0.011F),
                                                                       new Vector3(270.6974F, 180.0022F, 269.9978F),
                                                                       new Vector3(0.054F, 0.054F, 0.054F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.FireBallDash, "DisplayEgg",
                                                                       "Chest",
                                                                       new Vector3(0F, -0.006F, -0.247F),
                                                                       new Vector3(270F, 0F, 0F),
                                                                       new Vector3(0.472F, 0.472F, 0.472F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Fruit, "DisplayFruit",
                                                                       "Chest",
                                                                       new Vector3(-0.124F, 0.278F, 0.278F),
                                                                       new Vector3(63.86541F, 266.3865F, 122.9459F),
                                                                       new Vector3(0.335F, 0.335F, 0.346F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.GainArmor, "DisplayElephantFigure",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.046F, -0.299F),
                                                                       new Vector3(282.3987F, 180F, 180F),
                                                                       new Vector3(1.032F, 1.032F, 1.032F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Gateway, "DisplayVase",
                                                                       "Chest",
                                                                       new Vector3(-0.054F, 0.182F, -0.24F),
                                                                       new Vector3(343.8488F, 349.1142F, 34.65776F),
                                                                       new Vector3(0.275F, 0.275F, 0.275F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.GoldGat, "DisplayGoldGat",
                                                                       "Chest",
                                                                       new Vector3(-0.627F, 0.615F, -0.125F),
                                                                       new Vector3(0F, 93.71225F, 0F),
                                                                       new Vector3(0.133F, 0.133F, 0.133F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Jetpack, "DisplayBugWings",
                                                                       "Chest",
                                                                       new Vector3(0F, -0.078F, -0.085F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.206F, 0.206F, 0.206F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.LifestealOnHit, "DisplayLifestealOnHit",
                                                                       "Neck",
                                                                       new Vector3(-0.02F, 0.147F, -0.269F),
                                                                       new Vector3(14.9227F, 0.7F, 359.3365F),
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
                                                                       new Vector3(0F, 2.632F, 0F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.57588F, 0.57662F, 0.57662F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.QuestVolatileBattery, "DisplayBatteryArray",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.034F, -0.315F),
                                                                       new Vector3(3.67658F, 180F, 180F),
                                                                       new Vector3(0.397F, 0.397F, 0.397F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Recycle, "DisplayRecycler",
                                                                       "Chest",
                                                                       new Vector3(0.057F, 0.064F, -0.261F),
                                                                       new Vector3(0F, 90F, 354.3717F),
                                                                       new Vector3(0.085F, 0.085F, 0.085F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Saw, "DisplaySawmerangFollower",
                                                                       "Root",
                                                                       new Vector3(-0.004F, 2.568F, -0.046F),
                                                                       new Vector3(271.0232F, 185.0242F, 175.0119F),
                                                                       new Vector3(0.141F, 0.141F, 0.141F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Scanner, "DisplayScanner",
                                                                       "Chest",
                                                                       new Vector3(-0.648F, 0.293F, -0.068F),
                                                                       new Vector3(281.7952F, 180F, 180F),
                                                                       new Vector3(0.178F, 0.178F, 0.178F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.TeamWarCry, "DisplayTeamWarCry",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.127F, -0.261F),
                                                                       new Vector3(353.8062F, 180F, 180F),
                                                                       new Vector3(0.104F, 0.104F, 0.104F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.Tonic, "DisplayTonic",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.113F, -0.224F),
                                                                       new Vector3(354.6881F, 0F, 0F),
                                                                       new Vector3(0.269F, 0.269F, 0.269F)));

            #endregion quips

            #region dlc1

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PrimarySkillShuriken, "DisplayShuriken",
                                                                       "Staff",
                                                                       new Vector3(0F, 0.255F, -0.014F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.44F, 0.44F, 0.44F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.OutOfCombatArmor, "DisplayOddlyShapedOpal",
                                                                       "Staff",
                                                                       new Vector3(0F, 1.005F, 0.065F),
                                                                       new Vector3(22.94225F, 180F, 180F),
                                                                       new Vector3(0.449F, 0.449F, 0.453F)));
            //head
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(DLC1Content.Items.LunarSun,
                ItemDisplays.CreateDisplayRule("DisplaySunHead",
                                               "Head",
                                                                       new Vector3(0F, 0.119F, 0.054F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.994F, 0.997F, 0.997F)),
                ItemDisplays.CreateDisplayRule("DisplaySunHeadNeck",
                                               "Neck",
                                                                       new Vector3(0.007F, 0.027F, -0.02F),
                                                                       new Vector3(0F, 270F, 0F),
                                                                       new Vector3(1.681F, 1.498F, -1.885F)),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.Head)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MinorConstructOnKill, "DisplayDefenseNucleus",
                                                                       "Root",
                                                                       new Vector3(-0.374F, 2.148F, -0.536F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.28452F, 0.2811F, 0.2811F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HalfAttackSpeedHalfCooldowns, "DisplayLunarShoulderNature",
                                                                       "Head",
                                                                       new Vector3(0F, -0.055F, 0.189F),
                                                                       new Vector3(0F, 90F, 55.68917F),
                                                                       new Vector3(0.725F, 0.725F, 0.517F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HalfSpeedDoubleHealth, "DisplayLunarShoulderStone",
                                                                       "Head",
                                                                       new Vector3(0F, 0.307F, 0.087F),
                                                                       new Vector3(0F, 270F, 267.0847F),
                                                                       new Vector3(0.811F, 0.811F, 0.982F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.AttackSpeedAndMoveSpeed, "DisplayCoffee",
                                                                       "Hips",
                                                                       new Vector3(0.144F, 0.062F, -0.144F),
                                                                       new Vector3(358.4995F, 340.8977F, 355.4437F),
                                                                       new Vector3(0.168F, 0.168F, 0.168F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.GoldOnHurt, "DisplayRollOfPennies",
                                                                       "Staff",
                                                                       new Vector3(0F, -0.198F, -0.043F),
                                                                       new Vector3(86.22836F, 0F, 0F),
                                                                       new Vector3(0.983F, 0.983F, 0.983F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.FragileDamageBonus, "DisplayDelicateWatch",
                                                                       "LowerArmR",
                                                                       new Vector3(0F, 0.18F, 0.027F),
                                                                       new Vector3(85.66948F, 180F, 180F),
                                                                       new Vector3(0.867F, 1.471F, 0.886F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ImmuneToDebuff, "DisplayRainCoatBelt",
                                                                       "Hips",
                                                                       new Vector3(-0.017F, 0.077F, -0.01F),
                                                                       new Vector3(5.67388F, 0F, 0F),
                                                                       new Vector3(0.977F, 0.845F, 0.845F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RandomEquipmentTrigger, "DisplayBottledChaos",
                                                                       "Spine",
                                                                       new Vector3(0F, -0.044F, -0.152F),
                                                                       new Vector3(355.1696F, 0F, 0F),
                                                                       new Vector3(0.215F, 0.215F, 0.215F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.StrengthenBurn, "DisplayGasTank",
                                                                       "Coat1",
                                                                       new Vector3(-0.11F, 0.131F, 0.212F),
                                                                       new Vector3(11.24596F, 0F, 0F),
                                                                       new Vector3(0.139F, 0.139F, 0.139F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.VoidMegaCrabItem, "DisplayMegaCrabItem",
                                                                       "Staff",
                                                                       new Vector3(0F, 1.582F, -0.002F),
                                                                       new Vector3(85.22649F, 0F, 0F),
                                                                       new Vector3(0.188F, 0.188F, 0.188F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RegeneratingScrap, "DisplayRegeneratingScrap",
                                                                       "HandL",
                                                                       new Vector3(0.00102F, 0.14214F, 0.01592F),
                                                                       new Vector3(5.9476F, 174.2809F, 172.4873F),
                                                                       new Vector3(0.225F, 0.225F, 0.225F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PermanentDebuffOnHit, "DisplayScorpion",
                                                                       "Chest",
                                                                       new Vector3(0F, 0.188F, -0.115F),
                                                                       new Vector3(344.2816F, 0F, 0F),
                                                                       new Vector3(0.963F, 0.963F, 0.963F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CritDamage, "DisplayLaserSight",
                                                                       "Head",
                                                                       new Vector3(0.153F, 0.155F, 0.109F),
                                                                       new Vector3(90F, 90F, 0F),
                                                                       new Vector3(0.089F, 0.089F, 0.089F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.FreeChest, "DisplayShippingRequestForm",
                                                                       "Staff",
                                                                       new Vector3(0F, 0.566F, 0F),
                                                                       new Vector3(32.92329F, 0F, 26.54572F),
                                                                       new Vector3(0.662F, 0.664F, 0.662F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoveSpeedOnKill, "DisplayGrappleHook",
                                                                       "HandL",
                                                                       new Vector3(0F, 0.057F, 0.046F),
                                                                       new Vector3(342.545F, 165.3742F, 184.4758F),
                                                                       new Vector3(0.219F, 0.219F, 0.219F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RandomlyLunar, "DisplayDomino",
                                                                       "Root",
                                                                       new Vector3(-0.944F, 1.324F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(1.78067F, 1.78067F, 1.78067F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HealingPotion, "DisplayHealingPotion",
                                                                       "Hips",
                                                                       new Vector3(0.183F, 0.063F, 0.092F),
                                                                       new Vector3(349.5982F, 357.4122F, 14.05364F),
                                                                       new Vector3(0.063F, 0.063F, 0.063F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoreMissile, "DisplayICBM",
                                                                       "Spine",
                                                                       new Vector3(-0.145F, 0.025F, -0.16F),
                                                                       new Vector3(354.6163F, 0F, 0F),
                                                                       new Vector3(0.096F, 0.096F, 0.096F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(DLC1Content.Equipment.BossHunter,
                ItemDisplays.CreateDisplayRule("DisplayTricornGhost",
                                               "Head",
                                                                       new Vector3(0F, 0.361F, 0.005F),
                                                                       new Vector3(28.45431F, 0F, 0F),
                                                                       new Vector3(0.623F, 0.623F, 0.623F)),
                ItemDisplays.CreateDisplayRule("DisplayBlunderbuss",
                                               "Root",
                                                                       new Vector3(0F, 2.91544F, 0.00336F),
                                                                       new Vector3(90F, 0F, 0F),
                                                                       new Vector3(0.65983F, 0.65983F, 0.65983F))));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.BossHunterConsumed, "DisplayTricornUsed",
                                                                       "Head",
                                                                       new Vector3(0F, 0.37F, -0.051F),
                                                                       new Vector3(17.74602F, 0F, 0F),
                                                                       new Vector3(0.757F, 0.757F, 0.757F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.EliteVoidEquipment, "DisplayAffixVoid",
                                                                       "Head",
                                                                       new Vector3(0F, 0.08F, 0.149F),
                                                                       new Vector3(89.19473F, 180F, 180F),
                                                                       new Vector3(0.199F, 0.199F, 0.199F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.GummyClone, "DisplayGummyClone",
                                                                       "Chest",
                                                                       new Vector3(0.02F, 0.18F, -0.221F),
                                                                       new Vector3(355.3549F, 328.7025F, 2.81858F),
                                                                       new Vector3(0.294F, 0.294F, 0.294F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule("IrradiatingLaser", "DisplayIrradiatingLaser",
                                                                       "Chest",
                                                                       new Vector3(-0.559F, 0.308F, -0.096F),
                                                                       new Vector3(0F, 0F, 344.9919F),
                                                                       new Vector3(0.169F, 0.169F, 0.169F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.LunarPortalOnUse, "DisplayLunarPortalOnUse",
                                                                       "Root",
                                                                       new Vector3(0F, 3.18618F, 0F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.47222F, 0.47222F, 0.47222F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.Molotov, "DisplayMolotov",
                                                                       "Chest",
                                                                       new Vector3(0F, -0.046F, -0.18F),
                                                                       new Vector3(350.9389F, 0F, 0F),
                                                                       new Vector3(0.302F, 0.302F, 0.302F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.MultiShopCard, "DisplayExecutiveCard",
                                                                       "Staff",
                                                                       new Vector3(-0.003F, 0.641F, -0.021F),
                                                                       new Vector3(0F, 54.12595F, 0F),
                                                                       new Vector3(1.217F, 1.243F, 1.282F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Equipment.VendingMachine, "DisplayVendingMachine",
                                                                       "Chest",
                                                                       new Vector3(0.001F, 0.187F, -0.184F),
                                                                       new Vector3(9.90617F, 156.248F, 355.6707F),
                                                                       new Vector3(0.346F, 0.346F, 0.346F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Elites.Earth.eliteEquipmentDef, "DisplayEliteMendingAntlers",
                                                                       "Head",
                                                                       new Vector3(0F, 0.223F, 0.101F),
                                                                       new Vector3(73.20102F, 0F, 0F),
                                                                       new Vector3(0.988F, 0.988F, 0.988F)));

            #endregion


            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("com.DestroyedClone.AncientScepter"))
            {
                FixScepterDisplayRule(itemDisplayRules);
            }

            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("com.KomradeSpectre.Aetherium"))
            {
                SetAetheriumDisplayRules(itemDisplayRules);
            }


        }

        #region scepter

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private void FixScepterDisplayRule(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(AncientScepter.AncientScepterItem.instance.ItemDef,
                                                                       AncientScepter.AncientScepterItem.displayPrefab,
                                                                       "Staff",
                                                                       new Vector3(-0.005F, 0.776F, -0.032F),
                                                                       new Vector3(1.86516F, 229.9181F, 357.8922F),
                                                                       new Vector3(0.685F, 0.488F, 0.623F)));
        }

        #endregion scepter

        #region aeth
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private void SetAetheriumDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.AccursedPotion.instance.ItemDef,
                                                                       Aetherium.Items.AccursedPotion.ItemBodyModelPrefab,
                                                                       "Hips",
                                                                       new Vector3(-0.14109F, 0.06631F, -0.14107F), 
                                                                       new Vector3(2.0568F, 234.6652F, 2.4988F),
                                                                       new Vector3(0.06197F, 0.06197F, 0.06197F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.AlienMagnet.instance.ItemDef,
                                                                       Aetherium.Items.AlienMagnet.ItemBodyModelPrefab,
                                                                       "Root",
                                                                       new Vector3(-0.85034F, 1.83867F, -0.0771F),
                                                                       new Vector3(351.4943F, 0F, 0F),
                                                                       new Vector3(0.10931F, 0.10931F, 0.10931F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.BlasterSword.instance.ItemDef,
                                                                       Aetherium.Items.BlasterSword.ItemBodyModelPrefab,
                                                                       "Staff",
                                                                       new Vector3(-0.00001F, 1.5612F, 0.10585F),
                                                                       new Vector3(0F, 270F, 340.9426F),
                                                                       new Vector3(0.05965F, 0.05965F, 0.05965F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.BloodthirstyShield.instance.ItemDef,
                                                                       Aetherium.Items.BloodthirstyShield.ItemBodyModelPrefab,
                                                                       "LowerArmR",
                                                                       new Vector3(-0.01104F, 0.23983F, 0.12377F),
                                                                       new Vector3(15.93536F, 0F, 0F),
                                                                       new Vector3(0.18505F, 0.18505F, 0.18505F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.EngineersToolbelt.instance.ItemDef,
                                                                       Aetherium.Items.EngineersToolbelt.ItemBodyModelPrefab,
                                                                       "Hips",
                                                                       new Vector3(-0.00021F, 0.06833F, -0.02068F),
                                                                       new Vector3(6.90201F, 0F, 0F),
                                                                       new Vector3(0.23429F, 0.24265F, 0.15727F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.FeatheredPlume.instance.ItemDef,
                                                                       Aetherium.Items.FeatheredPlume.ItemBodyModelPrefab,
                                                                       "UpperArmL",
                                                                       new Vector3(0.32071F, 0.1289F, -0.45445F), 
                                                                       new Vector3(44.31231F, 289.3011F, 194.5541F),
                                                                       new Vector3(0.25964F, 0.18505F, 0.23623F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.Voidheart.instance.ItemDef,
                                                                       Aetherium.Items.Voidheart.ItemBodyModelPrefab,
                                                                       "Spine",
                                                                       new Vector3(-0.0061F, 0.10382F, 0.1135F),
                                                                       new Vector3(19.57261F, 324.6978F, 346.6553F),
                                                                       new Vector3(0.09114F, 0.09114F, 0.09114F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.InspiringDrone.instance.ItemDef,
                                                                       Aetherium.Items.InspiringDrone.ItemBodyModelPrefab,
                                                                       "Root",
                                                                       new Vector3(0.52308F, 2.89943F, -0.59161F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(1F, 1F, 1F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.NailBomb.instance.ItemDef,
                                                                       Aetherium.Items.NailBomb.ItemBodyModelPrefab,
                                                                       "Hips",
                                                                       new Vector3(0.06799F, 0.06878F, 0.1312F),
                                                                       new Vector3(86.4837F, 328.9632F, 314.8166F),
                                                                       new Vector3(0.09878F, 0.09878F, 0.09878F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.SharkTeeth.instance.ItemDef,
                                                                       Aetherium.Items.SharkTeeth.ItemBodyModelPrefab,
                                                                       "Head",
                                                                       new Vector3(0.00029F, 0.12822F, 0.15634F),
                                                                       new Vector3(28.23062F, 359.9906F, 179.9626F),
                                                                       new Vector3(0.13962F, 0.14138F, 0.13048F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.ShieldingCore.instance.ItemDef,
                                                                       Aetherium.Items.ShieldingCore.ItemBodyModelPrefab,
                                                                       "Spine",
                                                                       new Vector3(0F, 0.09549F, 0.05051F),
                                                                       new Vector3(0F, 90F, 96.66299F),
                                                                       new Vector3(0.3908F, 0.3908F, 0.3908F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.UnstableDesign.instance.ItemDef,
                                                                       Aetherium.Items.UnstableDesign.ItemBodyModelPrefab,
                                                                       "Chest",
                                                                       new Vector3(0.00771F, 0.25115F, -0.24186F),
                                                                       new Vector3(359.6312F, 44.63948F, 0.45308F),
                                                                       new Vector3(0.88639F, 0.88639F, 0.88639F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.WeightedAnklet.instance.ItemDef,
                                                                       Aetherium.Items.WeightedAnklet.ItemBodyModelPrefab,
                                                                       "Root",
                                                                       new Vector3(0.0045F, 0.21226F, -0.00913F),
                                                                       new Vector3(3.47227F, 0F, 7.27702F),
                                                                       new Vector3(0.34528F, 0.26704F, 0.31415F)));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(Aetherium.Items.WitchesRing.instance.ItemDef,
                ItemDisplays.CreateDisplayRule(Aetherium.Items.WitchesRing.ItemBodyModelPrefab,
                                               "HandR",
                                                                       new Vector3(-0.00001F, 0.11169F, 0.00156F),
                                                                       new Vector3(0F, 0F, 0F),
                                                                       new Vector3(0.09351F, 0.1016F, 0.09351F)),
                ItemDisplays.CreateDisplayRule(Aetherium.Items.WitchesRing.CircleBodyModelPrefab,
                                               "Staff",
                                                                       new Vector3(0.00327F, 1.24736F, -0.00034F),
                                                                       new Vector3(0F, 90F, 270F),
                                                                       new Vector3(0.45336F, 0.45336F, 0.02619F))
                ));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(Aetherium.Items.ZenithAccelerator.instance.ItemDef,
                                                                       Aetherium.Items.ZenithAccelerator.ItemBodyModelPrefab,
                                                                       "Staff",
                                                                       new Vector3(-0.00698F, 1.75696F, 0.04377F),
                                                                       new Vector3(0F, 180F, 180F),
                                                                       new Vector3(0.1688F, 0.1688F, 0.1688F)));
        }
        #endregion aeth
    }
}
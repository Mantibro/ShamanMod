using BepInEx.Configuration;
using ShamanMod.Modules.Characters;
using RoR2;
using R2API;
using RoR2.Skills;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ShamanMod.Modules.Survivors
{
    internal class ShamanSurvivor : SurvivorBase
    {
        //used when building your character using the prefabs you set up in unity
        //don't upload to thunderstore without changing this
        public override string prefabBodyName => "Shaman";

        public const string SHAMAN_PREFIX = ShamanPlugin.DEVELOPER_PREFIX + "_SHAMAN_BODY_";

        //used when registering your survivor's language tokens
        public override string survivorTokenPrefix => SHAMAN_PREFIX;
        public override BodyInfo bodyInfo { get; set; } = new BodyInfo
        {
            bodyName = "ShamanBody",
            bodyNameToken = SHAMAN_PREFIX + "NAME",
            subtitleNameToken = SHAMAN_PREFIX + "SUBTITLE",
            sortPosition = 20f,

            characterPortrait = ShamanAssets.mainAssetBundle.LoadAsset<Texture>("iconShaman"),
            bodyColor = new Color(0.0392156862745098f, 0.3137254901960784f, 0f),

            crosshair = Modules.ShamanAssets.LoadCrosshair("Captain"),
            //podPrefab = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/NetworkedObjects/SurvivorPod"),
            podPrefab = null,

            maxHealth = Modules.Config.F_ShamanBMaxHealth.Value,//80 By default.
            healthRegen = Modules.Config.F_ShamanBRegen.Value,  //0.9
            armor = Modules.Config.F_ShamanBArmor.Value,        //0
            shield = Modules.Config.F_ShamanBShield.Value,      //0
            jumpCount = Modules.Config.I_ShamanJumpCount.Value, //2
            damage = Modules.Config.F_ShamanBDamage.Value,      //12
            attackSpeed = Modules.Config.F_ShamanBAtkSpd.Value, //1
            crit = Modules.Config.F_ShamanBCrit.Value,          //1
            moveSpeed = Modules.Config.F_ShamanBSpeed.Value,    //7
            acceleration = Modules.Config.F_ShamanBAccel.Value, //80
            jumpPower = Modules.Config.F_ShamanBJump.Value,     //15

            healthGrowth = Modules.Config.F_ShamanLMaxHealth.Value,     //30
            regenGrowth = Modules.Config.F_ShamanLRegen.Value,          //0.2
            armorGrowth = Modules.Config.F_ShamanLArmor.Value,          //0
            shieldGrowth = Modules.Config.F_ShamanLShield.Value,        //0
            damageGrowth = Modules.Config.F_ShamanLDamage.Value,        //2.4
            attackSpeedGrowth = Modules.Config.F_ShamanLAtkSpd.Value,   //0
            critGrowth = Modules.Config.F_ShamanLCrit.Value,            //0
            moveSpeedGrowth = Modules.Config.F_ShamanLSpeed.Value,      //0
            jumpPowerGrowth = Modules.Config.F_ShamanLJump.Value,       //0
        };

        public override CustomRendererInfo[] customRendererInfos { get; set; } = new CustomRendererInfo[] 
        {
                new CustomRendererInfo
                {
                    childName = "shaman",
                    material = Materials.CreateHopooMaterial("shamanMaterial"),
                },
                new CustomRendererInfo
                {
                    childName = "shamanStaff",
                    material = Materials.CreateHopooMaterial("shamanStaffMaterial"),
                }
        };

        public override UnlockableDef characterUnlockableDef => null;

        public override Type characterMainState => typeof(EntityStates.GenericCharacterMain);

        public override ItemDisplaysBase itemDisplays => new ShamanItemDisplays();

                                                                          //if you have more than one character, easily create a config to enable/disable them like this
        public override ConfigEntry<bool> characterEnabledConfig => null; //Modules.Config.CharacterEnableConfig(bodyName);

        private static UnlockableDef masterySkinUnlockableDef;

        public override void InitializeCharacter()
        {
            base.InitializeCharacter();
        }

        public override void InitializeUnlockables()
        {
            //uncomment this when you have a mastery skin. when you do, make sure you have an icon too
           // masterySkinUnlockableDef = UnlockableAPI.AddUnlockable<Modules.Achievements.MasteryAchievement>();
        }

        public override void InitializeHitboxes()
        {
            ChildLocator childLocator = bodyPrefab.GetComponentInChildren<ChildLocator>();

            //example of how to create a hitbox
            //Transform hitboxTransform = childLocator.FindChild("BatonHitbox");
            //Modules.Prefabs.SetupHitbox(prefabCharacterModel.gameObject, hitboxTransform, "Baton");
        }

        public override void InitializeSkills()
        {
            Modules.Skills.CreateSkillFamilies(bodyPrefab);
            string prefix = ShamanPlugin.DEVELOPER_PREFIX;

            SkillLocator skillLocator = bodyPrefab.GetComponent<SkillLocator>();

            skillLocator.passiveSkill.enabled = true;
            skillLocator.passiveSkill.skillNameToken = prefix + "_SHAMAN_BODY_PASSIVE_NAME";
            skillLocator.passiveSkill.skillDescriptionToken = prefix + "_SHAMAN_BODY_PASSIVE_DESCRIPTION";
            skillLocator.passiveSkill.icon = Modules.ShamanAssets.mainAssetBundle.LoadAsset<Sprite>("texShamanPassive");

            #region Primary
            SkillDef shootSkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = prefix + "_SHAMAN_BODY_PRIMARY_STAFF_NAME",
                skillNameToken = prefix + "_SHAMAN_BODY_PRIMARY_STAFF_NAME",
                skillDescriptionToken = prefix + "_SHAMAN_BODY_PRIMARY_STAFF_DESCRIPTION",
                skillIcon = Modules.ShamanAssets.mainAssetBundle.LoadAsset<Sprite>("texShamanPrimary"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(SkillStates.StaffCast)),
                activationStateMachineName = "Weapon",
                baseMaxStock = 1,
                baseRechargeInterval = 0f,
                beginSkillCooldownOnSkillEnd = true,
                canceledFromSprinting = false,
                forceSprintDuringState = false,
                fullRestockOnAssign = true,
                interruptPriority = EntityStates.InterruptPriority.Skill,
                resetCooldownTimerOnUse = false,
                isCombatSkill = true,
                mustKeyPress = false,
                cancelSprintingOnActivation = true,
                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1
            });



            Modules.Skills.AddPrimarySkills(bodyPrefab, shootSkillDef);
            #endregion

            #region Secondary
            SkillDef batonSkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = prefix + "_SHAMAN_BODY_SECONDARY_HEALORB_NAME",
                skillNameToken = prefix + "_SHAMAN_BODY_SECONDARY_HEALORB_NAME",
                skillDescriptionToken = prefix + "_SHAMAN_BODY_SECONDARY_HEALORB_DESCRIPTION",
                skillIcon = Modules.ShamanAssets.mainAssetBundle.LoadAsset<Sprite>("texShamanSecondary"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(SkillStates.StaffHealingSkill)),
                activationStateMachineName = "Weapon",
                baseMaxStock = 1,
                baseRechargeInterval = 6f,
                beginSkillCooldownOnSkillEnd = false,
                canceledFromSprinting = false,
                forceSprintDuringState = false,
                fullRestockOnAssign = false,
                interruptPriority = EntityStates.InterruptPriority.Skill,
                resetCooldownTimerOnUse = false,
                isCombatSkill = true,
                mustKeyPress = false,
                cancelSprintingOnActivation = true,
                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1
            });

            SkillDef curseSkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = prefix + "_SHAMAN_BODY_SECONDARY_ALT_CURSEORB_NAME",
                skillNameToken = prefix + "_SHAMAN_BODY_SECONDARY_ALT_CURSEORB_NAME",
                skillDescriptionToken = prefix + "_SHAMAN_BODY_SECONDARY_ALT_CURSEORB_DESCRIPTION",
                skillIcon = Modules.ShamanAssets.mainAssetBundle.LoadAsset<Sprite>("texShamanSecondaryAlt"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(SkillStates.StaffCurseSkill)),
                activationStateMachineName = "Weapon",
                baseMaxStock = 1,
                baseRechargeInterval = 8f,
                beginSkillCooldownOnSkillEnd = false,
                canceledFromSprinting = false,
                forceSprintDuringState = false,
                fullRestockOnAssign = false,
                interruptPriority = EntityStates.InterruptPriority.Any,
                resetCooldownTimerOnUse = false,
                isCombatSkill = true,
                mustKeyPress = false,
                cancelSprintingOnActivation = true,
                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1
            });

            Modules.Skills.AddSecondarySkills(bodyPrefab, batonSkillDef);
            Modules.Skills.AddSecondarySkills(bodyPrefab, curseSkillDef);
            #endregion

            #region Utility
            SkillDef rollSkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = prefix + "_SHAMAN_BODY_UTILITY_GHOSTVEIL_NAME",
                skillNameToken = prefix + "_SHAMAN_BODY_UTILITY_GHOSTVEIL_NAME",
                skillDescriptionToken = prefix + "_SHAMAN_BODY_UTILITY_GHOSTVEIL_DESCRIPTION",
                skillIcon = Modules.ShamanAssets.mainAssetBundle.LoadAsset<Sprite>("texShamanUtility"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(SkillStates.GhostVeil)),
                activationStateMachineName = "Slide",
                baseMaxStock = 1,
                baseRechargeInterval = 20f,
                beginSkillCooldownOnSkillEnd = true,
                canceledFromSprinting = false,
                forceSprintDuringState = false,
                fullRestockOnAssign = true,
                interruptPriority = EntityStates.InterruptPriority.Any,
                resetCooldownTimerOnUse = true,
                isCombatSkill = false,
                mustKeyPress = false,
                cancelSprintingOnActivation = false,
                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1
            });

            SkillDef teleSkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = prefix + "_SHAMAN_BODY_UTILITY_ANCESTRY_ALT_NAME",
                skillNameToken = prefix + "_SHAMAN_BODY_UTILITY_ANCESTRY_ALT_NAME",
                skillDescriptionToken = prefix + "_SHAMAN_BODY_UTILITY_ANCESTRY_ALT_DESCRIPTION",
                skillIcon = Modules.ShamanAssets.mainAssetBundle.LoadAsset<Sprite>("texShamanUtilityAlt"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(SkillStates.Ancestry)),
                activationStateMachineName = "Slide",
                baseMaxStock = 1,
                baseRechargeInterval = 20f,
                beginSkillCooldownOnSkillEnd = false,
                canceledFromSprinting = false,
                forceSprintDuringState = false,
                fullRestockOnAssign = true,
                interruptPriority = EntityStates.InterruptPriority.Any,
                resetCooldownTimerOnUse = true,
                isCombatSkill = false,
                mustKeyPress = false,
                cancelSprintingOnActivation = false,
                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1
            });

            Modules.Skills.AddUtilitySkills(bodyPrefab, rollSkillDef);
            Modules.Skills.AddUtilitySkills(bodyPrefab, teleSkillDef);
            #endregion

            #region Special
            SkillDef ritualSkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = prefix + "_SHAMAN_BODY_SPECIAL_FUSION_NAME",
                skillNameToken = prefix + "_SHAMAN_BODY_SPECIAL_FUSION_NAME",
                skillDescriptionToken = prefix + "_SHAMAN_BODY_SPECIAL_FUSION_DESCRIPTION",
                skillIcon = Modules.ShamanAssets.mainAssetBundle.LoadAsset<Sprite>("texShamanSpecial"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(SkillStates.DistortedFusion)),
                activationStateMachineName = "Body",
                baseMaxStock = 1,
                baseRechargeInterval = 5f,
                beginSkillCooldownOnSkillEnd = true,
                canceledFromSprinting = false,
                forceSprintDuringState = false,
                fullRestockOnAssign = true,
                interruptPriority = EntityStates.InterruptPriority.Any,
                resetCooldownTimerOnUse = false,
                isCombatSkill = true,
                mustKeyPress = false,
                cancelSprintingOnActivation = true,
                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1
            });

            SkillDef frenzySkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = prefix + "_SHAMAN_BODY_SPECIAL_ALT_FERALCALL_NAME",
                skillNameToken = prefix + "_SHAMAN_BODY_SPECIAL_ALT_FERALCALL_NAME",
                skillDescriptionToken = prefix + "_SHAMAN_BODY_SPECIAL_ALT_FERALCALL_DESCRIPTION",
                skillIcon = Modules.ShamanAssets.mainAssetBundle.LoadAsset<Sprite>("texShamanSpecialAlt"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(SkillStates.FeralCall)),
                activationStateMachineName = "Slide",
                baseMaxStock = 1,
                baseRechargeInterval = 40f,
                beginSkillCooldownOnSkillEnd = false,
                canceledFromSprinting = false,
                forceSprintDuringState = false,
                fullRestockOnAssign = true,
                interruptPriority = EntityStates.InterruptPriority.Any,
                resetCooldownTimerOnUse = false,
                isCombatSkill = true,
                mustKeyPress = false,
                cancelSprintingOnActivation = true,
                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1
            });

            Modules.Skills.AddSpecialSkills(bodyPrefab, ritualSkillDef);
            Modules.Skills.AddSpecialSkills(bodyPrefab, frenzySkillDef);

            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("com.DestroyedClone.AncientScepter"))
            {
                InitScepterSkills();
            }

            #endregion
        }

        private void InitScepterSkills()
        {
            string prefix = ShamanPlugin.DEVELOPER_PREFIX;

            SkillDef scepterritualSkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = prefix + "_SHAMAN_BODY_SPECIAL_FUSION_SCEPTER_NAME",
                skillNameToken = prefix + "_SHAMAN_BODY_SPECIAL_FUSION_SCEPTER_NAME",
                skillDescriptionToken = prefix + "_SHAMAN_BODY_SPECIAL_FUSION_SCEPTER_DESCRIPTION",
                skillIcon = Modules.ShamanAssets.mainAssetBundle.LoadAsset<Sprite>("texShamanSpecialScepter"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(SkillStates.DistortedFusionScepter)),
                activationStateMachineName = "Body",
                baseMaxStock = 1,
                baseRechargeInterval = 5f,
                beginSkillCooldownOnSkillEnd = true,
                canceledFromSprinting = false,
                forceSprintDuringState = false,
                fullRestockOnAssign = true,
                interruptPriority = EntityStates.InterruptPriority.Any,
                resetCooldownTimerOnUse = false,
                isCombatSkill = true,
                mustKeyPress = false,
                cancelSprintingOnActivation = true,
                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1
            });

            AncientScepter.AncientScepterItem.instance.RegisterScepterSkill(scepterritualSkillDef, "ShamanBody", SkillSlot.Special, 0);

            SkillDef scepterFeralSkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = prefix + "_SHAMAN_BODY_SPECIAL_ALT_FERALCALL_SCEPTER_NAME",
                skillNameToken = prefix + "_SHAMAN_BODY_SPECIAL_ALT_FERALCALL_SCEPTER_NAME",
                skillDescriptionToken = prefix + "_SHAMAN_BODY_SPECIAL_ALT_FERALCALL_SCEPTER_DESCRIPTION",
                skillIcon = Modules.ShamanAssets.mainAssetBundle.LoadAsset<Sprite>("texShamanSpecialAltScepter"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(SkillStates.FeralCallScepter)),
                activationStateMachineName = "Slide",
                baseMaxStock = 1,
                baseRechargeInterval = 40f,
                beginSkillCooldownOnSkillEnd = false,
                canceledFromSprinting = false,
                forceSprintDuringState = false,
                fullRestockOnAssign = true,
                interruptPriority = EntityStates.InterruptPriority.Any,
                resetCooldownTimerOnUse = false,
                isCombatSkill = true,
                mustKeyPress = false,
                cancelSprintingOnActivation = true,
                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1
            });

            AncientScepter.AncientScepterItem.instance.RegisterScepterSkill(scepterFeralSkillDef, "ShamanBody", SkillSlot.Special, 1);
        }

        public override void InitializeSkins()
        {
            ModelSkinController skinController = prefabCharacterModel.gameObject.AddComponent<ModelSkinController>();
            ChildLocator childLocator = prefabCharacterModel.GetComponent<ChildLocator>();

            CharacterModel.RendererInfo[] defaultRendererinfos = prefabCharacterModel.baseRendererInfos;

            List<SkinDef> skins = new List<SkinDef>();

            #region DefaultSkin
            //this creates a SkinDef with all default fields
            SkinDef defaultSkin = Modules.Skins.CreateSkinDef(SHAMAN_PREFIX + "DEFAULT_SKIN_NAME",
                ShamanAssets.mainAssetBundle.LoadAsset<Sprite>("texShamanDefault"),
                defaultRendererinfos,
                prefabCharacterModel.gameObject);

            //these are your Mesh Replacements. The order here is based on your CustomRendererInfos from earlier
            //pass in meshes as they are named in your assetbundle
                defaultSkin.meshReplacements = Modules.Skins.getMeshReplacements(defaultRendererinfos,
                "shamanMesh",
                "shamanStaffMesh");

            //add new skindef to our list of skindefs. this is what we'll be passing to the SkinController
            skins.Add(defaultSkin);
            #endregion
            
            //uncomment this when you have a mastery skin
            #region MasterySkin
            
            //creating a new skindef as we did before
            SkinDef masterySkin = Modules.Skins.CreateSkinDef(ShamanPlugin.DEVELOPER_PREFIX + "_SHAMAN_BODY_MASTERY_SKIN_NAME",
                ShamanAssets.mainAssetBundle.LoadAsset<Sprite>("texShamanMastery"),
                defaultRendererinfos,
                prefabCharacterModel.gameObject,
                masterySkinUnlockableDef);

            //adding the mesh replacements as above. 
            //if you don't want to replace the mesh (for example, you only want to replace the material), pass in null so the order is preserved
            masterySkin.meshReplacements = Modules.Skins.getMeshReplacements(defaultRendererinfos,
                "shamanMasteryMesh",
                null);

            //masterySkin has a new set of RendererInfos (based on default rendererinfos)
            //you can simply access the RendererInfos defaultMaterials and set them to the new materials for your skin.
            masterySkin.rendererInfos[0].defaultMaterial = Modules.Materials.CreateHopooMaterial("shamanMasteryMaterial");
            masterySkin.rendererInfos[1].defaultMaterial = Modules.Materials.CreateHopooMaterial("shamanStaffMaterial");

            skins.Add(masterySkin);
            
            #endregion

            skinController.skins = skins.ToArray();
        }
    }
}

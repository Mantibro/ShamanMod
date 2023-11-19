using BepInEx.Configuration;
using ShamanMod.Modules.Characters;
using RoR2;
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

            characterPortrait = Assets.mainAssetBundle.LoadAsset<Texture>("iconShaman"),
            bodyColor = new Color(0.0392156862745098f, 0.3137254901960784f, 0f),

            crosshair = Modules.Assets.LoadCrosshair("Captain"),
            //podPrefab = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/NetworkedObjects/SurvivorPod"),
            podPrefab = null,

            maxHealth = 80f,
            healthRegen = 0.9f,
            armor = 0f,

            jumpCount = 2,
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
            //masterySkinUnlockableDef = Modules.Unlockables.AddUnlockable<Modules.Achievements.MasteryAchievement>();
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
            skillLocator.passiveSkill.icon = Modules.Assets.mainAssetBundle.LoadAsset<Sprite>("texShamanPassive");

            #region Primary
            SkillDef shootSkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = prefix + "_SHAMAN_BODY_PRIMARY_STAFF_NAME",
                skillNameToken = prefix + "_SHAMAN_BODY_PRIMARY_STAFF_NAME",
                skillDescriptionToken = prefix + "_SHAMAN_BODY_PRIMARY_STAFF_DESCRIPTION",
                skillIcon = Modules.Assets.mainAssetBundle.LoadAsset<Sprite>("texShamanPrimary"),
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
                skillIcon = Modules.Assets.mainAssetBundle.LoadAsset<Sprite>("texShamanSecondary"),
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
                skillIcon = Modules.Assets.mainAssetBundle.LoadAsset<Sprite>("texShamanSecondaryAlt"),
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
                skillIcon = Modules.Assets.mainAssetBundle.LoadAsset<Sprite>("texShamanUtility"),
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
                skillIcon = Modules.Assets.mainAssetBundle.LoadAsset<Sprite>("texShamanUtilityAlt"),
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
                skillIcon = Modules.Assets.mainAssetBundle.LoadAsset<Sprite>("texShamanSpecial"),
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
                skillIcon = Modules.Assets.mainAssetBundle.LoadAsset<Sprite>("texShamanSpecialAlt"),
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
            #endregion
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
                Assets.mainAssetBundle.LoadAsset<Sprite>("texShamanDefault"),
                defaultRendererinfos,
                prefabCharacterModel.gameObject);

            //these are your Mesh Replacements. The order here is based on your CustomRendererInfos from earlier
            //pass in meshes as they are named in your assetbundle
                //defaultSkin.meshReplacements = Modules.Skins.getMeshReplacements(defaultRendererinfos,
                //"krontroop",
                //"krongun",
                //"kronbaton");

            //add new skindef to our list of skindefs. this is what we'll be passing to the SkinController
            skins.Add(defaultSkin);
            #endregion
            
            //uncomment this when you have a mastery skin
            #region MasterySkin
            
            //creating a new skindef as we did before
            /*SkinDef masterySkin = Modules.Skins.CreateSkinDef(ShamanPlugin.DEVELOPER_PREFIX + "_SHAMAN_BODY_MASTERY_SKIN_NAME",
                Assets.mainAssetBundle.LoadAsset<Sprite>("texShamanMastery"),
                defaultRendererinfos,
                prefabCharacterModel.gameObject,
                masterySkinUnlockableDef);

            //adding the mesh replacements as above. 
            //if you don't want to replace the mesh (for example, you only want to replace the material), pass in null so the order is preserved
            masterySkin.meshReplacements = Modules.Skins.getMeshReplacements(defaultRendererinfos,
                "kronmastery",
                null,//no gun mesh replacement. use same gun mesh
                "kronmasterybaton");

            //masterySkin has a new set of RendererInfos (based on default rendererinfos)
            //you can simply access the RendererInfos defaultMaterials and set them to the new materials for your skin.
            masterySkin.rendererInfos[0].defaultMaterial = Modules.Materials.CreateHopooMaterial("kronMasteryMaterial");
            masterySkin.rendererInfos[1].defaultMaterial = Modules.Materials.CreateHopooMaterial("kronMasteryMaterial");
            masterySkin.rendererInfos[2].defaultMaterial = Modules.Materials.CreateHopooMaterial("kronMasteryMaterial");

            //here's a barebones example of using gameobjectactivations that could probably be streamlined or rewritten entirely, truthfully, but it works
            /*masterySkin.gameObjectActivations = new SkinDef.GameObjectActivation[]
            {
                new SkinDef.GameObjectActivation
                {
                    gameObject = childLocator.FindChildGameObject("GunModel"),
                    shouldActivate = false,
                }
            };
            //simply find an object on your child locator you want to activate/deactivate and set if you want to activate/deacitvate it with this skin

            skins.Add(masterySkin);*/
            
            #endregion

            skinController.skins = skins.ToArray();
        }
    }
}
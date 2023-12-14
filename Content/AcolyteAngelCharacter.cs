using BepInEx.Configuration;
using RoR2;
using RoR2.Skills;
using System;
using System.Collections.Generic;
using UnityEngine;
using EntityStates;
using R2API;
using RoR2.CharacterAI;
using KinematicCharacterController;


namespace ShamanMod.Modules.Characters
{
    internal class AcolyteAngelCharacter : CharacterBase
    {

        public override string prefabBodyName => "AcolyteAngel";

        public const string ACOLYTEANGEL_PREFIX = ShamanPlugin.DEVELOPER_PREFIX + "_ACOLYTEANGEL_BODY_";

        public override BodyInfo bodyInfo { get; set; } = new BodyInfo
        {
            armor = 25f,
            armorGrowth = 0f,
            bodyName = "AcolyteAngelBody",
            bodyNameToken = ACOLYTEANGEL_PREFIX + "NAME",
            subtitleNameToken = ShamanPlugin.DEVELOPER_PREFIX + "_ACOLYTEANGEL_SUBTITLE",
            bodyNameToClone = "GreaterWisp",
            bodyColor = new Color(0.0392156862745098f, 0.3137254901960784f, 0f),
            characterPortrait = Assets.mainAssetBundle.LoadAsset<Texture>("iconAcolyteAngel"),
            crosshair = Modules.Assets.LoadCrosshair("TiltedBracket"),
            podPrefab = null,

            maxHealth = 775f,
            healthRegen = -10f,
            damage = 18f,
            moveSpeed = 8f,
            jumpCount = 0,
        };

        public override CustomRendererInfo[] customRendererInfos { get; set; } = new CustomRendererInfo[]
        {
                new CustomRendererInfo
                {
                    childName = "acolyteangel",
                    material = Materials.CreateHopooMaterial("shamanMaterial"),
                }
        };

        public override Type characterMainState => typeof(EntityStates.GenericCharacterMain);
        //public override ItemDisplaysBase itemDisplays => new AcolyteBeastItemDisplays();

        public static GameObject masterPrefab;
        //internal static SkinDef.MinionSkinReplacement MasteryMinionSkinReplacement;

        public override void InitializeCharacter()
        {
            base.InitializeCharacter();
        }

        protected override void InitializeCharacterBodyAndModel()
        {
            base.InitializeCharacterBodyAndModel();

            CharacterBody body = bodyPrefab.GetComponent<CharacterBody>();
            body.bodyFlags = CharacterBody.BodyFlags.Mechanical;
            body.isChampion = true;

        }

        protected override void InitializeEntityStateMachine()
        {
            base.InitializeEntityStateMachine();

            EntityStateMachine entityStateMachine = EntityStateMachine.FindByCustomName(bodyPrefab, "Weapon");

        }

        protected override void InitializeCharacterMaster()
        {
            base.InitializeCharacterMaster();

            masterPrefab = PrefabAPI.InstantiateClone(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/CharacterMasters/GreaterWispMaster"), "AcolyteAngelMaster", true);
            masterPrefab.GetComponent<CharacterMaster>().bodyPrefab = bodyPrefab;

            foreach (AISkillDriver aiSkillDriver in masterPrefab.GetComponents<AISkillDriver>())
            {
                UnityEngine.Object.Destroy(aiSkillDriver);
            }

            masterPrefab.GetComponent<BaseAI>().fullVision = true;

            AISkillDriver curseprojectileDriver = masterPrefab.AddComponent<AISkillDriver>();
            curseprojectileDriver.customName = "AcolyteAngelCurseProjectile";
            curseprojectileDriver.movementType = AISkillDriver.MovementType.ChaseMoveTarget;
            curseprojectileDriver.moveTargetType = AISkillDriver.TargetType.CurrentEnemy;
            curseprojectileDriver.activationRequiresAimConfirmation = true;
            curseprojectileDriver.activationRequiresTargetLoS = false;
            curseprojectileDriver.selectionRequiresTargetLoS = true;
            curseprojectileDriver.maxDistance = 75f;
            curseprojectileDriver.minDistance = 0f;
            curseprojectileDriver.requireSkillReady = true;
            curseprojectileDriver.aimType = AISkillDriver.AimType.AtCurrentEnemy;
            curseprojectileDriver.ignoreNodeGraph = true;
            curseprojectileDriver.moveInputScale = 1f;
            curseprojectileDriver.driverUpdateTimerOverride = 0.5f;
            curseprojectileDriver.buttonPressType = AISkillDriver.ButtonPressType.Hold;
            curseprojectileDriver.minTargetHealthFraction = Mathf.NegativeInfinity;
            curseprojectileDriver.maxTargetHealthFraction = Mathf.Infinity;
            curseprojectileDriver.minUserHealthFraction = Mathf.NegativeInfinity;
            curseprojectileDriver.maxUserHealthFraction = Mathf.Infinity;
            curseprojectileDriver.skillSlot = SkillSlot.Special;

            AISkillDriver projectileDriver = masterPrefab.AddComponent<AISkillDriver>();
            projectileDriver.customName = "AcolyteAngelProjectile";
            projectileDriver.movementType = AISkillDriver.MovementType.ChaseMoveTarget;
            projectileDriver.moveTargetType = AISkillDriver.TargetType.CurrentEnemy;
            projectileDriver.activationRequiresAimConfirmation = true;
            projectileDriver.activationRequiresTargetLoS = false;
            projectileDriver.selectionRequiresTargetLoS = true;
            projectileDriver.maxDistance = 125f;
            projectileDriver.minDistance = 0f;
            projectileDriver.requireSkillReady = true;
            projectileDriver.aimType = AISkillDriver.AimType.AtCurrentEnemy;
            projectileDriver.ignoreNodeGraph = true;
            projectileDriver.moveInputScale = 1f;
            projectileDriver.driverUpdateTimerOverride = 0.5f;
            projectileDriver.buttonPressType = AISkillDriver.ButtonPressType.Hold;
            projectileDriver.minTargetHealthFraction = Mathf.NegativeInfinity;
            projectileDriver.maxTargetHealthFraction = Mathf.Infinity;
            projectileDriver.minUserHealthFraction = Mathf.NegativeInfinity;
            projectileDriver.maxUserHealthFraction = Mathf.Infinity;
            projectileDriver.skillSlot = SkillSlot.Secondary;

            AISkillDriver shootDriver = masterPrefab.AddComponent<AISkillDriver>();
            shootDriver.customName = "AcolyteAngelShoot";
            shootDriver.movementType = AISkillDriver.MovementType.StrafeMovetarget;
            shootDriver.moveTargetType = AISkillDriver.TargetType.CurrentEnemy;
            shootDriver.activationRequiresAimConfirmation = true;
            shootDriver.activationRequiresTargetLoS = false;
            shootDriver.selectionRequiresTargetLoS = true;
            shootDriver.maxDistance = 80f;
            shootDriver.minDistance = 6f;
            shootDriver.requireSkillReady = true;
            shootDriver.aimType = AISkillDriver.AimType.AtCurrentEnemy;
            shootDriver.ignoreNodeGraph = false;
            shootDriver.moveInputScale = 1f;
            shootDriver.driverUpdateTimerOverride = 0.5f;
            shootDriver.buttonPressType = AISkillDriver.ButtonPressType.Hold;
            shootDriver.minTargetHealthFraction = Mathf.NegativeInfinity;
            shootDriver.maxTargetHealthFraction = Mathf.Infinity;
            shootDriver.minUserHealthFraction = Mathf.NegativeInfinity;
            shootDriver.maxUserHealthFraction = Mathf.Infinity;
            shootDriver.skillSlot = SkillSlot.Primary;

            AISkillDriver followDriver = masterPrefab.AddComponent<AISkillDriver>();
            followDriver.customName = "Chase";
            followDriver.movementType = AISkillDriver.MovementType.ChaseMoveTarget;
            followDriver.moveTargetType = AISkillDriver.TargetType.CurrentEnemy;
            followDriver.activationRequiresAimConfirmation = false;
            followDriver.activationRequiresTargetLoS = false;
            followDriver.maxDistance = Mathf.Infinity;
            followDriver.minDistance = 0f;
            followDriver.aimType = AISkillDriver.AimType.AtMoveTarget;
            followDriver.ignoreNodeGraph = true;
            followDriver.moveInputScale = 1f;
            followDriver.driverUpdateTimerOverride = -1f;
            followDriver.buttonPressType = AISkillDriver.ButtonPressType.Hold;
            followDriver.minTargetHealthFraction = Mathf.NegativeInfinity;
            followDriver.maxTargetHealthFraction = Mathf.Infinity;
            followDriver.minUserHealthFraction = Mathf.NegativeInfinity;
            followDriver.maxUserHealthFraction = Mathf.Infinity;
            followDriver.skillSlot = SkillSlot.None;
            followDriver.shouldSprint = true;

            Modules.Content.AddMasterPrefab(masterPrefab);
        }

        public override void InitializeHitboxes()
        {
            ChildLocator childLocator = bodyPrefab.GetComponentInChildren<ChildLocator>();
        }

        #region skills

        public override void InitializeSkills()
        {          
            foreach (GenericSkill obj in bodyPrefab.GetComponentsInChildren<GenericSkill>())
            {
                UnityEngine.Object.DestroyImmediate(obj);
            }

            SkillLocator skillLocator = bodyPrefab.GetComponent<SkillLocator>();
            skillLocator.primary = Skills.CreateGenericSkillWithSkillFamily(bodyPrefab, "Primary");
            skillLocator.secondary = Skills.CreateGenericSkillWithSkillFamily(bodyPrefab, "Secondary");
            skillLocator.special = Skills.CreateGenericSkillWithSkillFamily(bodyPrefab, "Special");

            InitializePrimarySkills();

            InitializeSecondarySkills();

            InitializeSpecialSkills();
        }

        private void InitializePrimarySkills()
        {
            SkillDef shootSkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = "ACOLYTEANGEL_SHOOT",
                skillNameToken = "ACOLYTEANGEL_SHOOT",
                skillDescriptionToken = "ACOLYTEANGEL_SHOOT",
                skillIcon = Modules.Assets.mainAssetBundle.LoadAsset<Sprite>("texShamanSecondary"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(SkillStates.AcolyteAngelShootAttack)),
                activationStateMachineName = "Weapon",
                baseMaxStock = 10,
                baseRechargeInterval = 4f,
                beginSkillCooldownOnSkillEnd = false,
                canceledFromSprinting = false,
                forceSprintDuringState = false,
                fullRestockOnAssign = true,
                interruptPriority = EntityStates.InterruptPriority.Any,
                resetCooldownTimerOnUse = false,
                isCombatSkill = true,
                mustKeyPress = false,
                cancelSprintingOnActivation = false,
                rechargeStock = 10,
                requiredStock = 1,
                stockToConsume = 1
            });

            Modules.Skills.AddPrimarySkills(bodyPrefab, shootSkillDef);
        }

        private void InitializeSecondarySkills()
        {
            SkillDef projectileSkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = "ACOLYTEANGEL_PROJECTILE",
                skillNameToken = "ACOLYTEANGEL_PROJECTILE",
                skillDescriptionToken = "ACOLYTEANGEL_PROJECTILE",
                skillIcon = Modules.Assets.mainAssetBundle.LoadAsset<Sprite>("texShamanSecondary"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(SkillStates.AcolyteAngelProjectileAttack)),
                activationStateMachineName = "Weapon",
                baseMaxStock = 10,
                baseRechargeInterval = 10f,
                beginSkillCooldownOnSkillEnd = false,
                canceledFromSprinting = false,
                forceSprintDuringState = false,
                fullRestockOnAssign = true,
                interruptPriority = EntityStates.InterruptPriority.Any,
                resetCooldownTimerOnUse = false,
                isCombatSkill = true,
                mustKeyPress = false,
                cancelSprintingOnActivation = false,
                rechargeStock = 10,
                requiredStock = 1,
                stockToConsume = 1
            });

            Modules.Skills.AddSecondarySkills(bodyPrefab, projectileSkillDef);
        }

        private void InitializeSpecialSkills()
        {
            SkillDef curseSkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = "ACOLYTEANGEL_CURSE",
                skillNameToken = "ACOLYTEANGEL_CURSE",
                skillDescriptionToken = "ACOLYTEANGEL_CURSE",
                skillIcon = Modules.Assets.mainAssetBundle.LoadAsset<Sprite>("texShamanSecondary"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(SkillStates.AcolyteAngelCurseShoot)),
                activationStateMachineName = "Weapon",
                baseMaxStock = 3,
                baseRechargeInterval = 18f,
                beginSkillCooldownOnSkillEnd = false,
                canceledFromSprinting = false,
                forceSprintDuringState = false,
                fullRestockOnAssign = true,
                interruptPriority = EntityStates.InterruptPriority.Any,
                resetCooldownTimerOnUse = false,
                isCombatSkill = true,
                mustKeyPress = false,
                cancelSprintingOnActivation = false,
                rechargeStock = 3,
                requiredStock = 1,
                stockToConsume = 1
            });

            Modules.Skills.AddSpecialSkills(bodyPrefab, curseSkillDef);
        }
        #endregion skills

        public override void InitializeSkins()
        {
            ModelSkinController skinController = prefabCharacterModel.gameObject.AddComponent<ModelSkinController>();
            ChildLocator childLocator = prefabCharacterModel.GetComponent<ChildLocator>();

            CharacterModel.RendererInfo[] defaultRendererinfos = prefabCharacterModel.baseRendererInfos;

            List<SkinDef> skins = new List<SkinDef>();

            //this creates a SkinDef with all default fields
            SkinDef defaultSkin = Modules.Skins.CreateSkinDef(ACOLYTEANGEL_PREFIX + "DEFAULT_SKIN_NAME",
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

            skinController.skins = skins.ToArray();
        }
    }
}
using BepInEx.Configuration;
using RoR2;
using RoR2.Skills;
using System;
using System.Collections.Generic;
using UnityEngine;
using EntityStates;
using R2API;
using RoR2.CharacterAI;


namespace ShamanMod.Modules.Characters
{
    internal class AcolyteCharacter : CharacterBase
    {
        public override string prefabBodyName => "Acolyte";

        public const string ACOLYTE_PREFIX = ShamanPlugin.DEVELOPER_PREFIX + "_ACOLYTE_BODY_";

        public override BodyInfo bodyInfo { get; set; } = new BodyInfo
        {
            armor = 0f,
            armorGrowth = 0f,
            bodyName = "AcolyteBody",
            bodyNameToken = ACOLYTE_PREFIX + "NAME",
            subtitleNameToken = ShamanPlugin.DEVELOPER_PREFIX + "_ACOLYTE_SUBTITLE",
            bodyNameToClone = "Lemurian",
            bodyColor = new Color(0.0392156862745098f, 0.3137254901960784f, 0f),
            characterPortrait = Assets.mainAssetBundle.LoadAsset<Texture>("texAcolyteIcon"),
            crosshair = Modules.Assets.LoadCrosshair("TiltedBracket"),
            podPrefab = null,

            maxHealth = 160f,
            healthRegen = 1.2f,
            damage = 14f,
            moveSpeed = 7f,
            jumpCount = 1,
        };

        public override CustomRendererInfo[] customRendererInfos { get; set; } = new CustomRendererInfo[]
        {
                new CustomRendererInfo
                {
                    childName = "acolyte",
                    material = Materials.CreateHopooMaterial("acolyteMaterial"),
                }
        };

        public override Type characterMainState => typeof(EntityStates.GenericCharacterMain);
        //public override Type characterSpawnState => typeof(TowerSpawnState);
        public override ItemDisplaysBase itemDisplays => new AcolyteItemDisplays();

        public static GameObject masterPrefab;
        //internal static SkinDef.MinionSkinReplacement MasteryMinionSkinReplacement;

        public override void InitializeCharacter()
        {
            base.InitializeCharacter();

            //bodyPrefab.AddComponent<TowerWeaponComponent>();
            //bodyPrefab.AddComponent<TowerOwnerTrackerComponent>();
        }

        protected override void InitializeCharacterBodyAndModel()
        {
            base.InitializeCharacterBodyAndModel();

            //bodyPrefab.GetComponent<CharacterBody>().overrideCoreTransform = bodyPrefab.GetComponent<ChildLocator>().FindChild("Head");
            bodyPrefab.GetComponent<SfxLocator>().deathSound = "ShamanAcolyteGrowl";
            bodyPrefab.GetComponent<SfxLocator>().barkSound = "ShamanAcolyteGrowl";
        }

        protected override void InitializeEntityStateMachine()
        {
            base.InitializeEntityStateMachine();

            EntityStateMachine entityStateMachine = EntityStateMachine.FindByCustomName(bodyPrefab, "Weapon");

        }

        protected override void InitializeCharacterMaster()
        {
            base.InitializeCharacterMaster();

            masterPrefab = PrefabAPI.InstantiateClone(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/CharacterMasters/LemurianMaster"), "AcolyteMaster", true);
            masterPrefab.GetComponent<CharacterMaster>().bodyPrefab = bodyPrefab;

            foreach (AISkillDriver aiSkillDriver in masterPrefab.GetComponents<AISkillDriver>())
            {
                UnityEngine.Object.Destroy(aiSkillDriver);
                //todo: proper ai?
            }

            masterPrefab.GetComponent<BaseAI>().fullVision = true;

            AISkillDriver returnDriver = masterPrefab.AddComponent<AISkillDriver>();
            returnDriver.customName = "ReturnToLeader";
            returnDriver.movementType = AISkillDriver.MovementType.ChaseMoveTarget;
            returnDriver.moveTargetType = AISkillDriver.TargetType.CurrentLeader;
            returnDriver.activationRequiresAimConfirmation = false;
            returnDriver.activationRequiresTargetLoS = false;
            returnDriver.maxDistance = Mathf.Infinity;
            returnDriver.minDistance = 100f;
            returnDriver.aimType = AISkillDriver.AimType.AtMoveTarget;
            returnDriver.ignoreNodeGraph = false;
            returnDriver.moveInputScale = 1f;
            returnDriver.driverUpdateTimerOverride = -1f;
            returnDriver.buttonPressType = AISkillDriver.ButtonPressType.Abstain;
            returnDriver.minTargetHealthFraction = Mathf.NegativeInfinity;
            returnDriver.maxTargetHealthFraction = Mathf.Infinity;
            returnDriver.minUserHealthFraction = Mathf.NegativeInfinity;
            returnDriver.maxUserHealthFraction = Mathf.Infinity;
            returnDriver.skillSlot = SkillSlot.None;
            returnDriver.shouldSprint = true;

            AISkillDriver meleeDriver = masterPrefab.AddComponent<AISkillDriver>();
            meleeDriver.customName = "AcolyteMelee";
            meleeDriver.movementType = AISkillDriver.MovementType.ChaseMoveTarget;
            meleeDriver.moveTargetType = AISkillDriver.TargetType.CurrentEnemy;
            meleeDriver.activationRequiresAimConfirmation = true;
            meleeDriver.activationRequiresTargetLoS = false;
            meleeDriver.selectionRequiresTargetLoS = true;
            meleeDriver.maxDistance = 6f;
            meleeDriver.minDistance = 0f;
            meleeDriver.requireSkillReady = true;
            meleeDriver.aimType = AISkillDriver.AimType.AtCurrentEnemy;
            meleeDriver.ignoreNodeGraph = true;
            meleeDriver.moveInputScale = 0.4f;
            meleeDriver.driverUpdateTimerOverride = 0.5f;
            meleeDriver.buttonPressType = AISkillDriver.ButtonPressType.Hold;
            meleeDriver.minTargetHealthFraction = Mathf.NegativeInfinity;
            meleeDriver.maxTargetHealthFraction = Mathf.Infinity;
            meleeDriver.minUserHealthFraction = Mathf.NegativeInfinity;
            meleeDriver.maxUserHealthFraction = Mathf.Infinity;
            meleeDriver.skillSlot = SkillSlot.Secondary;

            AISkillDriver shootDriver = masterPrefab.AddComponent<AISkillDriver>();
            shootDriver.customName = "AcolyteShoot";
            shootDriver.movementType = AISkillDriver.MovementType.StrafeMovetarget;
            shootDriver.moveTargetType = AISkillDriver.TargetType.CurrentEnemy;
            shootDriver.activationRequiresAimConfirmation = true;
            shootDriver.activationRequiresTargetLoS = false;
            shootDriver.selectionRequiresTargetLoS = true;
            shootDriver.maxDistance = 100f;
            shootDriver.minDistance = 6f;
            shootDriver.requireSkillReady = true;
            shootDriver.aimType = AISkillDriver.AimType.AtCurrentEnemy;
            shootDriver.ignoreNodeGraph = false;
            shootDriver.moveInputScale = 0.4f;
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
            followDriver.ignoreNodeGraph = false;
            followDriver.moveInputScale = 1f;
            followDriver.driverUpdateTimerOverride = -1f;
            followDriver.buttonPressType = AISkillDriver.ButtonPressType.Hold;
            followDriver.minTargetHealthFraction = Mathf.NegativeInfinity;
            followDriver.maxTargetHealthFraction = Mathf.Infinity;
            followDriver.minUserHealthFraction = Mathf.NegativeInfinity;
            followDriver.maxUserHealthFraction = Mathf.Infinity;
            followDriver.skillSlot = SkillSlot.None;
            followDriver.shouldSprint = true;

            AISkillDriver restDriver = masterPrefab.AddComponent<AISkillDriver>();
            restDriver.customName = "FollowLeader";
            restDriver.movementType = AISkillDriver.MovementType.ChaseMoveTarget;
            restDriver.moveTargetType = AISkillDriver.TargetType.CurrentLeader;
            restDriver.activationRequiresAimConfirmation = false;
            restDriver.activationRequiresTargetLoS = false;
            restDriver.maxDistance = Mathf.Infinity;
            restDriver.minDistance = 4f;
            restDriver.aimType = AISkillDriver.AimType.AtMoveTarget;
            restDriver.ignoreNodeGraph = false;
            restDriver.moveInputScale = 1f;
            restDriver.driverUpdateTimerOverride = -1f;
            restDriver.buttonPressType = AISkillDriver.ButtonPressType.Abstain;
            restDriver.minTargetHealthFraction = Mathf.NegativeInfinity;
            restDriver.maxTargetHealthFraction = Mathf.Infinity;
            restDriver.minUserHealthFraction = Mathf.NegativeInfinity;
            restDriver.maxUserHealthFraction = Mathf.Infinity;
            restDriver.skillSlot = SkillSlot.None;
            restDriver.shouldSprint = false;

            Modules.Content.AddMasterPrefab(masterPrefab);
        }

        public override void InitializeHitboxes()
        {
            ChildLocator childLocator = bodyPrefab.GetComponentInChildren<ChildLocator>();

            //example of how to create a hitbox
            Transform hitboxTransform = childLocator.FindChild("MeleeHitbox");
            Modules.Prefabs.SetupHitbox(prefabCharacterModel.gameObject, hitboxTransform, "Melee");
        }

        #region skills

        public override void InitializeSkills()
        {          //maybe least elegant of my solutions but it's a DRY fix so half and half
            //Modules.Skills.CreateSkillFamiliesAlternate(bodyPrefab, 3);

            foreach (GenericSkill obj in bodyPrefab.GetComponentsInChildren<GenericSkill>())
            {
                UnityEngine.Object.DestroyImmediate(obj);
            }

            SkillLocator skillLocator = bodyPrefab.GetComponent<SkillLocator>();
            skillLocator.primary = Skills.CreateGenericSkillWithSkillFamily(bodyPrefab, "Primary");
            skillLocator.secondary = Skills.CreateGenericSkillWithSkillFamily(bodyPrefab, "Secondary");

            InitializePrimarySkills();

            InitializeSecondarySkills();
        }

        private void InitializePrimarySkills()
        {
            SkillDef shootSkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = "ACOLYTE_SHOOT",
                skillNameToken = "ACOLYTE_SHOOT",
                skillDescriptionToken = "ACOLYTE_SHOOT",
                skillIcon = Modules.Assets.mainAssetBundle.LoadAsset<Sprite>("texShamanSecondary"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(SkillStates.AcolyteShootAttack)),
                activationStateMachineName = "Weapon",
                baseMaxStock = 3,
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
                rechargeStock = 3,
                requiredStock = 1,
                stockToConsume = 1
            });

            Modules.Skills.AddPrimarySkills(bodyPrefab, shootSkillDef);
        }

        private void InitializeSecondarySkills()
        {
            SkillDef meleeSkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = "ACOLYTE_MELEE",
                skillNameToken = "ACOLYTE_MELEE",
                skillDescriptionToken = "ACOLYTE_MELEE",
                skillIcon = Modules.Assets.mainAssetBundle.LoadAsset<Sprite>("texShamanSecondary"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(SkillStates.AcolyteMeleeAttack)),
                activationStateMachineName = "Weapon",
                baseMaxStock = 1,
                baseRechargeInterval = 1f,
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

            Modules.Skills.AddSecondarySkills(bodyPrefab, meleeSkillDef);
        }
        #endregion skills

        public override void InitializeSkins()
        {
            ModelSkinController skinController = prefabCharacterModel.gameObject.AddComponent<ModelSkinController>();
            ChildLocator childLocator = prefabCharacterModel.GetComponent<ChildLocator>();

            CharacterModel.RendererInfo[] defaultRendererinfos = prefabCharacterModel.baseRendererInfos;

            List<SkinDef> skins = new List<SkinDef>();

            //this creates a SkinDef with all default fields
            SkinDef defaultSkin = Modules.Skins.CreateSkinDef(ACOLYTE_PREFIX + "DEFAULT_SKIN_NAME",
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
        }
    }
}
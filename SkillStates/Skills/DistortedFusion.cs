using EntityStates;
using RoR2;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RoR2.Navigation;
using System.Linq;
using System;
using UnityEngine.Networking;

namespace ShamanMod.SkillStates
{
    public class DistortedFusion : BaseSkillState
    {
        public static float damageCoefficient = Modules.StaticValues.baseDamageCoefficient;
        public static float procCoefficient = 1f;
        public static float baseDuration = 4f;
        public static float force = 800f;
        public static float recoil = 3f;
        public static float range = 256f;

        private float duration;
        private float fireTime;
        private bool hasFired;
        private string muzzleString;

        private int noSacrificed = 0;

        public override void OnEnter()
        {
            var literallyeverything = Resources.FindObjectsOfTypeAll(typeof(CharacterBody));

            this.fireTime = 3.25f;
            this.muzzleString = "Muzzle";

            noSacrificed = 0;

            foreach (CharacterBody cb in literallyeverything as CharacterBody[])
            {
                if (cb.baseNameToken == "MANTI_ACOLYTE_BODY_NAME" && cb.gameObject.GetComponent<TeamComponent>().teamIndex == base.gameObject.GetComponent<TeamComponent>().teamIndex)
                {
                    if (cb.master && cb.master.minionOwnership.ownerMaster.GetBody() == base.characterBody)
                    {
                        noSacrificed++;
                    }
                }
            }

            if (noSacrificed < 3)
            {
                Util.PlaySound("ShamanCastFusionFail", base.gameObject);
                EffectManager.SimpleMuzzleFlash(Modules.Assets.magicImpact2Effect, base.gameObject, this.muzzleString, false);
                this.duration = 0.25f;
                return;
            }

            base.OnEnter();

            Util.PlaySound("ShamanCastFusion", base.gameObject);
            EffectManager.SimpleMuzzleFlash(Modules.Assets.castFusionEffect, base.gameObject, this.muzzleString, false);

            this.duration = 4f;
            base.characterBody.SetAimTimer(5f);

            if (NetworkServer.active)
            {
                base.characterBody.AddTimedBuff(RoR2Content.Buffs.HiddenInvincibility, 4f);
            }

            base.PlayAnimation("FullBody, Override", "FusionCast", "ShootGun.playbackRate", 1f);
        }

        private void Fire()
        {
            if (!this.hasFired && noSacrificed > 2)
            {
                this.hasFired = true;

                var literallyeverything = Resources.FindObjectsOfTypeAll(typeof(CharacterBody));

                foreach (CharacterBody cb in literallyeverything as CharacterBody[])
                {
                    if (cb.baseNameToken == "MANTI_ACOLYTE_BODY_NAME" && cb.gameObject.GetComponent<TeamComponent>().teamIndex == base.gameObject.GetComponent<TeamComponent>().teamIndex)
                    {
                        if (cb.gameObject.GetComponent<HealthComponent>() && cb.master && cb.master.minionOwnership.ownerMaster.GetBody() == base.characterBody)
                        {
                            cb.gameObject.GetComponent<HealthComponent>().Suicide();
                            continue;
                        }
                    }
                }

                if (NetworkServer.active)
                {
                    base.characterBody.SendConstructTurret(base.characterBody,
                            base.gameObject.transform.position + new Vector3(0f, 10f, 0f),
                            base.gameObject.transform.rotation,
                            MasterCatalog.FindMasterIndex(Modules.Characters.AcolyteBeastCharacter.masterPrefab));
                }

                Util.PlaySound("ShamanSummonAcolyteBeast", base.gameObject);
            }
        }

        public override void OnExit()
        {
            base.OnExit();

            var literallyeverything = Resources.FindObjectsOfTypeAll(typeof(CharacterBody));

            foreach (CharacterBody cb in literallyeverything as CharacterBody[])
            {
                if (cb.baseNameToken == "MANTI_ACOLYTEBEAST_BODY_NAME" && cb.gameObject.GetComponent<TeamComponent>().teamIndex == base.gameObject.GetComponent<TeamComponent>().teamIndex)
                {
                    if (NetworkServer.active && cb.master && cb.master.minionOwnership.ownerMaster.GetBody() == base.characterBody)
                    {
                        if (noSacrificed < 3)
                            continue;

                        cb.healthComponent.HealFraction(1f, default);

                        for (int j = 0; j < (noSacrificed - 2); j++)
                        {
                            cb.AddTimedBuff(Modules.Buffs.acolyteBeastSummonBuff, 480f);
                        }

                        break;
                    }
                }
            }

            noSacrificed = 0;
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            if (base.fixedAge >= this.fireTime)
            {
                this.Fire();
            }

            if (base.fixedAge >= this.duration && base.isAuthority)
            {
                this.outer.SetNextStateToMain();
                return;
            }
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.Skill;
        }
    }
}
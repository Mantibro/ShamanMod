using EntityStates;
using RoR2;
using UnityEngine;

namespace ShamanMod.SkillStates
{
    public class AcolyteBeastShootAttack : BaseSkillState
    {
        public static float damageCoefficient = Modules.StaticValues.acBeastShootDamageCoefficient;
        public static float procCoefficient = 1f;
        public static float baseDuration = 0.5f;
        public static float force = 800f;
        public static float recoil = 5f;
        public static float range = 128f;
        //public static GameObject tracerEffectPrefab = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/Tracers/TracerGoldGat");
        public static GameObject tracerEffectPrefab = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/Tracers/TracerEngiTurret");

        private float duration;
        private float fireTime;
        private bool hasFired;
        private string muzzleString;

        public override void OnEnter()
        {
            base.OnEnter();
            this.duration = AcolyteBeastShootAttack.baseDuration / this.attackSpeedStat;
            //this.fireTime = 0.2f * this.duration;
            this.fireTime = 0f;
            base.characterBody.SetAimTimer(2f);
            this.muzzleString = "Muzzle";

            //base.PlayAnimation("Gesture, Override", "ShootGun", "ShootGun.playbackRate", 1f);
        }

        public override void OnExit()
        {
            base.OnExit();
        }

        private void Fire()
        {
            if (!this.hasFired)
            {
                this.hasFired = true;

                base.characterBody.AddSpreadBloom(1.5f);
                //EffectManager.SimpleMuzzleFlash(EntityStates.Commando.CommandoWeapon.FirePistol2.muzzleEffectPrefab, base.gameObject, this.muzzleString, false);
                EffectManager.SimpleMuzzleFlash(Modules.Assets.staffCastEffect, base.gameObject, this.muzzleString, false);
                Util.PlaySound("ShamanAcolyteBeastShoot", base.gameObject);

                if (base.isAuthority)
                {
                    Ray aimRay = base.GetAimRay();
                    base.AddRecoil(-1f * DistortedFusion.recoil, -2f * DistortedFusion.recoil, -0.5f * DistortedFusion.recoil, 0.5f * DistortedFusion.recoil);

                    new BulletAttack
                    {
                        bulletCount = 3,
                        aimVector = aimRay.direction,
                        origin = aimRay.origin,
                        damage = AcolyteBeastShootAttack.damageCoefficient * this.damageStat,
                        damageColorIndex = DamageColorIndex.Default,
                        damageType = DamageType.Generic,
                        falloffModel = BulletAttack.FalloffModel.DefaultBullet,
                        maxDistance = AcolyteBeastShootAttack.range,
                        force = AcolyteBeastShootAttack.force,
                        hitMask = LayerIndex.CommonMasks.bullet,
                        minSpread = 0f,
                        maxSpread = 5f,
                        isCrit = base.RollCrit(),
                        owner = base.gameObject,
                        muzzleName = muzzleString,
                        smartCollision = false,
                        procChainMask = default(ProcChainMask),
                        procCoefficient = procCoefficient,
                        radius = 0.75f,
                        sniper = false,
                        stopperMask = LayerIndex.CommonMasks.bullet,
                        weapon = null,
                        tracerEffectPrefab = AcolyteBeastShootAttack.tracerEffectPrefab,
                        spreadPitchScale = 0.25f,
                        spreadYawScale = 1f,
                        queryTriggerInteraction = QueryTriggerInteraction.UseGlobal,
                        hitEffectPrefab = Modules.Assets.magicImpact2Effect,
                    }.Fire();
                }
            }
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
            return InterruptPriority.PrioritySkill;
        }
    }
}
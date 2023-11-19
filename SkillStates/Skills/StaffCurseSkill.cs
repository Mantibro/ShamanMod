using EntityStates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoR2;
using RoR2.Navigation;
using System.Linq;
using UnityEngine.Networking;
using System;

namespace ShamanMod.SkillStates
{
    public class StaffCurseSkill : GenericProjectileBaseState
    {

        public static float BaseDuration = 0.75f;
        //delay here for example and to match animation
        //ordinarily I recommend not having a delay before projectiles. makes the move feel sluggish
        //public static float BaseDelayDuration = 0.2f * BaseDuration;

        public static float DamageCoefficient = Modules.StaticValues.staffDamageCoefficient;

        public override void OnEnter()
        {
            base.projectilePrefab = Modules.Projectiles.curseSkullPrefab;
            base.effectPrefab = Modules.Assets.staffCastEffect;
            base.targetMuzzle = "Muzzle";

            base.attackSoundString = "ShamanCurseSkullFire";
            
            base.baseDuration = BaseDuration;
            this.duration = BaseDuration / this.attackSpeedStat;
            //base.baseDelayBeforeFiringProjectile = 0.1f * BaseDuration;

            base.characterBody.SetAimTimer(2f);

            base.damageCoefficient = DamageCoefficient;
            //proc coefficient is set on the components of the projectile prefab
            base.force = 80f;

            base.projectilePitchBonus = 0;
            base.minSpread = 0f;
            base.maxSpread = 2f;

            base.recoilAmplitude = 0.1f;
            base.bloom = 10;

            base.OnEnter();
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.PrioritySkill;
        }

        public override void PlayAnimation(float duration)
        {

            if (base.GetModelAnimator())
            {
                base.PlayAnimation("Gesture, Override", "AcolyteSummoningSkill", "AcolyteSummoningSkill.playbackRate", this.duration);
            }
        }
    }
}
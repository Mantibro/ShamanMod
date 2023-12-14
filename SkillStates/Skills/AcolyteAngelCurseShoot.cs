using EntityStates;
using RoR2;
using RoR2.Projectile;
using UnityEngine;

namespace ShamanMod.SkillStates
{
    public class AcolyteAngelCurseShoot : GenericProjectileBaseState
    {

        public static float BaseDuration = 0.15f;
        //delay here for example and to match animation
        //ordinarily I recommend not having a delay before projectiles. makes the move feel sluggish
        //public static float BaseDelayDuration = 0.2f * BaseDuration;

        public static float DamageCoefficient = Modules.StaticValues.staffDamageCoefficient;

        public override void OnEnter()
        {
            base.projectilePrefab = Modules.Projectiles.curseSkullPrefab;
            base.effectPrefab = Modules.Assets.staffCastEffect;
            base.targetMuzzle = "Root";

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
            base.maxSpread = 20f;

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
                //base.PlayAnimation("Gesture, Override", "AcolyteAngelCurseShoot", "AcolyteAngelCurseShoot.playbackRate", this.duration);
            }
        }
    }
}
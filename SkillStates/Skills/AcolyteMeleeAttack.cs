using ShamanMod.SkillStates.BaseStates;
using RoR2;
using UnityEngine;

namespace ShamanMod.SkillStates
{
    public class AcolyteMeleeAttack : BaseMeleeAttack
    {
        public override void OnEnter()
        {
            this.hitboxName = "Melee";

            this.damageType = DamageType.Generic;
            this.damageCoefficient = Modules.StaticValues.acSlashDamageCoefficient;
            this.procCoefficient = 1f;
            this.pushForce = 300f;
            this.bonusForce = Vector3.zero;
            this.baseDuration = 1f;
            this.attackStartTime = 0.2f;
            this.attackEndTime = 0.4f;
            this.baseEarlyExitTime = 0.4f;
            this.hitStopDuration = 0.012f;
            this.attackRecoil = 0.5f;
            this.hitHopVelocity = 4f;

            this.swingSoundString = "ShamanAcolyteSwing";
            this.hitSoundString = ""; //ShamanAcolyteSwingImpact
            this.muzzleString = "MeleeHitbox";
            this.swingEffectPrefab = Modules.Assets.acolyteSwingEffect;
            this.hitEffectPrefab = Modules.Assets.magicImpactEffect;

            base.OnEnter();
        }

        protected override void PlayAttackAnimation()
        {
            //base.PlayAttackAnimation();
            base.PlayCrossfade("Gesture, Override", "Slash", "Slash.playbackRate", this.duration, 0.05f);
        }

        protected override void PlaySwingEffect()
        {
            base.PlaySwingEffect();
        }

        protected override void OnHitEnemyAuthority()
        {
            base.OnHitEnemyAuthority();
        }

        public override void OnExit()
        {
            base.OnExit();
        }
    }
}
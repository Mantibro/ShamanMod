using ShamanMod.SkillStates.BaseStates;
using RoR2;
using UnityEngine;

namespace ShamanMod.SkillStates
{
    public class AcolyteBeastMeleeSlam : BaseMeleeAttack
    {
        public override void OnEnter()
        {
            this.hitboxName = "Slam";

            this.damageType = DamageType.Stun1s;
            this.damageCoefficient = Modules.StaticValues.acBeastSlamDamageCoefficient;
            this.procCoefficient = 1f;
            this.pushForce = 1200f;
            this.bonusForce = Vector3.zero;
            this.baseDuration = 3f;
            this.attackStartTime = 0.45f;
            this.attackEndTime = 0.6f;
            this.baseEarlyExitTime = 0.8f;
            this.hitStopDuration = 0.012f;
            this.attackRecoil = 3f;
            this.hitHopVelocity = 12f;

            this.swingSoundString = "ShamanAcolyteBeastSlam";
            this.hitSoundString = ""; //ShamanAcolyteSwingImpact
            this.muzzleString = "SlamHitbox";
            this.swingEffectPrefab = EntityStates.BeetleGuardMonster.GroundSlam.slamEffectPrefab;
            this.hitEffectPrefab = null;

            Util.PlaySound("ShamanAcolyteBeastAttack", base.gameObject);

            base.OnEnter();
        }

        protected override void PlayAttackAnimation()
        {
            //base.PlayAttackAnimation();
            base.PlayCrossfade("Gesture, Override", "Slam", "Slam.playbackRate", this.duration, 0.05f);
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
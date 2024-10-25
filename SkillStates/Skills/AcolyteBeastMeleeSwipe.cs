using ShamanMod.SkillStates.BaseStates;
using RoR2;
using UnityEngine;

namespace ShamanMod.SkillStates
{
    public class AcolyteBeastMeleeSwipe : BaseMeleeAttack
    {
        public override void OnEnter()
        {
            this.hitboxName = "Slash";

            this.damageType = DamageType.Generic;
            this.damageCoefficient = Modules.StaticValues.acBeastSlashDamageCoefficient;
            this.procCoefficient = 1f;
            this.pushForce = 300f;
            this.bonusForce = Vector3.zero;
            this.baseDuration = 1.5f;
            this.attackStartTime = 0.4f;
            this.attackEndTime = 0.7f;
            this.baseEarlyExitTime = 0.8f;
            this.hitStopDuration = 0.012f;
            this.attackRecoil = 0.5f;
            this.hitHopVelocity = 4f;

            this.swingSoundString = "ShamanAcolyteBeastSwipe";
            this.hitSoundString = ""; //ShamanAcolyteSwingImpact
            this.muzzleString = "SlashHitbox";
            this.swingEffectPrefab = Modules.ShamanAssets.acolyteBeastSwingEffect;
            this.hitEffectPrefab = Modules.ShamanAssets.magicImpactEffect;

            Util.PlaySound("ShamanAcolyteBeastAttack", base.gameObject);

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
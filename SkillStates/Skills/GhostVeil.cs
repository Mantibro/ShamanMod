using EntityStates;
using RoR2;
using UnityEngine;
using UnityEngine.Networking;

namespace ShamanMod.SkillStates
{
    public class GhostVeil : BaseSkillState
    {
        public static float duration = 10f;
        public static float initialSpeedCoefficient = 5f;
        public static float finalSpeedCoefficient = 2.5f;

        public static float dodgeFOV = EntityStates.Commando.DodgeState.dodgeFOV;

        public override void OnEnter()
        {
            base.OnEnter();

            Util.PlaySound("ShamanGhostEnter", base.gameObject);

            if (NetworkServer.active)
            {
                base.characterBody.AddTimedBuff(Modules.Buffs.armorBuff, 10f);
                base.characterBody.AddTimedBuff(RoR2Content.Buffs.Cloak, 10f);
                base.characterBody.AddTimedBuff(RoR2Content.Buffs.CloakSpeed, 10f);
            }
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            if (base.fixedAge >= GhostVeil.duration && base.isAuthority)
            {
                this.outer.SetNextStateToMain();
                Util.PlaySound("ShamanGhostExit", base.gameObject);
                return;
            }
        }

        public override void OnExit()
        {
            base.OnExit();
        }

        public override void OnSerialize(NetworkWriter writer)
        {
            base.OnSerialize(writer);
        }

        public override void OnDeserialize(NetworkReader reader)
        {
            base.OnDeserialize(reader);
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.Skill;
        }
    }
}
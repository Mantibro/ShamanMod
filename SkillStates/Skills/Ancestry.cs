using EntityStates;
using RoR2;
using UnityEngine;
using UnityEngine.Networking;

namespace ShamanMod.SkillStates
{
        public class Ancestry : BaseSkillState
    {
        public static float duration = 1f;

        public override void OnEnter()
        {
            base.OnEnter();

            Util.PlaySound("ShamanTeleportCast", base.gameObject);
            EffectManager.SimpleMuzzleFlash(Modules.Assets.magicImpact2Effect, base.gameObject, "Muzzle", false);

            var literallyeverything = Resources.FindObjectsOfTypeAll(typeof(CharacterBody));

            foreach (CharacterBody cb in literallyeverything as CharacterBody[])
            {
                if (cb.gameObject.GetComponent<TeamComponent>().teamIndex == base.gameObject.GetComponent<TeamComponent>().teamIndex && cb != base.characterBody)
                {

                    if (cb.master && cb.master.minionOwnership.ownerMaster.GetBody() == base.characterBody)
                    {
                        if (NetworkServer.active)
                        {
                            Vector3 newpos = base.gameObject.transform.position + new Vector3((Random.value * 4f) - 2f, 0.1f + (Random.value * 1f), (Random.value * 4f) - 2f);
                            RoR2.TeleportHelper.TeleportBody(cb, newpos);
                        }

                        cb.healthComponent.barrier += cb.maxHealth * 0.6f;
                        Util.PlaySound("ShamanAncestralTeleport", cb.gameObject);
                        EffectManager.SimpleImpactEffect(Modules.Assets.acolyteSummonEffect, gameObject.transform.position, Vector3.up, true);
                    }
                }
            }
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            if (base.fixedAge >= Ancestry.duration && base.isAuthority)
            {
                this.outer.SetNextStateToMain();
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
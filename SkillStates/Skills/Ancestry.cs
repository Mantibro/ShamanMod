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
            EffectManager.SimpleMuzzleFlash(Modules.ShamanAssets.magicImpact2Effect, base.gameObject, "Muzzle", false);

            var literallyeverything = Resources.FindObjectsOfTypeAll(typeof(CharacterBody));

            foreach (CharacterBody cb in literallyeverything as CharacterBody[])
            {
                if (cb == null) continue;
                if (cb.gameObject == null) continue;
                if (cb.gameObject.GetComponent<TeamComponent>() == null) continue;
                if (base.gameObject.GetComponent<TeamComponent>() == null) continue;
                if (cb.master == null) continue;
                if (cb.master.minionOwnership == null) continue;
                if (cb.master.minionOwnership.ownerMaster == null) continue;
                // I AM GOING INSANE AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA

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
                        EffectManager.SimpleImpactEffect(Modules.ShamanAssets.acolyteSummonEffect, gameObject.transform.position, Vector3.up, true);
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
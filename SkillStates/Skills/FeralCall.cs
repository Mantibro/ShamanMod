using EntityStates;
using RoR2;
using UnityEngine;
using UnityEngine.Networking;

namespace ShamanMod.SkillStates
{
        public class FeralCall : BaseSkillState
    {
        public static float duration = 1f;

        public override void OnEnter()
        {
            base.OnEnter();

            Util.PlaySound("ShamanFrenzyCast", base.gameObject);
            EffectManager.SimpleMuzzleFlash(Modules.Assets.magicImpact2Effect, base.gameObject, "Muzzle", false);

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

                if (cb.gameObject.GetComponent<TeamComponent>().teamIndex == base.gameObject.GetComponent<TeamComponent>().teamIndex && cb != base.characterBody)
                {
                    if (cb.master && cb.master.minionOwnership.ownerMaster.GetBody() == base.characterBody && cb.name == "AcolyteBody(Clone)" )
                    {
                        if (NetworkServer.active)
                        {
                            //buffs
                            for (int _ = 0; _ < 100; _++)
                            {
                                cb.AddTimedBuff(RoR2Content.Buffs.PermanentCurse, 15f, 100);
                            }

                            cb.AddTimedBuff(Modules.Buffs.acolyteFrenzyBuff, 15f);

                        }
                        Util.PlaySound("ShamanAcolyteFrenziedGrowl", cb.gameObject);
                        EffectManager.SimpleImpactEffect(Modules.Assets.acolyteSummonEffect, cb.gameObject.transform.position, Vector3.up, true);
                    }
                }
            }
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            if (base.fixedAge >= FeralCall.duration && base.isAuthority)
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

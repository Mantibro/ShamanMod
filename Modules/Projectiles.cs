using R2API;
using RoR2;
using RoR2.Projectile;
using UnityEngine;
using UnityEngine.Networking;
using EntityStates;
using System.Collections;
using System.Collections.Generic;
using RoR2.Navigation;
using System.Linq;
using System;

namespace ShamanMod.Modules
{
    internal static class Projectiles
    {
        internal static GameObject staffCastPrefab;
        internal static GameObject healOrbPrefab;
        internal static GameObject curseSkullPrefab;

        internal static void RegisterProjectiles()
        {
            CreateStaffProjectile();
            CreateHealOrb();
            CreateCurseSkull();

            AddProjectile(staffCastPrefab);
            AddProjectile(healOrbPrefab);
            AddProjectile(curseSkullPrefab);
        }

        internal static void AddProjectile(GameObject projectileToAdd)
        {
            Modules.Content.AddProjectilePrefab(projectileToAdd);
        }

        private static void CreateStaffProjectile()
        {
            staffCastPrefab = CloneProjectilePrefab("LunarNeedleProjectile", "ShamanStaffProjectile");

            ProjectileImpactExplosion staffCastExplosion = staffCastPrefab.GetComponent<ProjectileImpactExplosion>();
            InitializeImpactExplosion(staffCastExplosion);

            staffCastExplosion.blastRadius = 0f;
            staffCastExplosion.destroyOnEnemy = true;
            staffCastExplosion.destroyOnWorld = true;
            staffCastExplosion.lifetime = 20f;
            staffCastExplosion.impactEffect = Modules.Assets.magicImpact2Effect;
            staffCastExplosion.lifetimeExpiredSound = Modules.Assets.CreateNetworkSoundEventDef("ShamanStaffCast");
            staffCastExplosion.timerAfterImpact = false;
            staffCastExplosion.lifetimeAfterImpact = 0f;
            staffCastExplosion.blastDamageCoefficient = 0f;

            staffCastPrefab.GetComponent<ProjectileSimple>().desiredForwardSpeed = 16f;

            ProjectileController castController = staffCastPrefab.GetComponent<ProjectileController>();

            if (Modules.Assets.mainAssetBundle.LoadAsset<GameObject>("ShamanMagicPellet") != null)
            {
                castController.ghostPrefab = CreateGhostPrefab("ShamanMagicPellet", false);
            }

            castController.startSound = "";
        }

        private static void CreateHealOrb()
        {
            healOrbPrefab = CloneProjectilePrefab("ImpVoidspikeProjectile", "ShamanHealBallProjectile");

            ProjectileImpactExplosion healingImpactExplosion = healOrbPrefab.GetComponent<ProjectileImpactExplosion>();
            InitializeImpactExplosion(healingImpactExplosion);

            healingImpactExplosion.blastRadius = 0f;
            healingImpactExplosion.destroyOnEnemy = true;
            healingImpactExplosion.destroyOnWorld = true;
            healingImpactExplosion.lifetime = 20f;
            healingImpactExplosion.impactEffect = Modules.Assets.magicImpact2Effect;
            //healingImpactExplosion.lifetimeExpiredSound = Modules.Assets.CreateNetworkSoundEventDef("ShamanHealOrbExplode");
            healingImpactExplosion.timerAfterImpact = false;
            healingImpactExplosion.lifetimeAfterImpact = 0f;
            healingImpactExplosion.blastDamageCoefficient = 0f;

            healOrbPrefab.GetComponent<ProjectileSimple>().desiredForwardSpeed = 38f;

            ProjectileController healOrbController = healOrbPrefab.GetComponent<ProjectileController>();
            healOrbPrefab.AddComponent<HealOrbImpact>();
          
            if (Modules.Assets.mainAssetBundle.LoadAsset<GameObject>("ShamanHealOrb") != null)
            {
                healOrbController.ghostPrefab = CreateGhostPrefab("ShamanHealOrb", false);
            }

            healOrbController.startSound = "";
        }

        private static void CreateCurseSkull()
        {
            curseSkullPrefab = CloneProjectilePrefab("LunarExploderShardProjectile", "ShamanCurseSkullProjectile");

            ProjectileImpactExplosion curseImpactExplosion = curseSkullPrefab.GetComponent<ProjectileImpactExplosion>();
            InitializeImpactExplosion(curseImpactExplosion);

            curseImpactExplosion.blastRadius = 14f;
            curseImpactExplosion.destroyOnEnemy = true;
            curseImpactExplosion.destroyOnWorld = true;
            curseImpactExplosion.lifetime = 20f;
            curseImpactExplosion.impactEffect = Modules.Assets.explodeSkullEffect;
            //curseImpactExplosion.lifetimeExpiredSound = Modules.Assets.CreateNetworkSoundEventDef("ShamanCurseSkullExplode");
            curseImpactExplosion.timerAfterImpact = false;
            curseImpactExplosion.lifetimeAfterImpact = 0f;
            curseImpactExplosion.blastDamageCoefficient = StaticValues.staffCurseCoefficient;
            curseImpactExplosion.GetComponent<ProjectileDamage>().damageType = DamageType.CrippleOnHit;

            curseSkullPrefab.GetComponent<ProjectileSimple>().desiredForwardSpeed = 34f;
            curseSkullPrefab.AddComponent<CurseSkullImpact>();

            ProjectileController curseSkullController = curseSkullPrefab.GetComponent<ProjectileController>();

            if (Modules.Assets.mainAssetBundle.LoadAsset<GameObject>("ShamanCurseSkull") != null)
            {
                curseSkullController.ghostPrefab = CreateGhostPrefab("ShamanCurseSkull", false);
            }

            curseSkullController.startSound = "";
        }

        internal class HealOrbImpact : MonoBehaviour, IProjectileImpactBehavior
        {
            private bool hasImpacted = false;
            public void OnProjectileImpact(ProjectileImpactInfo impactInfo)
            {
                if (hasImpacted)
                    return;

                ProjectileController recursiveCtrl = gameObject.GetComponent<ProjectileController>();
                var characterBody = recursiveCtrl.owner.GetComponent<CharacterBody>();

                List<HurtBox> healed = new List<HurtBox>();
                SphereSearch looker = new SphereSearch();
                looker.origin = gameObject.transform.position;
                looker.mask = LayerIndex.entityPrecise.mask;
                looker.radius = 14f;
                looker.RefreshCandidates();

                TeamMask tmmask = new TeamMask();
                tmmask.AddTeam(characterBody.gameObject.GetComponent<TeamComponent>().teamIndex);

                looker.FilterCandidatesByHurtBoxTeam(tmmask);
                looker.FilterCandidatesByDistinctHurtBoxEntities();
                looker.OrderCandidatesByDistance();
                looker.GetHurtBoxes(healed);
                looker.ClearCandidates();

                for (int i = 0; i < healed.Count; i++)
                {
                    HurtBox hurtBox = healed[i];
                    if (hurtBox.healthComponent)
                    {
                        hurtBox.healthComponent.Heal(characterBody.damage * StaticValues.staffHealingCoefficient, default, true);
                    }
                }

                EffectManager.SimpleImpactEffect(Modules.Assets.healBallExplodeEffect, gameObject.transform.position, Vector3.up, true);

                hasImpacted = true;
            }
        }

        internal class CurseSkullImpact : MonoBehaviour, IProjectileImpactBehavior
        {
            private bool hasImpacted = false;
            public void OnProjectileImpact(ProjectileImpactInfo impactInfo)
            {
                if (hasImpacted)
                    return;

                ProjectileController recursiveCtrl = gameObject.GetComponent<ProjectileController>();
                var characterBody = recursiveCtrl.owner.GetComponent<CharacterBody>();

                List<HurtBox> cursed = new List<HurtBox>();
                SphereSearch looker = new SphereSearch();
                looker.origin = gameObject.transform.position;
                looker.mask = LayerIndex.entityPrecise.mask;
                looker.radius = 14f;
                looker.RefreshCandidates();

                looker.FilterCandidatesByHurtBoxTeam(TeamMask.GetUnprotectedTeams(characterBody.gameObject.GetComponent<TeamComponent>().teamIndex));
                looker.FilterCandidatesByDistinctHurtBoxEntities();
                looker.OrderCandidatesByDistance();
                looker.GetHurtBoxes(cursed);
                looker.ClearCandidates();

                var literallyeverything = Resources.FindObjectsOfTypeAll(typeof(CharacterBody));

                if (NetworkServer.active)
                {
                    foreach (CharacterBody cb in literallyeverything as CharacterBody[])
                    {
                        bool cursedalready = false;

                        for (int i = 0; i < cursed.Count; i++)
                        {
                            HurtBox hurtBox = cursed[i];

                            if (cb.hurtBoxGroup && cb.hurtBoxGroup.hurtBoxes.Contains(hurtBox))
                            {
                                if (!cursedalready)
                                {
                                    for (int _ = 0; _ < 10; _++)
                                    {
                                        cb.AddTimedBuff(RoR2Content.Buffs.PermanentCurse, 60f, 1000);
                                    }
                                    cb.AddTimedBuff(RoR2Content.Buffs.Cripple, 20f);
                                    cursedalready = true;
                                }
                            }

                            if (cb.mainHurtBox == hurtBox)
                            {
                                if (!cursedalready)
                                {
                                    for (int _ = 0; _ < 10; _++)
                                    {
                                        cb.AddTimedBuff(RoR2Content.Buffs.PermanentCurse, 60f, 1000);
                                    }
                                    cb.AddTimedBuff(RoR2Content.Buffs.Cripple, 20f);
                                    cursedalready = true;
                                }
                            }
                        }

                    }
                }

                hasImpacted = true;
            }
        }

        private static void InitializeImpactExplosion(ProjectileImpactExplosion projectileImpactExplosion)
        {
            projectileImpactExplosion.blastDamageCoefficient = 1f;
            projectileImpactExplosion.blastProcCoefficient = 1f;
            projectileImpactExplosion.blastRadius = 1f;
            projectileImpactExplosion.bonusBlastForce = Vector3.zero;
            projectileImpactExplosion.childrenCount = 0;
            projectileImpactExplosion.childrenDamageCoefficient = 0f;
            projectileImpactExplosion.childrenProjectilePrefab = null;
            projectileImpactExplosion.destroyOnEnemy = false;
            projectileImpactExplosion.destroyOnWorld = false;
            projectileImpactExplosion.falloffModel = RoR2.BlastAttack.FalloffModel.None;
            projectileImpactExplosion.fireChildren = false;
            projectileImpactExplosion.impactEffect = null;
            projectileImpactExplosion.lifetime = 0f;
            projectileImpactExplosion.lifetimeAfterImpact = 0f;
            projectileImpactExplosion.lifetimeRandomOffset = 0f;
            projectileImpactExplosion.offsetForLifetimeExpiredSound = 0f;
            projectileImpactExplosion.timerAfterImpact = false;

            projectileImpactExplosion.GetComponent<ProjectileDamage>().damageType = DamageType.Generic;
        }

        private static GameObject CreateGhostPrefab(string ghostName, bool convertShaders = true)
        {
            GameObject ghostPrefab = Modules.Assets.mainAssetBundle.LoadAsset<GameObject>(ghostName);
            if (!ghostPrefab.GetComponent<NetworkIdentity>()) ghostPrefab.AddComponent<NetworkIdentity>();
            if (!ghostPrefab.GetComponent<ProjectileGhostController>()) ghostPrefab.AddComponent<ProjectileGhostController>();

            if (convertShaders)
            {
                Modules.Assets.ConvertAllRenderersToHopooShader(ghostPrefab);
            }

            return ghostPrefab;
        }

        private static GameObject CloneProjectilePrefab(string prefabName, string newPrefabName)
        {
            GameObject newPrefab = PrefabAPI.InstantiateClone(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Projectiles/" + prefabName), newPrefabName);
            return newPrefab;
        }
    }
}
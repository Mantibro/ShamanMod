using ShamanMod.SkillStates;
using ShamanMod.SkillStates.BaseStates;
using System.Collections.Generic;
using System;
using R2API;
using RoR2;
using RoR2.Projectile;
using UnityEngine;
using UnityEngine.Networking;
using EntityStates;
using System.Collections;
using RoR2.Navigation;
using System.Linq;

namespace ShamanMod.Modules
{
    public static class States
    {
        internal static void RegisterStates()
        {
            Modules.Content.AddEntityState(typeof(BaseMeleeAttack));
            Modules.Content.AddEntityState(typeof(AcolyteMeleeAttack));
            Modules.Content.AddEntityState(typeof(AcolyteShootAttack));
            Modules.Content.AddEntityState(typeof(AcolyteBeastShootAttack));
            Modules.Content.AddEntityState(typeof(AcolyteBeastMeleeSwipe));
            Modules.Content.AddEntityState(typeof(AcolyteBeastMeleeSlam));

            Modules.Content.AddEntityState(typeof(GhostVeil));
            Modules.Content.AddEntityState(typeof(Ancestry));
            Modules.Content.AddEntityState(typeof(DistortedFusion));

            Modules.Content.AddEntityState(typeof(StaffCast));
            Modules.Content.AddEntityState(typeof(StaffHealingSkill));
            Modules.Content.AddEntityState(typeof(StaffCurseSkill));
        }
    }
}
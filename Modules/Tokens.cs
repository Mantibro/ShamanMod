using R2API;
using System;

namespace ShamanMod.Modules
{
    internal static class Tokens
    {
        internal static void AddTokens()
        {
            #region Shaman
            string prefix = ShamanPlugin.DEVELOPER_PREFIX + "_SHAMAN_BODY_";

            string desc = "Shaman is a summoner who must rely on its trusty Acolytes to slay enemies.<color=#24732b>" + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Shaman occasionally summons Acolytes, a strong monster that will fight for it." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > In dire situations Ghostly Veil can be used to flee away from danger." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > At least 3 Acolytes are needed for the Ritual of Distorted Fusion. The more are sacrificed, the stronger your new ally will become." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Shaman's Staff is a minor source of damage which must be relied on when no minions are present." + Environment.NewLine + Environment.NewLine;

            string outro = "..and so it left, to spread and grow.";
            string outroFailure = "..and so it vanished, its kin left to replace it.";

            LanguageAPI.Add(prefix + "NAME", "Shaman");
            LanguageAPI.Add(prefix + "DESCRIPTION", desc);
            LanguageAPI.Add(prefix + "SUBTITLE", "Inoculable Varmint");
            #region lore

            string lore = $"This is the logbook entry of D. Furthen, naturalist for the UES [Redacted] in conjunction with the UES Research and Documentation of Outer Life. I am joined by my good friend Tharson, who is keeping me safe through this journey.";
            lore = lore + Environment.NewLine + Environment.NewLine + "---------------------" + Environment.NewLine + Environment.NewLine;
            lore = lore + $"Arriving onto the planet once more, a creature that seemingly appeared from out of thin-air. Given previous encounters with the wildlife on this planet, we assumed that it was another creature who upon seeing us would become hostile , we were pleasantly surprised that this one seemed to be welcoming of our presence. It even motioned for us to come to come closer.";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"I will describe its properties below. I have assigned its common name as `Shaman.`";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"* Tall, bipedal creatures loosely resembling humans but clearly alien. They wear a robe on their body and the skull of an unknown creature over their head that would fit the description of someone of the occult.";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"* Highly intelligent, they show that they can understand what me and Tharson are saying despite speaking in an unintelligible language. This language barrier however was remedied by body language and motions from their hands.";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"* When observed from a distance being attacked by the inhabitants of this planet, The creature would wield a staff and would defend itself by launching projectiles of unknown energy out of it.";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"* During the same encounter with the wildlife, creatures would emerge out of small orbs, or `seeds` that the Shaman would throw onto the ground. These creatures would go and fight for the Shaman, obeying its vocalized commands. If the creatures ever showed signs of fatigue or rebellion, the Shaman would lift its staff high in the air and point at the culprit, shouting something loudly. Upon this, all of the creatures, including the offerder would kneel down and stay quiet until the Shaman lowered its staff. ";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"We have decided to call these neophytes `Acolytes` to fit with the name given to the creature.";

            LanguageAPI.Add(prefix + "LORE", lore);
            #endregion

            LanguageAPI.Add(prefix + "OUTRO_FLAVOR", outro);
            LanguageAPI.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            LanguageAPI.Add(prefix + "DEFAULT_SKIN_NAME", "Default");
            LanguageAPI.Add(prefix + "MASTERY_SKIN_NAME", "Tomb Raiser");
            #endregion

            #region Passive
            LanguageAPI.Add(prefix + "PASSIVE_NAME", "Seed of Virality");
            LanguageAPI.Add(prefix + "PASSIVE_DESCRIPTION", $"Every 45 seconds summon an Acolyte that <style=cIsUtility>inherits all your items</style>. The cooldown is affected by attack speed.");
            #endregion

            #region Primary
            LanguageAPI.Add(prefix + "PRIMARY_STAFF_NAME", "Staff of Conquest");
            LanguageAPI.Add(prefix + "PRIMARY_STAFF_DESCRIPTION", $"Rapidly fire tracking pellets which deal <style=cIsDamage>{100f * StaticValues.staffDamageCoefficient}% damage</style>.");
            #endregion

            #region Secondary
            LanguageAPI.Add(prefix + "SECONDARY_HEALORB_NAME", "Wad of Earth");
            LanguageAPI.Add(prefix + "SECONDARY_HEALORB_DESCRIPTION", $"Fire a magic orb which explodes and <style=cIsHealing>heals</style> you and your allies for <style=cIsHealing>{100f * StaticValues.staffHealingCoefficient}% damage</style>.");

            LanguageAPI.Add(prefix + "SECONDARY_ALT_CURSEORB_NAME", "Vestige of Thorns");
            LanguageAPI.Add(prefix + "SECONDARY_ALT_CURSEORB_DESCRIPTION", $"Fire a cursed skull which explodes for <style=cIsDamage>{100f * StaticValues.staffCurseCoefficient}% damage</style>, <style=cIsDamage>Cripples</style> and <style=cIsDamage>Curses</style> enemies.");
            #endregion

            #region Utility
            LanguageAPI.Add(prefix + "UTILITY_GHOSTVEIL_NAME", "Ghostly Veil");
            LanguageAPI.Add(prefix + "UTILITY_GHOSTVEIL_DESCRIPTION", $"Become <style=cIsUtility>invislble</style>, gain increased <style=cIsUtility>movement speed</style> and <style=cIsUtility>100 armor</style> for a short duration.");

            LanguageAPI.Add(prefix + "UTILITY_ANCESTRY_ALT_NAME", "Ancestral Pathway");
            LanguageAPI.Add(prefix + "UTILITY_ANCESTRY_ALT_DESCRIPTION", $"<style=cIsUtility>Teleport</style> your minions to your current location and grant them a <style=cIsHealing>temporary barrier</style>.");
            #endregion

            #region Special

            string specialDesc = $"Sacrifice all of your summoned Acolytes and summon a <style=cIsDamage>powerful ally</style>. At least 3 Acolytes are needed for the Ritual.";

            LanguageAPI.Add(prefix + "SPECIAL_FUSION_NAME", "Ritual of Distorted Fusion");
            LanguageAPI.Add(prefix + "SPECIAL_FUSION_DESCRIPTION", specialDesc);

            LanguageAPI.Add(prefix + "SPECIAL_FUSION_SCEPTER_NAME", "Ritual of Twisted Fusion");
            LanguageAPI.Add(prefix + "SPECIAL_FUSION_SCEPTER_DESCRIPTION", specialDesc + Helpers.ScepterDescription($"Summon two guardian <style=cIsDamage>Stone Golems</style> after the ritual that <style=cIsUtility>inherit all your items</style>."));

            LanguageAPI.Add(prefix + "SPECIAL_ALT_FERALCALL_NAME", "Call of the Wild");
            LanguageAPI.Add(prefix + "SPECIAL_ALT_FERALCALL_DESCRIPTION", $"Have all of your Acolytes enter a <style=cIsDamage>Feral Frenzy</style> for 15 seconds, losing <color=#a80000>50% MAX HP</color>, but gaining massive <style=cIsDamage>damage</style> and <style=cIsUtility>speed</style> bonuses.");
            #endregion

            #region Achievements
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_NAME", "Shaman: Mastery");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_DESC", "As Shaman, beat the game or obliterate on Monsoon.");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_UNLOCKABLE_NAME", "Shaman: Mastery");
            #endregion
            #endregion

            #region Minions
            string ac_prefix = ShamanPlugin.DEVELOPER_PREFIX + "_ACOLYTE_BODY_";
            LanguageAPI.Add(ac_prefix + "NAME", "Acolyte");
            LanguageAPI.Add(ac_prefix + "SUBTITLE", "Kin of Contagion");

            lore = $"ANOTHER WORLD TO BE PART OF [nest].";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"TO [spore].";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"THOSE WHO [ascend] BECOME [shepherd].";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"THOSE WHO DONT [ascend] SERVE [shepherd] TO [spore].";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"ALL [shepherd] ARE SMART. ALL [shepherd] TO BE OBEYED. THEY HELP US SPREAD AND [spore].";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"[shepherd] SAY THIS WORLD IS PERFECT. PERFECT TO MAKE [nest].";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"[shepherd] TELL US THAT OTHERS FROM [unknown] HELP US MAKE [nest].";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"WE FOLLOW [shepherd] . WE FOLLOW THE OTHERS. THEY HELP US [spore]. HELP US SPREAD.";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"WE WILL MAKE THIS PLACE [nest].";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"ONCE THIS WORLD IS A PART OF [nest]. WE WILL FIND NEW WORLDS TO MAKE [nest].";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"WE WILL MAKE ALL WORLDS [nest].";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"WE DO THIS SO THAT ALL WILL BECOME ONE.";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"ALL BECOME ONE.";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"THAT IS WHAT WE WANT.";
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"TO BECOME ONE.";

            LanguageAPI.Add(ac_prefix + "LORE", lore);

            string acb_prefix = ShamanPlugin.DEVELOPER_PREFIX + "_ACOLYTEBEAST_BODY_";
            LanguageAPI.Add(acb_prefix + "NAME", "Shamanic Compound");
            LanguageAPI.Add(acb_prefix + "SUBTITLE", "Colossus of Singularity");

            lore = $"They felt the call, and joined together in pain." + Environment.NewLine;
            lore = lore + $"Their sacrifice, a cost they did disdain." + Environment.NewLine;
            lore = lore + $"And each small being felt the burning hate. . ." + Environment.NewLine;
            lore = lore + $"For the mass that was their ultimate fate." + Environment.NewLine;
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"The valiant hearts, their forms combined into one." + Environment.NewLine;
            lore = lore + $"Their suffering, a sacrifice forcibly done." + Environment.NewLine;
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"[shepherd], served, and satisfied." + Environment.NewLine;
            lore = lore + $"And each lesser being took pride." + Environment.NewLine;
            lore = lore + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            lore = lore + $"But the pain they felt, the cost they bore," + Environment.NewLine;
            lore = lore + $"All in service of their kin's war." + Environment.NewLine;

            LanguageAPI.Add(acb_prefix + "LORE", lore);

            #endregion
        }
    }
}
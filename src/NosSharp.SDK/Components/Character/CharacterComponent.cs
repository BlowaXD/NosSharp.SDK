using System;
using System.Reflection.Metadata.Ecma335;
using NosSharp.ECS.Components;

namespace NosSharp.SDK.Components.Character
{
    public class CharacterComponent : IComponent
    {
        public Type Type => typeof(CharacterComponent);

        #region Leveling

        /*
         * Level
         */
        public byte Level;
        public byte JobLevel;
        public byte HeroLevel;
        public event EventHandler LevelUp;
        private void OnLevelUp() => LevelUp?.Invoke(this, EventArgs.Empty);


        /*
         * XP
         */
        public uint LevelXp;
        public uint JobLevelXp;
        public uint HeroLevelXp;
        public event EventHandler XpGain;
        private void OnXpGain() => XpGain?.Invoke(this, EventArgs.Empty);

        #endregion


        #region Reputation
        /*
         * Reputation
         */
        public uint Reputation;
        public byte Dignity;

        public event EventHandler ReputationChange;
        private void OnReputationChange() => ReputationChange?.Invoke(this, EventArgs.Empty);

        public event EventHandler DignityChange;
        private void OnDignityChange() => DignityChange?.Invoke(this, EventArgs.Empty);

        #endregion

        /*
         * STATS PVE
         */
        public uint KillPve;
        public uint DeathPve;
        public uint HitPve;


        /*
         * STATS PVP
         */
        public uint KillPvp;
        public uint DeathPvP;
        public uint HitPvp;
    }
}
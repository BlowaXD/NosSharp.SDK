// NosSharp
// BattleComponent.cs

using System;
using System.ComponentModel;
using NosSharp.SDK.Components.Battle.Args;
using NosSharp.SDK.Core.Utilities;

namespace NosSharp.SDK.Components.Battle
{
    /// <summary>
    /// Will use IComponent
    /// </summary>
    public sealed class BattleComponent
    {
        public BattleComponent(BattleEntityType battleEntityType)
        {
            BattleEntityType = battleEntityType;
        }

        public BattleEntityType BattleEntityType { get; }

        /// <summary>
        /// Battle
        /// </summary>
        public static event TypedSenderEventHandler<BattleComponent, HitArgs> Hit;
        public static event TypedSenderEventHandler<BattleComponent, HitArgs> HitReceived;
        public static event TypedSenderEventHandler<BattleComponent, KillArgs> Kill;
        public static event TypedSenderEventHandler<BattleComponent, KillArgs> Death;
        public static event TypedSenderEventHandler<BattleComponent, SkillCastArgs> SkillCast;
        public static event TypedSenderEventHandler<BattleComponent, BuffReceivedArgs> BuffReceived;
        public static event TypedSenderEventHandler<BattleComponent, BuffReceivedArgs> DebuffReceived;

        private void OnHit(HitArgs e) => Hit?.Invoke(this, e);
        private void OnHitReceived(HitArgs e) => HitReceived?.Invoke(this, e);
        private void OnKill(KillArgs e) => Kill?.Invoke(this, e);
        private void OnDeath(KillArgs e) => Death?.Invoke(this, e);
        private void OnSkillCast(SkillCastArgs e) => SkillCast?.Invoke(this, e);
        private void OnBuffRececived(BuffReceivedArgs e) => BuffReceived?.Invoke(this, e);
        private void OnDebuffReceived(BuffReceivedArgs e) => DebuffReceived?.Invoke(this, e);


        public static event TypedSenderEventHandler<BattleComponent, MoveArgs> Move;
        private void OnMove(MoveArgs e) => Move?.Invoke(this, e);

    }
}
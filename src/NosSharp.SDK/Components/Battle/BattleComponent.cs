using System;
using MMOS.ECS.Components;
using NosSharp.SDK.Events;

namespace NosSharp.SDK.Components.Battle
{
    public class BattleComponent : IComponent
    {
        public event EventHandler Move;
        private void OnMove() => Move?.Invoke(this, EventArgs.Empty);


        public event EventHandler<DeathEventArg> Death;
        public event EventHandler Kill;
        public event EventHandler DamageDealt;
        public event EventHandler DamageReceived;
        public event EventHandler SkillCasted;


        private void OnDeath(DeathEventArg death) => Death?.Invoke(this, death);
        private void OnDamageReceived() => DamageReceived?.Invoke(this, EventArgs.Empty);
        private void OnKill() => Kill?.Invoke(this, EventArgs.Empty);
        private void OnDamageDealt() => DamageDealt?.Invoke(this, EventArgs.Empty);
        private void OnSkillCasted() => SkillCasted?.Invoke(this, EventArgs.Empty);


        public Type Type => typeof(BattleComponent);

        public uint Hp { get; private set; }
        public uint MaxHp { get; private set; }

        public uint Mp { get; private set; }
        public uint MaxMp { get; private set; }

        public byte AttackUpgrade { get; private set; }
        public byte DefenseUpgrade { get; private set; }

        public uint GenerateDamage(BattleComponent component)
        {
            return 0;
        }

        public void ReceiveDamage(uint damages)
        {
            ReceiveDamage(damages, null);
        }

        public void ReceiveDamage(uint damages, BattleComponent damager)
        {
            if (damages >= Hp)
            {
                var deathEventArg = new DeathEventArg()
                {
                    Killer = damager
                };
                OnDeath(deathEventArg);
            }

            OnDamageReceived();
        }
    }
}
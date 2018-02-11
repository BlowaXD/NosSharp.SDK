using System;
using System.Collections.Generic;
using System.Linq;
using NosSharp.ECS.Components;
using NosSharp.ECS.Entities;
using NosSharp.SDK.Components.Battle;
using NosSharp.SDK.Components.Character;
using NosSharp.SDK.Components.Inventory;

namespace NosSharp.SDK.Entities
{
    public class Character : IEntity
    {
        private readonly Dictionary<Type, IComponent> _components = new Dictionary<Type, IComponent>
        {
            { typeof(CharacterComponent), new CharacterComponent() },
            { typeof(BattleComponent), new BattleComponent() },
            { typeof(InventoryComponent), new InventoryComponent() }
        };

        public long Id { get; }
        public Type EntityType => typeof(Character);

        public bool HasComponent<T>()
        {
            return HasComponent(typeof(T));
        }

        public bool HasComponent(Type type)
        {
            return _components.ContainsKey(type);
        }

        public T GetComponent<T>() where T : IComponent
        {
            return (T)GetComponent(typeof(T));
        }

        public IComponent GetComponent(Type type)
        {
            return !_components.TryGetValue(type, out IComponent component) ? null : component;
        }

        public IComponent[] GetComponents()
        {
            return _components.Values.ToArray();
        }

        public IComponent[] GetComponents<T>() where T : IComponent
        {
            return GetComponents(typeof(T));
        }

        /// <inheritdoc />
        public IComponent[] GetComponents(Type type)
        {
            return _components.Values.Where(s => s.Type == type).ToArray();
        }

        public void AddComponent(IComponent component, Type type)
        {
            _components.TryAdd(type, component);
        }

        public void AddComponent<T>(IComponent component) where T : class
        {
            AddComponent(component, typeof(T));
        }

        public bool RemoveComponent<T>()
        {
            return RemoveComponent(typeof(T));
        }

        public bool RemoveComponent(Type type)
        {
            return _components.Remove(type);
        }

        public void Destroy()
        {
        }
    }
}
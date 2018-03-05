// NosSharp.SDK
// DependencyContainer.cs

using System;
using System.Collections.Generic;
using NosSharp.SDK.Core.Utilities;

namespace NosSharp.SDK.Core.Helper
{
    /// <summary>
    /// Singleton container that will hold objects
    /// </summary>
    public class DependencyContainer : Singleton<DependencyContainer>
    {
        /// <summary>
        /// Hold dependencies instances
        /// </summary>
        private readonly Dictionary<Type, object> _dependencies = new Dictionary<Type, object>();

        /// <summary>
        /// Register
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="object"></param>
        public void Register<T>(T @object)
        {
            _dependencies[typeof(T)] = @object;
        }


        /// <summary>
        /// Get an instance of <see cref="Type"/> <typeparamref name="T"/> and returns it
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Get<T>() where T : class
        {
            return !_dependencies.TryGetValue(typeof(T), out object dep) ? null : dep as T;
        }

        /// <summary>
        /// Get an instance of Type <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dependency"></param>
        /// <returns></returns>
        public bool Get<T>(out T dependency) where T : class, new()
        {
            bool test = _dependencies.TryGetValue(typeof(T), out object obj);
            dependency = obj as T;
            return test;
        }
    }
}
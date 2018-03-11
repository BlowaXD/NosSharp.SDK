// NosSharp.SDK
// GenericDependencyContainer.cs

using System;

namespace NosSharp.SDK.Core.Helper
{
    /// <summary>
    /// Compile time Dependency Container
    /// </summary>
    public static class GenericDependencyContainer<TService> where TService : class
    {
        private static Lazy<TService> _instance;

        /// <summary>
        /// Register
        /// </summary>
        /// <typeparam name="TDependency"></typeparam>
        public static void Register<TDependency>() where TDependency : TService, new()
        {
            _instance = new Lazy<TService>(() => new TDependency());
        }


        /// <summary>
        /// Get an instance of <see cref="Type"/> <typeparamref name="T"/> and returns it
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static TService Get() => _instance.Value;
    }
}
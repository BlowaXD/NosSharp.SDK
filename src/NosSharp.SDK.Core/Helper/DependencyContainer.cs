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
    public static class DependencyContainer<TService> where TService : class
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
        public static TService Get()
        {
            return _instance.Value;
        }
    }
}
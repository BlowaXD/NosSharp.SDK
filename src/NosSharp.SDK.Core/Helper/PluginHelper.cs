using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using NosSharp.SDK.Core.Plugins;

namespace NosSharp.SDK.Core.Helper
{
    public static class PluginHelper
    {
        /// <summary>
        /// Will load every plugins in the directory given as parameeter, will have to be a .dll
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="directoryPath"></param>
        public static IEnumerable<T> LoadPlugins<T>(string directoryPath) where T : IPlugin
        {
            if (directoryPath == null)
            {
                throw new ArgumentNullException(nameof(directoryPath));
            }

            List<T> plugins = new List<T>();
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
                return null;
            }

            foreach (string file in Directory.GetFiles(directoryPath, "*.dll"))
            {
                plugins.AddRange(LoadPlugins<T>(new FileInfo(file)));
            }

            return plugins;
        }

        /// <summary>
        /// Will load a plugin and return it as an <see cref="IPlugin"/> based on a <see cref="FileInfo"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="file"></param>
        /// <returns></returns>
        public static ICollection<T> LoadPlugins<T>(FileInfo file) where T : IPlugin
        {
            if (file == null)
            {
                throw new ArgumentNullException(nameof(file));
            }

            AssemblyName assemblyName = AssemblyName.GetAssemblyName(file.FullName);
            Assembly assembly = Assembly.LoadFrom(file.FullName);

            if (assembly == null)
            {
                return null;
            }

            Type[] types = assembly.GetTypes();
            Type pluginType = typeof(T);
            ICollection<Type> pluginTypes = types.Where(type => !type.IsInterface && !type.IsAbstract).Where(type => type.GetInterface(pluginType.FullName) != null).ToArray();

            ICollection<T> plugins = new List<T>(pluginTypes.Count);
            foreach (Type type in pluginTypes)
            {
                var plugin = (T)Activator.CreateInstance(type);
                plugins.Add(plugin);
            }

            return plugins;
        }
    }
}
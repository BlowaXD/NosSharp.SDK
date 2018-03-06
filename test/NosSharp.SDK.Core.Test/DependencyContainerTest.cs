using NosSharp.SDK.Core.Helper;
using Xunit;

namespace NosSharp.SDK.Core.Test
{
    public class DependencyContainerTest
    {
        internal interface IDependencyTest
        {
            bool IsAlive { get; }
        }

        internal class DependencyTestDependency : IDependencyTest
        {
            public bool IsAlive => true;
        }

        [Fact]
        public void TestDependencyContainer()
        {
            // register an instance of IDependencyTest for Inversion of Control
            DependencyContainer<IDependencyTest>.Register<DependencyTestDependency>();
            Assert.NotNull(DependencyContainer<IDependencyTest>.Get());
        }
    }
}
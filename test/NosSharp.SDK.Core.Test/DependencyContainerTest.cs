using System;
using Microsoft.Extensions.DependencyModel;
using NosSharp.SDK.Core.Helper;
using Xunit;

namespace NosSharp.SDK.Core.Test
{
    public class DependencyContainerTest
    {
        internal interface IDependencyTest
        {

        };

        internal class DependencyTestDependency : IDependencyTest
        {

        }

        [Fact]
        public void TestDependencyContainer()
        {
            // register an instance of IDependencyTest for Inversion of Control
            var objtest = new DependencyTestDependency();
            DependencyContainer.Instance.Register<IDependencyTest>(objtest);

            Assert.NotNull(DependencyContainer.Instance.Get<IDependencyTest>());
        }
    }
}

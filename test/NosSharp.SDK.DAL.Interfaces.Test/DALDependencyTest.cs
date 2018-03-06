using System;
using System.IO;
using NosSharp.SDK.Core.Configuration;
using NosSharp.SDK.Core.Helper;
using Xunit;

namespace NosSharp.SDK.DAL.Interfaces.Test
{
    internal class TestRateService : IRateService
    {
        public int XpRate => 1;
        public int JobXpRate => 1;
        public int HeroXpRate => 1337;
        public int DropRate => 2;
        public int DropRarityRate => 2;
        public int DropQuantityRate => 2;
        public int ReputationRate => 2;
        public bool ReputationOnKill => false;
        public int UpgradeRate => 2;
        public int RarifyRate => 2;
        public void Update()
        {
            // NOTHING IN THIS CASE
        }
    }

    public class FileTestRateService : IRateService
    {
        private RatesConfiguration _configuration;
        private readonly string _configurationPath;
        public FileTestRateService(string path)
        {
            _configurationPath = path;
            _configuration = ConfigurationHelper.Load<RatesConfiguration>(_configurationPath, true);
        }

        public int XpRate => _configuration.XpRate;
        public int JobXpRate => _configuration.JobXpRate;
        public int HeroXpRate => _configuration.HeroXpRate;
        public int DropRate => _configuration.DropRate;
        public int DropRarityRate => _configuration.DropRarityRate;
        public int DropQuantityRate => _configuration.DropQuantityRate;
        public int ReputationRate => _configuration.ReputationRate;
        public bool ReputationOnKill => _configuration.ReputationOnKill;
        public int UpgradeRate => _configuration.UpgradeRate;
        public int RarifyRate => _configuration.RarifyRate;

        /// <summary>
        /// Let's reload the file !
        /// </summary>
        public void Update()
        {
            _configuration = ConfigurationHelper.Load<RatesConfiguration>(_configurationPath, true);
        }
    }

    public class DalDependencyTest
    {
        [Fact]
        public void BasicDalDependencyTest()
        {
            var obj = new TestRateService();
            DependencyContainer.Instance.Register<IRateService>(obj);
            var dump = DependencyContainer.Instance.Get<IRateService>();
            Assert.Equal(1, dump.XpRate);
            Assert.Equal(1, dump.JobXpRate);
            Assert.Equal(1337, dump.HeroXpRate);
            Assert.Equal(2, dump.DropRate);
            Assert.Equal(2, dump.DropRarityRate);
            Assert.False(dump.ReputationOnKill);
        }

        [Fact]
        public void AdvancedDalDependencyTest()
        {
            const string ratesPath = "./config/rates.json";
            var obj = new FileTestRateService(ratesPath);
            DependencyContainer.Instance.Register<IRateService>(obj);
            var dep = DependencyContainer.Instance.Get<IRateService>();
            RatesConfiguration conf = ConfigurationHelper.Load<RatesConfiguration>(ratesPath);
            Assert.Equal(conf.XpRate, dep.XpRate);
            conf.XpRate = 25;
            Assert.NotEqual(conf.XpRate, dep.XpRate);
            ConfigurationHelper.Save(ratesPath, conf);
            // UPDATE THE CONFIG
            dep.Update();
            Assert.Equal(conf.XpRate, dep.XpRate);
        }
    }
}
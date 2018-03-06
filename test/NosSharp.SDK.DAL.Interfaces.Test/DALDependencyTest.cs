using System;
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

    public class RatesConfiguration
    {
        public RatesConfiguration()
        {
            XpRate = 1;
            JobXpRate = 1;
            HeroXpRate = 1;
            DropRate = 1;
            DropRarityRate = 1;
            DropQuantityRate = 1;
        }

        public int XpRate { get; set; }
        public int JobXpRate { get; set; }
        public int HeroXpRate { get; set; }

        public int DropRate { get; set; }
        public int DropRarityRate { get; set; }
        public int DropQuantityRate { get; set; }

        public int ReputationRate { get; set; }
        public bool ReputationOnKill { get; set; }

        public int UpgradeRate { get; set; }
        public int RarifyRate { get; set; }
    }

    public class FileTestRateService : IRateService
    {
        private RatesConfiguration _configuration;
        private readonly string _configurationPath;

        public FileTestRateService()
        {
            _configurationPath = "./config/rates.json";
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
            DependencyContainer<IRateService>.Register<TestRateService>();
            var dump = DependencyContainer<IRateService>.Get();
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
            DependencyContainer<IRateService>.Register<FileTestRateService>();
            var dep = DependencyContainer<IRateService>.Get();
            RatesConfiguration conf = ConfigurationHelper.Load<RatesConfiguration>(ratesPath);
            Assert.Equal(conf.XpRate, dep.XpRate);
            random:
            conf.XpRate = new Random().Next(100);
            if (conf.XpRate == dep.XpRate)
                goto random;
            Assert.NotEqual(conf.XpRate, dep.XpRate);
            ConfigurationHelper.Save(ratesPath, conf);
            // UPDATE THE CONFIG
            dep.Update();
            Assert.Equal(conf.XpRate, dep.XpRate);
        }
    }
}
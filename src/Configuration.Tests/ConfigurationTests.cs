using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemConfiguration.TeamConfiguration;

namespace Configuration.Tests
{
    [TestFixture]
    public class ConfigurationTests
    {
        bool isDebug;
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
#if DEBUG
            isDebug = true;
#endif
        }


        [Test]
        public void Test_GetStartingQuarterback()
        {
            Assert.IsTrue(isDebug
                ? FootballTeam.OffensiveRoster.Qb.Starter == ExpectedDebugConfig.QB_STARTER
                : FootballTeam.OffensiveRoster.Qb.Starter == ExpectedReleaseConfig.QB_STARTER);
        }

        [Test]
        public void Test_GetSecondStringQuarterback()
        {
            Assert.IsTrue(isDebug
                            ? FootballTeam.OffensiveRoster.Qb.SecondString == ExpectedDebugConfig.QB_SECOND_STRING
                            : FootballTeam.OffensiveRoster.Qb.SecondString == ExpectedReleaseConfig.QB_SECOND_STRING);
        }

        [Test]
        public void Test_GetThirdStringQuarterback()
        {
            Assert.IsTrue(isDebug
                            ? FootballTeam.OffensiveRoster.Qb.ThirdString == ExpectedDebugConfig.QB_THIRD_STRING
                            : FootballTeam.OffensiveRoster.Qb.ThirdString == ExpectedReleaseConfig.QB_THIRD_STRING);
        }

        [Test]
        public void Test_GetOLLeftTackle()
        {
            Assert.IsTrue(isDebug
                            ? FootballTeam.OffensiveRoster.OL.LeftTackle == ExpectedDebugConfig.OL_LEFT_TACKLE
                            : FootballTeam.OffensiveRoster.OL.LeftTackle == ExpectedReleaseConfig.OL_LEFT_TACKLE);
        }

        [Test]
        public void Test_GetOLLeftGuard()
        {
            Assert.IsTrue(isDebug
                            ? FootballTeam.OffensiveRoster.OL.LeftGuard == ExpectedDebugConfig.OL_LEFT_GUARD
                            : FootballTeam.OffensiveRoster.OL.LeftGuard == ExpectedReleaseConfig.OL_LEFT_GUARD);
        }

        [Test]
        public void Test_GetOLCenter()
        {
            Assert.IsTrue(isDebug
                            ? FootballTeam.OffensiveRoster.OL.Center == ExpectedDebugConfig.OL_CENTER
                            : FootballTeam.OffensiveRoster.OL.Center == ExpectedReleaseConfig.OL_CENTER);
        }

        [Test]
        public void Test_GetOLRightGuard()
        {
            Assert.IsTrue(isDebug
                            ? FootballTeam.OffensiveRoster.OL.RightGuard == ExpectedDebugConfig.OL_RIGHT_GUARD
                            : FootballTeam.OffensiveRoster.OL.RightGuard == ExpectedReleaseConfig.OL_RIGHT_GUARD);
        }

        [Test]
        public void Test_GetOLRightTackle()
        {
            Assert.IsTrue(isDebug
                            ? FootballTeam.OffensiveRoster.OL.RightTackle == ExpectedDebugConfig.OL_RIGHT_TACKLE
                            : FootballTeam.OffensiveRoster.OL.RightTackle == ExpectedReleaseConfig.OL_RIGHT_TACKLE);
        }

        [Test]
        public void Test_GetOLReserve1()
        {
            Assert.IsTrue(isDebug
                            ? FootballTeam.OffensiveRoster.OL.Reserve1 == ExpectedDebugConfig.OL_RESERVE_ONE
                            : FootballTeam.OffensiveRoster.OL.Reserve1 == ExpectedReleaseConfig.OL_RESERVE_ONE);
        }

        [Test]
        public void Test_GetOLReserve2()
        {
            Assert.IsTrue(isDebug
                            ? FootballTeam.OffensiveRoster.OL.Reserve2 == ExpectedDebugConfig.OL_RESERVE_TWO
                            : FootballTeam.OffensiveRoster.OL.Reserve2 == ExpectedReleaseConfig.OL_RESERVE_TWO);
        }
    }
}

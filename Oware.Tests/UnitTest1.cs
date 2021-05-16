using System.Collections.Generic;
using NUnit.Framework;
using NSubstitute;
namespace Oware.Tests
{
    public class MockScoreHouse : IScoreHouse {

        public int GetCount() {
            throw new System.NotImplementedException();
        }

        public void AddSeed(Seed seed) {
            List<Seed> seedsInHouse =  new List<Seed>();
            seedsInHouse.Add(seed);
        }

        public void Reset() {
            throw new System.NotImplementedException();
        }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
			// ARRANGE:
			House house = new House (0, 0);
			house.AddSeedInPot(new Seed());
			// ACT:
			house.ResetHouse();
			// ASSERT:
            Assert.AreEqual(4, house.GetCount(), "Initialised houses should contain 4 seeds");
        }
		
		[Test]
		public void Test2()
		{
			// ARRANGE:
            IScoreHouse sOne = new ScoreHouse();
            IScoreHouse mock = Substitute.For<IScoreHouse>();
            Seed theSeed = new Seed();
            sOne = mock;
            Player one = new Player("john", sOne);
            // ACT:
            one.AddSeedToScoreHouse(theSeed);
            // ASSERT:
            sOne.Received().AddSeed(theSeed);
		}
    }
}
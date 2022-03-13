using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {

        [Test]
        public void IsAxeLoseDurability()
        {
            Dummy dummy = new Dummy(100, 10);
            Axe axe = new Axe(1, 10);
            axe.Attack(dummy);
            Assert.AreEqual(9, axe.DurabilityPoints, "Axe durability points doesn't decrease.");
        }

        [Test]
        public void AttackWithBrokenAxe()
        {
            Dummy dummy = new Dummy(100, 10);
            Axe axe = new Axe(10, 0);
            Assert.Throws<InvalidOperationException>(() => axe
                .Attack(dummy), "Axe is broken.");
        }

        [Test]
        public void IsTheAttackPointsReal()
        {
            Axe axe = new Axe(10, 10);
            Assert.AreEqual(10, axe.AttackPoints);
        }
    }
}
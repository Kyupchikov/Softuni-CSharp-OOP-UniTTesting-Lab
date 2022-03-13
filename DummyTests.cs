using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private int health = 10;
        private int experience = 10;
        private Dummy dummy;

        [SetUp]
        public void SetUp()
        {
            dummy = new Dummy(health, experience);
        }


        [Test]
        public void DoesDummyLoseHealthIfAttacked()
        {
            int attack = 5;
            dummy.TakeAttack(attack);
            Assert.AreEqual(health - attack, dummy.Health, "Dummy doesn't lose health!");
        }

        [Test]
        public void DoesDeadDummyThrowsAnException()
        {
            Axe axe = new Axe(10, 10);
            axe.Attack(dummy);
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(2), "Dummy is dead.");
        }

        [Test]
        public void DoesDeadDummyGiveXp()
        {
            Dummy dummy = new Dummy(0, 10);
            if (dummy.IsDead())
            {
                Assert.AreEqual(experience, dummy.GiveExperience());
            }
            else
            {
                Assert.Fail("Dead Dummy doesn't give XP!");
            }
        }

        [Test]
        public void DoesAliveDummyGiveXP()
        {
            Assert.That(() => { dummy.GiveExperience(); }, Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
        }
    }
}
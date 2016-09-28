using NUnit.Framework;

namespace AgeCharacterSheets.Core.Tests
{
    [TestFixture]
    public class AbilityTest
    {
        [Test]
        public void AbilityCanBeImplicitlyCreatedFromInteger()
        {
            Ability ability = 18;

            Assert.That(ability.Value, Is.EqualTo(18));
            Assert.That(ability.Rating, Is.EqualTo(4));
        }

        [TestCase(int.MinValue)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(19)]
        [TestCase(int.MaxValue)]
        public void AnyNumberNotBetweenThreeAndEighteenThrowInvalidException(int invalidNumber)
        {
            TestDelegate test = () => { Ability ability = invalidNumber; };

            Assert.That(test, Throws.TypeOf<System.InvalidCastException>());
        }
    }
}

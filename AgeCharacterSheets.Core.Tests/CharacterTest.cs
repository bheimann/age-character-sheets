using NUnit.Framework;

namespace AgeCharacterSheets.Core.Tests
{
    [TestFixture]
    public class ACharacterShould
    {
        [Test]
        public void BeAbleToBeNamed()
        {
            var character = new Character();

            character.Name = "Franken Beans";

            Assert.AreEqual(character.Name, "Franken Beans");
        }

        [Test]
        public void HasAbilities()
        {
            var character = new Character()
            {
                Abilities = new Abilities
                {
                    Accuracy = 18,
                    Communication = 17,
                    Constitution = 14,
                    Dexterity = 11,
                    Fighting = 8,
                    Intelligence = 7,
                    Perception = 6,
                    Strength = 4,
                    Willpower = 3,
                },
            };

            Assert.That(character.Abilities.Accuracy.Rating, Is.EqualTo(4));
            Assert.That(character.Abilities.Communication.Rating, Is.EqualTo(3));
            Assert.That(character.Abilities.Constitution.Rating, Is.EqualTo(2));
            Assert.That(character.Abilities.Dexterity.Rating, Is.EqualTo(1));
            Assert.That(character.Abilities.Fighting.Rating, Is.EqualTo(0));
            Assert.That(character.Abilities.Intelligence.Rating, Is.EqualTo(0));
            Assert.That(character.Abilities.Perception.Rating, Is.EqualTo(0));
            Assert.That(character.Abilities.Strength.Rating, Is.EqualTo(-1));
            Assert.That(character.Abilities.Willpower.Rating, Is.EqualTo(-2));
        }
    }
}

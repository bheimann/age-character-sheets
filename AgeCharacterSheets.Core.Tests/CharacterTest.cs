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
    }
}

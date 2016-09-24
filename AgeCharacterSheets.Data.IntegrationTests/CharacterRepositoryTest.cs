using AgeCharacterSheets.Core;
using NUnit.Framework;

namespace AgeCharacterSheets.Data.IntegrationTests
{
    [TestFixture]
    public class CharacterRepositoryShould
    {
        [Test]
        public void PullOutPersistedCharacter()
        {
            var characterRepository = new CharacterRepository();
            var frank = new Character();
            var key = "fff";

            characterRepository.Save(frank, key);

            var found = characterRepository.Find(key);
            
            Assert.AreEqual(frank, found);
        }
    }
}

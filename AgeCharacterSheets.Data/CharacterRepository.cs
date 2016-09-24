using AgeCharacterSheets.Core;
using System.Collections.Generic;

namespace AgeCharacterSheets.Data
{
    public class CharacterRepository : ICharacterRepository
    {
        private IDictionary<string, Character> _characters = new Dictionary<string, Character>();

        public Character Find(string key)
        {
            return _characters[key];
        }

        public void Save(Character character, string key)
        {
            _characters[key] = character;
        }
    }
}

namespace AgeCharacterSheets.Core
{
    public interface ICharacterRepository
    {
        Character Find(string key);
        void Save(Character character, string key);
    }
}

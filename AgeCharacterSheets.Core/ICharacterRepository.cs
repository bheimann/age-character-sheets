using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCharacterSheets.Core
{
    public interface ICharacterRepository
    {
        Character Find(string key);
        void Save(Character character, string key);
    }
}

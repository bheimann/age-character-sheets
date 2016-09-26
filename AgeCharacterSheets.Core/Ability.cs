using System;

namespace AgeCharacterSheets.Core
{
    public class Ability
    {
        public int Value { get; private set; }
        public int Rating { get; private set; }

        public static implicit operator Ability(int sumOfRolls)
        {
            return new Ability
            {
                Value = sumOfRolls,
                Rating = DetermineAbilityRating(sumOfRolls),
            };
        }

        //TODO switch to math. I've tried a few varitions of dividing and subtracting but i can't remember what brian said
        private static int DetermineAbilityRating(int sumOfRolls)
        {
            switch (sumOfRolls)
            {
                case 3: return -2;
                case 4: return -1;
                case 5: return -1;
                case 6: return 0;
                case 7: return 0;
                case 8: return 0;
                case 9: return 1;
                case 10: return 1;
                case 11: return 1;
                case 12: return 2;
                case 13: return 2;
                case 14: return 2;
                case 15: return 3;
                case 16: return 3;
                case 17: return 3;
                case 18: return 4;
                default:
                    throw new InvalidCastException(string.Format("Who in the world taught you how to count up 3d6? {0} is not a valid sum", sumOfRolls));
            }
        }
    }
}
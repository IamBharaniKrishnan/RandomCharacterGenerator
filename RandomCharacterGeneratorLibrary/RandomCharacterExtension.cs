using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCharacterGeneratorLibrary
{
    public static class RandomCharacterExtension
    {
        /// <summary>
        /// Generate random characters based on given length.
        /// </summary>
        /// <param name="random">Random class extension.</param>
        /// <param name="minLength">Minimum character length. Default character is 1</param>
        /// <returns></returns>
        public static IEnumerable<char> GenerateRandomCharacters(this Random random, int minLength = 1)
        {
            List<char> characters = new List<char>();

            for (char c = 'A'; c <= 'z' ; c++)
            {
                characters.Add(c);
            }

            for(int i = 0; i < minLength; i++)
            {
                yield return characters[random.Next(characters.Count)];
            }
        }
    }
}

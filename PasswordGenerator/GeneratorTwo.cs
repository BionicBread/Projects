using System;

namespace randomNumbers
{
    public class GeneratorTwo : IGenericGenerator
    {
        // Generates a string of 10 character consisting of lower case letters and numbers
        public int passwordLength { get; private set; } = 10;
        private Random random = new Random();

        private char[] NumberPool()
        {
            char[] numberArray = new char[10];
            
            for (int i = 0; i < 10; i++)
            {
                char iterator = ((char)((char)48 + i));
                numberArray[i] = iterator;
            }
            return numberArray;
        }

        private char[] CharacterPool()
        {
            char[] CharacterArray = new char[25];

            for (int i = 0; i < 25; i++)
            {
                char iterator = ((char)((char)97 + i));
                CharacterArray[i] = iterator;
            }
            return CharacterArray;
        }
        public string GeneratePassword()
        {
            char[] buffer = new char[passwordLength];
            int selector;
            char[] numberPool = NumberPool();
            char[] characterPool = CharacterPool();
            for (var i = 0; i < passwordLength; i++)
            {
                selector = random.Next(0,2);
                if (selector == 0)
                {
                    buffer[i] = numberPool[random.Next(0,10)];
                }
                else
                    buffer[i] = characterPool[random.Next(0,25)];
            }
            string password = new string(buffer);
            return password;
        }
    }
}

using System;

namespace randomNumbers
{
    public class GeneratorOne : IGenericGenerator
    {
        // Generates a string of 10 character consisting only of lower case letters
        public int passwordLength { get; private set; } = 10;
        private Random random = new Random();

        public string GeneratePassword() 
        {

            char[] buffer = new char[passwordLength];

            for (var i = 0; i < passwordLength; i++)
                { 
                buffer[i] = (char)random.Next();
                }
        string password = new string(buffer);
            return password;
        }
}
}

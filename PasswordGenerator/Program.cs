using System;
namespace randomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //GENERATE 20 random strings
            int i = 0;
            GeneratorTwo test = new GeneratorTwo();
            while (i < 20)
            {
                Console.WriteLine(test.GeneratePassword());
                i++;
            }

        }
    }
}

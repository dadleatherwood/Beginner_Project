using System;

namespace Conditional_Statements
{
    class NewProgram
    {
        public static void Main(string[] args)
        {
            var hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It is morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It is afternoon.");
            }
            else
            {
                Console.WriteLine("It is evening.");
            }
        }
    }
}

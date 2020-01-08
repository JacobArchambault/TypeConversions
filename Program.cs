using System;

namespace TypeConversions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***** Fun with type conversions *****");

            // Add two shorts and print the result
            short numb1 = 30000, numb2 = 30000;
            short answer = (short)Add(numb1, numb2);
            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);
            NarrowingAttempt();
            Console.ReadLine();
        }
        static int Add(int x, int y) => x + y;
        static void NarrowingAttempt()
        {
            int myInt = 200;

            // Explicitly cast the int into a byte (no loss of data).
            byte myByte = (byte)myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
        }
    }
}

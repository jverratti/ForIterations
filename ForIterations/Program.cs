using System;

namespace ForIterations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i.ToString());

                if(i == 7)
                {
                    Console.WriteLine("Found seven!");
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
//for loops are used to run a program until a 
//certain result is hit
//i++ == i + 1
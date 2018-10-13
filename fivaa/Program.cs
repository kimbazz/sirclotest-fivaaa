using System;

namespace fivaa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Fivaa(5);
            Console.ReadLine();
        }

        private static void Fivaa(int number)
        {            
            for(int i = number; i > 0; i--)
            {
                string prefix = (number-1).ToString();
                string postfix = (number+1).ToString();
                Console.Write(string.Concat(prefix, prefix));                
                for (int j = 0; j < number; j++)
                {                    
                    Console.Write(postfix);
                }
                Console.WriteLine();
                number--;
            }
        }

    }
}

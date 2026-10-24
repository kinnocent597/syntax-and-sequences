using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace syntaxandsequences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a
            for (int i = 1; i <= 8; i++)
            {
                for(int j = 1; j <= 8; j++)
                {
                    if ((i + j) % 2==0)
                    {
                        Console.Write("# ");
                    }
                    
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //b
            Console.Write("Enter size: ");
            int Size = int.Parse(Console.ReadLine());
            char c = 'A';
            Console.WriteLine();

            for (int i = Size - 2; i > 0; i--)
            {
                for (int j = 0; j <= Size - 1 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= (2 * i + 1); j++)
                {
                    Console.Write(c);
                }
                c++;
                Console.WriteLine();
                
            }
            
            for (int i = 0; i <= Size - 2; i++)
            {
                for (int j = 0; j <=Size - 1 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (2 * i + 1); j++)
                {
                    Console.Write(c);
                }
                Console.WriteLine(); 
                c--;
            }
            Console.WriteLine();
            

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

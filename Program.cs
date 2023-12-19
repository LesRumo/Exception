using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.Write("Enter a number that you want to find a square root for? ");
                int num = Convert.ToInt32(Console.ReadLine());
                double SquareRoot =Math.Sqrt(num);
                Console.WriteLine(SquareRoot);
                    
                    }
            catch ( Exception e) 
            { 
                Console.WriteLine( e.Message);
            }

            Console.ReadLine();
            
            
        }
    }
}

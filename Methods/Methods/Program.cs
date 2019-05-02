using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter Name:");
                string name = Console.ReadLine();
                Console.WriteLine(Greeting(name));

                int number1 = 10;
                int number2 = 100;
                Console.WriteLine("{0} + {1} = {2}", number1, number2, Calculate(number1, number2));

                Console.Write("Enter First Number:");
                int num3 = int.Parse(Console.ReadLine());
                Console.Write("Enter Second Number:");
                int num4 = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} + {1} = {2}", num3, num4, Calculate(num3, num4));
            
        }

            static string Greeting(string name)
            {
                return "Greetings " + name + ", this app will ask for 2 numbers.";
                
            }

            static int Calculate(int number1 , int number2)
            {
                int total = number1 + number2;
                return total;
            
            }
        
        

       
         
       
        
          
        

               
    }
}

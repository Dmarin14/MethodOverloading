using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 3));

            Console.WriteLine(Add(1.56m, 2.78m));

            Console.WriteLine(Add(47, 52, true));

            Console.ReadLine();
        }

        public static int Add(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static string Add(int num1, int num2, bool check)
        {
            
            if (check == true)
            {
                var response = (num1 + num2 < 1) ? $"{num1 + num2} dollar" : $"{num1 + num2} dollars";
                return response;
            }
            else
            {
                var response = $"{num1 + num2}";
                return response;
            }
            
        }
    }
}

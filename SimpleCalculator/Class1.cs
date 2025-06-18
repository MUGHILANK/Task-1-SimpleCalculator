using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Class1
    {

        public void add() 
        {           
                Console.WriteLine("=========== ADD =========");
                Console.Write("A: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("B: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a + b);

        }

        public void sub() 
        {
            Console.WriteLine("=========== SUB =========");
            Console.Write("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            
                long c = a - b; Console.WriteLine("Answer: "+ c);
        }


        public void mul() {
            Console.WriteLine("=========== mul =========");
            Console.Write("A: ");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            float b = Convert.ToInt32(Console.ReadLine());
          
                double c = a * b; Console.WriteLine("Answer: "+ c);

        }


        public void div()
        {
            Console.WriteLine("=========== DIV =========");
            Console.Write("A: ");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            float b = Convert.ToInt32(Console.ReadLine());
            
                double c = a / b; Console.WriteLine("Answer: "+ c);
          }

        public void mod()
        {
            Console.WriteLine("=========== Mod =========");
            Console.Write("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
           int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a%b);
        }


        public void greaterSmall()
        {
            Console.WriteLine("=========== Positive or Negative =========");
            Console.Write("Enter number Positive or Negative: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(num >= 0 ? "Number is Positive" : "Number is Negative");

        }


        public void greaterLarge() {
            Console.WriteLine("=========== Greatest or smallest =========");
            Console.Write("First number: ");
            long a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Secound Number: ");
            long b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a > b ? "First Value is greater" : "Secound value is greater");
        }

    }
}

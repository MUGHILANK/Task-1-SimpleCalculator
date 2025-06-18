using SimpleCalculator;
using System.ComponentModel;

namespace simpleCalculator
{ 
    internal class Program
    {
        public static void Main(string[] args)
        {

            Class1 myObj = new Class1();
            Console.WriteLine("simple calculator");

            while (true) {
                Console.WriteLine("1.For add \n2.Sub \n3.multply \n4.Div \n5.Modules \n6.Greatest or smallest \n7.Numbers are positive");
                int switch_value = Convert.ToInt32(Console.ReadLine());
                switch (switch_value)
                {
                    case 1:
                        myObj.add();          
                     break;
                    
                    case 2:
                        myObj.sub();
                        break;

                    case 3:
                        myObj.mul();
                        break;

                    case 4:
                        myObj.div();
                        break;

                    case 5:
                        myObj.mod();
                        break;

                    case 6:
                        myObj.greaterLarge();
                        break;
                    case 7:
                        myObj.greaterSmall();
                        break;

                    default:
                        Console.WriteLine("break");
                        break;
                        
                }

                Console.WriteLine("Sure want to exit..! Y/n");
                string input = Console.ReadLine().ToUpper();
                if (input != "N") {
                    break;
                }
            }
        }
    }
}
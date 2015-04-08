using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float numValue1;
            float numValue2;
            float totalValue;
            string mathOperator;
            int i = 0;

            Console.WriteLine("This basic calculator will allow you to add, subtract, multiply, or divide two numbers.");
            Console.WriteLine(" ");

            numValue1 = GetNumValue(i);
            i++;
            numValue2 = GetNumValue(i);
            mathOperator = GetMathOperator();
                        
            switch (mathOperator)
            {
                case "A":
                    Console.Write("You wanted to add {0} and {1}.  ", numValue1, numValue2);
                    totalValue = AddValues(numValue1, numValue2);
                    break;

                case "S":
                    Console.Write("You wanted to subtract {0} from {1}.  ", numValue1, numValue2);
                    totalValue = SubtractValues(numValue1, numValue2);
                    break;

                case "M":
                    Console.Write("You wanted to multiply {0} and {1}.  ", numValue1, numValue2);
                    totalValue = MultiplyValues(numValue1, numValue2);
                    break;

                case "D":
                    Console.Write("You wanted to divide {0} by {1}.  ", numValue1, numValue2);
                    totalValue = DivideValues(numValue1, numValue2);
                    break;

                default:
                    Console.WriteLine("There's a problem...");
                    totalValue = 9999;
                    break;
            }
            Console.WriteLine("The answer is: " + totalValue);
            Console.ReadKey();

        }


        static float GetNumValue(int i)
        {
            float value;
            string stringValue;
            bool result = true;
            string [] order = {"first", "second"};

            do
            {
                if (result)
                {
                    Console.Write("Please enter your {0} numeric value: ", order[i]);             
                }
                else
                {
                    Console.Write("You did not enter a number. Please try again: ");
                } 
                stringValue = Console.ReadLine();
                result = Single.TryParse(stringValue, out value);
               
            } while (!result);

            return value;
        }


        static string GetMathOperator()
        {
            string mathOp ="A";
            bool result = true;

            Console.Write("Choose an operator: (A)dd, (S)ubtract, (M)ultiply, or (D)ivide: ");
               
            mathOp = Console.ReadLine();
            mathOp = mathOp.Trim();
            mathOp = mathOp.ToUpper();          
               
            do
            {
                if ((mathOp != "A") && (mathOp != "S") && (mathOp != "M") && (mathOp != "D"))
                {
                    Console.Write("That was not an accepted operator.  Please try again: ");
                    result = false;
                    mathOp = Console.ReadLine();
                    mathOp = mathOp.Trim();
                    mathOp = mathOp.ToUpper();          
                }
                else
                {
                    result = true;
                }
                             
            } while (!result);	         
                       
            return mathOp;
        }


        static float AddValues( float val1, float val2)
        {
            return val1 + val2;
        }


        static float SubtractValues(float val1, float val2)
        {
            return val1 - val2;
        }


        static float MultiplyValues(float val1, float val2)
        {
            return val1 * val2;
        }


        static float DivideValues(float val1, float val2)
        {
            if ((val1 == 0) || (val2 == 0))
            {
                return 0;
            }
            else
            {
                return val1 / val2;
            }
        }
    }
}

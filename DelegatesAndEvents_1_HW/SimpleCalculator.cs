using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents_1_HW
{
    public class SimpleCalculator
    {
        public int NumberGetter()
        {
            int number = 0;
            do
            {
                Console.Write("Please enter positive number: ");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number <= 0);

            return number;
        }

        public void PrintMenu() {
            Console.WriteLine($"\n1. Add" +
                                       $"\n2. Subtraction" +
                                       $"\n3. Multiply" +
                                       $"\n4. Divide" );
        }

        public int GetUserChoice()
        {
            int numberMenu = 0;
            do
            {
                Console.Write("Please enter number according to menu (1-4) ");
                numberMenu = Convert.ToInt32(Console.ReadLine());
            } while (numberMenu < 1 || numberMenu >4);

            return numberMenu;
        }

        public double Calculate(int num1, int num2, int choose) {
            

            double result = 0;
            switch (choose)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        break;
                    }
                    else
                    {
                        result = Double.NaN;
                        break;
                    }
            }
            return result;
        }

        public void PrintResultNicely(double result) {
            Console.WriteLine($"*** {result} ***");
        }
    }
}

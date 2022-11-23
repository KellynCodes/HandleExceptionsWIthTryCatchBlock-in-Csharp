using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class HowToHandleExceptions
    {
        public enum zeroEnum
        {
         zero = 0
        }
        public void Return()
        {
           Console.WriteLine("Enter your age");
            string age = Console.ReadLine();
            Console.WriteLine("Enter number to divide");
            int dividByZero = int.Parse(Console.ReadLine());

           //Lets take this problem below to create an exception handling program
           //Throw error when user:
           string[] userNames = {"Kelechi", "Amos", "Omeh", "Jenny", "Brendan", "Philip"};
            try
            {
                //1. Input string where int is surposed to be returned;
                int Age = int.Parse(age);
                //
                //
                //2. When user try to open file that doesnt exist in the current machine.
                FileStream fs = File.Open(@"C:\user/KELLYNCODES/Downloads/jone-bruz.pdf", FileMode.Open);
                //
                //
                //3. When user want to divide a value by zero;
                int divide(int input, int value)
                {
                   return value / input;
                }
                divide((int)zeroEnum.zero, dividByZero);

                Console.WriteLine("Your input was correct");
            }

            catch (FormatException exception)
            {
                Console.Clear();
                Console.WriteLine($"Format exception: {exception.Message}\n");
                Return();
            }
            catch (DivideByZeroException divideByZero)
            {
                Console.Clear();
                Console.WriteLine($"Divide by zero: {divideByZero.Message}\n");
                Return();
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.Clear();
                Console.WriteLine($"File Directory not found Exception: {ex.Message}\n");
                Return();
            }
            catch (System.Exception ex)
            {
        //This block will catch any other exceptions... that happend while running the code.
                Console.Clear();
                Console.WriteLine($"Other exception Catch: {ex.Message} \n");
                Return();
            }
        }
    }
}

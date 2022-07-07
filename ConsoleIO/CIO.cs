using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIO
{
    public static class CIO
    {
        public static string PromptForInput(string message)
        {
            Console.WriteLine(message);
            string userInput;
            userInput = Console.ReadLine();

            return userInput;
        }

        public static string PromptForInput(string message, bool allowEmpty)
        {
            bool goodInput = allowEmpty;
            Console.WriteLine(message);
            string userInput;

            do
            {
                userInput = Console.ReadLine();
                if (!allowEmpty && userInput.Length == 0)
                {
                    goodInput = false;
                    Console.WriteLine("Invalid Input. Input can't be empty.");
                }
                else
                {
                    goodInput = true;
                }

            } while (!goodInput);

            return userInput;
        }

        public static int PromptForMenuSelection(IEnumerable<string> options, bool startZero)
        {
            bool goodInput = false;
            int userInput;

            do
            {
                int i = startZero ? 0 : 1;

                foreach (string option in options)
                {
                    Console.WriteLine(i + ". " + option);
                    i++;
                }

                string stringInput = Console.ReadLine();
                goodInput = int.TryParse(stringInput, out userInput);

                if (goodInput && userInput >= (startZero ? 0 : 1) && userInput < i)
                {
                    goodInput = true;
                }
                else
                {
                    Console.WriteLine("Input is invalid.");
                    goodInput = false;
                }

            } while (!goodInput);

            return userInput;
        }

    }
}

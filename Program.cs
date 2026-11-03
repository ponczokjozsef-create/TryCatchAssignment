using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Everything that could cause an error is placed inside a try block
            try
            {
                // 1. Ask the user for their age
                Console.WriteLine("Please enter your age:");

                // Read the input and convert it to a whole number.
                // If the input is not a number (e.g. "abc"), this line throws a FormatException.
                int age = Convert.ToInt32(Console.ReadLine());

                // 4. If the age is zero or negative, throw an exception on purpose
                //    so the matching catch block below can show a specific error message
                if (age <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                // 2. Calculate the birth year: the current year minus the user's age.
                //    (It may be off by one year if the user's birthday hasn't happened yet this year.)
                int birthYear = DateTime.Now.Year - age;

                // Display the year the user was born
                Console.WriteLine("You were born in " + birthYear + ".");
            }
            // 4. This catch block runs only when the age was zero or negative
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Error: Your age must be greater than zero. Please enter a positive number.");
            }
            // 5. This catch block runs for any other exception (for example, letters instead of a number)
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please enter a valid whole number for your age.");
            }

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}
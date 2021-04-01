using System;

namespace Lab1
{
    class Program
    {
        //This is a member variable. It is a 'member' of class Program! Now, any 'member' method within this class can access this variable.
        //It has the private modifier as we don't need to access this variable from any other classes - it's only used from within!
        private static int currentIndex = 0;

        // declaring new method for expanding array
        static void expandArrayBy10(ref int[] numbers)
        {
            int expandedNumberOfCells = currentIndex + 10;
            int[] expandedNumbers = new int[expandedNumberOfCells];
            for (int i = 0; i < currentIndex; i++)
            {
                expandedNumbers[i] = numbers[i];
            }
            numbers = expandedNumbers;
        }



        static void Main(string[] args)
        {
            int[] numbers = new int[10];


            // do-while loop to repeat until all of the integers are entered
            bool repeat = true;
            do
            {
                //hello
                Console.WriteLine("Please enter an integer:");
                string line = Console.ReadLine();
                // if statement to allow user to use the word exit to stop the program
                if (line == "exit")
                {
                    repeat = false;
                }
                //else condition for when user enters an integer or anything other then "exit"
                else
                {
                    //try catch
                    try
                    {
                        int number = int.Parse(line);
                        Console.WriteLine("The integer that you entered was:" + number);
                        numbers[currentIndex] = number;
                        currentIndex++;
                        // expending the array if necessary so that an arbitrary number of integers
                        if (currentIndex == numbers.Length)
                        {
                            expandArrayBy10(ref numbers);
                        }
                    }

                    // so that the code doesn't break if an integer is not entered and also prompts the user
                    catch (FormatException)
                    {
                        Console.WriteLine("That was not an integer!");
                    }
                }

            }
            // end of while loop ensuring program loops until the exit condition is satisfied
            while (repeat);
            // this function will print the integers that have been inputted once the do-while loop is satisfied/ user enters exit
            for (int i = 0; i < currentIndex; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            // so that you can see if the program is working requires user to press a key before exiting
            Console.ReadKey();
            Console.WriteLine("Press any key to exit");
        }
    }
}

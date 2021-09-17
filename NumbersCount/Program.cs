using System;

namespace NumbersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 3.30: Write an app that inputs five numbers and 
            //determines and displays the number of negative numbers input, 
            //the number of positive numbers input and the number of zeros input

            //Declaring Variables
            int num = 0, counter = 0, poscount = 0, negcount = 0, zerocount = 0;


            //Calculations
            while(counter < 5)
            {
                //Input Numbers
                Console.WriteLine("Please input a number: ");
         

                if (int.TryParse(Console.ReadLine(), out num))
                {
                    if (num > 0)
                    {
                        poscount++;
                    }
                    if (num < 0)
                    {
                        negcount++;
                    }
                    if (num == 0)
                    {
                        zerocount++;
                    }

                    counter++;
                }

            }

            Console.WriteLine($"The number of positive numbers is {poscount}");
            Console.WriteLine($"The number of negative numbers is {negcount}");
            Console.WriteLine($"The number of Zeros is {zerocount}");
            Console.ReadLine();
        }
    }
}

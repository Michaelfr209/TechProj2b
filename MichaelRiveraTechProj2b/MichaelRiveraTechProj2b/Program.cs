using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelRiveraTechProj2b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What grade (0-100) do you expect to earn in ISM 4300?  ");

            try
            {
                string input = Console.ReadLine();

                int value_of_input = int.Parse(input);






                if ((value_of_input > 0) && (value_of_input <= 100))
                {
                    Console.WriteLine("Assigning your grade based on 2020 syllabus...");



                    if ((value_of_input >= 90) && (value_of_input <= 100))

                    {
                        Console.WriteLine("You have entered " + value_of_input + "." + "You have an A in the class.");
                    }




                    else if ((value_of_input >= 80) && (value_of_input < 90))
                    {
                        Console.WriteLine("You have entered " + value_of_input + "." + "You have an B in the class.");
                    }

                    else if ((value_of_input >= 70) && (value_of_input < 80))
                    {
                        Console.WriteLine("You have entered " + value_of_input + "." + "You have an C in the class.");
                    }


                    else if ((value_of_input >= 60) && (value_of_input < 70))
                    {
                        Console.WriteLine("You have entered " + value_of_input + "." + " You have an D in the class.");
                    }



                    else if ((value_of_input >= 0) && (value_of_input < 59))
                    {
                        Console.WriteLine("You have entered " + value_of_input + "." + "You have an F in the class.");
                    }





                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }





            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }

        }
    }
}

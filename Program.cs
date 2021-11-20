using System;

namespace deliverable1
{

    class Program
    {
        public static void Main(string[] args)
        {

            // 1 inch = 3.5 fidget spinners
            // 1 foot = 5 memes
            bool userContinue = true;

            while (userContinue == true)

            {
                Console.WriteLine("What unit of measurement would you like? Please select one of the following: Foot, Inches, Fidget Spinners, Memes");
                string userResponse = Console.ReadLine();
                string userInput = userResponse.ToLower();

                if (userResponse == "inches"){

                    Console.WriteLine("How many would you like? ");
                    double userInches = double.Parse(Console.ReadLine());
                    double fidgetOutput = userInches * 3.5;
                    Console.WriteLine(fidgetOutput + " fidget spinners");
                }
                 else if (userResponse == "feet"){

                    Console.WriteLine("How many would you like? ");
                    double userFeet = double.Parse(Console.ReadLine());
                    double memesOuput = userFeet * 5;
                    Console.WriteLine(memesOuput + " memes");
                }
                else if (userResponse == "memes"){

                    Console.WriteLine("How many would you like? ");
                    double userMemes = double.Parse(Console.ReadLine());
                    double feetOutput = userMemes / 5;
                    Console.WriteLine(feetOutput + " feet");
                }
                else if (userResponse == "fidget spinners") {

                    Console.WriteLine("How many would you like? ");
                    double userFS = double.Parse(Console.ReadLine());
                    double inchOutput = userFS / 3.5;
                    Console.WriteLine(inchOutput + " inches");
                }

                Console.WriteLine("Would you like to convert another one? (yes/no)");
                string userAgain = Console.ReadLine();
                string userReply = userAgain.ToLower();

                if (userResponse == "yes")
                {
                    userContinue = true;
                }
                else
                {
                    break;
                }
            }


         
        }

    }
}
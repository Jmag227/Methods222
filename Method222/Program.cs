using System;

namespace Method222
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            

                Console.WriteLine("Hello! What's your name?");
                var Name = Console.ReadLine();
                Console.WriteLine($"Heyo {Name}! How are ya? Wanna see a little trick?");

                YesOrNo(Name);

                Console.WriteLine("Pick a number in your head between 1-10. Hit ENTER when you're good to go");
                Console.ReadLine();

                Trick(Name);



            

            static void YesOrNo(string name)
            {
                String userChoice = Console.ReadLine();
                if (userChoice == "Yes")
                {
                    string message = "Yay! Here I go.";
                    Console.WriteLine(message);
                }
                else if (userChoice == "yes")
                {
                    string message = "Dope, let's get it,";
                    Console.WriteLine(message);
                }
                else if (userChoice == "y")
                {
                    string message = ("Here we go");
                    Console.WriteLine(message);
                }
                else
                {
                    string message = "Ha! to bad, here it is anyway";
                    Console.WriteLine(message);
                }



            }








        }



        static void Trick(string name)
        {
            int num1 = 0;
            int num2 = 6;
            int num3 = 2;
            int num4 = 1;

            Console.WriteLine("take that number and double it");
            Console.WriteLine("Now add 6, press enter");
            Console.ReadLine();
            Console.WriteLine("Now devide it by 2, then hit ENTER");
            Console.ReadLine();
            Console.WriteLine("Subtract your number from the start.. ie if your starting number was 2, subtract 2");
            Console.WriteLine("OKAY! Drum role pleae... Your answer is.. (hit enter for the reveal)");
            Console.ReadLine();
            Console.WriteLine(num1 + num2 / num3 * num4);

        }
    }


}

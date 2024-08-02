using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name and type of program run on start up//
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("**Press Enter to after every command to Continue**");
            Console.ReadLine();

            //Questions for students//
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();   
            Console.WriteLine("Hello, " + yourName);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Ok, you are on the " + yourCourse + " course.");
            Console.ReadLine();

            Console.WriteLine("What page number?");
            string yourPage = Console.ReadLine();
            Console.WriteLine("Got it, you are on page number " + yourPage);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please enter true or false");
            string needsHelp = Console.ReadLine();
            Console.WriteLine("You have answered: " + needsHelp);
            Console.ReadLine();

            Console.WriteLine("Where there any positive experiences you would like to share? Give specifics.");
            string posExperiences = Console.ReadLine();
            Console.WriteLine("Thank you for your answer");
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you would like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("Thank you for your feedback");
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            Console.WriteLine("Good job!");
            Console.ReadLine();

            //Closing Statement//
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}

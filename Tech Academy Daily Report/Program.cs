using System;

namespace Tech_Academy_Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report.");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Course: " + yourCourse);
            Console.ReadLine();
            // converting int to string so the program will run
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("Page number is: " + pageNumber);
            Console.ReadLine();
            // using bool to provide true or false for response
            Console.WriteLine("Do you need any help, Answer True or False");
            bool needHelp = false;
            string helpStatus = Convert.ToString(needHelp);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string positiveExp = Console.ReadLine();
            Console.WriteLine(positiveExp);
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine(feedBack);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            Console.WriteLine("Hours studied today: " + hoursStudied);
            Console.ReadLine();

            // End of program
            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}

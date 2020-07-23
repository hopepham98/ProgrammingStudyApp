using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

/*
 * Title created at network-science.de
 */

namespace ProgrammingStudyApp
{
    public class Questions

    {
        public Questions()
        {
            Intro();
        }
        public void Intro()
        {
            ForegroundColor = ConsoleColor.Yellow;
            string TitleText = "Programming Stuy App by Hope Pham";
            TitleText = @"

   _         _                           _             _       _ 
  | |    ___| |_ ___    __ _  ___    ___| |_ _   _  __| |_   _| |
  | |   / _ \ __/ __|  / _` |/ _ \  / __| __| | | |/ _` | | | | |
  | |__|  __/ |_\__ \ | (_| | (_) | \__ \ |_| |_| | (_| | |_| |_|
  |_____\___|\__|___/  \__, |\___/  |___/\__|\__,_|\__,_|\__, (_)
                       |___/                             |___/   
";

            Title = "Programming Study App by Hope Pham";
            Write(TitleText);
            ReadLine();
            Clear();
            Questionone();
   
        }
        public void Questionone()
        {
            ForegroundColor = ConsoleColor.Green;

            Console.Write("Q1) What is a string?\n1) a data type of number and object.\n2) a sum of number.\n3) a data type of charaters.\n4) none of the above.\n");
            int answer1 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            String message1 = (answer1 != 3) ? "INCORRECT! Please try again." : "CORRECT!";
            Console.WriteLine(message1);

            ReadLine();
            Clear();
            Questiontwo();

        }

        public static void Questiontwo()
        {
            ForegroundColor = ConsoleColor.Green;

            Console.Write("Q2) What is a Boolean?\n1) a data type of numbers.\n2) true or false.\n3) a true or false object.\n4) none of the above.\n");
            int answer2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            String message2 = (answer2 != 2) ? "INCORRECT! Please try agian." : "CORRECT!";
            Console.WriteLine(message2);
            ReadLine();
            Clear();
            Questionthree();

        }
        public static void Questionthree()
        {
            ForegroundColor = ConsoleColor.Green;

            Console.Write("Q3) What is a double?\n1) a large number that include decimal.\n2) a sum of number.\n3) a file with large numbers.\n4) none of the above.\n");
            int answer3 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            String message3 = (answer3 != 1) ? "INCORRECT! Please try again." : "CORRECT!";
            Console.WriteLine(message3);
            ReadLine();
            Clear();
            Questionfour();

        }
        public static void Questionfour()
        {
            ForegroundColor = ConsoleColor.Green;

            Console.Write("Q4) What is a class?\n1) a reference types.\n2) a place where you learn.\n3) the level where one is at.\n4) a title one have for themselve.\n");
            int answer4 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            String message4 = (answer4 != 2) ? "INCORRECT! Please try again." : "CORRECT!";
            Console.WriteLine(message4);
            ReadLine();
            Clear();
            Questionfive();
        }
        public static void Questionfive()
        {
            ForegroundColor = ConsoleColor.Green;

            Console.Write("Q5) What is a object?\n1) a variable used in OOP.\n2) a sum of data.\n3) an identity that have basic concepts of OOP.\n4) none of the above.\n");
            int answer5 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            String message5 = (answer5 != 3) ? "INCORRECT! Please try agian." : "CORRECT!";
            Console.WriteLine(message5);
            ReadLine();
         
        }

      
    } 

}
               

                 
            

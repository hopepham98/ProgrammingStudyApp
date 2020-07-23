using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ProgrammingStudyApp
{
    public class Start
    {
        public string answer;

        public void Enter()
        {
            ForegroundColor = System.ConsoleColor.Yellow;

            WriteLine("Hello, would you like to study with this short quiz on programming?");
            answer = ReadLine();
            if (answer == "yes")
            {
               

            }

            else if (answer == "no")
                WriteLine("That would be fince. Please run again if you change your mind.");
            else
                WriteLine("ERROR! Please enter in \"yes\" or \"no\"!");
            ReadLine();
            Clear();
            
        }
    }
}
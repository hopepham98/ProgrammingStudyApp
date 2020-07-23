using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using static System.Console; 

namespace ProgrammingStudyApp
{
    public class Student
    {
        public string Name = "Anonymous Student";
        public string Major = "Anonymous Major";

        public void Intro()
        {
            ForegroundColor = System.ConsoleColor.Green;

            TextInfo TitleCase = new CultureInfo("en-US", false).TextInfo;


            WriteLine("Welcome to the Programming Study Application by Hope Pham." +
                " If you have come here to study then you are in the right app, but first" +
                " please introduce yourself. What is your name?");

            Name = ReadLine();
            Name = TitleCase.ToTitleCase(Name);
            WriteLine("Hello " + Name + "!");
            ReadLine();

            WriteLine("What is your major?.");

            Major = ReadLine();
            Major = TitleCase.ToTitleCase(Major);
            WriteLine(Name + " is majoring in " + Major + "." + " Press enter to continue.");
            ReadLine();

            Clear();
        }
    }
}
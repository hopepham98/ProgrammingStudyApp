using System;
using static System.Console;

/*
 * Programming Study App by Hope Pham
 * PROG 101 (01), June 18, 2020
 * Title created at network-science.de
 * 
 * Project: Code from Code Project page https://www.codeproject.com/Questions/1214607/Creating-a-quiz-in-Csharp
 * Code Author: https://www.codeproject.com/script/Membership/View.aspx?mid=13513329
 * Licensed under CPOL https://www.codeproject.com/info/cpol10.aspx
 */

namespace ProgrammingStudyApp
{
    class Program
    {
        static void Main()
        {
            BackgroundColor = ConsoleColor.DarkBlue;
            ForegroundColor = ConsoleColor.Yellow;
            Clear();
            string TitleText = "Programming Stuy App by Hope Pham";
            TitleText = @"

     ___                                         _           
    | . \ _ _  ___  ___  _ _  ___ ._ _ _ ._ _ _ <_>._ _  ___ 
    |  _/| '_>/ . \/ . || '_><_> || ' ' || ' ' || || ' |/ . |
    |_|  |_|  \___/\_. ||_|  <___||_|_|_||_|_|_||_||_|_|\_. |
                   <___'                                <___'
            ___    _          _         ___           
           / __> _| |_ _ _  _| | _ _   | . | ___  ___ 
           \__ \  | | | | |/ . || | |  |   || . \| . \
           <___/  |_| `___|\___|`_. |  |_|_||  _/|  _/
                                <___'       |_|  |_| 

                           By Hope Pham                     
                       (press enter to study) 
";

            Title = "Programming Study App by Hope Pham";
            Write(TitleText);

            ReadKey();
            Clear();

            Start start = new Start();
            start.Enter();

            Student student = new Student();
            student.Intro();

            Questions questions = new Questions();
            questions.Questionone();
            Clear();





        }
    }
}

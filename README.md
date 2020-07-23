# ProgrammingStudyApp :books:
This is an application that was created during my Summer 2020 Intro to Programming class. An application that enables to take a short quiz on programming terms and tries to receive points.

## Assignment Challenge(s)
The biggest challenge that I face when building this application was the random method code since I didn't know how to formate that, but with my professor's help, I ended up figuring it out. I also had some difficulties with inserting codes to allow players to receive points and formate my questions and answer using an array or list. However, I figure that out with the help with my professor and the internship.

## Image of Application Intro:

![ProgrammingStudyApp](https://user-images.githubusercontent.com/67672827/88249850-4803d880-cc6b-11ea-9425-fc70a082faf3.png)


## Code Example:

```markdown
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
```

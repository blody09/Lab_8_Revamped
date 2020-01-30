using System;
using System.Collections.Generic;

namespace Revision_lab8
{
    
        class Program
        {
            static void Main(string[] args)
            {
                //string list with various students names
                List<string> names = new List<string> { "Sean", "Kyle", "James" };
                //string list for hometown
                List<string> hometown = new List<string> { "Ann Arbor", "Dearborn", "Irish Hills" };
                //repeat above for the final arrays of information you want
                List<string> food = new List<string> { "Salad", "string cheese", "curry" };
                //create another list of favorite numbers
                List<string> car = new List<string> { "Toyota Supra", "Nissan GTR", "Nissan Skyline" };
                Console.WriteLine("Welcome to the January C# class.");
                Console.WriteLine();
             RunAgain:
                Console.WriteLine("What would you like to do \n1. Get to know your classmates or \n2. Add new classmate?\n");
                Console.WriteLine("Enter 1 or 2");
                Console.WriteLine();
                string wouldYou = Console.ReadLine();
                if (wouldYou == "1" || wouldYou == "2")
                {
                    goto LetsContinue;
                }
                else
                {
                    goto RunAgain;
                }
            LetsContinue:
                //declare variables before while loop
                bool userChoice = true;
                bool repeat = true;
                int student = 1;
                //if loop to ask if user wants to add classmate
                if (wouldYou == "1")
                {
                    //while loop to prompt user to see if they would like to repeat
                    while (repeat)
                    {
                        Console.WriteLine("Class Directory:");
                        
                        for (int i = 0; i < names.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {names[i]}");
                            //assuring that it's 1. person 2.person...not 0.person
                        }
                        Console.WriteLine();
                        student = RangeCheck(int.Parse(GetUserInput("Pick a number to learn more about that student?")), 1, names.Count);
                        Console.WriteLine($"Classmate {student} is {names[student - 1]}.");
                        //use another while loop for choice validaiton
                        while (userChoice)
                        {
                       
                    
                    MoreStudentInfo:
                            //ask user what to learn next
                            string topic = GetUserInput($"What would you like to know about {names[student - 1]}. (Hometown, Food, or their Car?)").ToLower();
                            //switch cases to navigate and validate users inputs
                            switch (topic)
                            {
                                case "hometown":

                                    Console.WriteLine($"{names[student - 1]} is from {hometown[student - 1]}.");
                                    Console.WriteLine("Would you like to learn more about this student? y/n?");
                                    string continue1 = Console.ReadLine();
                                    // use this string to see if the usuer would like to coninu
                                    if (continue1 == "n")
                                    {
                                        goto RunAgain;
                                    }
                                    else if (continue1 == "y")
                                    {
                                        goto MoreStudentInfo;
                                    }
                                    break;


                                case "food":
                                    Console.WriteLine($"{names[student - 1]}'s favorite food is {food[student - 1]}.");
                                    Console.WriteLine("Would you like to learn more about this student? y/n?");
                                    string continue2 = Console.ReadLine();
                                    //continue based on user input
                                    if (continue2 == "n")
                                    {
                                        goto RunAgain;
                                    }
                                    else if (continue2 == "y")
                                    {
                                        goto MoreStudentInfo;
                                    }
                                    break;


                                case "car":
                                    Console.WriteLine($"{names[student - 1]} Drives a {car[student - 1]}.");
                                    Console.WriteLine("Would you like to learn more about this student? y/n?");
                                    string continue3 = Console.ReadLine();
                                    //continue based on user input
                                    if (continue3 == "n")
                                    {
                                        goto RunAgain;
                                    }
                                    else if (continue3 == "y")
                                    {
                                        goto MoreStudentInfo;
                                    }
                                    break;



                                //default statement so if anything else is besides  whats in the case is entered it prompts them again
                                default:
                                    Console.WriteLine("This data doesnt exist for this person.");
                                    break;
                            }
                            userChoice = true;
                            Console.WriteLine("Would you like to learn about another student, y/n?\n");
                            string learnMore = Console.ReadLine();
                            if (learnMore == "y")
                            {
                                goto RunAgain;
                            }
                            else if (learnMore == "n")
                            {
                                goto ThisIsTheEnd;
                            }
                        }
                    }
                }
                else if (wouldYou == "2")
                {
                    //add new user method here
                    names.Add(GetUserInput("What is the name of the student you wish to add?\n"));
                    hometown.Add(GetUserInput("Where are they from?\n"));
                    food.Add(GetUserInput("What is their favorite food?\n"));
                    car.Add(GetUserInput("What Type of car do they drive?\n"));
                    Console.WriteLine(" Lets Start again. \n");
                    goto RunAgain;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            ThisIsTheEnd:;
            }
            //user input method
            public static string GetUserInput(string message)
            {
                Console.WriteLine(message);
                return Console.ReadLine();
            }
            //number input validation
            public static int RangeCheck(int number, int lower, int upper)
            {
                if (number >= lower && number <= upper)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine($"Invalid Input. Input should be between {lower}-{upper}");
                    number = int.Parse(Console.ReadLine());
                    return RangeCheck(number, lower, upper);
                }
            }
        }








    }


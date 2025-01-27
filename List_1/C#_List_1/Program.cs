﻿using System;

namespace Data_Structures_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ListExercise listExercise = new ListExercise();
            string UserInput1;
            int Option = 0;
            bool IsRunning = true;

            // Loop for both menu display and validation
            while (IsRunning)
            { 
            Console.WriteLine("A menu of options: \n");
            Console.WriteLine("Press 1 to add to the end of the list.\n" +
                "Press 2 to insert an element at a given location.\n" +
                "Press 3 to delete an element from a given location.\n" +
                "Press 4 to display all of the list elements.\n" +
                "Press 5 to the count of the total number of elements.\n" +
                "Press 6 to clear (initialize) an list.\n" +
                "Press 7 to exit the program.\n");

                Console.WriteLine("Please enter a number between 1 and 7: ");
                UserInput1 = Console.ReadLine();

                // Try to parse the input to an integer
                if (int.TryParse(UserInput1, out Option) && Option >= 1 && Option <= 7)
                {
                    Console.WriteLine($"You entered: {Option}");

                    // Switch statement to handle menu options
                    switch (Option)
                    {
                        case 1:                            
                            listExercise.AddToEnd();
                            listExercise.DisplayList();
                            break;
                        case 2:
                            Console.WriteLine("Enter the index where you want to insert the element: ");
                            int InsertIndex = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the value you want to insert: ");
                            int InsertValue = Convert.ToInt32(Console.ReadLine());
                            listExercise.InsertElement(InsertIndex, InsertValue);
                            listExercise.DisplayList();
                            break;
                        case 3: 
                            Console.WriteLine("Enter the index of the element you want to delete: ");
                            int DeleteIndex = Convert.ToInt32(Console.ReadLine());
                            listExercise.DeleteElement(DeleteIndex);
                            listExercise.DisplayList();
                            break;
                        case 4:
                            listExercise.DisplayList();
                            break;
                        case 5:
                            listExercise.DisplayCount();
                            listExercise.DisplayList();
                            break;
                        case 6:
                            listExercise.ClearList();
                            listExercise.DisplayList();
                            break;
                        case 7:
                            IsRunning = false;
                            Console.WriteLine("Exiting the program.");
                            break;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                }
            }
        }
    }
}


﻿using System;
using System.Collections.Generic;
using System.IO;
using Capstone.Classes;
using Capstone.Classes.Items;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileInventory = Path.GetFullPath(@"vendingmachine.csv");
            Machine machine = new Machine(fileInventory);
            
            Console.WriteLine("Welcome to the CuteCo, inc. Vendo-Matic 800!");
            Console.WriteLine(" (1) Display Vending Machine Items \n (2) Purchase \n (3) Exit");
            Console.WriteLine("Please make your selection");

            int userInput = -1;
            while (userInput <= 0 || userInput > 3)
            {
                bool parseWorked = int.TryParse(Console.ReadLine(), out userInput);
                if (userInput <= 0 || userInput > 3|| !parseWorked)
                {
                    Console.WriteLine("Please try again!");
                }                
            }
            if(userInput == 1)
            {
                machine.Display();
            } else if (userInput == 2)
            {
                //do transaction stuff
            } else { Console.WriteLine("Thanks for using CuteCo, inc. Vendo-Matic 800! \nPlease come back soon!"); }
        }
    }
}
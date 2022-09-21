using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Schema;

class MainClass
{


    public static void Main()
    {
        // Welcoming the customer in

        Console.WriteLine("Welcome in! Here at Buffet Time, it is $9.99 per person.");
        Console.WriteLine("We only charge extra for coke and at the moment we can only seat parties of 6 or less.");
        Console.WriteLine("How many are in your group today?");

        // Recieving the amount of customers 

        int partynumber = int.Parse(Console.ReadLine());


        
        if (partynumber <= 6)
        {
            Console.WriteLine("A table for " + partynumber + ". Please follow me this way!");
        }
        else
        {
            Console.WriteLine(" We currently dont have the space for that, I apologize.");
            return;
        }
        
        // Drink orders

        int water = 0;
        int coke = 0;
        for (int i = 1; i < (partynumber+1); i++)
        {
            Console.WriteLine("Now for drinks. Again we have coke and water.");
            Console.WriteLine("What would you like customer #" + i);
            string drink = Console.ReadLine();


        
                if (drink == "water")
                {
                    ++water;
                    Console.WriteLine("Water, great choice!");
                }
                else if (drink == "Water")
                {
                    ++water;
                    Console.WriteLine("Water, great choice!");
                }
                else if (drink == "coke")
                {
                    Console.WriteLine("Coke is my favorite too!");
                    ++coke;
                }
                else if (drink == "Coke")
                {
                    Console.WriteLine("Coke is my favorite too!");
                    ++coke;
                }
                else
                {
                    Console.WriteLine("Im sorry, we dont have that.");
                    // Remove line 69 if we dont want to give them an option in ordering a drink if they make the wrong choice
                    i--;
                    continue;
                }     

        }
        // displaying the amount of drinks to customers
        if (water == 0)
        {
            Console.WriteLine("Alrighty, all together there are " + coke + " cokes.");
        }
        else if (coke == 0)
        {
            Console.WriteLine("Alrighty, all together there are " + water + " waters.");
        }
        else
        {
            Console.WriteLine(" Alrighty, all together there are " + water + " waters and there are " + coke + " cokes.");
        }
        Console.WriteLine("Feel free to go grab your food! The pizza here is delicious. Ill be right back with your drinks");

        // Calculating bill 

        decimal totalcokes = coke * 3.25m;
        decimal totalfood = partynumber * 9.99m;
        decimal total = totalcokes + totalfood;

        // displaying the bill
        Console.WriteLine("Also here is your bill. The total comes out to $" + total + ".");
        Console.WriteLine();
        Console.WriteLine("Bill");
        Console.WriteLine(partynumber + " buffets = " + partynumber + " x $9.99 = $" + totalfood);
        Console.WriteLine(coke + " cokes = " + coke + " x $3.25 = $" + totalcokes);
        Console.WriteLine(water + " waters = free");
        Console.WriteLine("$" + total +" = $" + totalfood + " + $"+ totalcokes);
    }
}

﻿//Random random = new Random();

//int dayUntilExpiration = random.Next(12);
//int discountPercentage = 0;

////dayUntilExpiration = 0;
////Console.WriteLine(dayUntilExpiration);

//if (dayUntilExpiration > 10)
//{

//}
//else if (dayUntilExpiration > 5)
//{
//    Console.WriteLine("Your subscription will expire soon. Renew now!");
//}
//else if (dayUntilExpiration > 1)
//{
//    Console.WriteLine("Your subscription expires in " + dayUntilExpiration + " days.");
//    discountPercentage = 10;
//}
//else if (dayUntilExpiration == 1)
//{
//    Console.WriteLine("Your subscription expieres within a day!");
//    discountPercentage = 20;
//}
//else if (dayUntilExpiration == 0)
//{
//    Console.WriteLine("Your subscription has expired.");
//}

//if (discountPercentage > 0)
//{
//    Console.WriteLine("Renew now and save " + discountPercentage + "%.");
//}

/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

//string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

//Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
//Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
//Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

//fraudulentOrderIDs[0] = "F000";

//Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
//Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


//string[] names = { "Rowena", "Robin", "Bao" };
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}

//int[] inventory = { 200, 450, 700, 175, 250 };
//int sum = 0;
//int bin = 0;

//foreach (int items in inventory)
//{
//    sum += items;
//    bin++;
//    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
//}

//Console.WriteLine($"We have {sum} items in inventory.");


//string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

//foreach (string orderID in orderIDs)
//{
//    if (orderID.StartsWith("B"))
//    {
//        Console.WriteLine(orderID);
//    }
//}

///*
//  The following code creates five random OrderIDs
//  to test the fraud detection process.  OrderIDs 
//  consist of a letter from A to E, and a three
//  digit number. Ex. A123.
//*/
//Random random = new Random();
//string[] orderIDs = new string[5];

//for (int i = 0; i < orderIDs.Length; i++)
//{
//    int prefixValue = random.Next(65, 70);
//    string prefix = Convert.ToChar(prefixValue).ToString();
//    string suffix = random.Next(1, 1000).ToString("000");

//    orderIDs[i] = prefix + suffix;
//}

//foreach (var orderID in orderIDs)
//{
//    Console.WriteLine(orderID);
//}


//Random dice = new Random();

//int roll1 = dice.Next(1, 7);
//int roll2 = dice.Next(1, 7);
//int roll3 = dice.Next(1, 7);

//int total = roll1 + roll2 + roll3;
//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
//{
//    if ((roll1 == roll2) && (roll2 == roll3))
//    {
//        Console.WriteLine("You rolled triples!  +6 bonus to total!");
//        total += 6;
//    }
//    else
//    {
//        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//        total += 2;
//    }
//}


///*
//   This code reverses a message, counts the number of times 
//   a particular character appears, then prints the results
//   to the console window.
//*/

//string originalMessage = "The quick brown fox jumps over the lazy dog.";

//char[] message = originalMessage.ToCharArray();
//Array.Reverse(message);

//int letterCount = 0;

//foreach (char letter in message)
//{
//    if (letter == 'o')
//    {
//        letterCount++;
//    }
//}

//string newMessage = new String(message);

//Console.WriteLine(newMessage);
//Console.WriteLine($"'o' appears {letterCount} times.");


using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

foreach (string name in studentNames)
{
    if (name == "Sophia")
    { 
        int sophiaSum = 0;

        decimal sophiaScore;

        foreach (int score in sophiaScores)
        {
            sophiaSum += score;
        }

        sophiaScore = (decimal)sophiaSum / currentAssignments;

        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
    }
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

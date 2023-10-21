//decimal myDecimal = 3.14m;
//Console.WriteLine($"decimal: {myDecimal}");

//int myInt = (int)myDecimal;
//Console.WriteLine($"int: {myInt}");

//decimal myDecimal = 1.23456789m;
//float myFloat = (float)myDecimal;

//Console.WriteLine($"Decimal: {myDecimal}");
//Console.WriteLine($"Float  : {myFloat}");

//string first = "5";
//string second = "7";
//int sum = int.Parse(first) + int.Parse(second);
//Console.WriteLine(sum);

//string value1 = "5";
//string value2 = "7";
//int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
//Console.WriteLine(result);

//int value = (int)1.5m; // casting truncates
//Console.WriteLine(value);

//int value2 = Convert.ToInt32(1.5m); // converting rounds up
//Console.WriteLine(value2);

//string value = "bad";
//int result = 0;
//if (int.TryParse(value, out result))
//{
//    Console.WriteLine($"Measurement: {result}");
//}
//else
//{
//    Console.WriteLine("Unable to report the measurement.");
//}

//if (result > 0)
//Console.WriteLine($"Measurement (w/ offset): {50 + result}");

//----------------------------------------------------------------------------------

//using System.Globalization;
//CultureInfo.CurrentCulture = new CultureInfo("en-US");

//string[] values = { "12.3", "45", "ABC", "11", "DEF" };

//decimal total = 0m;
//string message = "";

//foreach (var value in values)
//{
//    decimal number; // stores the TryParse "out" value
//    if (decimal.TryParse(value, out number))
//    {
//        total += number;
//    }
//    else
//    {
//        message += value;
//    }
//}

//Console.WriteLine($"Message: {message}");
//Console.WriteLine($"Total: {total}");

//-------------------------------------------------------------------------------------

//int value1 = 12;
//decimal value2 = 6.2m;
//float value3 = 4.3f;

//int result1 = Convert.ToInt32(value1) / Convert.ToInt32(value2);
//decimal result2 = Convert.ToDecimal(value2) / Convert.ToDecimal(value3);
//float result3 = value3 / value1;

//// Your code here to set result1
//// Hint: You need to round the result to nearest integer (don't just truncate)
//Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

//// Your code here to set result2
//Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

//// Your code here to set result3
//Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

//-------------------------------------------------------------------------------------

//string[] pallets = { "B14", "A11", "B12", "A13" };
//Console.WriteLine("");

//Array.Clear(pallets, 0, 2);
//Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}

//Console.WriteLine("");
//Array.Resize(ref pallets, 6);
//Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

//pallets[4] = "C01";
//pallets[5] = "C02";

//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}

//Console.WriteLine("");
//Array.Resize(ref pallets, 3);
//Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}

//-------------------------------------------------------------------------------------

//string value = "abc123";
//char[] valueArray = value.ToCharArray();
//Array.Reverse(valueArray);
////string result = new string(valueArray);
//string result = string.Join(",", valueArray);
//Console.WriteLine(result);

//string[] items = result.Split(',');
//foreach (string item in items)
//{
//    Console.WriteLine(item);
//}

//-------------------------------------------------------------------------------------

//string pangram = "The quick brown fox jumps over the lazy dog";

//char[] pangramArray = pangram.ToCharArray();
//Array.Reverse(pangramArray);
//string outcome = string.Join("", pangramArray);
//Console.WriteLine(outcome);

//string pangram = "The quick brown fox jumps over the lazy dog";

//// Step 1
//string[] message = pangram.Split(' ');

//// Step 2
//string[] newMessage = new string[message.Length];

//// Step 3
//for (int i = 0; i < message.Length; i++)
//{
//    char[] letters = message[i].ToCharArray();
//    Array.Reverse(letters);
//    newMessage[i] = new string(letters);
//}

//// Step 4
//string result = string.Join(" ", newMessage);
//Console.WriteLine(result);

//-------------------------------------------------------------------------------------

//string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
//string[] items = orderStream.Split(',');
//Array.Sort(items);

//foreach (var item in items)
//{
//    if (item.Length == 4)
//    {
//        Console.WriteLine(item);
//    }
//    else
//    {
//        Console.WriteLine(item + "\t- Error");
//    }
//}

//-------------------------------------------------------------------------------------

//string first = "Hello";
//string second = "World";
//Console.WriteLine($"{first} {second}!");
//Console.WriteLine($"{second} {first}!");
//Console.WriteLine($"{first} {first} {first}!");

//decimal price = 67.55m;
//decimal salePrice = 59.99m;

//string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

//yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; // inserted
//Console.WriteLine(yourDiscount);

//-------------------------------------------------------------------------------------

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"Shares: {productShares:N3} Product");
Console.WriteLine($"    Sub Total: {subtotal:C}");
Console.WriteLine($"        Tax: {taxPercentage:P2}");
Console.WriteLine($"    Total Billed: {total:C}");

//-------------------------------------------------------------------------------------





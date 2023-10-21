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

//int invoiceNumber = 1201;
//decimal productShares = 25.4568m;
//decimal subtotal = 2750.00m;
//decimal taxPercentage = .15825m;
//decimal total = 3185.19m;

//Console.WriteLine($"Invoice Number: {invoiceNumber}");
//Console.WriteLine($"Shares: {productShares:N3} Product");
//Console.WriteLine($"    Sub Total: {subtotal:C}");
//Console.WriteLine($"        Tax: {taxPercentage:P2}");
//Console.WriteLine($"    Total Billed: {total:C}");

//-------------------------------------------------------------------------------------

//string input = "Pad this";
//Console.WriteLine(input.PadLeft(12, '-'));
//Console.WriteLine(input.PadRight(12, '-'));

//string paymentId = "769C";
//string payeeName = "Mr. Stephan ortega";
//string paymentAmount = "$5,000.00";

//var formettedLine = paymentId.PadRight(6);
//formettedLine += payeeName.PadRight(24);
//formettedLine += paymentAmount.PadLeft(10);

//Console.WriteLine("1234567890123456789012345678901234567890");
//Console.WriteLine(formettedLine);

//-------------------------------------------------------------------------------------

//string customerName = "Ms. Barros";

//string currentProduct = "Magic Yield";
//int currentShares = 2975000;
//decimal currentReturn = 0.1275m;
//decimal currentProfit = 55000000.0m;

//string newProduct = "Glorious Future";
//decimal newReturn = 0.13125m;
//decimal newProfit = 63000000.0m;

//// Your logic here

//Console.WriteLine($"Dear {customerName}, \n\rAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
//Console.WriteLine($"Currently, you own {currentShares:C} shares at a return of {currentReturn:P2}.\n");
//Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

//Console.WriteLine("Here's a quick comparison:\n");

//string comparisonMessage = "";

//comparisonMessage = currentProduct.PadRight(20);
//comparisonMessage += string.Format("{0:P}", currentReturn).PadRight(10);
//comparisonMessage += string.Format("{0:C}", currentProfit).PadRight(20);

//comparisonMessage += "\n";
//comparisonMessage += newProduct.PadRight(20);
//comparisonMessage += string.Format("{0:P}", newReturn).PadRight(10);
//comparisonMessage += string.Format("{0:C}", newProfit).PadRight(20);

//// Your logic here

//Console.WriteLine(comparisonMessage);

//-------------------------------------------------------------------------------------

//string message = "What is the value <span>between the tags</span>?";

//int openingPosition = message.IndexOf("<span>");
//int closingPosition = message.IndexOf("</span>");

//openingPosition += 6;
//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));

//-------------------------------------------------------------------------------------

//string message = "(What if) I am (only interested) in the last (set of parentheses)?";
//int openingPosition = message.LastIndexOf('(');

//openingPosition += 1;
//int closingPosition = message.LastIndexOf(')');
//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));

//string message = "(What if) there are (more than) one (set of parentheses)?";
//while (true)
//{
//    int openingPosition = message.IndexOf('(');
//    if (openingPosition == -1) break;

//    openingPosition += 1;
//    int closingPosition = message.IndexOf(')');
//    int length = closingPosition - openingPosition;
//    Console.WriteLine(message.Substring(openingPosition, length));

//    // Note the overload of the Substring to return only the remaining 
//    // unprocessed message:
//    message = message.Substring(closingPosition + 1);
//}

//string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

//// The IndexOfAny() helper method requires a char array of characters. 
//// You want to look for:

//char[] openSymbols = { '[', '{', '(' };

//// You'll use a slightly different technique for iterating through 
//// the characters in the string. This time, use the closing 
//// position of the previous iteration as the starting index for the 
////next open symbol. So, you need to initialize the closingPosition 
//// variable to zero:

//int closingPosition = 0;

//while (true)
//{
//    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//    if (openingPosition == -1) break;

//    string currentSymbol = message.Substring(openingPosition, 1);

//    // Now  find the matching closing symbol
//    char matchingSymbol = ' ';

//    switch (currentSymbol)
//    {
//        case "[":
//            matchingSymbol = ']';
//            break;
//        case "{":
//            matchingSymbol = '}';
//            break;
//        case "(":
//            matchingSymbol = ')';
//            break;
//    }

//    // To find the closingPosition, use an overload of the IndexOf method to specify 
//    // that the search for the matchingSymbol should start at the openingPosition in the string. 

//    openingPosition += 1;
//    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//    // Finally, use the techniques you've already learned to display the sub-string:

//    int length = closingPosition - openingPosition;
//    Console.WriteLine(message.Substring(openingPosition, length));
//}

//-------------------------------------------------------------------------------------

//string data = "12345John Smith          5000  3  ";
//string updatedData = data.Remove(5, 20);
//Console.WriteLine(updatedData);

//string message = "This--is--ex-amp-le--da-ta";
//message = message.Replace("--", " ");
//message = message.Replace("-", "");
//Console.WriteLine(message);

//-------------------------------------------------------------------------------------

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

int quantityStart = input.IndexOf("<span>");
int quantityEnd = input.IndexOf("</span>");
quantityStart += "<span>".Length;
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

output = input.Replace("&trade;", "&reg;");

int divStart = input.IndexOf("<div>");
int divLength = "<div>".Length;
output = output.Remove(divStart, divLength);

int divCloseStart = output.IndexOf("</div>");
int divCloseLength = "</div>".Length;
output = output.Remove(divCloseStart, divCloseLength);
output = $"Output: {output}";

Console.WriteLine(quantity);
Console.WriteLine(output);




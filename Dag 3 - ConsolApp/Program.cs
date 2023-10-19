//////int employeeLevel = 100;
//////string employeeName = "John Smith";

//////string titel = "";

//////switch (employeeLevel)
//////{
//////    case 100:
//////    case 200:
//////        titel = "Senior Associate";
//////        break;
//////    case 300:
//////        titel = "Manager";
//////        break;
//////    case 400:
//////        titel = "Senior Manager";
//////        break;
//////    default:
//////        titel = "Associate";
//////        break;
//////}

//////Console.WriteLine($"{employeeName}, {titel}");


////// SKU = Stock Keeping Unit. 
////// SKU value format: <product #>-<2-letter color code>-<size code>



////string sku = "01-MN-L";

////string[] product = sku.Split('-');

////string type = "";
////string color = "";
////string size = "";


////switch (product[0])
////{
////    case "01":
////        type = "Sweat shirt";
////        break;
////    case "02":
////        type = "T-Shirt";
////        break;
////    case "03":
////        type = "Sweat pants";
////        break;
////    default:
////        type = "Other";
////        break;
////}

////switch (product[1])
////{
////    case "BL":
////        color = "Black";
////        break;
////    case "MN":
////        color = "Maroon";
////        break;
////    default:
////        type = "White";
////        break;
////}


////switch (product[2])
////{
////    case "S":
////        size = "Small";
////        break;
////    case "M":
////        size = "Medium";
////        break;
////    case "L":
////        size = "Large";
////        break;
////    default:
////        size = "One Size Fits All";
////        break;
////}

////Console.WriteLine($"Product: {size} {color} {type}");



////string[] names = { "Alex", "Eddie", "David", "Michael" };

////for (int i = 0; i < names.Length; i++)
////{
////    if (names[i] == "David") names[i] = "sammy";
////}


////foreach (var name in names)
////{
////    Console.WriteLine(name);
////}



////for (int i = 1; i < 101; i++)
////{
////    if ((i % 3 == 0) && (i % 5 == 0))
////        Console.WriteLine($"{i} - FizzBuzz");
////    else if (i % 3 == 0)
////        Console.WriteLine($"{i} - Fizz");
////    else if (i % 5 == 0)
////        Console.WriteLine($"{i} - Buzz");
////    else
////        Console.WriteLine($"{i}");
////}


//Random random = new Random();
//int current = random.Next(1, 11);


//do
//{
//    current = random.Next(1, 11);

//    if (current >= 8) continue;

//    Console.WriteLine(current);
//} while (current != 7);

///*
//while (current >= 3)
//{
//    Console.WriteLine(current);
//    current = random.Next(1, 11);
//}
//Console.WriteLine($"Last number: {current}");
//*/


Random roll = new Random();

int hero = 10;
int monster = 10;

do
{
    int attack = roll.Next(1, 11);
    monster -= attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monster} health.");
    Console.WriteLine("\n\rPress the Enter key to continue");
    Console.ReadLine();

    if (hero <= 0) continue;

    attack = roll.Next(1, 11);
    hero -= attack;
    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {hero} health.");
    Console.WriteLine("\n\rPress the Enter key to continue");
    Console.ReadLine();


}
while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
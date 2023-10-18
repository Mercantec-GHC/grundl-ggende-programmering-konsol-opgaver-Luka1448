//int employeeLevel = 100;
//string employeeName = "John Smith";

//string titel = "";

//switch (employeeLevel)
//{
//    case 100:
//    case 200:
//        titel = "Senior Associate";
//        break;
//    case 300:
//        titel = "Manager";
//        break;
//    case 400:
//        titel = "Senior Manager";
//        break;
//    default:
//        titel = "Associate";
//        break;
//}

//Console.WriteLine($"{employeeName}, {titel}");


// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>



string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";


switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "Sweat shirt";
        break;
    case "03":
        type = "Sweat shirt";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        type = "White";
        break;
}


switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");
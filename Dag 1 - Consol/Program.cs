// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello, World!");

//Console.Write("Congratulations!");
//Console.Write(" ");
//Console.Write("You wrote your first lines of code.");

//Console.WriteLine("This is the first line.");
//Console.WriteLine("This is the second line.");

//Console.WriteLine('b');
//Console.WriteLine(123);
//F forteller compileren at det er en float
//Console.WriteLine(0.25F);
//Console.WriteLine(2.625);
//m forteller compileren at det er en decimal
//Console.WriteLine(12.39816m);

//Console.WriteLine(true);
//Console.WriteLine(false);

//Console.WriteLine("123");
//Console.WriteLine(123);

//Console.WriteLine("true");
//Console.WriteLine(true);



//string firstname = "Bob";
//int messages = 3;
//decimal temperature = 34.4m;

//Console.Write(
//    "Hello, " + firstname + "! You have " + messages + " messages in your inbox. The temperature is " + temperature + " celsius."
//);


//Console.WriteLine("Hello\nWorld!");
//Console.WriteLine("Hello\tWorld!");

//Console.WriteLine("Hello \"World\"!");

//Console.WriteLine("c:\\source\\repos");

//Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
//Console.WriteLine("Invoice: 1021\t\tComplete!");
//Console.WriteLine("Invoice: 1022\t\tComplete!");
//Console.WriteLine("\nOutput Directory:\t");
//Console.Write(@"c:\invoices");

//Console.WriteLine(@"    c:\source\repos    
//        (this is where your code goes)");


//Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
//Console.WriteLine("Invoice: 1021\t\tComplete!");
//Console.WriteLine("Invoice: 1022\t\tComplete!");
//Console.WriteLine("\nOutput Directory:\t");
//Console.Write(@"c:\invoices");

//// To generate Japanese invoices:
//// Nihon no seikyū-sho o seisei suru ni wa:
//Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
//// User command to run an application
//Console.WriteLine(@"c:\invoices\app.exe -j");



//string firstName = "Bob";
//string message = $"Hello {firstName}!";
//Console.WriteLine(message);

//int version = 11;
//string updateText = "Update to Windows";
//string message = $"{updateText} {version}";
//Console.WriteLine(message);

//int version = 11;
//string updateText = "Update to Windows";
//Console.WriteLine($"{updateText} {version}!");

//string projectName = "First-Project";
//Console.WriteLine($@"C:\Output\{projectName}\Data");

//View English output:
//  c:\Exercise\ACME\data.txt

//Посмотреть русский вывод:
//  c:\Exercise\ACME\ru-RU\data.txt


//string projectName = "ACME";
//string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434:";
//Console.WriteLine("View English output:");
//Console.WriteLine($@"  c:\Exercise\{projectName}\data.txt");
//Console.WriteLine(" ");
//Console.WriteLine(russianMessage);
//Console.WriteLine($@"  c:\Exercise\{projectName}\ru-RU\data.txt");

//Console.WriteLine(" ");

//string projectName2 = "ACME";
//string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
//Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

//string russianMessage2 = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
//string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
//Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
﻿Random random = new Random();

int dayUntilExpiration = random.Next(12);
int discountPercentage = 0;

//dayUntilExpiration = 0;
//Console.WriteLine(dayUntilExpiration);

if (dayUntilExpiration > 10)
{

}
else if (dayUntilExpiration > 5)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (dayUntilExpiration > 1)
{
    Console.WriteLine("Your subscription expires in " + dayUntilExpiration + " days.");
    discountPercentage = 10;
}
else if (dayUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expieres within a day!");
    discountPercentage = 20;
}
else if (dayUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}

if (discountPercentage > 0)
{
    Console.WriteLine("Renew now and save " + discountPercentage + "%.");
}

Random random = new Random();

int dayUntilExpiration = random.Next(12);
int discountPercentage = 0;

dayUntilExpiration = 11;

Console.WriteLine(dayUntilExpiration);

if (dayUntilExpiration > 10)
{
    Console.WriteLine("NEJ");
}
if (dayUntilExpiration >= 6)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (dayUntilExpiration > 1)
{
    Console.WriteLine("Your subscription expires in " + dayUntilExpiration + " days.\r\nRenew now and save 10%!");
}
else if (dayUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expieres within a day!\nRenew now and save 20%");
}
else if (dayUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
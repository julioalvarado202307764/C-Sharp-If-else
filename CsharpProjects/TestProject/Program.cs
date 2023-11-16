Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;


// Your code goes here
if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine( $"Your subscription expires in {daysUntilExpiration} days");
    discountPercentage = 10;
}
else if(daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if(discountPercentage > 0){
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
/*if (daysUntilExpiration == 0) //Esta otra forma asigno el porcentaje dentro del if de días de expiración
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
    if (discountPercentage > 0)
    {
        Console.WriteLine($"Renew now and save {discountPercentage}%!");
    }
}
else if (daysUntilExpiration <= 5)
{

    Console.WriteLine($"Your subscription expired in {daysUntilExpiration} days.");
    discountPercentage = 10;
    if (discountPercentage > 0)
    {
        Console.WriteLine($"Renew now and save {discountPercentage}%!");
    }
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
*/

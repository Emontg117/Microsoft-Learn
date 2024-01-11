/*
Author: Elisha Montgomery
Title: Improve Renewal Rate of Subscriptions Challenge

Instructions:
- Display a renewal message when a user logs into the system and is notified their subscription will soon end.
- The given code can not be removed and all provided variables must be used.
- The solution must use separate if and if-else statements to implement the business rules. The if-else statement can include multiple else if parts.

Rules:
1. The code should only display one message
2. If the user's subscription will expire in 10 days or less, display the message: "Your subscription will expire soon. Renew now!"
3. If the user's subscription will expire in 5 days or less, display the messages: "Your subscription expires in _ days. Renew now and save 10%!"
4. If the user's subscription will expire in 1 day, display the messages: "Your subscription expires within a day! Renew now and save 20%!"
5. If the user's subscription has expired, display the message: "Your subscription has expired."
6. If the user's subscription doesn't expire in 10 days or less, display nothing.

Given Code:

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

*/

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if(daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day!");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if(discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
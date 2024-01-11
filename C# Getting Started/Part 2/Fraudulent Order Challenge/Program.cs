/*
Author: Elisha Montgomery
Title: Fraudulent Order Challenge

Prompt: Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. 
You write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". 
This will be used by the fraud team to investigate further.

Instructions:
- Declare an array and initialize it with the following elements:
B123
C234
A345
C15
B177
G3003
C235
B179

- Create a foreach statement to iterate through each element of the array.
- Report the Order IDs that start with the letter "B".

*/

string[] orders = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string order in orders)
{
    if (order.StartsWith("B"))
    {
        Console.WriteLine($"Possible Fraudulent Order: {order}");
    }
}
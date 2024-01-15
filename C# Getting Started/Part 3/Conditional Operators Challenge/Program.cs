/*
Author: Elisha Montgomery
Title: Conditional Operators Challenge

Prompt: Write code to display the result of a coin flip using conditional operators

Instructions:
- Use the Random class to generate a value
- Based on the value generated, use the conditional operator to display either heads or tails
- Challenge should be completed using three lines of code
*/
Random rnd = new Random();
string flip = rnd.Next(2) == 1 ? "Heads" : "Tails" ;
Console.WriteLine(flip);
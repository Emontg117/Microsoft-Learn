/*
Author: Elisha Montgomery
Title: Microsoft Learn - Math Class Methods Challenge

Instructions: 
- Find a method of the System.Math class that returns the larger of two numbers.
- Research the method and successfully implement it into the prewritten code given.
- The final solution for this challenge must use the given code, and must use the Console.WriteLine(largerValue); statement to generate the output.
- The application should output: 600.

Given Code:

int firstValue = 500;
int secondValue = 600;
int largerValue;

Console.WriteLine(largerValue);

*/

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue); // Max() is a method of the System.Math class that returns the larger of two given numbers.

Console.WriteLine(largerValue);
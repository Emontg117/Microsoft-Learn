/*
Author: Elisha Montgomery
Title: Decision Logic Challenge

Prompt: In this challenge, you'll implement decision logic based on a series of business rules. 
The business rules specify the access that will be granted to users based on their role-based permissions and their career level. 
Code branches will display a different message to the user depending on their permissions and level.

Instructions:
- Using the given business rules and code, evaluate permission and level to output the correct message.

Business Rules:
If Admin with level higher than 55, output: Welcome, Super Admin user.
If Admin with level less than or equal to 55, output: Welcome, Admin user.
If Manager with level 20 or higher, output: Contact an Admin for access.
If Manager with level less than 20, output: You do not have sufficient privileges.
If User not an Admin or Manager, output: You do not have sufficient privileges.

Given Code:
string permission = "Admin|Manager";
int level = 55;

*/
string permission = "Admin|Manager";
int level = 55;

/*
If the user is an admin, check for level, output corresponding message.
If not an admin, check if manager, then check level, then output corresponding message.
If neither admin nor manager, output corresponding message.
*/

if (permission.Contains("Admin"))
{
    if (level > 55)
        Console.WriteLine("Welcome, Super Admin user.");
    else
        Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
        Console.WriteLine("Contact an Admin for access.");
    else
        Console.WriteLine("You do not have sufficient privileges");
}
else
{
    Console.WriteLine("You do not have sufficient privileges");
}
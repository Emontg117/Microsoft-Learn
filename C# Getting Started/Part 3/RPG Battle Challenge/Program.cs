/*

Author: Elisha Montgomery
Title: RPG Battle Challenge

Prompt: A hero and a monster start with the same health score. 
During the hero's turn, they'll generate a random value which will be subtracted from the monster's health. 
If the monster's health is greater than zero, they'll take their turn and attack the hero. 
As long as both the hero and the monster have health greater than zero, the battle will resume.

Rules:
- You must use either the do-while statement or the while statement as an outer game loop.
- The hero and the monster will start with 10 health points.
- All attacks will be a value between 1 and 10.
- The hero will attack first.
- Print the amount of health the monster lost and their remaining health.
- If the monster's health is greater than 0, it can attack the hero.
- Print the amount of health the hero lost and their remaining health.
- Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
- Print the winner.

*/
Random random = new Random();
bool inBattle = true;

int heroHealth = 10;
int monsterHealth = 10;
int damage = 0;

do
{
    if (heroHealth > 0) 
    {
        Console.WriteLine("Hero Attacks...");
        damage = random.Next(1, 10);
        monsterHealth -= damage;
        Console.WriteLine($"Monster takes {damage} damage. They have {monsterHealth} health remaining!");
    }
    else 
    {
        Console.WriteLine("The battle is over. The Monster wins!");
        inBattle = false;
        continue;
    }
    if (monsterHealth > 0)
    {
        Console.WriteLine("Monster Attacks...");
        damage = random.Next(1, 10);
        heroHealth -= damage;
        Console.WriteLine($"Hero takes {damage} damage. They have {heroHealth} health remaining!");
    } 
    else 
    {
        Console.WriteLine("The battle is over. The Hero wins!");
        inBattle = false;
        continue;
    }
}while(inBattle);
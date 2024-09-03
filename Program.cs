Skill attack = new() 
{
Name = "Attack enemy",
ManaCost = 10
};

Skill heal = new() 
{
    Name = "heal self",
    ManaCost = 20
};

Skill active = attack;

System.Console.WriteLine(active.Name);
Console.ReadLine();
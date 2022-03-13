using System;

public class StartUp
{
    static void Main(string[] args)
    {
        Dummy dummy = new Dummy(100, 10);

        Axe axe = new Axe(10, 10);
       
        Console.WriteLine(axe.AttackPoints);
        Console.WriteLine(axe.DurabilityPoints);
        Console.WriteLine(dummy.Health);
        axe.Attack(dummy);
        Console.WriteLine(axe.AttackPoints);
        Console.WriteLine(axe.DurabilityPoints);
        Console.WriteLine(dummy.Health);
    }
}

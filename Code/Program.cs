using System;

class Program
{
    public static double GetMagicNumber()
    {
         var random = new Random();
         return random.NextDouble();
    }
    public static int GetRandomInt()
    {
        var random = new Random();
        return random.Next(1,10);
    }

    public static int GetRandom()
    {
<<<<<<< HEAD
        var random = new Random();
        return random.Next(1,10);
=======
        Console.WriteLine("Hello, World!");
>>>>>>> parent of 7042f98... Program.cs
    }

    static void Main(string[] args)
    {
        Code.boxingUnboxing.Start();

    }   
}
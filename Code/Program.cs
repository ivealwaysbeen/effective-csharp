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
        var random = new Random();
        return random.Next(1,10);
    }

    static void Main(string[] args)
    {
        Code.boxingUnboxing.Start();

    }   
}
using System;

namespace helloapp;

public class program
{
    public static void Main()
    {
        Console.WriteLine("hello everyone");
        GreetWhite();
        GreetBlack();
    }

    private static void GreetWhite()
    {
        Console.WriteLine("hello white");
    }

    private static void GreetBlack()
    {
        Console.WriteLine("hello black");
    }
}


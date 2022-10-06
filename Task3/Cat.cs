using System;

namespace Task3;

public class Cat : ISpeaking
{
    public void Speak()
    {
        Console.WriteLine("Meow!");
    }
}
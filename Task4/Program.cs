using System;
using Task4;

var rnd1 = new RandomNumberGenerator();
var rnd2 = new RandomNumberGenerator(1337);
Console.WriteLine($"First generator:\nRnd: {rnd1.Next()}\nRnd (0-100): {rnd1.Next(100)}\nRnd (50-100): {rnd1.Next(50, 100)}");
Console.WriteLine();
Console.WriteLine($"Second generator:\nRnd: {rnd2.Next()}\nRnd (0-100): {rnd2.Next(100)}\nRnd (50-100): {rnd2.Next(50, 100)}");
using System;
using Task4;

var rnd = new RandomNumberGenerator();

Console.WriteLine(rnd.Next());
Console.WriteLine(rnd.Next(100));
Console.WriteLine(rnd.Next(50, 100));
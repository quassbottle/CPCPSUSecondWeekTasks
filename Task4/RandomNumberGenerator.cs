using System;

namespace Task4;

public class RandomNumberGenerator
{
    public int Seed { get; }
    private int _state;

    public RandomNumberGenerator()
    {
        Seed = Environment.TickCount;
        _state = Seed;
    }

    public RandomNumberGenerator(int seed)
    {
        Seed = seed;
        _state = Seed;
    }

    public int Next()
    {
        _state ^= _state << 7;
        _state ^= _state >> 13;
        _state ^= _state << 3;
        return _state;
    }

    public int Next(int topBound)
    {
        return Next() % topBound;
    }

    public int Next(int lowBound, int topBound)
    {
        return Next(topBound) + lowBound + 1;
    }
}
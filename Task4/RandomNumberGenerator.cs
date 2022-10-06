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
        _state ^= _state << 13;
        _state ^= _state >> 17;
        _state ^= _state << 5;
        _state = Math.Abs(_state);
        return _state;
    }

    public int Next(int topBound)
    {
        return Next(0, topBound);
    }

    public int Next(int lowBound, int topBound)
    {
        int next = Next();
        int result = (next % (topBound - lowBound)) + lowBound;
        return result;
    }
}
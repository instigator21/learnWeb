﻿using System;
using System.Diagnostics;

struct Plant
{
    private int height;

    internal void Grow(int value)
    {
        Debug.Assert(0 < value);
        height += value;
    }

    internal int GetHeight()
    {
        return height;
    }
}

static class EntryPoint
{
    private static void Accelerate(Plant target)
    {
        target.Grow(1);
    }

    static void Main()
    {
        Plant plant = new Plant();
        Accelerate(plant);
        Console.Write(plant.GetHeight());
        Console.WriteLine("The end");
    }
}
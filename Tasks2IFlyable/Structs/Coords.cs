﻿namespace Tasks2IFlyable.Structs
{
    public struct Coords
    {
        public Coords(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; }
        public double Y { get; }
        public double Z { get; }
    }
}

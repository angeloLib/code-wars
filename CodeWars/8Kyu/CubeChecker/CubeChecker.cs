using System;
namespace CodeWars._8Kyu.CubeChecker
{
    public class CubeCheck
    {
        public bool IsCube(double volume, double side)
        {
            return (Math.Pow(side, 3) == volume && side > 0);
        }
    }
}

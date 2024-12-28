using System;

namespace CodeWars._7Kyu.BuildingSpheres
{
    public class Sphere
    {
        public int Radius { get; private set; }
        public int Mass { get; private set; }

        private const double FourThirds = 4.0 / 3.0;

        public Sphere(int radius, int mass)
        {
            Radius = radius;
            Mass = mass;
        }

        public int GetRadius() { return Radius; }
        public int GetMass() { return Mass; }

        public double GetVolume()
        {
            double volume = FourThirds * Math.PI * Math.Pow(Radius, 3);
            return Math.Round(volume, 5); // Round to 5 decimal places
        }

        public double GetSurfaceArea()
        {
            double area = 4 * Math.PI * Math.Pow(Radius, 2);
            return Math.Round(area, 5); // Round to 5 decimal places
        }

        public double GetDensity()
        {
            double volume = GetVolume(); // Already rounded
            double density = Mass / volume;
            return Math.Round(density, 5); // Round to 5 decimal places
        }
    }
}

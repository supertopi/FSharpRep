using System;

namespace CSharpPhysics
{
    public static class MyPhysics
    {
        private const double _g = 9.81;

        public static double GetStandardGravityForce(double mass )
        {
            return mass * _g;
        }

        public static double GetStandardGravityForce(string mass)
        {
            return GetStandardGravityForce(double.Parse(mass));
        }
    }
}

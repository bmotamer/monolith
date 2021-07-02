using System;

namespace Monolith
{
    
    public static class MathHelper
    {

        public const double Deg2Rad = Math.PI / 180.0;
        public const double Rad2Deg = 180.0 / Math.PI;
        
        public static double VerticalToHorizontalFieldOfView(double verticalFieldOfView, double aspectRatio)
        {
            return 2.0 * Math.Atan(Math.Tan(0.5 * verticalFieldOfView) * aspectRatio);
        }

        public static ulong Pack(uint left, uint right) => ((ulong)left << 32) | right;

        public static void Unpack(ulong value, out uint left, out uint right)
        {
            left = (uint)(value >> 32);
            right = (uint)(value & uint.MaxValue);
        }
        
    }
    
}

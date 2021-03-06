﻿using System;

namespace Alturos.ImageAnnotation.Helper
{
    public static class MathExtension
    {
        public static double Clamp(this double val, double min, double max)
        {
            if (val < min) { return min; }
            if (val > max) { return max; }
            return val;
        }

        public static float Clamp(this float val, float min, float max)
        {
            return (float)((double)val).Clamp(min, max);
        }
    }
}

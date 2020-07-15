using System;

namespace Exercise_2
{
    public static class InchConverter
    {
        private const double ratio = 0.0254;

        public static double FromMeter(double meter)
        {
            return meter / ratio;
        }

        public static double FromInch(double inch)
        {
            return inch * ratio;
        }
    }
}

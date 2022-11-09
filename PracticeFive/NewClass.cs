using System;

namespace C_Sharp
{
    public class MyMath
    {
        public double[] MakeRandomDoubleArray(int length, int min, int max)
        {
            double[] array = new double[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = Math.Round(new Random().NextDouble() * (max - min) + min, 2);
            }
            return array;
        }
    }
}

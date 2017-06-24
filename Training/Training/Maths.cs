using System;

namespace Training
{
    public sealed class Maths
    {
        private Maths()
        {

        }
        private static readonly Lazy<Maths> lazy = new Lazy<Maths>(() => new Maths());
        public static Maths Instance
        {
            get
            {
                return lazy.Value;
            }
        }


        public int Maximum(int[] values)
        {
            int max = values[0];
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }
            return max;
        }
    } 
}

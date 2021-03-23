using System;
namespace itSTEP_8th
{
    public class tempArray
    {
        int[] temps;
        public int Length => temps.Length;

        public int this[int index]
        {
            get => temps[index];
            set => temps[index] = value*value;
        }
        public tempArray(int size)
        {
            temps = new int[size];
        }
    }
}

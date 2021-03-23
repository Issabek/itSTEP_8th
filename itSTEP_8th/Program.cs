using System;
using itSTEP_8th;

namespace itSTEP_8th
{
    class Program
    {
        

        static void Main(string[] args)
        {
            tempArray arr = new tempArray(2);
            arr[0] = 5;
            arr[1] = 2;
            Console.WriteLine(arr[0]+" "+arr[1]);
            
        }
    }
}

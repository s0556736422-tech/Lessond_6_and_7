using System.Text.RegularExpressions;

namespace Lessond_6_and_7
{
    internal class Program
    {
        public static void Print1<T>(T o)
        {
            Console.WriteLine(o );
        }
        static void Main(string[] args)
        {
            int[]arr= { 1,2,3,4,5,6,7,8,9,0} ;
            string[] arr1 = { "hello","world","you're","o.k?" };


            SwapArr<int> sp =new SwapArr<int>(arr);
            SwapArr<string> sp1 = new SwapArr<string>(arr1);
            sp.swap(2,3);
            sp1.swap(0,1);








        }
    }
}

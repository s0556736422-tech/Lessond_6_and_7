using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessond_6_and_7
{
    public class SwapArr<T>
    {
        private T [] arr;
        private T temp;
        public SwapArr(T[] ar) { arr = ar; }
        public void swap(int i1, int i2)
        {
            if(arr.Length>i2)
            {
                temp = arr[i1];
                arr[i1] = arr[i2];
                arr[i2]=temp;
                Console.WriteLine(string.Join(",",arr));
            }
        }
    }
}

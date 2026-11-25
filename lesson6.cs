using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lessond_6_and_7
{
    public class lesson6
    {
        public void str() {  string str = Console.ReadLine();
            //1
            Console.WriteLine(Regex.IsMatch(str,@"^[0][5]\d{8}"));
            //2
            Console.WriteLine(Regex.IsMatch(str, @"^[a][b][c]\d$"));
            //3
            Console.WriteLine(Regex.IsMatch(str, @"^[c][o][l][o][r]$|^[c][a][l][a][r]$"));
            //4
            Console.WriteLine(Regex.IsMatch(str, @"^[aeiou]+$"));
            //5
            Console.WriteLine(Regex.IsMatch(str, @"^\w{6,10}$"));
            //6
            Console.WriteLine(Regex.IsMatch(str, @"[c][a][t]+|[d][o][g]+"));
            //7
            Console.WriteLine(Regex.IsMatch(str, @"@.|\d[@][gmail.com]$|[co.il]$"));
            //8
            Console.WriteLine(Regex.Replace(str,@" +"," "));
            //9
            string[] arr = Regex.Split(str, @"\d+");
        Console.WriteLine(arr[0]);}
       
    }
}

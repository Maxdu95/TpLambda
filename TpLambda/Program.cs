using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLambda
{
    class Program
    {
        delegate int monDelegate(int i);
        delegate bool monDelegate2(int i, int j);
        delegate bool monDelegate3(int i, string c);
        delegate string monDelegate4(string s);
        delegate bool monDelegate5(int i);
        delegate string monDelegate6(string c);
        delegate int monDelegate7();
        delegate int monDelegate8(int i, int m, int n);
        delegate List<char> monDelegate9(string c);
        static void Main(string[] args)
        {
            monDelegate9 del = (s) => { Console.WriteLine(s); foreach (char c in s) { } };

            Func<string, List<char>> f = (s) => { Console.WriteLine(s); foreach (char c in s) { Console.WriteLine(c); } };

            List<char> result = f("hello");

            Console.WriteLine(result);
           
            Console.ReadLine();
        }
    }
}

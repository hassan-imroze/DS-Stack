using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic stack operations:");
            BasicStackFunctions();
            //Console.WriteLine("Reversing a string:");
            //ReversingAString();
            Console.WriteLine("Balance Check:");
            BalanceCheck();
            Console.ReadKey();
        }

        static void BasicStackFunctions()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(string.Format("Item Count:{0}", stack.Count));
            Console.WriteLine(string.Format("Peeked Item:{0}", stack.Peek()));
            Console.WriteLine(string.Format("Popped Item:{0}", stack.Pop()));
            Console.WriteLine(string.Format("Peeked again:{0}", stack.Peek()));

        }

        static void ReversingAString()
        {
            Console.Write("Input:");
            string input = Console.ReadLine();
            Console.WriteLine(string.Format("Reversed output:{0}", StringReverser.Reverse(input)));

        }

        static void BalanceCheck()
        {
            Console.Write("Input:");
            string input = Console.ReadLine();
            Console.WriteLine(string.Format("Balanced:{0}", StringBalanceChecker.IsBalanced(input)));

        }
    }
}

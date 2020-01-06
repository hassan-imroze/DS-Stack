using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Stack
{
    public class StringReverser
    {
        public static string Reverse(string input)
        {
            if (input == null)
                throw new ArgumentNullException();

            StringBuilder sbOutput = new StringBuilder();
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }
            while (stack.Count > 0)
            {
                sbOutput.Append(stack.Pop());
            }

            return sbOutput.ToString();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Stack
{
    class StringBalanceChecker
    {
        private static List<char> leftBrackets = new  List<char> { '(','{','[', '<' };
        private static List<char> rightBrackets = new List<char> { ')', '}', ']', '>' };

        public static bool IsBalanced(string input)
        {
            if (input == null)
                throw new NullReferenceException();

            Stack<char> brackets = new Stack<char>();

            foreach (var item in input.ToCharArray())
            {
                if (IsLeftBracket(item))
                    brackets.Push(item);
                else if(IsRightBracket(item))
                {
                    if (brackets.Count == 0)
                        return false;
                    var poppedItem = brackets.Pop();
                    if (!bracketsMatch(poppedItem, item)) return false;
                }
            }

            return brackets.Count == 0;
        }

        private static bool IsLeftBracket(char ch)
        {
            return leftBrackets.Contains(ch);
        }


        private static bool IsRightBracket(char ch)
        {
            return rightBrackets.Contains(ch);
        }

        private static bool bracketsMatch(char left,char right)
        {
            return leftBrackets.IndexOf(left) == rightBrackets.IndexOf(right);
        }

    }
}

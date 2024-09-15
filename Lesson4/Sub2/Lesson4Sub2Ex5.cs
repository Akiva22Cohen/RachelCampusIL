using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rachel_Campus_IL.Lesson4.Sub2
{
    public class Lesson4Sub2Ex5
    {
        public static bool IsExist(Stack<int> stk, int num)
        {
            Stack<int> temp = new Stack<int>();

            while (!stk.IsEmpty())
            {
                if (stk.Top() % 10 == num)
                {
                    while (!temp.IsEmpty())
                        stk.Push(temp.Pop());

                    return true;
                }

                temp.Push(stk.Pop());
            }

            while (!temp.IsEmpty())
                stk.Push(temp.Pop());

            return false;
        }

        public static Stack<int> Clone(Stack<int> st)
        {
            Stack<int> temp = new Stack<int>();
            Stack<int> newStack = new Stack<int>();

            while (!st.IsEmpty())
                temp.Push(st.Pop());

            while (!temp.IsEmpty())
            {
                newStack.Push(temp.Top());
                st.Push(temp.Pop());
            }

            return newStack;
        }

        public static bool AllExist(Stack<int> stk)
        {
            Stack<int> temp = Clone(stk);
            Stack<int> cloneStk = Clone(stk);
            int num;

            while (!temp.IsEmpty())
            {
                num = temp.Pop();
                while (num >= 10)
                    num /= 10;

                if (!IsExist(cloneStk, num))
                    return false;
            }
            return true;
        }

        public static void Run()
        {
            int num = 8;
            Stack<int> stk = new Stack<int>();
            stk.Push(77);
            stk.Push(568);
            stk.Push(251);
            stk.Push(162);

            Console.WriteLine("stk:");
            Console.WriteLine(stk);

            Console.WriteLine();
            Console.WriteLine($"IsExist(Stack<int> {stk}, int {num}) => " + IsExist(stk, num));
            Console.WriteLine();

            Console.WriteLine("stk:");
            Console.WriteLine(stk);

            Console.WriteLine();
            Console.WriteLine($"Clone(Stack<int> st): " + Clone(stk));
            Console.WriteLine();

            Console.WriteLine("stk:");
            Console.WriteLine(stk);

            Stack<int> stk2 = new Stack<int>();
            stk2.Push(7);
            stk2.Push(28);
            stk2.Push(12334);
            stk2.Push(565);
            stk2.Push(251);
            stk2.Push(122);

            Console.WriteLine();
            Console.WriteLine($"AllExist({stk2}): " + AllExist(stk2));
            Console.WriteLine();

            Console.WriteLine("stk2:");
            Console.WriteLine(stk2);

            Stack<int> stk3 = new Stack<int>();
            stk3.Push(12334);
            stk3.Push(521);
            stk3.Push(245);
            stk3.Push(1223);

            Console.WriteLine();
            Console.WriteLine($"AllExist({stk3}): " + AllExist(stk3));
            Console.WriteLine();

            Console.WriteLine("stk3:");
            Console.WriteLine(stk3);
        }
    }
}

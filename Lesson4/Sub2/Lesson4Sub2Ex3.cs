using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rachel_Campus_IL.Lesson4.Sub2
{
    public class Lesson4Sub2Ex3
    {
        public static Stack<int> NotInBlock(Stack<int> st)
        {
            Stack<int> temp = new Stack<int>();
            Stack<int> newStack = new Stack<int>();
            int num;

            while (!st.IsEmpty())
            {
                num = st.Pop();

                if (!st.IsEmpty() && num == st.Top())
                {
                    while (!st.IsEmpty() && num == st.Top())
                        temp.Push(st.Pop());
                }
                else
                    newStack.Push(num);
                temp.Push(num);
            }

            while (!temp.IsEmpty())
                st.Push(temp.Pop());

            return newStack;
        }

        public static void Run()
        {
            Stack<int> st = new Stack<int>();
            st.Push(15);
            st.Push(-4);
            st.Push(-4);
            st.Push(3);
            st.Push(5);
            st.Push(0);
            st.Push(0);
            st.Push(0);
            st.Push(5);
            st.Push(5);
            st.Push(15);
            st.Push(14);
            Console.WriteLine("st:");
            Console.WriteLine(st);

            Console.WriteLine();
            Console.WriteLine("NotInBlock(st):");
            Console.WriteLine(NotInBlock(st).ToString());
            Console.WriteLine();

            Console.WriteLine("st:");
            Console.WriteLine(st);
        }
    }
}

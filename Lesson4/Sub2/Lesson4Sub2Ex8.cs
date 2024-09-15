using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rachel_Campus_IL.Lesson4.Sub2
{
    public class Lesson4Sub2Ex8
    {
        // סכום של זוג איברים סמוכים במחסנית
        // O(n) : סיבוכיות
        public static int FindMaxSum(Stack<int> st)
        {
            Stack<int> tempSt = new Stack<int>();
            int maxSum = 0, temp;
            int prev = st.Pop();
            tempSt.Push(prev);

            while (!st.IsEmpty())
            {
                temp = prev + st.Top();
                if (maxSum < temp)
                    maxSum = temp;

                prev = st.Pop();
                tempSt.Push(prev);
            }

            while (!tempSt.IsEmpty())
                st.Push(tempSt.Pop());

            return maxSum;
        }

        public static int MaxCuple(Stack<int> st1, Stack<int> st2)
        {
            int sum1 = 0, maxSum2 = FindMaxSum(st2);
            bool flag = false;
            Stack<int> tempSt1 = new Stack<int>();

            while (!st1.IsEmpty() && !flag)
            {
                sum1 = st1.Top();
                tempSt1.Push(st1.Pop());

                if (!st1.IsEmpty())
                    sum1 += st1.Top();

                if (sum1 > maxSum2)
                    flag = true;
            }

            while (!tempSt1.IsEmpty())
                st1.Push(tempSt1.Pop());

            return flag ? sum1 : 0;
        }

        public static void Run()
        {
            Stack<int> st1 = new Stack<int>();
            st1.Push(7);
            st1.Push(6);
            st1.Push(14);
            st1.Push(8);
            st1.Push(12);
            st1.Push(9);
            st1.Push(7);

            Stack<int> st2 = new Stack<int>();
            st2.Push(11);
            st2.Push(9);
            st2.Push(1);
            st2.Push(4);
            st2.Push(13);
            st2.Push(4);
            st2.Push(8);
            st2.Push(2);

            Console.WriteLine("st1:");
            Console.WriteLine(st1);
            Console.WriteLine();
            Console.WriteLine("st2:");
            Console.WriteLine(st2);

            Console.WriteLine();
            Console.WriteLine("MaxCuple: " + MaxCuple(st1, st2));
            Console.WriteLine();

            Console.WriteLine("st1:");
            Console.WriteLine(st1);
            Console.WriteLine();
            Console.WriteLine("st2:");
            Console.WriteLine(st2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rachel_Campus_IL.Lesson4.Sub2
{
    public class Lesson4Sub2Ex11
    {
        public static void ChangeDirectionNum(Stack<int> s)
        {
            Stack<int> temp = new Stack<int>();
            int n;
            bool flag = true;

            while (!s.IsEmpty())
            {
                n = s.Pop();

                if (!s.IsEmpty())
                {
                    if (flag)
                    {
                        if (n > s.Top())
                        {
                            temp.Push(n);
                            flag = false;
                        }
                    }
                    else
                    {
                        if (n < s.Top())
                        {
                            temp.Push(n);
                            flag = true;
                        }
                    }
                }

                temp.Push(n);
            }

            while (!temp.IsEmpty())
                s.Push(temp.Pop());
        }


        public static void Run()
        {
            Stack<int> s = new Stack<int>();
            s.Push(2);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(2);
            s.Push(1);

            Stack<int> s2 = new Stack<int>();
            s2.Push(3);
            s2.Push(7);
            s2.Push(3);
            s2.Push(7);
            s2.Push(3);

            Stack<int> s3 = new Stack<int>();
            s3.Push(9);
            s3.Push(6);
            s3.Push(5);
            s3.Push(4);

            Console.WriteLine("s:");
            Console.WriteLine("Befor ChangeDirectionNum(s)");
            Console.WriteLine(s);

            Console.WriteLine();
            Console.WriteLine("After ChangeDirectionNum(s)");
            ChangeDirectionNum(s);
            Console.WriteLine(s);


            Console.WriteLine();
            Console.WriteLine("s2:");
            Console.WriteLine("Befor ChangeDirectionNum(s2)");
            Console.WriteLine(s2);

            Console.WriteLine();
            Console.WriteLine("After ChangeDirectionNum(s2)");
            ChangeDirectionNum(s2);
            Console.WriteLine(s2);


            Console.WriteLine();
            Console.WriteLine("s3:");
            Console.WriteLine("Befor ChangeDirectionNum(s3)");
            Console.WriteLine(s3);

            Console.WriteLine();
            Console.WriteLine("After ChangeDirectionNum(s3)");
            ChangeDirectionNum(s3);
            Console.WriteLine(s3);
        }
    }
}

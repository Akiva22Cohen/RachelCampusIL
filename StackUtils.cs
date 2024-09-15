using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rachel_Campus_IL
{
    public class StackUtils
    {
        //   אוסף פעולות נפוצות / תבניות עבור מחסנית
        // ===============================================

        // המכילה ערכים אקראיים size פעולה הבונה מחסנית בגודל  
        // המתקבלים כפרמטרים max-ל min בתחום בין  
        public static Stack<int> BuildRnd(int size, int min, int max)
        {
            Random rnd = new Random();
            int num;
            Stack<int> stk = new Stack<int>();
            for (int i = 0; i < size; i++)
            {
                num = rnd.Next(min, max);   // הגרלת מספר בתחום המבוקש
                stk.Push(num);
            }
            return stk;
        }


        // הפעולה מקבלת מחסנית
        // הפעולה מדפיסה את המחסנית
        // הפעולה שומרת על המחסנית המקורית
        public static void Print(Stack<int> stk)
        {
            Stack<int> tmp = new Stack<int>();  // מחסנית עזר
            Console.Write(" Top  ");
            while (!stk.IsEmpty())  // העברה למחסנית עזר
            {
                Console.Write(stk.Top() + "-->");
                tmp.Push(stk.Pop());
            }


            while (!tmp.IsEmpty())  // שחזור המחסנית המקורית
            {
                stk.Push(tmp.Pop());
            }

            Console.WriteLine(" ]");
        }

        // הפעולה מקבלת מחסנית
        // הפעולה מחזירה את מספר האיברים במחסנית
        // הפעולה שומרת על המחסנית המקורית
        public static int Length(Stack<int> stk)
        {
            int len = 0;
            Stack<int> tmp = new Stack<int>();  // מחסנית עזר
            while (!stk.IsEmpty())    // העברה למחסנית עזר
            {
                len++;
                tmp.Push(stk.Pop());
            }

            while (!tmp.IsEmpty())  // שחזור המחסנית המקורית
            {
                stk.Push(tmp.Pop());
            }

            return len;
        }

        // הפעולה מקבלת מחסנית
        // הפעולה מחזירה את סכום האיברים במחסנית
        // הפעולה שומרת על המחסנית המקורית
        public static int Sum(Stack<int> stk)
        {
            int sum = 0;
            Stack<int> tmp = new Stack<int>();  // מחסנית עזר
            while (!stk.IsEmpty())    // העברה למחסנית עזר
            {
                sum = sum + stk.Top();
                tmp.Push(stk.Pop());
            }

            while (!tmp.IsEmpty())  // שחזור המחסנית המקורית
            {
                stk.Push(tmp.Pop());
            }

            return sum;
        }

        // הפעולה מקבלת מחסנית ומספר שלם
        // הפעולה מחזירה את מספר המופעים של המספר במחסנית
        // הפעולה שומרת על המחסנית המקורית
        public static int Count(Stack<int> stk, int num)
        {
            int count = 0;
            Stack<int> tmp = new Stack<int>();  // מחסנית עזר
            while (!stk.IsEmpty())     // העברה למחסנית עזר
            {
                if (stk.Top() == num)
                    count++;
                tmp.Push(stk.Pop());
            }

            while (!tmp.IsEmpty())  // שחזור המחסנית המקורית
            {
                stk.Push(tmp.Pop());
            }

            return count;
        }

        // הפעולה מקבלת מחסנית ומספר שלם שהוא מיקום במחסנית
        // הפעולה מחזירה את האיבר מהמחסנית במיקום שהתקבל כפרמטר
        // הנחה: המיקום קיים במחסנית. 
        // ספירת המיקום מתבצעת מלמעלה, החל מ-1
        // הפעולה שומרת על המחסנית המקורית
        public static int ElementAt(Stack<int> stk, int num)
        {

            Stack<int> tmp = new Stack<int>();  // מחסנית עזר
            for (int i = 0; i < num - 1; i++) // איברים למחסנית העזר num-1 נעביר
            {
                tmp.Push(stk.Pop());
            }

            int element = stk.Top();  // num זה האיבר המבוקש, במקום

            while (!tmp.IsEmpty())  // שחזור המחסנית המקורית
            {
                stk.Push(tmp.Pop());
            }

            return element;
        }

        // הפעולה מקבלת מחסנית ומספר שלם
        // הפעולה מחזירה אמת אם המספר קיים במחסנית ושקר אחרת
        // הפעולה שומרת על המחסנית המקורית
        public static bool IsExist(Stack<int> stk, int num)
        {
            bool isExist = false; ;
            Stack<int> tmp = new Stack<int>();  // מחסנית עזר
            while (!stk.IsEmpty() && !isExist)    // העברה למחסנית עזר עד שנמצא 
            {
                isExist = (stk.Top() == num);  // האם האיבר נמצא

                tmp.Push(stk.Pop());
            }

            while (!tmp.IsEmpty())  // שחזור המחסנית המקורית
            {
                stk.Push(tmp.Pop());
            }

            return isExist;
        }

        // הפעולה מקבלת מחסנית ומספר שלם
        // הפעולה מחזירה אמת אם כל האיברים במחסנית זהים 
        // הפעולה שומרת על המחסנית המקורית
        public static bool IsAll(Stack<int> stk)
        {
            bool isAll = true;
            Stack<int> tmp = new Stack<int>();  // מחסנית עזר

            if (!stk.IsEmpty())   // נעביר למחסנית עזר את הראשון - אם קיים
                tmp.Push(stk.Pop());

            while (!stk.IsEmpty() && isAll)    // העברה למחסנית עזר עד שנמצא 
            {
                isAll = (stk.Top() == tmp.Top());  // האם האיבר שהוצאנו זהה לאחרון

                tmp.Push(stk.Pop());
            }

            while (!tmp.IsEmpty())  // שחזור המחסנית המקורית
            {
                stk.Push(tmp.Pop());
            }

            return isAll;
        }


        // הפעולה מקבלת מחסנית ומחזירה אמת אם המחסנית מסודרת בסדר עולה  אחרת מחזירה שקר
        // הנחה: המחסנית לא ריקה
        // הפעולה שומרת על המחסנית המקורית
        public static bool IsOle(Stack<int> stk)
        {
            bool isOle = true;
            int num = stk.Top();  // נשמור על האיבר הראשון
            Stack<int> tmp = new Stack<int>();  // מחסנית עזר
            tmp.Push(stk.Pop());  // נשמור על האיבר הראשון

            while (!stk.IsEmpty())    // העברה למחסנית עזר את כל האיברים 
            {
                isOle = isOle && (stk.Top() > num);  // האם האיבר שהוצאנו קטן מהקודם ששמרנו

                num = stk.Top();
                tmp.Push(stk.Pop());
            }

            while (!tmp.IsEmpty())  // שחזור המחסנית המקורית
            {
                stk.Push(tmp.Pop());
            }

            return isOle;
        }

        // הפעולה מקבלת מחסנית ומספר שלם
        // הפעולה מחזירה את הערך המקסימלי במחסנית
        // הנחה: המחסנית לא ריקה
        // הפעולה שומרת על המחסנית המקורית
        public static int Max(Stack<int> stk, int num)
        {
            int max = stk.Top();   // נתחיל מהאיבר הראשון

            Stack<int> tmp = new Stack<int>();  // מחסנית עזר
            while (!stk.IsEmpty())   // העברה למחסנית עזר
            {
                max = Math.Max(max, stk.Top());

                tmp.Push(stk.Pop());
            }

            while (!tmp.IsEmpty())  // שחזור המחסנית המקורית
            {
                stk.Push(tmp.Pop());
            }

            return max;
        }


        // הפעולה מקבלת מחסנית ומספר שלם
        // הפעולה מחזירה את האיבר האחרון/ התחתון במחסנית
        // הנחה: המחסנית לא ריקה
        // הפעולה שומרת על המחסנית המקורית
        public static int Last(Stack<int> stk, int num)
        {

            Stack<int> tmp = new Stack<int>();  // מחסנית עזר
            while (!stk.IsEmpty())   // העברה למחסנית עזר
            {
                tmp.Push(stk.Pop());
            }

            int last = tmp.Top();   // זה האיבר האחרון/התחתון מהמחסנית המקורית

            while (!tmp.IsEmpty())  // שחזור המחסנית המקורית
            {
                stk.Push(tmp.Pop());
            }

            return last;
        }

        // הפעולה מקבלת מחסנית ומספר שלם
        // הפעולה מוציאה ומחזירה את האיבר האחרון/ התחתון במחסנית
        // הנחה: המחסנית לא ריקה
        // הפעולה שומרת על המחסנית המקורית
        public static int RemoveLast(Stack<int> stk)
        {
            Stack<int> tmp = new Stack<int>();   // מחסנית עזר
            while (!stk.IsEmpty())   // העברה למחסנית עזר
            {
                tmp.Push(stk.Pop());
            }

            int last = tmp.Pop();  // הוצאת האיבר האחרון

            while (!tmp.IsEmpty())   // שחזור המחסנית המקורית
            {
                stk.Push(tmp.Pop());
            }

            return last;
        }


        // הפעולה מקבלת מחסנית 
        // הפעולה מחזירה מחסנית שהיא העתק של המחסנית המקורית 
        // הפעולה שומרת על המחסנית המקורית
        public static Stack<int> Duplicate(Stack<int> stk)
        {
            Stack<int> tmp = new Stack<int>();     // מחסנית עזר
            Stack<int> stk2 = new Stack<int>();
            while (!stk.IsEmpty())
            {
                tmp.Push(stk.Pop());
            }
            while (!tmp.IsEmpty())    // שחזור המחסנית המקורית ושכפולה
            {
                stk2.Push(tmp.Top());
                stk.Push(tmp.Pop());
            }

            return stk2;
        }


        // הפעולה מקבלת מחסנית 
        // הפעולה מחזירה מחסנית שהיא העתק של המחסנית המקורית בסדר הפוך
        // הפעולה שומרת על המחסנית המקורית
        public static Stack<int> DuplicateReverse(Stack<int> stk)
        {
            Stack<int> tmp = new Stack<int>();     // מחסנית עזר
            Stack<int> stk2 = new Stack<int>();
            while (!stk.IsEmpty())
            {
                stk2.Push(tmp.Top());
                tmp.Push(stk.Pop());
            }
            while (!tmp.IsEmpty())    // שחזור המחסנית המקורית ושכפולה
            {
                stk.Push(tmp.Pop());
            }

            return stk2;
        }

        // הפעולה מקבלת מחסנית 
        // הפעולה הופכת את סדר האיברים במחסנית
        /*public static void Reverse(Stack<int> stk)
        {
            Queue<int> tmp = new Queue<int>();     // תור עזר
            while (!stk.IsEmpty())        // העברה לתור עזר
            {
                tmp.Insert(stk.Pop());
            }
            while (!tmp.IsEmpty())    // החזרה למחסנית המקורית בסדר הפוך
            {
                stk.Push(tmp.Remove());
            }
        }*/

        //    פעולות רקורסיביות
        //==========================

        // הפעולה מקבלת מחסנית
        // הפעולה מדפיסה את המחסנית
        // הפעולה שומרת על המחסנית המקורית
        public static void PrintRec(Stack<int> stk)
        {
            Console.Write(" Top  ");
            PrintRec_(stk);
        }
        // פעולת עזר
        private static void PrintRec_(Stack<int> stk)
        {
            if (stk.IsEmpty())  //תנאי עצירה
            {
                Console.WriteLine(" ]");
                return;
            }

            int x = stk.Pop();
            Console.Write(x + "-->");
            PrintRec_(stk);
            stk.Push(x);
        }


        // הפעולה מקבלת מחסנית
        // הפעולה מדפיסה את המחסנית בסדר הפוך
        // הפעולה שומרת על המחסנית המקורית
        public static void PrintReverseRec(Stack<int> stk)
        {
            Console.Write(" Top  ");
            PrintReverseRec_(stk);
            Console.WriteLine(" ]");
        }
        // פעולת עזר
        private static void PrintReverseRec_(Stack<int> stk)
        {
            if (stk.IsEmpty())  //תנאי עצירה
                return;

            int x = stk.Pop();
            PrintReverseRec_(stk);
            Console.Write(x + "-->");
            stk.Push(x);
        }


        // הפעולה מקבלת מחסנית
        // הפעולה מחזירה את  סכום האיברים במחסנית
        // הפעולה שומרת על המחסנית המקורית
        public static int SumRec(Stack<int> stk)
        {
            if (stk.IsEmpty())  //תנאי עצירה
                return 0;

            int x = stk.Pop();
            int sum = x + SumRec(stk);
            stk.Push(x);
            return sum;
        }


        // הפעולה מקבלת מחסנית
        // הפעולה מחזירה את  מספר האיברים במחסנית
        // הפעולה שומרת על המחסנית המקורית
        public static int LengthRec(Stack<int> stk)
        {
            if (stk.IsEmpty())  //תנאי עצירה
                return 0;

            int x = stk.Pop();
            int len = 1 + LengthRec(stk);
            stk.Push(x);
            return len;
        }


        // הפעולה מקבלת מחסנית ומספר שלם
        // הפעולה מחזירה אמת אם המספר קיים במחסנית ושקר אחרת
        // הפעולה שומרת על המחסנית המקורית
        public static bool IsExistRec(Stack<int> stk, int num)
        {
            if (stk.IsEmpty())  //תנאי עצירה
                return false;

            int x = stk.Pop();
            bool exist = (x == num) || IsExistRec(stk, num);  // האם האיבר התורן מתאים או.. בשאר יש את האיבר שמחפשים
            stk.Push(x);
            return exist;
        }


        // הפעולה מקבלת מחסנית ומספר שלם
        // הפעולה מחזירה אמת אם כל האיברים במחסנית זהים לראשון
        // הנחה: המחסנית לא ריקה
        // הפעולה שומרת על המחסנית המקורית
        public static bool IsAllRec(Stack<int> stk)
        {
            int x = stk.Pop();
            bool isAll = IsAllRec(stk, x);
            stk.Push(x);
            return isAll;
        }

        public static bool IsAllRec(Stack<int> stk, int last)
        {
            if (stk.IsEmpty())  //תנאי עצירה
                return true;

            int x = stk.Pop();
            bool isAll = (last == x) &&    // ... האם האיבר התורן מתאים  וגם 
                          IsAllRec(stk, x);  //  בשאר המחסנית כל האיברים זהים 
            stk.Push(x);
            return isAll;


        }
        /*
        public static bool IsAllRec(Stack<int> stk)
        {
            if (stk.IsEmpty())  //תנאי עצירה
                return true;

            int x = stk.Pop();

            bool isAll = true;
            if (!stk.IsEmpty() )
                isAll = ( x == stk.Top()) &&    // ... האם האיבר התורן מתאים  וגם 
                         IsAllRec(stk);  //  בשאר המחסנית כל האיברים זהים 
            stk.Push(x);
            return isAll;

        }
        */




        // הפעולה מקבלת מחסנית 
        // הפעולה מחזירה את הממוצע של כל המספרים במחסנית
        // הפעולה שומרת על המחסנית המקורית
        public static double AvgRec(Stack<int> stk)
        {
            if (stk.IsEmpty())  //אם המחסנית ריקה - הממוצע 0
                return 0;

            return AvgRec(stk, 0, 0);
        }

        public static double AvgRec(Stack<int> stk, int sum, int count)
        {
            if (stk.IsEmpty())  //תנאי עצירה
            {
                // מכיל את הכמות שלהם count-מכיל את סכום אברי כל המחסנית ו sum במצב זה 
                return (double)sum / count;     // נחשב את הממוצע ונחזיר אותו
            }

            int x = stk.Pop();

            //  נמשיך, ברקורסיה, לסכום ולספור את האיברים במחסנית
            double avg = AvgRec(stk, sum + x, count + 1);

            stk.Push(x);
            return avg;
        }
    }
}
